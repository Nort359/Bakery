using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddChangeMaterial : MetroFramework.Forms.MetroForm
    {
        public AddChangeMaterial()
        {
            InitializeComponent();

            // Подключение к БД
            try
            {
                Connection.getConnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Заполнение comboBox типами
            string selectQuery = @"SELECT Название FROM Типы";

            OleDbCommand selectCommand = new OleDbCommand(selectQuery, Connection.getConnection());

            OleDbDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                comboBoxType.Items.Add(reader[0]);
            }

            // Заполнение comboBox продукцией
            selectQuery = @"SELECT Наименование FROM Продукция";

            selectCommand = new OleDbCommand(selectQuery, Connection.getConnection());

            reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                comboBoxProduct.Items.Add(reader[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentMaterial == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о сырье:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о сырье:";

                
                // Получение выбранного сырья
                selectQuery = @"SELECT Сырьё.Код_сырья,
                                       Сырьё.Наименование AS `Наименование сырья`,
                                       Сырьё.Количество,
                                       Сырьё.Срок_годности_в_днях AS `Срок годности в днях`,
                                       Сырьё.Общая_стоимость AS `Общая стоимость`,
                                       Сырьё.Дата_заказа AS `Дата заказа`,
                                       Типы.Название AS `Тип измерения`,
                                       Продукция.Наименование AS `Наименование продукции`
                                   FROM Сырьё, Типы, Продукция
                                       WHERE (Сырьё.Код_типа = Типы.Код)
                                                 AND
                                             (Сырьё.Код_продукции = Продукция.Код_продукции)
                                                 AND 
                                             (Сырьё.Код_сырья = " + ManagerMainForm.idCurrentRowMaterial + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                reader = command.ExecuteReader();
                reader.Read();

                txtTitleMaterial.Text = reader["Наименование сырья"].ToString();
                txtCountMaterial.Text = reader["Количество"].ToString();
                txtPriceMaterial.Text = reader["Общая стоимость"].ToString();
                txtTimeTillDownMaterial.Text = reader["Срок годности в днях"].ToString();
                comboBoxType.Text = reader["Тип измерения"].ToString();
                comboBoxProduct.Text = reader["Наименование продукции"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitleMaterial.Text;
            string count = txtCountMaterial.Text;
            string price = txtPriceMaterial.Text;
            string timeTillDown = txtTimeTillDownMaterial.Text;
            string dateOrder = DateTime.Now.ToShortDateString();

            dateOrder = DateTime.Parse(dateOrder).ToString("dd.MM.yyyy");

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Название' не может оставаться пустым");
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (price == "".Trim()) errors.Add("Поле 'Общая стоимость' не может оставаться пустым");
            if (timeTillDown == "".Trim()) errors.Add("Поле 'Срок годности в днях' не может оставаться пустым");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество не может равняться нулю");
            if (price == "0") errors.Add("Общая стоимость не может равняться нулю");
            if (timeTillDown == "0") errors.Add("Срок годности не может равняться нулю");

            // Проверка на минимальное количество символов
            if (title.Length < 3) errors.Add("Минимальная длина поля 'Название' 3 символа");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string type = comboBoxType.Text;

                string selectQuery = @"SELECT Код
                                          FROM Типы
                                              WHERE Название = '" + type + "'";

                int typeId = Helper.getId(selectQuery);

                // Получаем код продукции
                string product = comboBoxProduct.Text;

                selectQuery = @"SELECT Код_продукции
                                    FROM Продукция
                                        WHERE Наименование = '" + product + "'";

                int productId = Helper.getId(selectQuery);

                // Вставка данных
                string insertQuery = @"INSERT INTO Сырьё (Наименование,
                                                          Количество,
                                                          Срок_годности_в_днях,
                                                          Общая_стоимость,
                                                          Дата_заказа,
                                                          Код_типа,
                                                          Код_продукции)
                                                VALUES ('" + title + "', " +
                                                "" + count + ", " +
                                                "" + timeTillDown + ", " +
                                                "" + price + ", " +
                                                "'" + dateOrder + "', " +
                                                "" + typeId + ", " +
                                                "" + productId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новое сырьё было успешно добавлено!\nВы хотите продолжить добавление новых продукций?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Если продолжать не нужно - закрываем соединение
                if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        Connection.getConnection().Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Program.Context.MainForm = new ManagerMainForm();

                    Close();

                    Program.Context.MainForm.Show();
                }
                else
                {
                    txtTitleMaterial.Text = "";
                    txtCountMaterial.Text = "";
                    txtPriceMaterial.Text = "";
                    txtTimeTillDownMaterial.Text = "";
                }
            }
            else
            {
                // Если ошибки есть выводим первую из них
                MessageBox.Show(errors.First(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string title = txtTitleMaterial.Text;
            string count = txtCountMaterial.Text;
            string price = txtPriceMaterial.Text;
            string timeTillDown = txtTimeTillDownMaterial.Text;
            string dateOrder = DateTime.Now.ToShortDateString();

            dateOrder = DateTime.Parse(dateOrder).ToString("dd.MM.yyyy");

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Название' не может оставаться пустым");
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (price == "".Trim()) errors.Add("Поле 'Общая стоимость' не может оставаться пустым");
            if (timeTillDown == "".Trim()) errors.Add("Поле 'Срок годности в днях' не может оставаться пустым");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество не может равняться нулю");
            if (price == "0") errors.Add("Общая стоимость не может равняться нулю");
            if (timeTillDown == "0") errors.Add("Срок годности не может равняться нулю");

            // Проверка на минимальное количество символов
            if (title.Length < 3) errors.Add("Минимальная длина поля 'Название' 3 символа");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string type = comboBoxType.Text;

                string selectQuery = @"SELECT Код
                                          FROM Типы
                                              WHERE Название = '" + type + "'";

                int typeId = Helper.getId(selectQuery);

                // Получаем код продукции
                string product = comboBoxProduct.Text;

                selectQuery = @"SELECT Код_продукции
                                    FROM Продукция
                                        WHERE Наименование = '" + product + "'";

                int productId = Helper.getId(selectQuery);

                // Изменение данных
                string query = @"UPDATE Сырьё SET
                                        Наименование = '" + title + "', " +
                                        "Количество = '" + count + "', " +
                                        "Срок_годности_в_днях = " + timeTillDown + ", " +
                                        "Общая_стоимость = " + price + ", " +
                                        "Дата_заказа = '" + dateOrder + "', " +
                                        "Код_типа = " + typeId + ", " +
                                        "Код_продукции = " + productId + "" +
                                        "   WHERE Код_сырья = " + ManagerMainForm.idCurrentRowMadeProduct;

                OleDbCommand insertCommand = new OleDbCommand(query, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Запись о сырье была успешна обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    Connection.getConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Program.Context.MainForm = new ManagerMainForm();

                Close();

                Program.Context.MainForm.Show();
            }
            else
            {
                // Если ошибки есть выводим первую из них
                MessageBox.Show(errors.First(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new ManagerMainForm();

            Close();

            Program.Context.MainForm.Show();
        }

        private void txtTitleMaterial_Enter(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;

                int index = 0;
                int.TryParse(control.TabIndex.ToString(), out index);

                Control next = Controls.OfType<Control>()
                                       .Where(c => c.TabIndex == index + 1)
                                       .First();

                Helper.PaintLabelUp(next);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtTitleMaterial_Leave(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;

                int index = 0;
                int.TryParse(control.TabIndex.ToString(), out index);

                Control next = Controls.OfType<Control>()
                                       .Where(c => c.TabIndex == index + 1)
                                       .First();

                Helper.PaintLabelDown(next);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
