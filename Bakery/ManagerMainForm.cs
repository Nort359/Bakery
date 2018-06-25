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

            OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                DataTable dbDataSet = new DataTable();
                adapter.Fill(dbDataSet);

                BindingSource bSourse = new BindingSource();
                bSourse.DataSource = dbDataSet;

                dataGridView1.DataSource = bSourse;

                adapter.Update(dbDataSet);

                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillDataGridEmployee(string query)
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

                dataGridView1.DataSource = bSourse;

                adapter.Update(dbDataSet);

                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            flagChangeCurrentEmployee = false;

            // Заполнение dataGrid данными из БД

            fillDataGridEmployee();

            int.TryParse(dataGridView1.Rows[0].Cells[0].Value.ToString(), out idCurrentRowEmployee);
        }

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

            Program.Context.MainForm = new AddEmployee();

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

            Program.Context.MainForm = new AddEmployee();

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
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

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
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count - 1);

                        PdfPCell cell = new PdfPCell(new Phrase("Таблица сотрудников", fontBold));

                        cell.BackgroundColor = new BaseColor(Color.Wheat);
                        cell.Padding = 20;
                        cell.Colspan = 14;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;

                        table.AddCell(cell);


                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                continue;
                            }

                            PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridView1.Columns[j].HeaderText, fontBold));

                            itemCapture.Padding = 5;
                            itemCapture.Colspan = 1;
                            itemCapture.HorizontalAlignment = Element.ALIGN_CENTER;

                            table.AddCell(itemCapture);
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (j == 0)
                                {
                                    continue;
                                }

                                if (dataGridView1[j, i].Value != null)
                                {
                                    PdfPCell itemCapture = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString(), font));

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

            fillDataGridEmployee(selectQuery);
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"index.html");
        }
    }
}
