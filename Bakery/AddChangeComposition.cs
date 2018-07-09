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
    public partial class AddChangeComposition : MetroFramework.Forms.MetroForm
    {
        public AddChangeComposition()
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

            // Заполнение comboBox Сырьём
            string selectQueryMaterial = @"SELECT Наименование FROM Сырьё";

            OleDbCommand selectCommandMaterial = new OleDbCommand(selectQueryMaterial, Connection.getConnection());

            OleDbDataReader selectReaderMaterial = selectCommandMaterial.ExecuteReader();

            while (selectReaderMaterial.Read())
            {
                comboBoxMaterial.Items.Add(selectReaderMaterial[0]);
            }

            // Заполнение comboBox Типами
            string selectQueryType = @"SELECT Название FROM Типы";

            OleDbCommand selectCommandType = new OleDbCommand(selectQueryType, Connection.getConnection());

            OleDbDataReader selectReaderType = selectCommandType.ExecuteReader();

            while (selectReaderType.Read())
            {
                comboBoxSize.Items.Add(selectReaderType[0]);
            }

            // Заполнение comboBox Продукцией
            string selectQueryProduct = @"SELECT Наименование FROM Продукция";

            OleDbCommand selectCommandProduct = new OleDbCommand(selectQueryProduct, Connection.getConnection());

            OleDbDataReader selectReaderProduct = selectCommandProduct.ExecuteReader();

            while (selectReaderProduct.Read())
            {
                comboBoxProduct.Items.Add(selectReaderProduct[0]);
            }

            // Скрытие элементов
            if (ManagerMainForm.flagChangeCurrentMadeProduct == false)
            {
                btnChange.Visible = false;
                lblMainEmployee.Text = "Введите все необходимые данные о составе продукта:";
            }
            else
            {
                btnAdd.Visible = false;
                lblMainEmployee.Text = "Исправьте все необходимые данные о составе продукта:";

                /*
                // Получение выбранной продукции
                string selectQuery = @"SELECT Количество,
                                              Вес_гр AS `Вес (гр)`,
                                              Дата_приготовления AS `Дата приготовления`,
                                              Типы.Название AS `Название типов`,
                                              Продукция.Наименование AS `Наименование продукции`
                                         FROM Приготовления, Типы,Продукция
                                            WHERE
                                                (Приготовления.Код_продукции = Продукция.Код_продукции)
                                                    AND 
                                                (Приготовления.Код_типа = Типы.Код)
                                                    AND 
                                                (Приготовления.Код = " + ManagerMainForm.idCurrentRowMadeProduct + ")";

                OleDbCommand command = new OleDbCommand(selectQuery, Connection.getConnection());

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                txtCountMadeProduct.Text = reader["Количество"].ToString();
                txtDateMadeProduct.Text = reader["Дата приготовления"].ToString();
                comboBoxSizeMadeProduct.Text = reader["Название типов"].ToString();
                comboBoxProductMadeProduct.Text = reader["Наименование продукции"].ToString();
                */
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
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
    }
}
