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
    public partial class AddChangeProduct : MetroFramework.Forms.MetroForm
    {
        private int getId(string query)
        {
            OleDbCommand selectCommandGetCountryId = new OleDbCommand(query, Connection.getConnection());

            string id = selectCommandGetCountryId.ExecuteScalar().ToString();

            int countryEmployeeId = 0;

            int.TryParse(id, out countryEmployeeId);

            return countryEmployeeId;
        }

        public AddChangeProduct()
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

            // Заполнение comboBox должностями
            string selectQueryEmployee = @"SELECT Имя, Фамилия, Отчество FROM Сотрудники";

            OleDbCommand selectCommandPosition = new OleDbCommand(selectQueryEmployee, Connection.getConnection());

            OleDbDataReader readerEmployee = selectCommandPosition.ExecuteReader();

            while (readerEmployee.Read())
            {
                comboBoxEmployeeProduct.Items.Add(readerEmployee[0] + " " + readerEmployee[1] + " " + readerEmployee[2]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentProduct == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о продукте:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о продукте:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Наименование, Вес_гр AS `Вес (гр)`,
                                          Срок_годности_в_сутках AS `Срок годности (сут)`,
                                          Оптимальная_стоимость AS `Оптимальная стоимость`,
                                          Розничная_стоимость AS `Розничная стоимость`,
                                          Сотрудники.Имя, Сотрудники.Фамилия, Сотрудники.Отчество
                                     FROM Сотрудники, Продукция
                                        WHERE
                                            (Сотрудники.Код_личного_дела = Продукция.Код_сотрудника)
                                                AND 
                                            (Продукция.Код_продукции = " + ManagerMainForm.idCurrentRowProduct + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtTitleProduct.Text = reader["Наименование"].ToString();
                txtWeightProduct.Text = reader["Вес (гр)"].ToString();
                txtTimeTillDownProduct.Text = reader["Срок годности (сут)"].ToString();
                txtOptimalPriceProduct.Text = reader["Оптимальная стоимость"].ToString();
                txtRealPriceProduct.Text = reader["Розничная стоимость"].ToString();
                comboBoxEmployeeProduct.Text = reader["Имя"].ToString() + " " + reader["Фамилия"].ToString() + " " + reader["Отчество"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitleProduct.Text;
            string weight = txtWeightProduct.Text;
            string optimalPrice = txtOptimalPriceProduct.Text;
            string realPrice = txtRealPriceProduct.Text;
            string timeTillDown = txtTimeTillDownProduct.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Название' не может оставаться пустым");
            if (weight == "".Trim()) errors.Add("Поле 'Вес' не может оставаться пустым");
            if (optimalPrice == "".Trim()) errors.Add("Поле 'Оптимальная стоимость' не может оставаться пустым");
            if (realPrice == "".Trim()) errors.Add("Поле 'Розничная стоимость' не может оставаться пустым");
            if (timeTillDown == "".Trim()) errors.Add("Поле 'Срок годности' не может оставаться пустым");
            if (comboBoxEmployeeProduct.Text == "".Trim()) errors.Add("Сотрудник не выбран");

            // Проверка числовых типов на нули
            if (weight == "0") errors.Add("Вес не может равняться нулю");
            if (optimalPrice == "0") errors.Add("Оптимальная стоимость не может равняться нулю");
            if (realPrice == "0") errors.Add("Розничная стоимость не может равняться нулю");
            if (timeTillDown == "0") errors.Add("Срок годности не может равняться нулю");

            // Проверка на минимальное количество символов
            if (title.Length < 3) errors.Add("Минимальная длина поля 'Название' 3 символа");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                string[] employeeData = comboBoxEmployeeProduct.Text.Split(' ');

                string nameEmployee = employeeData[0];
                string surnameEmployee = employeeData[1];
                string middleNameEmployee = employeeData[2];

                // Если данные есть во всех полях
                // Получение id выбранной должности

                string selectQueryGetEmployee = @"SELECT Код_личного_дела
                                                    FROM Сотрудники
                                                        WHERE
                                                            (Имя = '" + nameEmployee + "')" +
                                                            "   AND" +
                                                            "(Фамилия = '" + surnameEmployee + "')" +
                                                            "   AND" +
                                                            "(Отчество = '" + middleNameEmployee + "')";

                int employeeId = getId(selectQueryGetEmployee);

                // Вставка данных
                string insertQuery = @"INSERT INTO Продукция (Наименование, Вес_гр, Срок_годности_в_сутках, Оптимальная_стоимость, Розничная_стоимость, Код_сотрудника)
                                            VALUES ('" + title + "'," +
                                            "" + weight + "," +
                                            "" + timeTillDown + "," +
                                            "" + optimalPrice + "," +
                                            "" + realPrice + "," +
                                            "" + employeeId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новая продукция была успешно добавлена!\nВы хотите продолжить добавление новых продукций?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            string title = txtTitleProduct.Text;
            string weight = txtWeightProduct.Text;
            string optimalPrice = txtOptimalPriceProduct.Text;
            string realPrice = txtRealPriceProduct.Text;
            string timeTillDown = txtTimeTillDownProduct.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Название' не может оставаться пустым");
            if (weight == "".Trim()) errors.Add("Поле 'Вес' не может оставаться пустым");
            if (optimalPrice == "".Trim()) errors.Add("Поле 'Оптимальная стоимость' не может оставаться пустым");
            if (realPrice == "".Trim()) errors.Add("Поле 'Розничная стоимость' не может оставаться пустым");
            if (timeTillDown == "".Trim()) errors.Add("Поле 'Срок годности' не может оставаться пустым");
            if (comboBoxEmployeeProduct.Text == "".Trim()) errors.Add("Сотрудник не выбран");

            // Проверка числовых типов на нули
            if (weight == "0") errors.Add("Вес не может равняться нулю");
            if (optimalPrice == "0") errors.Add("Оптимальная стоимость не может равняться нулю");
            if (realPrice == "0") errors.Add("Розничная стоимость не может равняться нулю");
            if (timeTillDown == "0") errors.Add("Срок годности не может равняться нулю");

            // Проверка на минимальное количество символов
            if (title.Length < 3) errors.Add("Минимальная длина поля 'Название' 3 символа");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                string[] employeeData = comboBoxEmployeeProduct.Text.Split(' ');

                string nameEmployee = employeeData[0];
                string surnameEmployee = employeeData[1];
                string middleNameEmployee = employeeData[2];

                // Если данные есть во всех полях
                // Получение id выбранной должности

                string selectQueryGetEmployee = @"SELECT Код_личного_дела
                                                    FROM Сотрудники
                                                        WHERE
                                                            (Имя = '" + nameEmployee + "')" +
                                                            "   AND" +
                                                            "(Фамилия = '" + surnameEmployee + "')" +
                                                            "   AND" +
                                                            "(Отчество = '" + middleNameEmployee + "')";

                int employeeId = getId(selectQueryGetEmployee);

                string query = @"UPDATE Продукция SET
                                            Наименование = '" + title + "', " +
                                           "Вес_гр = " + weight + ", " +
                                           "Срок_годности_в_сутках = " + timeTillDown + ", " +
                                           "Оптимальная_стоимость = " + optimalPrice + ", " +
                                           "Розничная_стоимость = " + realPrice + ", " +
                                           "Код_сотрудника = " + employeeId + "" +
                                           "   WHERE Код_продукции = " + ManagerMainForm.idCurrentRowProduct;

                OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Продукция была успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtTitleProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if ((letter < 'А' || letter > 'я') && letter != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtWeightProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
