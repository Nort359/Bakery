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
        public static int idCurrentRowEmployee = -1;
        public static bool flagChangeCurrentEmployee = false;

        public static int idCurrentRowProduct = -1;
        public static bool flagChangeCurrentProduct = false;

        public static int idCurrentRowMadeProduct = -1;
        public static bool flagChangeCurrentMadeProduct = false;

        private void fillDataGrid(string query, DataGridView dataGrid)
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
        }

        private void fillDataGridEmployee()
        {
            string selectQuery = @"SELECT Код_личного_дела, Фамилия, Имя, Отчество,
                                          Должности.Должность,
                                          Дата_рождения AS `Дата рождения`,
                                          Номер_паспорта AS `Номер паспорта`,
                                          Серия_паспорта AS `Серия паспорта`, ИНН,
                                          Стаж_работы AS `Стаж работы`, Образование,
                                          Телефон, Страны.Название AS `Страна`,
                                          Города.Название AS `Город`, Сотрудники.Адрес
                                    FROM Сотрудники, Должности, Страны, Города
                                        WHERE
                                            (Сотрудники.Должность = Должности.Код_должности)
                                                AND
                                            (Сотрудники.Код_страны = Страны.Код)
                                                AND
                                            (Сотрудники.Код_города = Города.Код)";

            fillDataGrid(selectQuery, dataGridEmployee);
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

            fillDataGrid(selectQuery, dataGridProduct);
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

            fillDataGrid(selectQuery, dataGridMadeProduct);
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

            // Заполнение dataGrid Сотрудники данными из БД
            fillDataGridEmployee();

            // Заполнение dataGrid Продукции данными из БД
            fillDataGridProduct();

            // Заполнение dataGrid Приготовления данными из БД
            fillDataGridMadeProduct();

            // Значение id по умолчанию
            int.TryParse(dataGridEmployee.Rows[0].Cells[0].Value.ToString(), out idCurrentRowEmployee);
            int.TryParse(dataGridProduct.Rows[0].Cells[0].Value.ToString(), out idCurrentRowProduct);
            int.TryParse(dataGridMadeProduct.Rows[0].Cells[0].Value.ToString(), out idCurrentRowMadeProduct);

            tabControll.TabPages[0].Select();

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
            btn.BackColor = Color.FromArgb(244, 133, 72);
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);

                    /*
                    // подключаем шрифт
                    String FONT_LOCATION = Server.MapPath("~/fonts/arial.ttf");
                    BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font italicFont = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.ITALIC);
                    */

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
                        PdfPTable table = new PdfPTable(dataGridEmployee.Columns.Count - 1);

                        PdfPCell cell = new PdfPCell(new Phrase("Таблица сотрудников", fontBold));

                        cell.BackgroundColor = new BaseColor(Color.Wheat);
                        cell.Padding = 20;
                        cell.Colspan = 14;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;

                        table.AddCell(cell);


                        for (int j = 0; j < dataGridEmployee.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                continue;
                            }

                            PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridEmployee.Columns[j].HeaderText, fontBold));

                            itemCapture.Padding = 5;
                            itemCapture.Colspan = 1;
                            itemCapture.HorizontalAlignment = Element.ALIGN_CENTER;

                            table.AddCell(itemCapture);
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dataGridEmployee.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridEmployee.Columns.Count; j++)
                            {
                                if (j == 0)
                                {
                                    continue;
                                }

                                if (dataGridEmployee[j, i].Value != null)
                                {
                                    PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridEmployee[j, i].Value.ToString(), font));

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

        private void txtNameEmployee_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchEmployee.Text;

            string selectQuery = @"SELECT Код_личного_дела, Фамилия, Имя, Отчество,
                                          Должности.Должность,
                                          Дата_рождения AS `Дата рождения`,
                                          Номер_паспорта AS `Номер паспорта`,
                                          Серия_паспорта AS `Серия паспорта`, ИНН,
                                          Стаж_работы AS `Стаж работы`, Образование,
                                          Телефон, Страны.Название AS `Страна`,
                                          Города.Название AS `Город`, Сотрудники.Адрес
                                    FROM Сотрудники, Должности, Страны, Города
                                        WHERE
                                            (Сотрудники.Должность = Должности.Код_должности)
                                                AND
                                            (Сотрудники.Код_страны = Страны.Код)
                                                AND
                                            (Сотрудники.Код_города = Города.Код)
                                                AND
                                            ((Фамилия LIKE '%" + search + "%')" +
                                            "   OR" +
                                            "(Имя LIKE '%" + search + "%')" +
                                            "   OR" +
                                            "(Отчество LIKE '%" + search + "%'))";

            fillDataGrid(selectQuery, dataGridEmployee);
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
                                            "((Продукция.Оптимальная_стоимость >= " + fromRealPrice + ")" +
                                            "   AND " +
                                            "(Продукция.Оптимальная_стоимость <= " + toRealPrice + "))" +
                                            "   AND " +
                                            "((Продукция.Оптимальная_стоимость >= " + fromWeight + ")" +
                                            "   AND " +
                                            "(Продукция.Оптимальная_стоимость <= " + toWeight + "))" +
                                            "   AND " +
                                            "((Сотрудники.Фамилия LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Сотрудники.Имя LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Сотрудники.Отчество LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Продукция.Наименование LIKE '%" + search + "%'))";

            fillDataGrid(selectQuery, dataGridProduct);
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

        private void btnReportProduct_Click(object sender, EventArgs e)
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
                        PdfPTable table = new PdfPTable(dataGridProduct.Columns.Count - 1);

                        PdfPCell cell = new PdfPCell(new Phrase("Таблица продукции", fontBold));

                        cell.BackgroundColor = new BaseColor(Color.Wheat);
                        cell.Padding = 20;
                        cell.Colspan = 8;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;

                        table.AddCell(cell);


                        for (int j = 0; j < dataGridProduct.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                continue;
                            }

                            PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridProduct.Columns[j].HeaderText, fontBold));

                            itemCapture.Padding = 5;
                            itemCapture.Colspan = 1;
                            itemCapture.HorizontalAlignment = Element.ALIGN_CENTER;

                            table.AddCell(itemCapture);
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dataGridProduct.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridProduct.Columns.Count; j++)
                            {
                                if (j == 0)
                                {
                                    continue;
                                }

                                if (dataGridProduct[j, i].Value != null)
                                {
                                    PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridProduct[j, i].Value.ToString(), font));

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

        #endregion

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
            // TODO: ДОДЕЛАТЬ!!! Выводит только по датам, нужно добавить месяца
            DateTime date;
            DateTime now = DateTime.Now;

            DateTime.TryParse(dataGridMadeProduct.Rows[e.RowIndex].Cells[6].Value.ToString(), out date);

            int timeToDown = 0;

            TimeSpan substractDate = now.Subtract(date);

            int different = 0;

            string wholeDifferent = "";

            for (int i = 0; i <= substractDate.ToString().Length; i++)
            {
                if (substractDate.ToString()[i] == '.')
                {
                    break;
                }
                else
                {
                    wholeDifferent += substractDate.ToString()[i];
                }
            }

            int.TryParse(wholeDifferent, out different);
            int.TryParse(dataGridMadeProduct.Rows[e.RowIndex].Cells[3].Value.ToString(), out timeToDown);

            int restTime = timeToDown - different;

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
        }

        private void txtSearchMadeProduct_TextChanged(object sender, EventArgs e)
        {
            string fromCount = txtFromCountMadeProduct.Text != "".Trim() ? txtFromCountMadeProduct.Text : "0";
            string toCount = txtToCountMadeProduct.Text != "".Trim() ? txtToCountMadeProduct.Text : "999999999";

            bool isTimeIs = checkBoxTimeIsMadeProduct.Checked;
            bool isTimeLess = checkBoxTimeLessMadeProduct.Checked;
            bool isTimeNo = checkBoxTimeNoMadeProduct.Checked;

            string search = txtSearchMadeProduct.Text;

            /*
            string query = @"SELECT Приготовления.Код,
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

            OleDbCommand command = new OleDbCommand(query, Connection.getConnection());

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

            }
            */

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



            //selectQuery += " AND DATEDIFF(year, DateValue(Приготовления.Дата_приготовления), DateValue( '" + DateTime.Now.ToString("dd.MM.yyyy") + "' )) > 1";

            selectQuery += "   AND " +
                                    "((Сотрудники.Фамилия LIKE '%" + search + "%')" +
                                    "   OR " +
                                    "(Сотрудники.Имя LIKE '%" + search + "%')" +
                                    "   OR " +
                                    "(Сотрудники.Отчество LIKE '%" + search + "%')" +
                                    "   OR " +
                                    "(Продукция.Наименование LIKE '%" + search + "%'))";

            //MessageBox.Show(selectQuery);

            /*
             string fromCount = txtFromCountMadeProduct.Text != "".Trim() ? txtFromCountMadeProduct.Text : "0";
            string toCount = txtToCountMadeProduct.Text != "".Trim() ? txtToCountMadeProduct.Text : "999999999";

            DateTime fromDate = txtFromDateMadeProduct.Value;
            DateTime toDate = txtToDateMadeProduct.Value;

            //fromDate = DateTime.Parse(fromDate).ToString("dd.MM.yyyy");
            //toDate = DateTime.Parse(toDate).ToString("dd.MM.yyyy");

            //string now = DateTime.Now.ToShortDateString();

            //now = DateTime.Parse(now).ToString("dd.MM.yyyy");

            //MessageBox.Show(DateTime.Parse(toDate).CompareTo(DateTime.Parse(now)).ToString());

            string search = txtSearchMadeProduct.Text;

            //WHERE created_at BETWEEN STR_TO_DATE('2008-08-14 00:00:00', '%Y-%m-%d %H:%i:%s') 
  //AND STR_TO_DATE('2008-08-23 23:59:59', '%Y-%m-%d %H:%i:%s');

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
                                            "(Приготовления.Количество <= " + toCount + "))" +
                                            "   AND " +
                                            "(Приготовления.Дата_приготовления" +
                                            "   BETWEEN CONVERT(DATETIME, '" + fromDate + "')" +
                                            "   AND CONVERT(DATETIME, '" + toDate + "'))" +
                                            "   AND " +
                                            "((Сотрудники.Фамилия LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Сотрудники.Имя LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Сотрудники.Отчество LIKE '%" + search + "%')" +
                                            "   OR " +
                                            "(Продукция.Наименование LIKE '%" + search + "%'))";

            MessageBox.Show(selectQuery);

            fillDataGrid(selectQuery, dataGridMadeProduct);
             */

            fillDataGrid(selectQuery, dataGridMadeProduct);
        }

        private void txtFromDateMadeProduct_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
