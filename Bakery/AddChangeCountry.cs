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
    public partial class AddChangeCountry : MetroFramework.Forms.MetroForm
    {
        public AddChangeCountry()
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

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentCountry == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о стране:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о стране:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Название
                                          FROM Страны
                                             WHERE Код = " + ManagerMainForm.idCurrentRowCountry;

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtTitle.Text = reader["Название"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Вставка данных
                string insertQuery = @"INSERT INTO Страны (Название)
                                                VALUES ('" + title + "')";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новыя запись о стране была успешно добавлена!\nВы хотите продолжить добавление стран?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (title == "".Trim()) errors.Add("Поле 'Наименование' не может оставаться пустым");

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Изменение данных
                string query = @"UPDATE Страны SET 
                                        Название = '" + title + "'" +
                                       "   WHERE Код = " + ManagerMainForm.idCurrentRowCountry;

                OleDbCommand insertCommand = new OleDbCommand(query, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Запись о стране была успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
