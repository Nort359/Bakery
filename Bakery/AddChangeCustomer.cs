using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddChangeCustomer : MetroFramework.Forms.MetroForm
    {
        private int getId(string query)
        {
            OleDbCommand selectCommandGetCountryId = new OleDbCommand(query, Connection.getConnection());

            string id = selectCommandGetCountryId.ExecuteScalar().ToString();

            int countryEmployeeId = 0;

            int.TryParse(id, out countryEmployeeId);

            return countryEmployeeId;
        }

        private void getCities(MetroFramework.Controls.MetroComboBox comboBoxFrom, MetroFramework.Controls.MetroComboBox comboBoxTo)
        {
            // Получение id выбранной страны
            string text = comboBoxFrom.Text;

            string selectQueryGetCountryId = @"SELECT Код
                                                FROM Страны
                                                    WHERE Название = '" + text + "'";

            int id = getId(selectQueryGetCountryId);

            if (id != 0)
            {
                // Заполнение comboBox городами
                string selectQueryCity = @"SELECT Название
                                             FROM Города
                                                WHERE Код_страны = " + id;

                OleDbCommand selectCommandCity = new OleDbCommand(selectQueryCity, Connection.getConnection());

                OleDbDataReader selectReaderCity = selectCommandCity.ExecuteReader();

                comboBoxTo.Items.Clear();
                comboBoxTo.MaxDropDownItems = 5;

                while (selectReaderCity.Read())
                {
                    comboBoxTo.Items.Add(selectReaderCity[0]);
                }
            }
        }

        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);

            action();

            SetInterval(action, timeout);
        }

        public AddChangeCustomer()
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
            string selectQueryCountryLaw = @"SELECT Название FROM Страны";

            OleDbCommand selectCommandCountryLaw = new OleDbCommand(selectQueryCountryLaw, Connection.getConnection());

            OleDbDataReader selectReaderCountryLaw = selectCommandCountryLaw.ExecuteReader();

            while (selectReaderCountryLaw.Read())
            {
                comboBoxLawCountryAddressCustomer.Items.Add(selectReaderCountryLaw[0]);
            }

            // Заполнение comboBox странами
            string selectQueryCountryReal = @"SELECT Название FROM Страны";

            OleDbCommand selectCommandCountryReal = new OleDbCommand(selectQueryCountryReal, Connection.getConnection());

            OleDbDataReader selectReaderCountryReal = selectCommandCountryReal.ExecuteReader();

            while (selectReaderCountryReal.Read())
            {
                comboBoxRealCountryAddressCustomer.Items.Add(selectReaderCountryReal[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentCustomer == false)
            {
                btnChangeEmployee.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о заказчике:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о заказчике:";

                string selectQuery = @"SELECT Код_заказчика,
                                              Наименование,
                                              Юридический_адрес AS `Юридический адрес`,
                                              Фактический_адрес AS `Фактический адрес`,
                                              ФИО_руководителя AS `ФИО_руководителя`,
                                              Телефон,
                                              Электронная_почта AS `Электронная почта`
                                        FROM Заказчики
                                            WHERE Код_заказчика = " + ManagerMainForm.idCurrentRowCustomer;

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                string countryLaw = reader["Юридический адрес"].ToString().Split(',')[0].Trim();
                string countryReal = reader["Фактический адрес"].ToString().Split(',')[0].Trim();

                comboBoxLawCountryAddressCustomer.Text = countryLaw;
                comboBoxRealCountryAddressCustomer.Text = countryReal;

                string cityLaw = reader["Юридический адрес"].ToString().Split(',')[1].Split('.')[1].Trim();
                string cityReal = reader["Фактический адрес"].ToString().Split(',')[1].Split('.')[1].Trim();

                comboBoxLawCityAddressCustomer.Text = cityLaw;
                comboBoxRealCityAddressCustomer.Text = cityReal;

                string[] adressLawArray = reader["Юридический адрес"].ToString().Split(',');
                string[] adressRealArray = reader["Фактический адрес"].ToString().Split(',');

                string adressLaw = "";
                string adressReal = "";

                for (int i = 2; i < adressLawArray.Length; i++)
                {
                    adressLaw += adressLawArray[i];
                    if (i != adressLawArray.Length - 1) adressLaw += ",";
                }

                for (int i = 2; i < adressRealArray.Length; i++)
                {
                    adressReal += adressRealArray[i];
                    if (i != adressRealArray.Length - 1) adressReal += ",";
                }

                txtLawAddressCustomer.Text = adressLaw;
                txtRealAddressCustomer.Text = adressReal;

                txtTitleCustomer.Text = reader["Наименование"].ToString();
                txtEmailCustomer.Text = reader["Электронная почта"].ToString();
                txtPhoneCustomer.Text = reader["Телефон"].ToString();

                string[] fio = reader["ФИО_руководителя"].ToString().Split(' ');

                txtNameCustomer.Text = fio[0];
                txtSurnameCustomer.Text = fio[1];
                txtMiddleNameCustomer.Text = fio[2];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string countryLaw = comboBoxLawCountryAddressCustomer.Text;
            string cityLaw = comboBoxLawCityAddressCustomer.Text;
            string addressLaw = txtLawAddressCustomer.Text;

            string countryReal = comboBoxRealCountryAddressCustomer.Text;
            string cityReal = comboBoxRealCityAddressCustomer.Text;
            string addressReal = txtRealAddressCustomer.Text;

            string name = txtNameCustomer.Text;
            string surname = txtSurnameCustomer.Text;
            string middleName = txtMiddleNameCustomer.Text;

            string title = txtTitleCustomer.Text;
            string email = txtEmailCustomer.Text;
            string phone = txtPhoneCustomer.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (countryLaw == "".Trim()) errors.Add("Выбирите страну юридического адреса");
            if (cityLaw == "".Trim()) errors.Add("Выбирите город юридического адреса");
            if (addressLaw == "".Trim()) errors.Add("Поле 'Юридический адрес' не может оставаться пустым");

            if (countryReal == "".Trim()) errors.Add("Выбирите страну фактического адреса");
            if (cityReal == "".Trim()) errors.Add("Выбирите город фактического адреса");
            if (addressReal == "".Trim()) errors.Add("Поле 'Фактический адрес' не может оставаться пустым");

            if (name == "".Trim()) errors.Add("Поле 'Имя заказчика' не может оставаться пустым");
            if (surname == "".Trim()) errors.Add("Поле 'Фамилия заказчика' не может оставаться пустым");
            if (middleName == "".Trim()) errors.Add("Поле 'Отчество заказчика' не может оставаться пустым");

            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");
            if (email == "".Trim()) errors.Add("Поле 'Email' не может оставаться пустым");
            if (phone == "".Trim()) errors.Add("Поле 'Номер телефона' не может оставаться пустым");

            // Проверка email на валидность
            if (!Helper.IsValidEmail(email)) errors.Add("Email введён некорректно");

            // Проверка на длину полей
            if (name.Length < 3) errors.Add("Поле 'Имя заказчика' не может быть меньше трёх символов");
            if (surname.Length < 3) errors.Add("Поле 'Фамилия заказчика' не может быть меньше трёх символов");
            if (middleName.Length < 3) errors.Add("Поле 'Отчество заказчика' не может быть меньше трёх символов");

            if (title.Length < 3) errors.Add("Поле 'Наименование' не может быть меньше трёх символов");
            if (email.Length < 4) errors.Add("Поле 'Email' не может быть меньше четырёх символов");
            if (phone.Length < 3) errors.Add("Поле 'Номер телефона' быть меньше трёх символов");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Вставка данных
                string insertQuery = @"INSERT INTO Заказчики (Наименование,
                                                              Юридический_адрес,
                                                              Фактический_адрес,
                                                              ФИО_руководителя,
                                                              Телефон,
                                                              Электронная_почта)
                                            VALUES ('" + title + "'," +
                                            "'" + countryLaw + ", г. " + cityLaw + ", " + addressLaw + "', " +
                                            "'" + countryReal + ", г. " + cityReal + ", " + addressReal + "', " +
                                            "'" + name + " " + surname + " " + middleName + "', " +
                                            "'" + phone + "', " +
                                            "'" + email + "')";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Запись о заказчике была успешно добавлена./nВы хотите продолжить добавление?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                } else
                {
                    comboBoxLawCountryAddressCustomer.Text = "";
                    comboBoxRealCountryAddressCustomer.Text = "";

                    comboBoxLawCityAddressCustomer.Text = "";
                    comboBoxRealCityAddressCustomer.Text = "";

                    txtLawAddressCustomer.Text = "";
                    txtRealAddressCustomer.Text = "";

                    txtTitleCustomer.Text = "";
                    txtEmailCustomer.Text = "";
                    txtPhoneCustomer.Text = "";

                    txtNameCustomer.Text = "";
                    txtSurnameCustomer.Text = "";
                    txtMiddleNameCustomer.Text = "";
                }
            }
            else
            {
                // Если ошибки есть выводим первую из них
                MessageBox.Show(errors.First(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            string countryLaw = comboBoxLawCountryAddressCustomer.Text;
            string cityLaw = comboBoxLawCityAddressCustomer.Text;
            string addressLaw = txtLawAddressCustomer.Text;

            string countryReal = comboBoxRealCountryAddressCustomer.Text;
            string cityReal = comboBoxRealCityAddressCustomer.Text;
            string addressReal = txtRealAddressCustomer.Text;

            string name = txtNameCustomer.Text;
            string surname = txtSurnameCustomer.Text;
            string middleName = txtMiddleNameCustomer.Text;

            string title = txtTitleCustomer.Text;
            string email = txtEmailCustomer.Text;
            string phone = txtPhoneCustomer.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (countryLaw == "".Trim()) errors.Add("Выбирите страну юридического адреса");
            if (cityLaw == "".Trim()) errors.Add("Выбирите город юридического адреса");
            if (addressLaw == "".Trim()) errors.Add("Поле 'Юридический адрес' не может оставаться пустым");

            if (countryReal == "".Trim()) errors.Add("Выбирите страну фактического адреса");
            if (cityReal == "".Trim()) errors.Add("Выбирите город фактического адреса");
            if (addressReal == "".Trim()) errors.Add("Поле 'Фактический адрес' не может оставаться пустым");

            if (name == "".Trim()) errors.Add("Поле 'Имя заказчика' не может оставаться пустым");
            if (surname == "".Trim()) errors.Add("Поле 'Фамилия заказчика' не может оставаться пустым");
            if (middleName == "".Trim()) errors.Add("Поле 'Отчество заказчика' не может оставаться пустым");

            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");
            if (email == "".Trim()) errors.Add("Поле 'Email' не может оставаться пустым");
            if (phone == "".Trim()) errors.Add("Поле 'Номер телефона' не может оставаться пустым");

            // Проверка email на валидность
            if (!Helper.IsValidEmail(email)) errors.Add("Email введён некорректно");

            // Проверка на длину полей
            if (name.Length < 3) errors.Add("Поле 'Имя заказчика' не может быть меньше трёх символов");
            if (surname.Length < 3) errors.Add("Поле 'Фамилия заказчика' не может быть меньше трёх символов");
            if (middleName.Length < 3) errors.Add("Поле 'Отчество заказчика' не может быть меньше трёх символов");

            if (title.Length < 3) errors.Add("Поле 'Наименование' не может быть меньше трёх символов");
            if (email.Length < 4) errors.Add("Поле 'Email' не может быть меньше четырёх символов");
            if (phone.Length < 3) errors.Add("Поле 'Номер телефона' быть меньше трёх символов");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Изменение данных
                string query = @"UPDATE Заказчики SET
                                            Наименование = '" + title + "', " +
                                           "Юридический_адрес = '" + countryLaw + ", г. " + cityLaw + ", " + addressLaw + "', " +
                                           "Фактический_адрес = '" + countryReal + ", г. " + cityReal + ", " + addressReal + "', " +
                                           "ФИО_руководителя = '" + name + " " + surname + " " + middleName + "', " +
                                           "Телефон = '" + phone + "', " +
                                           "Электронная_почта = '" + email + "'" +
                                           "   WHERE Код_заказчика = " + ManagerMainForm.idCurrentRowCustomer;

                OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Запись о заказчике была успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void comboBoxLawCountryAddressCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            getCities(comboBoxLawCountryAddressCustomer, comboBoxLawCityAddressCustomer);
        }

        private void comboBoxRealCountryAddressCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            getCities(comboBoxRealCountryAddressCustomer, comboBoxRealCityAddressCustomer);
        }
    }
}
