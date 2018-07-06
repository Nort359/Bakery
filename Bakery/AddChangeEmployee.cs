using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddChangeEmployee : MetroFramework.Forms.MetroForm
    {

        private int getId(string query)
        {
            OleDbCommand selectCommandGetCountryId = new OleDbCommand(query, Connection.getConnection());

            string id = selectCommandGetCountryId.ExecuteScalar().ToString();

            int countryEmployeeId = 0;

            int.TryParse(id, out countryEmployeeId);

            return countryEmployeeId;
        }

        public AddChangeEmployee()
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
            string selectQueryPosition = @"SELECT Должность FROM Должности";

            OleDbCommand selectCommandPosition = new OleDbCommand(selectQueryPosition, Connection.getConnection());

            OleDbDataReader selectReaderPosition = selectCommandPosition.ExecuteReader();

            while(selectReaderPosition.Read())
            {
                comboBoxPositionEmployee.Items.Add(selectReaderPosition[0]);
            }

            // Заполнение comboBox образованием
            string selectQueryEducation = @"SELECT Название FROM Образование";

            OleDbCommand selectCommandEducation = new OleDbCommand(selectQueryEducation, Connection.getConnection());

            OleDbDataReader selectReaderEducation = selectCommandEducation.ExecuteReader();

            while (selectReaderEducation.Read())
            {
                txtEducationEmployee.Items.Add(selectReaderEducation[0]);
            }

            // Заполнение comboBox странами
            string selectQueryCountry = @"SELECT Название FROM Страны";

            OleDbCommand selectCommandCountry = new OleDbCommand(selectQueryCountry, Connection.getConnection());

            OleDbDataReader selectReaderCountry = selectCommandCountry.ExecuteReader();

            while (selectReaderCountry.Read())
            {
                comboBoxCountryEmployee.Items.Add(selectReaderCountry[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentEmployee == false)
            {
                btnChangeEmployee.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о сотруднике:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о сотруднике:";

                // Получение выбранного сотрудника
                string selectQuery = @"SELECT Код_личного_дела,
                                              Фамилия,
                                              Имя,
                                              Отчество,
                                              Должности.Должность,
                                              Дата_рождения AS `Дата рождения`,
                                              Номер_паспорта AS `Номер паспорта`,
                                              Серия_паспорта AS `Серия паспорта`,
                                              ИНН,
                                              Стаж_работы AS `Стаж работы`,
                                              Образование.Название AS `Образование`,
                                              Телефон,
                                              Страны.Название AS `Страна`,
                                              Города.Название AS `Город`,
                                              Сотрудники.Адрес
                                        FROM Сотрудники, Должности, Страны, Города, Образование
                                            WHERE
                                                (Сотрудники.Должность = Должности.Код_должности)
                                                    AND
                                                (Сотрудники.Код_образования = Образование.Код)
                                                    AND 
                                                (Сотрудники.Код_страны = Страны.Код)
                                                    AND
                                                (Сотрудники.Код_города = Города.Код)
                                                    AND
                                                (Сотрудники.Код_личного_дела = " + ManagerMainForm.idCurrentRowEmployee + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtNameEmployee.Text = reader["Имя"].ToString();
                txtSurnameEmployee.Text = reader["Фамилия"].ToString();
                txtMiddleNameEmployee.Text = reader["Отчество"].ToString();
                comboBoxPositionEmployee.Text = reader["Должность"].ToString();
                txtBirthDayEmployee.Text = reader["Дата рождения"].ToString();
                txtPassportNumberEmployee.Text = reader["Номер паспорта"].ToString();
                txtSerialNumberEmployee.Text = reader["Серия паспорта"].ToString();
                txtINNEmployee.Text = reader["ИНН"].ToString();
                txtPhoneNumberEmployee.Text = reader["Телефон"].ToString();
                txtExpirienceEmployee.Text = reader["Стаж работы"].ToString();
                txtEducationEmployee.Text = reader["Образование"].ToString();
                txtAddressEmployee.Text = reader["Адрес"].ToString();
                comboBoxCountryEmployee.Text = reader["Страна"].ToString();
                comboBoxCityEmployee.Text = reader["Город"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string surname = txtSurnameEmployee.Text;
            string name = txtNameEmployee.Text;
            string middleName = txtMiddleNameEmployee.Text;
            string position = comboBoxPositionEmployee.Text;
            string birthDay = txtBirthDayEmployee.Value.ToShortDateString();
            string passportNumber = txtPassportNumberEmployee.Text;
            string passportSerial = txtSerialNumberEmployee.Text;
            string INN = txtINNEmployee.Text;
            string expirience = txtExpirienceEmployee.Text;
            string education = txtEducationEmployee.Text;
            string phoneNumber = txtPhoneNumberEmployee.Text;
            string country = comboBoxCountryEmployee.Text;
            string city = comboBoxCityEmployee.Text;
            string address = txtAddressEmployee.Text;


            birthDay = DateTime.Parse(birthDay).ToString("dd.MM.yyyy");

            if (surname.Length >= 3 && name.Length >= 3 && middleName.Length >= 3 &&
                position.Length >= 3 && birthDay.Length >= 3 && passportNumber.Length >= 3 &&
                passportSerial.Length >= 3 && INN.Length >= 3 && education.Length >= 3 &&
                phoneNumber.Length >= 3 && country.Length >= 3 && city.Length >= 3 && address.Length >= 3)
            {
                // Получение id выбранной должности
                string positionEmployeeText = comboBoxPositionEmployee.Text;

                string selectQueryGetPosition = @"SELECT Код_должности
                                                    FROM Должности
                                                        WHERE Должность = '" + positionEmployeeText + "'";

                int positionEmployeeId = getId(selectQueryGetPosition);

                // Получение id выбранной страны
                string contryEmployeeText = comboBoxCountryEmployee.Text;

                string selectQueryGetCountryId = @"SELECT Код
                                                      FROM Страны
                                                          WHERE Название = '" + contryEmployeeText + "'";

                int countryEmployeeId = getId(selectQueryGetCountryId);

                // Получение id выбранного города
                string cityEmployeeText = comboBoxCityEmployee.Text;

                string selectQueryGetCityId = @"SELECT Код
                                                    FROM Города
                                                        WHERE Название = '" + cityEmployeeText + "'";

                int cityEmployeeId = getId(selectQueryGetCityId);

                // Получение id выбранного образования
                string eduEmployeeText = txtEducationEmployee.Text;

                string selectQueryGetEduId = @"SELECT Код
                                                    FROM Образование
                                                        WHERE Название = '" + eduEmployeeText + "'";

                int eduEmployeeId = getId(selectQueryGetEduId);

                // Вставка данных
                string insertQuery = @"INSERT INTO Сотрудники (Фамилия, Имя, Отчество, Должность, Дата_рождения, Номер_паспорта, Серия_паспорта, ИНН, Стаж_работы, Код_образования, Телефон, Код_страны, Код_города, Адрес)
                                        VALUES ('" + surname + "', '" + name + "', '" + middleName +
                                            "', " + positionEmployeeId + ", '" + birthDay + "', " + passportNumber + ", " + passportSerial + "" +
                                            ", " + INN + ", '" + expirience + "', " + eduEmployeeId + ", '" + phoneNumber + "', " +
                                            "" + countryEmployeeId + ", " + cityEmployeeId + ", '" + address + "')";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новый сотрудник был успешно добавлен!\nВы хотите продолжить добавление новых сотрудников?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Не все данные были введены.\nПожалуйста, проверьте поля ввода и повторите снова.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void comboBoxCountryEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            // Получение id выбранной страны
            string contryEmployeeText = comboBoxCountryEmployee.Text;

            string selectQueryGetCountryId = @"SELECT Код
                                                FROM Страны
                                                    WHERE Название = '" + contryEmployeeText + "'";

            int countryEmployeeId = getId(selectQueryGetCountryId);

            if (countryEmployeeId != 0)
            {
                // Заполнение comboBox городами
                string selectQueryCity = @"SELECT Название
                                             FROM Города
                                                WHERE Код_страны = " + countryEmployeeId;

                OleDbCommand selectCommandCity = new OleDbCommand(selectQueryCity, Connection.getConnection());

                OleDbDataReader selectReaderCity = selectCommandCity.ExecuteReader();

                comboBoxCityEmployee.Items.Clear();
                comboBoxCityEmployee.MaxDropDownItems = 5;

                while (selectReaderCity.Read())
                {
                    comboBoxCityEmployee.Items.Add(selectReaderCity[0]);
                }
            }
        }

        private void txtMiddleNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if ((letter < 'А' || letter > 'я') && letter != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPassportNumberEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            string surname = txtSurnameEmployee.Text;
            string name = txtNameEmployee.Text;
            string middleName = txtMiddleNameEmployee.Text;
            string position = comboBoxPositionEmployee.Text;
            string birthDay = txtBirthDayEmployee.Value.ToShortDateString();
            string passportNumber = txtPassportNumberEmployee.Text;
            string passportSerial = txtSerialNumberEmployee.Text;
            string INN = txtINNEmployee.Text;
            string expirience = txtExpirienceEmployee.Text;
            string education = txtEducationEmployee.Text;
            string phoneNumber = txtPhoneNumberEmployee.Text;
            string country = comboBoxCountryEmployee.Text;
            string city = comboBoxCityEmployee.Text;
            string address = txtAddressEmployee.Text;


            birthDay = DateTime.Parse(birthDay).ToString("dd.MM.yyyy");

            if (surname.Length >= 3 && name.Length >= 3 && middleName.Length >= 3 &&
                position.Length >= 3 && birthDay.Length >= 3 && passportNumber.Length >= 3 &&
                passportSerial.Length >= 3 && INN.Length >= 3 && education.Length >= 3 &&
                phoneNumber.Length >= 3 && country.Length >= 3 && city.Length >= 3 && address.Length >= 3)
            {
                // Получение id выбранной должности
                string positionEmployeeText = comboBoxPositionEmployee.Text;

                string selectQueryGetPosition = @"SELECT Код_должности
                                                    FROM Должности
                                                        WHERE Должность = '" + positionEmployeeText + "'";

                int positionEmployeeId = getId(selectQueryGetPosition);

                // Получение id выбранной страны
                string contryEmployeeText = comboBoxCountryEmployee.Text;

                string selectQueryGetCountryId = @"SELECT Код
                                                      FROM Страны
                                                          WHERE Название = '" + contryEmployeeText + "'";

                int countryEmployeeId = getId(selectQueryGetCountryId);

                // Получение id выбранного города
                string cityEmployeeText = comboBoxCityEmployee.Text;

                string selectQueryGetCityId = @"SELECT Код
                                                    FROM Города
                                                        WHERE Название = '" + cityEmployeeText + "'";

                int cityEmployeeId = getId(selectQueryGetCityId);

                // Получение id выбранного образования
                string eduEmployeeText = txtEducationEmployee.Text;

                string selectQueryGetEduId = @"SELECT Код
                                                    FROM Образование
                                                        WHERE Название = '" + eduEmployeeText + "'";

                int eduEmployeeId = getId(selectQueryGetEduId);

                // Обновление данных
                string updateQuery = @"UPDATE Сотрудники SET
                                              Фамилия = '" + surname + "', " +
                                              "Имя = '" + name + "', " +
                                              "Отчество = '" + middleName + "', " +
                                              "Должность = '" + positionEmployeeId + "', " +
                                              "Дата_рождения = '" + birthDay + "', " +
                                              "Номер_паспорта = " + passportNumber + ", " +
                                              "Серия_паспорта = " + passportSerial + ", " +
                                              "ИНН = " + INN + ", " +
                                              "Стаж_работы = '" + expirience + "', " +
                                              "Код_образования = " + eduEmployeeId + ", " +
                                              "Телефон = '" + phoneNumber + "', " +
                                              "Код_страны = " + countryEmployeeId + ", " +
                                              "Код_города = " + cityEmployeeId + ", " +
                                              "Адрес = '" + address + "'" +
                                              "   WHERE Код_личного_дела = " + ManagerMainForm.idCurrentRowEmployee;

                OleDbCommand updateCommand = new OleDbCommand(updateQuery, Connection.getConnection());

                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Данные о сотруднике были успешно изменены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Не все данные были введены.\nПожалуйста, проверьте поля ввода и повторите снова.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Styles
        private void txtNameEmployee_Enter(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtNameEmployee_Leave(object sender, EventArgs e)
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
        #endregion
    }
}
