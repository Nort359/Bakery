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
    public partial class AddChangeType : MetroFramework.Forms.MetroForm
    {
        public AddChangeType()
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
            if (ManagerMainForm.flagChangeCurrentType == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о типе:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о типе:";

                // Получение выбранной продукции
                string selectQuery = @"SELECT Название
                                          FROM Типы
                                             WHERE Код = " + ManagerMainForm.idCurrentRowType;

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
                string insertQuery = @"INSERT INTO Типы (Название)
                                                VALUES ('" + title + "')";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Новыя запись о типе была успешно добавлена!\nВы хотите продолжить добавление типов?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                string query = @"UPDATE Типы SET 
                                        Название = '" + title + "'" +
                                       "   WHERE Код = " + ManagerMainForm.idCurrentRowType;

                OleDbCommand insertCommand = new OleDbCommand(query, Connection.getConnection());
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Запись о типе была успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
