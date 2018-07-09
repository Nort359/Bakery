using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bakery
{
    public partial class ManagerMainForm : MetroFramework.Forms.MetroForm
    {
        // Переменные для таблицы Сотрудники
        public static int idCurrentRowEmployee = -1;
        public static bool flagChangeCurrentEmployee = false;

        // Переменные для таблицы Продукция
        public static int idCurrentRowProduct = -1;
        public static bool flagChangeCurrentProduct = false;

        // Переменные для таблицы Приготовления
        public static int idCurrentRowMadeProduct = -1;
        public static bool flagChangeCurrentMadeProduct = false;

        // Переменные для таблицы Заказчики
        public static int idCurrentRowCustomer = -1;
        public static bool flagChangeCurrentCustomer = false;

        // Переменные для таблицы Заказы
        public static int idCurrentRowOrder = -1;
        public static bool flagChangeCurrentOrder = false;

        // Переменные для таблицы Сырьё
        public static int idCurrentRowMaterial = -1;
        public static bool flagChangeCurrentMaterial = false;

        private void makeReport(DataGridView dataGrid, string tableName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);

                    string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                    var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    var fontBold = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"/image.png");
                        jpg.Alignment = Element.ALIGN_CENTER;
                        doc.Add(jpg);
                        PdfPTable table = new PdfPTable(dataGrid.Columns.Count - 1);

                        PdfPCell cell = new PdfPCell(new Phrase(tableName, fontBold));

                        cell.BackgroundColor = new BaseColor(Color.Wheat);
                        cell.Padding = 20;
                        cell.Colspan = dataGrid.ColumnCount - 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;

                        table.AddCell(cell);


                        for (int j = 0; j < dataGrid.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                continue;
                            }

                            PdfPCell itemCapture = new PdfPCell(new Phrase(dataGrid.Columns[j].HeaderText, fontBold));

                            itemCapture.Padding = 5;
                            itemCapture.Colspan = 1;
                            itemCapture.HorizontalAlignment = Element.ALIGN_CENTER;

                            table.AddCell(itemCapture);
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dataGrid.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGrid.Columns.Count; j++)
                            {
                                if (j == 0)
                                {
                                    continue;
                                }

                                if (dataGrid[j, i].Value != null)
                                {
                                    PdfPCell itemCapture = new PdfPCell(new Phrase(dataGrid[j, i].Value.ToString(), font));

                                    itemCapture.Padding = 5;
                                    itemCapture.Colspan = 1;
                                    itemCapture.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(itemCapture);
                                }
                            }
                        }

                        doc.Add(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void fillDataGrid(string query, DataGridView dataGrid, int width = 120)
        {
            OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                DataTable dbDataSet = new DataTable();
                adapter.Fill(dbDataSet);

                BindingSource bSourse = new BindingSource();
                bSourse.DataSource = dbDataSet;

                dataGrid.DataSource = bSourse;

                adapter.Update(dbDataSet);

                dataGrid.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].MinimumWidth = width;
            }
        }

        private void fillDataGridEmployee()
        {
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
                                            (Сотрудники.Код_города = Города.Код)";

            fillDataGrid(selectQuery, dataGridEmployee, 124);

            comboBoxSearchEmployee.SelectedIndex = 0;
        }

        private void fillDataGridProduct()
        {
            string selectQuery = @"SELECT Код_продукции, Наименование, Вес_гр AS `Вес (гр)`,
                                          Срок_годности_в_сутках AS `Срок годности (сут)`,
                                          Оптимальная_стоимость AS `Оптимальная стоимость`,
                                          Розничная_стоимость AS `Розничная стоимость`,
                                          Сотрудники.Имя, Сотрудники.Фамилия, Сотрудники.Отчество
                                     FROM Сотрудники, Продукция
                                        WHERE
                                            (Сотрудники.Код_личного_дела = Продукция.Код_сотрудника)";

            fillDataGrid(selectQuery, dataGridProduct, 108);

            comboBoxSearchProduct.SelectedIndex = 0;
        }

        private void fillDataGridMadeProduct()
        {
            string selectQuery = @"SELECT Приготовления.Код,
                                          Продукция.Наименование,
                                          Продукция.Вес_гр AS `Вес (гр)`,
                                          Продукция.Срок_годности_в_сутках AS `Срок годности (сут)`,
                                          Продукция.Оптимальная_стоимость AS `Оптимальная стоимость`,
                                          Приготовления.Количество,
                                          Приготовления.Дата_приготовления AS `Дата приготовления`,
                                          Типы.Название AS `Измеряется в`,
                                          Продукция.Розничная_стоимость AS `Розничная стоимость`,
                                          Сотрудники.Имя,
                                          Сотрудники.Фамилия,
                                          Сотрудники.Отчество
                                     FROM Сотрудники, Продукция, Приготовления, Типы
                                        WHERE
                                            (Сотрудники.Код_личного_дела = Продукция.Код_сотрудника)
                                                AND 
                                            (Приготовления.Код_продукции = Продукция.Код_продукции)
                                                AND 
                                            (Приготовления.Код_типа = Типы.Код)";

            fillDataGrid(selectQuery, dataGridMadeProduct, 108);

            comboBoxSearchMadeProduct.SelectedIndex = 0;
        }

        private void fillDataGridCustomer()
        {
            string selectQuery = @"SELECT Код_заказчика,
                                          Наименование,
                                          Юридический_адрес AS `Юридический адрес`,
                                          Фактический_адрес AS `Фактический адрес`,
                                          ФИО_руководителя AS `ФИО_руководителя`,
                                          Телефон,
                                          Электронная_почта AS `Электронная почта`
                                    FROM Заказчики";

            fillDataGrid(selectQuery, dataGridCustomer, 144);

            comboBoxSearchCustomers.SelectedIndex = 0;
        }

        private void fillDataGridOrders()
        {
            
             string selectQuery = @"SELECT Заказы.Код_заказа,
                                           Продукция.Наименование AS `Наименование продукции`,
                                           Заказчики.Наименование AS `Наименование заказчика`,
                                           Заказы.Количество,
                                           Заказы.Дата AS `Дата заказа`,
                                           Заказы.Стоимость AS `Общая стоимость заказа`,
                                           Заказы.Количество * Продукция.Вес_гр AS `Общий вес (гр)`
                                      FROM Заказчики, Заказы, Приготовления, Продукция
                                         WHERE (Заказы.Код_заказчика = Заказчики.Код_заказчика)
                                                  AND
                                               (Заказы.Код_приготовления = Приготовления.Код)
                                                  AND 
                                               (Приготовления.Код_продукции = Продукция.Код_продукции)";

            fillDataGrid(selectQuery, dataGridOrders, 108);

            comboBoxSearchOrders.SelectedIndex = 0;
        }

        private void fillDataGridMaterial()
        {
            string selectQuery = @"SELECT Сырьё.Код_сырья,
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
                                          (Сырьё.Код_продукции = Продукция.Код_продукции)";

            fillDataGrid(selectQuery, dataGridMaterial, 108);

            comboBoxSearchMaterial.SelectedIndex = 0;
        }

        public ManagerMainForm()
        {
            InitializeComponent();

            try
            {
                Connection.getConnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Меняем флаг изменения данных в начальный state
            flagChangeCurrentEmployee = false;
            flagChangeCurrentProduct = false;
            flagChangeCurrentMadeProduct = false;
            flagChangeCurrentCustomer = false;
            flagChangeCurrentOrder = false;
            flagChangeCurrentMaterial = false;

            // Заполнение dataGrid Сотрудники данными из БД
            fillDataGridEmployee();

            // Заполнение dataGrid Продукции данными из БД
            fillDataGridProduct();

            // Заполнение dataGrid Приготовления данными из БД
            fillDataGridMadeProduct();

            // Заполнение dataGrid Заказчики данными из БД
            fillDataGridCustomer();

            // Заполнение dataGrid Заказы данными из БД
            fillDataGridOrders();

            // Заполнение dataGrid Сырьё данными из БД
            fillDataGridMaterial();

            // Значение id по умолчанию
            try { int.TryParse(dataGridEmployee.Rows[0].Cells[0].Value.ToString(), out idCurrentRowEmployee); } catch(Exception e) { }
            try { int.TryParse(dataGridProduct.Rows[0].Cells[0].Value.ToString(), out idCurrentRowProduct); } catch (Exception e) { }
            try { int.TryParse(dataGridMadeProduct.Rows[0].Cells[0].Value.ToString(), out idCurrentRowMadeProduct); } catch(Exception e) { }
            try { int.TryParse(dataGridCustomer.Rows[0].Cells[0].Value.ToString(), out idCurrentRowCustomer); } catch (Exception e) { }
            try { int.TryParse(dataGridOrders.Rows[0].Cells[0].Value.ToString(), out idCurrentRowOrder); } catch (Exception e) { }
            try { int.TryParse(dataGridMaterial.Rows[0].Cells[0].Value.ToString(), out idCurrentRowMaterial); } catch (Exception e) { }

            tabControll.TabPages[0].Select();

            // Сразу делаем чекбоксы выделенными в таблице Приготовления
            checkBoxTimeIsMadeProduct.Checked = true;
            checkBoxTimeLessMadeProduct.Checked = true;
            checkBoxTimeNoMadeProduct.Checked = true;
        }

        #region Admin panel

        private void btnMakeBackUpBD_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "dbBackup(" + DateTime.Today.ToString("dd.MM.yyyy") + ")" + ".mdb";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string pathFile = saveFileDialog1.FileName;
                    Connection.getConnection().Close();

                    File.Copy(Connection.getDBName(), @pathFile, true);

                    MessageBox.Show("Резервное копирование успешно завершено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.getConnection().Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnGetDBFromCopy_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string pathFile = openFileDialog1.FileName;
                    Connection.getConnection().Close();

                    File.Copy(@pathFile, @"BakeryDB.mdb", true);
                    MessageBox.Show("Восстановление успешно завершено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Connection.getConnection().Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion

        #region Employees

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeEmployee();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            flagChangeCurrentEmployee = true;

            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeEmployee();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // Получание удаляемого сотрудника
            string selectQuery = @"SELECT Фамилия, Имя, Отчество
                                    FROM Сотрудники
                                        WHERE Код_личного_дела = " + idCurrentRowEmployee.ToString();

            OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            string name = reader[0].ToString();
            string surname = reader[1].ToString();
            string middleName = reader[2].ToString();

            // Вставка данных
            string deleteQuery = @"DELETE FROM Сотрудники WHERE Код_личного_дела = " + idCurrentRowEmployee.ToString();

            OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

            DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить сотрудника: '" + name + " "
                                                            + surname + " " + middleName + "' из БД?",
                                                            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем запись и обновляем dataGrid
                deleteCommand.ExecuteNonQuery();
                fillDataGridEmployee();
            }
        }

        private void btnAddEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(133, 156, 42);
            btn.ForeColor = Color.FromName("ControlLightLight");
        }

        private void btnAddEmployee_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromName("ControlLightLight");
            btn.ForeColor = Color.FromArgb(41, 39, 40);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridEmployee.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowEmployee);
            }
        }

        private void btnReportEmployee_Click(object sender, EventArgs e)
        {
            makeReport(dataGridEmployee, "Таблица сотрудников");
        }

        private void txtNameEmployee_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchEmployee.Text;

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
                                            (Сотрудники.Код_города = Города.Код)";

            switch (comboBoxSearchEmployee.SelectedIndex)
            {
                case 0:
                    {
                        selectQuery += "    AND " +
                                       "((Фамилия LIKE '%" + search + "%')" +
                                       "   OR" +
                                       "(Имя LIKE '%" + search + "%')" +
                                       "   OR" +
                                       "(Отчество LIKE '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        selectQuery += "    AND " +
                                       "(Фамилия LIKE '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        selectQuery += "    AND " +
                                       "(Имя LIKE '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += "    AND " +
                                       "(Отчество LIKE '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridEmployee, 124);
        }

        #endregion


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"index.html");
        }

        #region Products

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeProduct();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            flagChangeCurrentProduct = true;

            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeProduct();

            Close();

            Program.Context.MainForm.Show();
        }

        private void txtFromOptimalPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtFromOptimalPriceProduct_TextChanged(object sender, EventArgs e)
        {
            string fromOptimalPrice = txtFromOptimalPriceProduct.Text != "".Trim() ? txtFromOptimalPriceProduct.Text : "0";
            string toOptimalPrice = txtToOptimalPriceProduct.Text != "".Trim() ? txtToOptimalPriceProduct.Text : "999999999";

            string fromRealPrice = txtFromRealPriceProduct.Text != "".Trim() ? txtFromRealPriceProduct.Text : "0";
            string toRealPrice = txtToRealPriceProduct.Text != "".Trim() ? txtToRealPriceProduct.Text : "999999999";

            string fromWeight = txtFromWeightProduct.Text != "".Trim() ? txtFromWeightProduct.Text : "0";
            string toWeight = txtToWeightProduct.Text != "".Trim() ? txtToWeightProduct.Text : "999999999";

            string search = txtSearchProduct.Text;

            string selectQuery = @"SELECT Код_продукции, Наименование, Вес_гр AS `Вес (гр)`,
                                          Срок_годности_в_сутках AS `Срок годности (сут)`,
                                          Оптимальная_стоимость AS `Оптимальная стоимость`,
                                          Розничная_стоимость AS `Розничная стоимость`,
                                          Сотрудники.Имя, Сотрудники.Фамилия, Сотрудники.Отчество
                                     FROM Сотрудники, Продукция
                                        WHERE
                                            (Сотрудники.Код_личного_дела = Продукция.Код_сотрудника)
                                                AND 
                                            ((Продукция.Оптимальная_стоимость >= " + fromOptimalPrice + ")" +
                                            "   AND " +
                                            "(Продукция.Оптимальная_стоимость <= " + toOptimalPrice + "))" +
                                            "   AND " +
                                            "((Продукция.Розничная_стоимость >= " + fromRealPrice + ")" +
                                            "   AND " +
                                            "(Продукция.Розничная_стоимость <= " + toRealPrice + "))" +
                                            "   AND " +
                                            "((Продукция.Вес_гр >= " + fromWeight + ")" +
                                            "   AND " +
                                            "(Продукция.Вес_гр <= " + toWeight + "))";

            switch(comboBoxSearchProduct.SelectedIndex)
            {
                case 0:
                    {
                        selectQuery += "    AND " +
                                       "((Сотрудники.Фамилия LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Сотрудники.Имя LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Сотрудники.Отчество LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Продукция.Наименование LIKE '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        selectQuery += "    AND " +
                                       "(Продукция.Наименование LIKE '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Фамилия LIKE '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Имя LIKE '%" + search + "%')";
                    }
                    break;

                case 4:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Отчество LIKE '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridProduct, 108);
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridProduct.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowProduct);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Получание удаляемого сотрудника
                string selectQuery = @"SELECT Наименование
                                    FROM Продукция
                                        WHERE Код_продукции = " + idCurrentRowProduct.ToString();

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                string title = reader[0].ToString();

                // Вставка данных
                string deleteQuery = @"DELETE FROM Продукция WHERE Код_продукции = " + idCurrentRowProduct.ToString();

                OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

                DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить продукцию: '" + title + "' из БД?",
                                                                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Удаляем запись и обновляем dataGrid
                    deleteCommand.ExecuteNonQuery();
                    fillDataGridProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReportProduct_Click(object sender, EventArgs e)
        {
            makeReport(dataGridProduct, "Таблица продукции");
        }

        #endregion

        #region MadeProduct
        private void btnAddMadeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeMadeProduct();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeMadeProduct_Click(object sender, EventArgs e)
        {
            flagChangeCurrentMadeProduct = true;

            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeMadeProduct();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnDeleteMadeProduct_Click(object sender, EventArgs e)
        {
            // Удаление
            string deleteQuery = @"DELETE FROM Приготовления WHERE Код = " + idCurrentRowMadeProduct.ToString();

            OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

            DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить текущуюю запись из БД?",
                                                            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем запись и обновляем dataGrid
                deleteCommand.ExecuteNonQuery();
                fillDataGridMadeProduct();
            }
        }

        private void btnReportMadeProduct_Click(object sender, EventArgs e)
        {
            makeReport(dataGridMadeProduct, "Таблица приготовления");
        }

        private void dataGridMadeProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridMadeProduct.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowMadeProduct);
            }
        }

        private void dataGridMadeProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DateTime date;
            DateTime now = DateTime.Now;

            DateTime.TryParse(dataGridMadeProduct.Rows[e.RowIndex].Cells[6].Value.ToString(), out date);

            int timeToDown = 0;

            TimeSpan t = now - date;
            double NrOfDays = t.TotalDays;
            int.TryParse(dataGridMadeProduct.Rows[e.RowIndex].Cells[3].Value.ToString(), out timeToDown);

            int restTime = timeToDown - int.Parse(Math.Round(NrOfDays).ToString());

            if (restTime > 2)
            {
                // До окончания срока годности ещё долго
                dataGridMadeProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(127, 255, 0);
            }
            else if (restTime <= 2 && restTime > 0)
            {
                // Срок годности вот вот истечёт
                dataGridMadeProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 165, 0);
            }
            else if (restTime <= 0)
            {
                // Срок годности истёк
                dataGridMadeProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(220, 20, 60);
                dataGridMadeProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            // Удаляем строки, если определённые чекбоксы выключены
            if (!checkBoxTimeIsMadeProduct.Checked)
            {
                if (restTime > 2)
                {
                    // До окончания срока годности ещё долго
                    dataGridMadeProduct.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (!checkBoxTimeLessMadeProduct.Checked)
            {
                if (restTime <= 2 && restTime > 0)
                {
                    // До окончания срока годности ещё долго
                    dataGridMadeProduct.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (!checkBoxTimeNoMadeProduct.Checked)
            {
                if (restTime <= 0)
                {
                    // До окончания срока годности ещё долго
                    dataGridMadeProduct.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void txtSearchMadeProduct_TextChanged(object sender, EventArgs e)
        {
            string fromCount = txtFromCountMadeProduct.Text != "".Trim() ? txtFromCountMadeProduct.Text : "0";
            string toCount = txtToCountMadeProduct.Text != "".Trim() ? txtToCountMadeProduct.Text : "999999999";

            bool isTimeIs = checkBoxTimeIsMadeProduct.Checked;
            bool isTimeLess = checkBoxTimeLessMadeProduct.Checked;
            bool isTimeNo = checkBoxTimeNoMadeProduct.Checked;

            string search = txtSearchMadeProduct.Text;

            string selectQuery = @"SELECT Приготовления.Код,
                                          Продукция.Наименование,
                                          Продукция.Вес_гр AS `Вес (гр)`,
                                          Продукция.Срок_годности_в_сутках AS `Срок годности (сут)`,
                                          Продукция.Оптимальная_стоимость AS `Оптимальная стоимость`,
                                          Приготовления.Количество,
                                          Приготовления.Дата_приготовления AS `Дата приготовления`,
                                          Типы.Название AS `Измеряется в`,
                                          Продукция.Розничная_стоимость AS `Розничная стоимость`,
                                          Сотрудники.Имя,
                                          Сотрудники.Фамилия,
                                          Сотрудники.Отчество
                                     FROM Сотрудники, Продукция, Приготовления, Типы
                                        WHERE
                                            (Сотрудники.Код_личного_дела = Продукция.Код_сотрудника)
                                                AND 
                                            (Приготовления.Код_продукции = Продукция.Код_продукции)
                                                AND 
                                            (Приготовления.Код_типа = Типы.Код)
                                                AND 
                                            ((Приготовления.Количество >= " + fromCount + ")" +
                                            "   AND " +
                                            "(Приготовления.Количество <= " + toCount + "))";

            switch(comboBoxSearchMadeProduct.SelectedIndex)
            {
                case 0:
                    {
                        selectQuery += "    AND " +
                                       "((Сотрудники.Фамилия LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Сотрудники.Имя LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Сотрудники.Отчество LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Продукция.Наименование LIKE '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        selectQuery += "    AND " +
                                       "(Продукция.Наименование LIKE '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Фамилия LIKE '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Имя LIKE '%" + search + "%')";
                    }
                    break;

                case 4:
                    {
                        selectQuery += "    AND " +
                                       "(Сотрудники.Отчество LIKE '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridMadeProduct, 108);
        }

        #endregion

        #region Customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeCustomer();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {
            flagChangeCurrentCustomer = true;

            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeCustomer();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Получание удаляемого заказчика
            string selectQuery = @"SELECT Наименование
                                    FROM Заказчики
                                        WHERE Код_заказчика = " + idCurrentRowCustomer.ToString();

            OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            string title = reader[0].ToString();

            // Удаление данных
            string deleteQuery = @"DELETE FROM Заказчики WHERE Код_заказчика = " + idCurrentRowCustomer.ToString();

            OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

            DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить заказчика: '" + title + "' из БД?",
                                                            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем запись и обновляем dataGrid
                deleteCommand.ExecuteNonQuery();
                fillDataGridCustomer();
            }
        }

        private void btnReportCustomer_Click(object sender, EventArgs e)
        {
            makeReport(dataGridCustomer, "Таблица заказчиков");
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridCustomer.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowCustomer);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchCustomer.Text;

            string selectQuery = @"SELECT Код_заказчика,
                                          Наименование,
                                          Юридический_адрес AS `Юридический адрес`,
                                          Фактический_адрес AS `Фактический адрес`,
                                          ФИО_руководителя AS `ФИО_руководителя`,
                                          Телефон,
                                          Электронная_почта AS `Электронная почта`
                                    FROM Заказчики";

            switch(comboBoxSearchCustomers.SelectedIndex)
            {
                case 0:
                    {
                        selectQuery += " WHERE ((Наименование LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(ФИО_руководителя LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Юридический_адрес LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Фактический_адрес LIKE '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        selectQuery += " WHERE (Наименование LIKE '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        selectQuery += " WHERE (ФИО_руководителя LIKE '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += " WHERE (Юридический_адрес LIKE '%" + search + "%')";
                    }
                    break;

                case 4:
                    {
                        selectQuery += " WHERE (Фактический_адрес LIKE '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridCustomer, 144);
        }

        #endregion

        #region Orders
        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeOrder();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            // Удаление данных
            // При удалении заказа нужно вернуть количество заказнной продукции в таблицу приготовление
            string deleteQuery = @"DELETE FROM Заказы WHERE Код_заказа = " + idCurrentRowOrder.ToString();

            OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

            DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить запись о заказе из БД?",
                                                            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Получим данный заказ, чтобы узнать количество заказнной продукции
                string selectQuery = @"SELECT Количество,
                                              Код_приготовления
                                            FROM Заказы
                                                WHERE Код_заказа = " + idCurrentRowOrder.ToString();

                OleDbCommand selectCommand = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader selectReader = selectCommand.ExecuteReader();
                selectReader.Read();

                int count = 0;
                int idMadeProduct = 0;

                int.TryParse(selectReader["Количество"].ToString(), out count);
                int.TryParse(selectReader["Код_приготовления"].ToString(), out idMadeProduct);

                string selectQueryMadeProdcut = @"SELECT Количество
                                                       FROM Приготовления
                                                           WHERE Код = " + idMadeProduct.ToString();

                OleDbCommand selectCommandMadeProdcut = new OleDbCommand(selectQueryMadeProdcut, Connection.getConnection());
                OleDbDataReader selectReaderMadeProdcut = selectCommandMadeProdcut.ExecuteReader();
                selectReaderMadeProdcut.Read();

                int countMadeProdcut = 0;

                int.TryParse(selectReaderMadeProdcut["Количество"].ToString(), out countMadeProdcut);

                int sum = count + countMadeProdcut;

                // Изменение данных
                string query = @"UPDATE Приготовления SET
                                            Количество = " + sum +
                                            "   WHERE Код = " + idMadeProduct;

                OleDbCommand updateCommand = new OleDbCommand(query, Connection.getConnection());
                updateCommand.ExecuteNonQuery();

                // Удаляем запись и обновляем dataGrid
                deleteCommand.ExecuteNonQuery();
                fillDataGridOrders();

                fillDataGridMadeProduct();
            }
        }

        private void btnReportOrders_Click(object sender, EventArgs e)
        {
            makeReport(dataGridOrders, "Таблица заказов");
        }

        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridOrders.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowOrder);
            }
        }

        private void txtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            string fromCount = txtFromCountOrders.Text != "".Trim() ? txtFromCountOrders.Text : "0";
            string toCount = txtToCountOrders.Text != "".Trim() ? txtToCountOrders.Text : "999999999";

            string fromPrice = txtFromPriceOrders.Text != "".Trim() ? txtFromPriceOrders.Text : "0";
            string toPrice = txtToPriceOrders.Text != "".Trim() ? txtToPriceOrders.Text : "999999999";

            string search = txtSearchOrders.Text;

            string selectQuery = @"SELECT Заказы.Код_заказа,
                                          Продукция.Наименование AS `Наименование продукции`,
                                          Заказчики.Наименование AS `Наименование заказчика`,
                                          Заказы.Количество,
                                          Заказы.Дата AS `Дата заказа`,
                                          Заказы.Стоимость AS `Общая стоимость заказа`,
                                          Заказы.Количество * Продукция.Вес_гр AS `Общий вес (гр)`
                                     FROM Заказчики, Заказы, Приготовления, Продукция
                                        WHERE (Заказы.Код_заказчика = Заказчики.Код_заказчика)
                                                AND
                                              (Заказы.Код_приготовления = Приготовления.Код)
                                                AND 
                                              (Приготовления.Код_продукции = Продукция.Код_продукции)
                                                AND 
                                            ((Заказы.Количество >= " + fromCount + ")" +
                                            "   AND " +
                                            "(Заказы.Количество <= " + toCount + "))" +
                                            "   AND " +
                                            "((Заказы.Стоимость >= " + fromPrice + ")" +
                                            "   AND " +
                                            "(Заказы.Стоимость <= " + toPrice + "))";

            switch(comboBoxSearchOrders.SelectedIndex)
            {
                case 0:
                    {
                        selectQuery += "    AND " +
                                       "((Продукция.Наименование LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Заказчики.Наименование LIKE '%" + search + "%')" +
                                       "   OR " +
                                       "(Заказы.Дата LIKE '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        selectQuery += "    AND " +
                                       "(Продукция.Наименование LIKE '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        selectQuery += "    AND " +
                                       "(Заказчики.Наименование LIKE '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += "    AND " +
                                       "(Заказы.Дата LIKE '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridOrders, 108);
        }
        #endregion

        #region Material
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeMaterial();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeMaterial_Click(object sender, EventArgs e)
        {
            flagChangeCurrentMaterial = true;

            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeMaterial();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                // Получание удаляемого сырья
                string selectQuery = @"SELECT Наименование
                                         FROM Сырьё
                                             WHERE Код_сырья = " + idCurrentRowMaterial.ToString();

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                string title = reader[0].ToString();

                // Вставка данных
                string deleteQuery = @"DELETE FROM Сырьё WHERE Код_сырья = " + idCurrentRowMaterial.ToString();

                OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, Connection.getConnection());

                DialogResult dialogResult = MessageBox.Show("Вы действительно собираетесь удалить сырьё: '" + title + "' из БД?",
                                                                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Удаляем запись и обновляем dataGrid
                    deleteCommand.ExecuteNonQuery();
                    fillDataGridMaterial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReportMaterial_Click(object sender, EventArgs e)
        {
            makeReport(dataGridMaterial, "Таблица сырья");
        }

        private void dataGridMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridMaterial.Rows[e.RowIndex];

                int.TryParse(row.Cells[0].Value.ToString(), out idCurrentRowMaterial);
            }
        }

        private void txtSearchMaterial_TextChanged(object sender, EventArgs e)
        {
            string fromCount = txtFromCountMaterial.Text != "".Trim() ? txtFromCountMaterial.Text : "0";
            string toCount = txtToCountMaterial.Text != "".Trim() ? txtToCountMaterial.Text : "999999999";

            string fromPrice = txtFromPriceMaterial.Text != "".Trim() ? txtFromPriceMaterial.Text : "0";
            string toPrice = txtToPriceMaterial.Text != "".Trim() ? txtToPriceMaterial.Text : "999999999";

            string search = txtSearchMaterial.Text;

            string selectQuery = @"SELECT Сырьё.Код_сырья,
                                          Сырьё.Наименование AS `Наименование сырья`,
                                          Сырьё.Количество,
                                          Сырьё.Срок_годности_в_днях AS `Срок годности в днях`,
                                          Сырьё.Общая_стоимость AS `Общая стоимость`,
                                          Сырьё.Дата_заказа AS `Дата заказа`,
                                          Типы.Название AS `Тип измерения`,
                                          Продукция.Наименование AS `Наименование продукции`
                                      FROM Сырьё, Типы, Продукция
                                          WHERE ((Сырьё.Код_типа = Типы.Код)
                                              AND
                                          (Сырьё.Код_продукции = Продукция.Код_продукции))
                                              AND 
                                          ((Сырьё.Количество >= " + fromCount + ")" +
                                          "   AND " +
                                          "(Сырьё.Количество <= " + toCount + "))" +
                                          "   AND " +
                                          "((Сырьё.Общая_стоимость >= " + fromPrice + ")" +
                                          "   AND " +
                                          "(Сырьё.Общая_стоимость <= " + toPrice + "))";

            switch (comboBoxSearchMaterial.SelectedIndex)
            {
                case 0:
                    {
                        // По всем полям, которые не вошли в фильтрацию
                        selectQuery += " AND " +
                                       "((Сырьё.Наименование LIKE  '%" + search + "%')";

                        selectQuery += " OR " +
                                       "(Сырьё.Срок_годности_в_днях LIKE  '%" + search + "%')";

                        selectQuery += " OR " +
                                       "(Сырьё.Дата_заказа LIKE  '%" + search + "%'))";
                    }
                    break;

                case 1:
                    {
                        // По Названию
                        selectQuery += " AND " +
                                       "(Сырьё.Наименование LIKE  '%" + search + "%')";
                    }
                    break;

                case 2:
                    {
                        // По Количество
                        selectQuery += " AND " +
                                       "(Сырьё.Количество LIKE  '%" + search + "%')";
                    }
                    break;

                case 3:
                    {
                        selectQuery += " AND " +
                                       "(Сырьё.Срок_годности_в_днях LIKE  '%" + search + "%')";
                    }
                    break;

                case 4:
                    {
                        selectQuery += " AND " +
                                       "(Сырьё.Общая_стоимость LIKE  '%" + search + "%')";
                    }
                    break;

                case 5:
                    {
                        selectQuery += " AND " +
                                       "(Сырьё.Дата_заказа LIKE  '%" + search + "%')";
                    }
                    break;
            }

            fillDataGrid(selectQuery, dataGridMaterial, 108);
        }
        #endregion

        private void btnAddComposition_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.Context.MainForm = new AddChangeComposition();

            Close();

            Program.Context.MainForm.Show();
        }

        private void btnChangeComposition_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteComposition_Click(object sender, EventArgs e)
        {

        }

        private void btnReportComposition_Click(object sender, EventArgs e)
        {

        }
    }
}
