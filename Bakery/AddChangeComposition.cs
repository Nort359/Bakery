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
    public partial class AddChangeComposition : MetroFramework.Forms.MetroForm
    {
        public AddChangeComposition()
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

            // Заполнение comboBox Сырьём
            string selectQueryMaterial = @"SELECT Наименование FROM Сырьё";

            OleDbCommand selectCommandMaterial = new OleDbCommand(selectQueryMaterial, Connection.getConnection());

            OleDbDataReader selectReaderMaterial = selectCommandMaterial.ExecuteReader();

            while (selectReaderMaterial.Read())
            {
                comboBoxMaterial.Items.Add(selectReaderMaterial[0]);
            }

            // Заполнение comboBox Типами
            string selectQueryType = @"SELECT Название FROM Типы";

            OleDbCommand selectCommandType = new OleDbCommand(selectQueryType, Connection.getConnection());

            OleDbDataReader selectReaderType = selectCommandType.ExecuteReader();

            while (selectReaderType.Read())
            {
                comboBoxSize.Items.Add(selectReaderType[0]);
            }

            // Заполнение comboBox Продукцией
            string selectQueryProduct = @"SELECT Наименование FROM Продукция";

            OleDbCommand selectCommandProduct = new OleDbCommand(selectQueryProduct, Connection.getConnection());

            OleDbDataReader selectReaderProduct = selectCommandProduct.ExecuteReader();

            while (selectReaderProduct.Read())
            {
                comboBoxProduct.Items.Add(selectReaderProduct[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentComposition == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о составе продукта:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о составе продукта:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Состав.Код,
                                              Сырьё.Наименование AS `Наименование сырья`,
                                              Продукция.Наименование AS `Наименование продукции`,
                                              Типы.Название AS `Тип измерения`,
                                              Состав.Количество
                                          FROM Состав, Сырьё, Типы, Продукция
                                              WHERE (Состав.Код_типа = Типы.Код)
                                                  AND
                                              (Состав.Код_продукции = Продукция.Код_продукции)
                                                  AND
                                              (Состав.Код_сырья = Сырьё.Код_сырья)
                                                  AND 
                                              (Состав.Код = " + ManagerMainForm.idCurrentRowComposition + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtCount.Text = reader["Количество"].ToString();
                comboBoxSize.Text = reader["Тип измерения"].ToString();
                comboBoxMaterial.Text = reader["Наименование сырья"].ToString();
                comboBoxProduct.Text = reader["Наименование продукции"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string count = txtCount.Text;
            string product = comboBoxProduct.Text;
            string material = comboBoxMaterial.Text;
            string type = comboBoxSize.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (product == "".Trim()) errors.Add("Выбирите продукт");
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (material == "".Trim()) errors.Add("Выбирите сырьё");
            if (type == "".Trim()) errors.Add("Выбирите размер");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество не может равняться нулю");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string selectQuery = @"SELECT Код
                                          FROM Типы
                                              WHERE Название = '" + type + "'";

                int typeId = Helper.getId(selectQuery);

                // Получаем код продукции
                selectQuery = @"SELECT Код_продукции
                                    FROM Продукция
                                        WHERE Наименование = '" + product + "'";

                int productId = Helper.getId(selectQuery);

                // Получаем код сырья
                selectQuery = @"SELECT Код_сырья
                                    FROM Сырьё
                                        WHERE Наименование = '" + material + "'";

                int materialId = Helper.getId(selectQuery);

                // Вставка данных
                string insertQuery = @"INSERT INTO Состав (Количество,
                                                          Код_продукции,
                                                          Код_сырья,
                                                          Код_типа)
                                                VALUES (" + count + ", " +
                                                "" + productId + ", " +
                                                "" + materialId + ", " +
                                                "" + typeId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новыя запись о составе продукции была успешно добавлена!\nВы хотите продолжить добавление новыз составов?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                    txtCount.Text = "";
                    comboBoxProduct.Text = "";
                    comboBoxMaterial.Text = "";
                    comboBoxSize.Text = "";
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
            string count = txtCount.Text;
            string product = comboBoxProduct.Text;
            string material = comboBoxMaterial.Text;
            string type = comboBoxSize.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (product == "".Trim()) errors.Add("Выбирите продукт");
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (material == "".Trim()) errors.Add("Выбирите сырьё");
            if (type == "".Trim()) errors.Add("Выбирите размер");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество не может равняться нулю");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string selectQuery = @"SELECT Код
                                          FROM Типы
                                              WHERE Название = '" + type + "'";

                int typeId = Helper.getId(selectQuery);

                // Получаем код продукции
                selectQuery = @"SELECT Код_продукции
                                    FROM Продукция
                                        WHERE Наименование = '" + product + "'";

                int productId = Helper.getId(selectQuery);

                // Получаем код сырья
                selectQuery = @"SELECT Код_сырья
                                    FROM Сырьё
                                        WHERE Наименование = '" + material + "'";

                int materialId = Helper.getId(selectQuery);

                // Изменение данных
                string query = @"UPDATE Состав SET 
                                        Количество = " + count + ", " +
                                       "Код_продукции = " + productId + ", " +
                                       "Код_сырья = " + materialId + ", " +
                                       "Код_типа = " + typeId +
                                       "   WHERE Код = " + ManagerMainForm.idCurrentRowMadeProduct;

                OleDbCommand insertCommand = new OleDbCommand(query, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Запись о составе продукции была успешно изменена!",
                                "Успех!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

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
    }
}
