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
    public partial class AddChangeOrder : MetroFramework.Forms.MetroForm
    {
        private int onePrice = 0;
        private int oneWeight = 0;

        private int globalPrice = 0;
        private int globalCount = 0;

        private int idMadeProduct = 0;

        public AddChangeOrder()
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
            string selectQueryProduct = @"SELECT Наименование FROM Продукция";

            OleDbCommand selectCommandProduct = new OleDbCommand(selectQueryProduct, Connection.getConnection());

            OleDbDataReader selectReaderPosition = selectCommandProduct.ExecuteReader();

            while (selectReaderPosition.Read())
            {
                comboBoxProduct.Items.Add(selectReaderPosition[0]);
            }

            // Заполнение comboBox странами
            string selectQueryCountry = @"SELECT Наименование FROM Заказчики";

            OleDbCommand selectCustomer = new OleDbCommand(selectQueryCountry, Connection.getConnection());

            OleDbDataReader selectReaderCountry = selectCustomer.ExecuteReader();

            while (selectReaderCountry.Read())
            {
                comboBoxCustomer.Items.Add(selectReaderCountry[0].ToString());
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentOrder == false)
            {
                btnChangeEmployee.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о заказе:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о заказе:";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string product = comboBoxProduct.Text;
            string customer = comboBoxCustomer.Text;
            string date = DateTime.Now.ToShortDateString();
            string count = txtCount.Text;

            date = DateTime.Parse(date).ToString("dd.MM.yyyy");

            List<string> errors = new List<string>();

            // Проверка полей на пустоту
            if (count == "".Trim()) errors.Add("Поле 'Количество' не может оставаться пустым");
            if (date == "".Trim()) errors.Add("Поле 'Дата' не может оставаться пустым");
            if (product == "".Trim()) errors.Add("Выбирите продукцию");
            if (customer == "".Trim()) errors.Add("Выбирите заказчика");

            // Проверка числовых типов на нули
            if (count == "0") errors.Add("Количество заказываемой продукции не может равняться нулю");

            int currentCount = 0;

            int.TryParse(count, out currentCount);

            // Проверка на количество товара
            if (currentCount > globalCount) errors.Add("Вы ввели слишком большое количество. Этой продукции нет в таком количестве. Всего в наличии: " + globalCount);

            // Проверяет есть ли ошибки
            if (errors.Count == 0) // Если ошибок нет
            {
                // Получение id выбранной продукции
                string selectQueryCustomer = @"SELECT Код_заказчика
                                                    FROM Заказчики
                                                        WHERE Наименование = '" + customer + "'";

                int customerId = Helper.getId(selectQueryCustomer);

                // Вставка данных
                string insertQuery = @"INSERT INTO Заказы (Количество,
                                                           Дата,
                                                           Стоимость,
                                                           Код_приготовления,
                                                           Код_заказчика)
                                            VALUES (" + count + "," +
                                            "'" + date + "', " +
                                            "" + globalPrice + ", " +
                                            "" + idMadeProduct + ", " +
                                            "" + customerId + ")";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                // Вычитаем товары из таблицы приготовленно
                int newCount = globalCount - currentCount;

                // Изменение данных
                string query = @"UPDATE Приготовления SET
                                            Количество = " + newCount +
                                            "   WHERE Код = " + idMadeProduct;

                insertCommand = new OleDbCommand(query, Connection.getConnection());

                insertCommand.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Запись о заказе продукции была успешно добавлена./nВы хотите продолжить добавление?", "Успех!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {

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

        private void fillComboBoxDates(int productId)
        {
            // Получение id выбранной продукции
            string query = @"SELECT Приготовления.Код,
                                    Продукция.Код_продукции,
                                    Приготовления.Количество,
                                    Продукция.Вес_гр,
                                    Продукция.Срок_годности_в_сутках,
                                    Приготовления.Дата_приготовления
                                FROM Продукция, Приготовления
                                WHERE (Приготовления.Код_продукции = " + productId + ")" +
                                    "   AND " +
                                    "(Продукция.Код_продукции = Приготовления.Код_продукции)";

            OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

            OleDbDataReader reader = command.ExecuteReader();

            comboBoxEnableDatesOrders.Items.Clear();
            comboBoxIds.Items.Clear();

            while (reader.Read())
            {
                string date = reader["Дата_приготовления"].ToString();
                comboBoxEnableDatesOrders.Items.Add(DateTime.Parse(date).ToString("dd.MM.yyyy"));
                comboBoxIds.Items.Add(reader["Код"]);
            }
        }

        private void comboBoxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            string product = comboBoxProduct.Text;

            // Получение id выбранного типа
            string selectQueryProduct = @"SELECT Код_продукции
                                            FROM Продукция
                                                WHERE Наименование = '" + product + "'";

            int productId = Helper.getId(selectQueryProduct);

            fillComboBoxDates(productId);
        }

        private void comboBoxEnableDatesOrders_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(comboBoxEnableDatesOrders.SelectedIndex.ToString(), out id);

            int idMadeP = 0;
            int.TryParse(comboBoxIds.Items[id].ToString(), out idMadeP);

            idMadeProduct = idMadeP;

            string product = comboBoxProduct.Text;
            string date = comboBoxEnableDatesOrders.Text;

            date = DateTime.Parse(date).ToString("dd.MM.yyyy");

            // Получение id выбранного типа
            string selectQueryProduct = @"SELECT Код_продукции
                                            FROM Продукция
                                                WHERE Наименование = '" + product + "'";

            int productId = Helper.getId(selectQueryProduct);

            // Получение id выбранной продукции
            string querySelect = @"SELECT Продукция.Код_продукции,
                                    Приготовления.Количество,
                                    Продукция.Вес_гр,
                                    Продукция.Срок_годности_в_сутках,
                                    Приготовления.Дата_приготовления
                                FROM Продукция, Приготовления
                                WHERE (Приготовления.Код_продукции = " + productId + ")" +
                                    "   AND " +
                                    "(Продукция.Код_продукции = Приготовления.Код_продукции)";

            OleDbCommand commandSelect = new OleDbCommand(querySelect, Connection.getConnection());

            OleDbDataReader readeSelect = commandSelect.ExecuteReader();

            // Получение id выбранной продукции
            string query = @"SELECT Приготовления.Код,
                                    Продукция.Код_продукции,
                                    Приготовления.Количество,
                                    Продукция.Вес_гр,
                                    Продукция.Срок_годности_в_сутках,
                                    Продукция.Оптимальная_стоимость,
                                    Приготовления.Дата_приготовления
                                FROM Продукция, Приготовления
                                    WHERE (Приготовления.Код_продукции = " + productId + ")" +
                                        "   AND " +
                                        "(Приготовления.Код = " + idMadeProduct + ")" +
                                        "   AND " +
                                        "(Приготовления.Код_продукции = Продукция.Код_продукции)";

            OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

            OleDbDataReader reader = command.ExecuteReader();

            reader.Read();

            txtPriceForOne.Text = "";
            int.TryParse(reader["Оптимальная_стоимость"].ToString(), out onePrice);
            int.TryParse(reader["Вес_гр"].ToString(), out oneWeight);
            int.TryParse(reader["Количество"].ToString(), out globalCount);

            lblRest.Text = "Осталось: ";
            lblRest.Text += reader["Количество"];
            txtPriceForOne.Text += reader["Оптимальная_стоимость"];

            fillComboBoxDates(productId);

            txtPriceForOne.Text = onePrice.ToString();
            txtWeightForOne.Text = oneWeight.ToString();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int.TryParse(txtCount.Text, out count);
            globalPrice = onePrice * count;

            txtPrice.Text = globalPrice.ToString();
            txtWeight.Text = (oneWeight * count).ToString();
        }

        private void comboBoxProduct_Enter(object sender, EventArgs e)
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

        private void comboBoxProduct_Leave(object sender, EventArgs e)
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
