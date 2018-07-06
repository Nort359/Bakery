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
    public partial class AddChangeMadeProduct : MetroFramework.Forms.MetroForm
    {
        private int getId(string query)
        {
            OleDbCommand selectCommandGetCountryId = new OleDbCommand(query, Connection.getConnection());

            string id = selectCommandGetCountryId.ExecuteScalar().ToString();

            int countryEmployeeId = 0;

            int.TryParse(id, out countryEmployeeId);

            return countryEmployeeId;
        }

        public AddChangeMadeProduct()
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

            // Заполнение comboBox Типами
            string selectQueryType = @"SELECT Название FROM Типы";

            OleDbCommand selectCommandType = new OleDbCommand(selectQueryType, Connection.getConnection());

            OleDbDataReader selectReaderType = selectCommandType.ExecuteReader();

            while (selectReaderType.Read())
            {
                comboBoxSizeMadeProduct.Items.Add(selectReaderType[0]);
            }

            // Заполнение comboBox Продукцией
            string selectQueryProduct = @"SELECT Наименование FROM Продукция";

            OleDbCommand selectCommandProduct = new OleDbCommand(selectQueryProduct, Connection.getConnection());

            OleDbDataReader selectReaderProduct = selectCommandProduct.ExecuteReader();

            while (selectReaderProduct.Read())
            {
                comboBoxProductMadeProduct.Items.Add(selectReaderProduct[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentMadeProduct == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о приготовлении продукта:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о приготовлении продукта:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Количество,
                                              Вес_гр AS `Вес (гр)`,
                                              Дата_приготовления AS `Дата приготовления`,
                                              Типы.Название AS `Название типов`,
                                              Продукция.Наименование AS `Наименование продукции`
                                         FROM Приготовления, Типы,Продукция
                                            WHERE
                                                (Приготовления.Код_продукции = Продукция.Код_продукции)
                                                    AND 
                                                (Приготовления.Код_типа = Типы.Код)
                                                    AND 
                                                (Приготовления.Код = " + ManagerMainForm.idCurrentRowMadeProduct + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtCountMadeProduct.Text = reader["Количество"].ToString();
                txtDateMadeProduct.Text = reader["Дата приготовления"].ToString();
                comboBoxSizeMadeProduct.Text = reader["Название типов"].ToString();
                comboBoxProductMadeProduct.Text = reader["Наименование продукции"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string count = txtCountMadeProduct.Text;
            string date = txtDateMadeProduct.Value.ToShortDateString();
            string size = comboBoxSizeMadeProduct.Text;
            string product = comboBoxProductMadeProduct.Text;

            date = DateTime.Parse(date).ToString("dd.MM.yyyy");

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (date == "".Trim()) errors.Add("Поле 'Дата приготовления' не может оставаться пустым");
            if (size == "".Trim()) errors.Add("Выбирите тип имерения продукции");
            if (product == "".Trim()) errors.Add("Выбирите продукцию");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество приготовленной продукции не может равняться нулю");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получение id выбранного типа
                string selectQueryGetType = @"SELECT Код
                                                FROM Типы
                                                    WHERE Название = '" + size + "'";

                int typeId = getId(selectQueryGetType);

                // Получение id выбранной продукции
                string selectQueryProductId = @"SELECT Код_продукции
                                                            FROM Продукция
                                                                WHERE Наименование = '" + product + "'";

                int productId = getId(selectQueryProductId);

                // Вставка данных
                string insertQuery = @"INSERT INTO Приготовления (Количество, Дата_приготовления, Код_типа, Код_продукции)
                                            VALUES (" + count + "," +
                                            "'" + date + "'," +
                                            "" + typeId + "," +
                                            "" + productId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Запись о приготовлении продукции была успешно добавлена./nВы хотите продолжить добавление?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            }
            else
            {
                // Если ошибки есть выводим первую из них
                MessageBox.Show(errors.First(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string count = txtCountMadeProduct.Text;
            string date = txtDateMadeProduct.Value.ToShortDateString();
            string size = comboBoxSizeMadeProduct.Text;
            string product = comboBoxProductMadeProduct.Text;

            date = DateTime.Parse(date).ToString("dd.MM.yyyy");

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (date == "".Trim()) errors.Add("Поле 'Дата приготовления' не может оставаться пустым");
            if (size == "".Trim()) errors.Add("Выбирете тип змерения продукции");
            if (product == "".Trim()) errors.Add("Поле 'Розничная стоимость' не может оставаться пустым");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество приготовленной продукции не может равняться нулю");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получение id выбранного типа
                string selectQueryGetType = @"SELECT Код
                                                FROM Типы
                                                    WHERE Название = '" + size + "'";

                int typeId = getId(selectQueryGetType);

                // Получение id выбранной продукции
                string selectQueryProductId = @"SELECT Код_продукции
                                                            FROM Продукция
                                                                WHERE Наименование = '" + product + "'";

                int productId = getId(selectQueryProductId);

                // Изменение данных
                string query = @"UPDATE Приготовления SET
                                            Количество = " + count + ", " +
                                           "Дата_приготовления = '" + date + "', " +
                                           "Код_типа = " + typeId + ", " +
                                           "Код_продукции = " + productId + "" +
                                           "   WHERE Код = " + ManagerMainForm.idCurrentRowMadeProduct;

                OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Запись о приготовлении продукции была успешно изменена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtCountMadeProduct_Enter(object sender, EventArgs e)
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

        private void txtCountMadeProduct_Leave(object sender, EventArgs e)
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
