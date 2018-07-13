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
    public partial class AddChangeCity : MetroFramework.Forms.MetroForm
    {
        public AddChangeCity()
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

            // Заполнение comboBox странами
            string selectQueryCountryReal = @"SELECT Название FROM Страны";

            OleDbCommand selectCommandCountryReal = new OleDbCommand(selectQueryCountryReal, Connection.getConnection());

            OleDbDataReader selectReaderCountryReal = selectCommandCountryReal.ExecuteReader();

            while (selectReaderCountryReal.Read())
            {
                comboBoxCountry.Items.Add(selectReaderCountryReal[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentCity == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о городе:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о городе:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Города.Название AS `Название города`,
                                              Страны.Название AS `Название страны`
                                          FROM Города, Страны
                                             WHERE Страны.Код = Города.Код_страны
                                                    AND
                                                Города.Код = " + ManagerMainForm.idCurrentRowCity;

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtTitle.Text = reader["Название города"].ToString();
                comboBoxCountry.Text = reader["Название страны"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string country = comboBoxCountry.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");
            if (country == "".Trim()) errors.Add("Выбирите страну");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string selectQuery = @"SELECT Код
                                          FROM Страны
                                              WHERE Название = '" + country + "'";

                int countryId = Helper.getId(selectQuery);

                // Вставка данных
                string insertQuery = @"INSERT INTO Города (Название, Код_страны)
                                                VALUES ('" + title + "', " + countryId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новыя запись о городе была успешно добавлена!\nВы хотите продолжить добавление городов?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                    txtTitle.Text = "";
                    comboBoxCountry.Text = "";
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
            string title = txtTitle.Text;
            string country = comboBoxCountry.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");
            if (country == "".Trim()) errors.Add("Выбирите страну");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получаем код типа
                string selectQuery = @"SELECT Код
                                          FROM Страны
                                              WHERE Название = '" + country + "'";

                int countryId = Helper.getId(selectQuery);

                // Изменение данных
                string query = @"UPDATE Города SET 
                                        Название = '" + title + "', " +
                                        "Код_страны = " + countryId +
                                        "   WHERE Код = " + ManagerMainForm.idCurrentRowCity;

                OleDbCommand insertCommand = new OleDbCommand(query, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Запись о городе была успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
