namespace Bakery
{
    partial class ManagerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControll = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtSearchEmployee = new MetroFramework.Controls.MetroTextBox();
            this.btnReportEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnChangeEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.groupBoxWeight = new System.Windows.Forms.GroupBox();
            this.txtToWeightProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtFromWeightProduct = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxRealPrice = new System.Windows.Forms.GroupBox();
            this.txtToRealPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtFromRealPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxOptimalPrice = new System.Windows.Forms.GroupBox();
            this.txtToOptimalPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtFromOptimalPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnReportProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxFilterMadeProduct = new System.Windows.Forms.GroupBox();
            this.groupBoxCountMadeProduct = new System.Windows.Forms.GroupBox();
            this.txtToCountMadeProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtFromCountMadeProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchMadeProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnReportMadeProduct = new System.Windows.Forms.Button();
            this.btnDeleteMadeProduct = new System.Windows.Forms.Button();
            this.btnChangeMadeProduct = new System.Windows.Forms.Button();
            this.btnAddMadeProduct = new System.Windows.Forms.Button();
            this.dataGridMadeProduct = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnMakeBackUpBD = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.checkBoxTimeIsMadeProduct = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxTimeLessMadeProduct = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxTimeNoMadeProduct = new MetroFramework.Controls.MetroCheckBox();
            this.tabControll.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxWeight.SuspendLayout();
            this.groupBoxRealPrice.SuspendLayout();
            this.groupBoxOptimalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.groupBoxFilterMadeProduct.SuspendLayout();
            this.groupBoxCountMadeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMadeProduct)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControll
            // 
            this.tabControll.Controls.Add(this.metroTabPage1);
            this.tabControll.Controls.Add(this.metroTabPage2);
            this.tabControll.Controls.Add(this.metroTabPage4);
            this.tabControll.Controls.Add(this.metroTabPage3);
            this.tabControll.Location = new System.Drawing.Point(33, 85);
            this.tabControll.Name = "tabControll";
            this.tabControll.SelectedIndex = 2;
            this.tabControll.Size = new System.Drawing.Size(956, 472);
            this.tabControll.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControll.TabIndex = 0;
            this.tabControll.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtSearchEmployee);
            this.metroTabPage1.Controls.Add(this.btnReportEmployee);
            this.metroTabPage1.Controls.Add(this.btnDeleteEmployee);
            this.metroTabPage1.Controls.Add(this.btnChangeEmployee);
            this.metroTabPage1.Controls.Add(this.btnAddEmployee);
            this.metroTabPage1.Controls.Add(this.dataGridEmployee);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(951, 440);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Сотрудники";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtSearchEmployee
            // 
            // 
            // 
            // 
            this.txtSearchEmployee.CustomButton.Image = null;
            this.txtSearchEmployee.CustomButton.Location = new System.Drawing.Point(879, 2);
            this.txtSearchEmployee.CustomButton.Name = "";
            this.txtSearchEmployee.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchEmployee.CustomButton.TabIndex = 1;
            this.txtSearchEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchEmployee.CustomButton.UseSelectable = true;
            this.txtSearchEmployee.CustomButton.Visible = false;
            this.txtSearchEmployee.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchEmployee.Lines = new string[0];
            this.txtSearchEmployee.Location = new System.Drawing.Point(0, 10);
            this.txtSearchEmployee.MaxLength = 32767;
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PromptText = "Поиск";
            this.txtSearchEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.SelectionLength = 0;
            this.txtSearchEmployee.SelectionStart = 0;
            this.txtSearchEmployee.ShortcutsEnabled = true;
            this.txtSearchEmployee.Size = new System.Drawing.Size(907, 30);
            this.txtSearchEmployee.TabIndex = 22;
            this.txtSearchEmployee.UseSelectable = true;
            this.txtSearchEmployee.WaterMark = "Поиск";
            this.txtSearchEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtNameEmployee_TextChanged);
            // 
            // btnReportEmployee
            // 
            this.btnReportEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReportEmployee.Location = new System.Drawing.Point(699, 353);
            this.btnReportEmployee.Name = "btnReportEmployee";
            this.btnReportEmployee.Size = new System.Drawing.Size(208, 48);
            this.btnReportEmployee.TabIndex = 21;
            this.btnReportEmployee.Text = "Отчёт";
            this.btnReportEmployee.UseVisualStyleBackColor = false;
            this.btnReportEmployee.Click += new System.EventHandler(this.btnReportEmployee_Click);
            this.btnReportEmployee.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnReportEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(466, 353);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(227, 48);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            this.btnDeleteEmployee.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnDeleteEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnChangeEmployee
            // 
            this.btnChangeEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnChangeEmployee.Location = new System.Drawing.Point(233, 353);
            this.btnChangeEmployee.Name = "btnChangeEmployee";
            this.btnChangeEmployee.Size = new System.Drawing.Size(227, 48);
            this.btnChangeEmployee.TabIndex = 18;
            this.btnChangeEmployee.Text = "Изменить";
            this.btnChangeEmployee.UseVisualStyleBackColor = false;
            this.btnChangeEmployee.Click += new System.EventHandler(this.btnChangeEmployee_Click);
            this.btnChangeEmployee.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnChangeEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 353);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(227, 48);
            this.btnAddEmployee.TabIndex = 17;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            this.btnAddEmployee.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnAddEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Location = new System.Drawing.Point(0, 46);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.ReadOnly = true;
            this.dataGridEmployee.Size = new System.Drawing.Size(907, 301);
            this.dataGridEmployee.TabIndex = 4;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBoxFilter);
            this.metroTabPage2.Controls.Add(this.txtSearchProduct);
            this.metroTabPage2.Controls.Add(this.btnReportProduct);
            this.metroTabPage2.Controls.Add(this.btnDeleteProduct);
            this.metroTabPage2.Controls.Add(this.btnChangeProduct);
            this.metroTabPage2.Controls.Add(this.btnAddProduct);
            this.metroTabPage2.Controls.Add(this.dataGridProduct);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(948, 430);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Продукция";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFilter.Controls.Add(this.groupBoxWeight);
            this.groupBoxFilter.Controls.Add(this.groupBoxRealPrice);
            this.groupBoxFilter.Controls.Add(this.groupBoxOptimalPrice);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter.Location = new System.Drawing.Point(699, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(227, 337);
            this.groupBoxFilter.TabIndex = 31;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтрация";
            // 
            // groupBoxWeight
            // 
            this.groupBoxWeight.Controls.Add(this.txtToWeightProduct);
            this.groupBoxWeight.Controls.Add(this.txtFromWeightProduct);
            this.groupBoxWeight.Location = new System.Drawing.Point(0, 238);
            this.groupBoxWeight.Name = "groupBoxWeight";
            this.groupBoxWeight.Size = new System.Drawing.Size(227, 99);
            this.groupBoxWeight.TabIndex = 42;
            this.groupBoxWeight.TabStop = false;
            this.groupBoxWeight.Text = "По весу:";
            // 
            // txtToWeightProduct
            // 
            // 
            // 
            // 
            this.txtToWeightProduct.CustomButton.Image = null;
            this.txtToWeightProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtToWeightProduct.CustomButton.Name = "";
            this.txtToWeightProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtToWeightProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToWeightProduct.CustomButton.TabIndex = 1;
            this.txtToWeightProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToWeightProduct.CustomButton.UseSelectable = true;
            this.txtToWeightProduct.CustomButton.Visible = false;
            this.txtToWeightProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtToWeightProduct.Lines = new string[0];
            this.txtToWeightProduct.Location = new System.Drawing.Point(6, 61);
            this.txtToWeightProduct.MaxLength = 32767;
            this.txtToWeightProduct.Name = "txtToWeightProduct";
            this.txtToWeightProduct.PasswordChar = '\0';
            this.txtToWeightProduct.PromptText = "Максимум";
            this.txtToWeightProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToWeightProduct.SelectedText = "";
            this.txtToWeightProduct.SelectionLength = 0;
            this.txtToWeightProduct.SelectionStart = 0;
            this.txtToWeightProduct.ShortcutsEnabled = true;
            this.txtToWeightProduct.Size = new System.Drawing.Size(194, 30);
            this.txtToWeightProduct.TabIndex = 40;
            this.txtToWeightProduct.UseSelectable = true;
            this.txtToWeightProduct.WaterMark = "Максимум";
            this.txtToWeightProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToWeightProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToWeightProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtToWeightProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // txtFromWeightProduct
            // 
            // 
            // 
            // 
            this.txtFromWeightProduct.CustomButton.Image = null;
            this.txtFromWeightProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtFromWeightProduct.CustomButton.Name = "";
            this.txtFromWeightProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFromWeightProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFromWeightProduct.CustomButton.TabIndex = 1;
            this.txtFromWeightProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFromWeightProduct.CustomButton.UseSelectable = true;
            this.txtFromWeightProduct.CustomButton.Visible = false;
            this.txtFromWeightProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFromWeightProduct.Lines = new string[0];
            this.txtFromWeightProduct.Location = new System.Drawing.Point(6, 25);
            this.txtFromWeightProduct.MaxLength = 32767;
            this.txtFromWeightProduct.Name = "txtFromWeightProduct";
            this.txtFromWeightProduct.PasswordChar = '\0';
            this.txtFromWeightProduct.PromptText = "Минимум";
            this.txtFromWeightProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFromWeightProduct.SelectedText = "";
            this.txtFromWeightProduct.SelectionLength = 0;
            this.txtFromWeightProduct.SelectionStart = 0;
            this.txtFromWeightProduct.ShortcutsEnabled = true;
            this.txtFromWeightProduct.Size = new System.Drawing.Size(194, 30);
            this.txtFromWeightProduct.TabIndex = 39;
            this.txtFromWeightProduct.UseSelectable = true;
            this.txtFromWeightProduct.WaterMark = "Минимум";
            this.txtFromWeightProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFromWeightProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromWeightProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtFromWeightProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // groupBoxRealPrice
            // 
            this.groupBoxRealPrice.Controls.Add(this.txtToRealPriceProduct);
            this.groupBoxRealPrice.Controls.Add(this.txtFromRealPriceProduct);
            this.groupBoxRealPrice.Location = new System.Drawing.Point(0, 141);
            this.groupBoxRealPrice.Name = "groupBoxRealPrice";
            this.groupBoxRealPrice.Size = new System.Drawing.Size(227, 99);
            this.groupBoxRealPrice.TabIndex = 41;
            this.groupBoxRealPrice.TabStop = false;
            this.groupBoxRealPrice.Text = "По розничной цене:";
            // 
            // txtToRealPriceProduct
            // 
            // 
            // 
            // 
            this.txtToRealPriceProduct.CustomButton.Image = null;
            this.txtToRealPriceProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtToRealPriceProduct.CustomButton.Name = "";
            this.txtToRealPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtToRealPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToRealPriceProduct.CustomButton.TabIndex = 1;
            this.txtToRealPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToRealPriceProduct.CustomButton.UseSelectable = true;
            this.txtToRealPriceProduct.CustomButton.Visible = false;
            this.txtToRealPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtToRealPriceProduct.Lines = new string[0];
            this.txtToRealPriceProduct.Location = new System.Drawing.Point(6, 61);
            this.txtToRealPriceProduct.MaxLength = 32767;
            this.txtToRealPriceProduct.Name = "txtToRealPriceProduct";
            this.txtToRealPriceProduct.PasswordChar = '\0';
            this.txtToRealPriceProduct.PromptText = "Максимум";
            this.txtToRealPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToRealPriceProduct.SelectedText = "";
            this.txtToRealPriceProduct.SelectionLength = 0;
            this.txtToRealPriceProduct.SelectionStart = 0;
            this.txtToRealPriceProduct.ShortcutsEnabled = true;
            this.txtToRealPriceProduct.Size = new System.Drawing.Size(194, 30);
            this.txtToRealPriceProduct.TabIndex = 40;
            this.txtToRealPriceProduct.UseSelectable = true;
            this.txtToRealPriceProduct.WaterMark = "Максимум";
            this.txtToRealPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToRealPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToRealPriceProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtToRealPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // txtFromRealPriceProduct
            // 
            // 
            // 
            // 
            this.txtFromRealPriceProduct.CustomButton.Image = null;
            this.txtFromRealPriceProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtFromRealPriceProduct.CustomButton.Name = "";
            this.txtFromRealPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFromRealPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFromRealPriceProduct.CustomButton.TabIndex = 1;
            this.txtFromRealPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFromRealPriceProduct.CustomButton.UseSelectable = true;
            this.txtFromRealPriceProduct.CustomButton.Visible = false;
            this.txtFromRealPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFromRealPriceProduct.Lines = new string[0];
            this.txtFromRealPriceProduct.Location = new System.Drawing.Point(6, 25);
            this.txtFromRealPriceProduct.MaxLength = 32767;
            this.txtFromRealPriceProduct.Name = "txtFromRealPriceProduct";
            this.txtFromRealPriceProduct.PasswordChar = '\0';
            this.txtFromRealPriceProduct.PromptText = "Минимум";
            this.txtFromRealPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFromRealPriceProduct.SelectedText = "";
            this.txtFromRealPriceProduct.SelectionLength = 0;
            this.txtFromRealPriceProduct.SelectionStart = 0;
            this.txtFromRealPriceProduct.ShortcutsEnabled = true;
            this.txtFromRealPriceProduct.Size = new System.Drawing.Size(194, 30);
            this.txtFromRealPriceProduct.TabIndex = 39;
            this.txtFromRealPriceProduct.UseSelectable = true;
            this.txtFromRealPriceProduct.WaterMark = "Минимум";
            this.txtFromRealPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFromRealPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromRealPriceProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtFromRealPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // groupBoxOptimalPrice
            // 
            this.groupBoxOptimalPrice.Controls.Add(this.txtToOptimalPriceProduct);
            this.groupBoxOptimalPrice.Controls.Add(this.txtFromOptimalPriceProduct);
            this.groupBoxOptimalPrice.Location = new System.Drawing.Point(0, 36);
            this.groupBoxOptimalPrice.Name = "groupBoxOptimalPrice";
            this.groupBoxOptimalPrice.Size = new System.Drawing.Size(227, 99);
            this.groupBoxOptimalPrice.TabIndex = 0;
            this.groupBoxOptimalPrice.TabStop = false;
            this.groupBoxOptimalPrice.Text = "По оптимальной цене:";
            // 
            // txtToOptimalPriceProduct
            // 
            // 
            // 
            // 
            this.txtToOptimalPriceProduct.CustomButton.Image = null;
            this.txtToOptimalPriceProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtToOptimalPriceProduct.CustomButton.Name = "";
            this.txtToOptimalPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtToOptimalPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToOptimalPriceProduct.CustomButton.TabIndex = 1;
            this.txtToOptimalPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToOptimalPriceProduct.CustomButton.UseSelectable = true;
            this.txtToOptimalPriceProduct.CustomButton.Visible = false;
            this.txtToOptimalPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtToOptimalPriceProduct.Lines = new string[0];
            this.txtToOptimalPriceProduct.Location = new System.Drawing.Point(6, 61);
            this.txtToOptimalPriceProduct.MaxLength = 32767;
            this.txtToOptimalPriceProduct.Name = "txtToOptimalPriceProduct";
            this.txtToOptimalPriceProduct.PasswordChar = '\0';
            this.txtToOptimalPriceProduct.PromptText = "Максимум";
            this.txtToOptimalPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToOptimalPriceProduct.SelectedText = "";
            this.txtToOptimalPriceProduct.SelectionLength = 0;
            this.txtToOptimalPriceProduct.SelectionStart = 0;
            this.txtToOptimalPriceProduct.ShortcutsEnabled = true;
            this.txtToOptimalPriceProduct.Size = new System.Drawing.Size(194, 30);
            this.txtToOptimalPriceProduct.TabIndex = 40;
            this.txtToOptimalPriceProduct.UseSelectable = true;
            this.txtToOptimalPriceProduct.WaterMark = "Максимум";
            this.txtToOptimalPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToOptimalPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToOptimalPriceProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtToOptimalPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // txtFromOptimalPriceProduct
            // 
            // 
            // 
            // 
            this.txtFromOptimalPriceProduct.CustomButton.Image = null;
            this.txtFromOptimalPriceProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtFromOptimalPriceProduct.CustomButton.Name = "";
            this.txtFromOptimalPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFromOptimalPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFromOptimalPriceProduct.CustomButton.TabIndex = 1;
            this.txtFromOptimalPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFromOptimalPriceProduct.CustomButton.UseSelectable = true;
            this.txtFromOptimalPriceProduct.CustomButton.Visible = false;
            this.txtFromOptimalPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFromOptimalPriceProduct.Lines = new string[0];
            this.txtFromOptimalPriceProduct.Location = new System.Drawing.Point(6, 25);
            this.txtFromOptimalPriceProduct.MaxLength = 32767;
            this.txtFromOptimalPriceProduct.Name = "txtFromOptimalPriceProduct";
            this.txtFromOptimalPriceProduct.PasswordChar = '\0';
            this.txtFromOptimalPriceProduct.PromptText = "Минимум";
            this.txtFromOptimalPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFromOptimalPriceProduct.SelectedText = "";
            this.txtFromOptimalPriceProduct.SelectionLength = 0;
            this.txtFromOptimalPriceProduct.SelectionStart = 0;
            this.txtFromOptimalPriceProduct.ShortcutsEnabled = true;
            this.txtFromOptimalPriceProduct.Size = new System.Drawing.Size(194, 30);
            this.txtFromOptimalPriceProduct.TabIndex = 39;
            this.txtFromOptimalPriceProduct.UseSelectable = true;
            this.txtFromOptimalPriceProduct.WaterMark = "Минимум";
            this.txtFromOptimalPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFromOptimalPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromOptimalPriceProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            this.txtFromOptimalPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromOptimalPriceProduct_KeyPress);
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(665, 2);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(0, 12);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Поиск";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(693, 30);
            this.txtSearchProduct.TabIndex = 29;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Поиск";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtFromOptimalPriceProduct_TextChanged);
            // 
            // btnReportProduct
            // 
            this.btnReportProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReportProduct.Location = new System.Drawing.Point(699, 355);
            this.btnReportProduct.Name = "btnReportProduct";
            this.btnReportProduct.Size = new System.Drawing.Size(227, 48);
            this.btnReportProduct.TabIndex = 28;
            this.btnReportProduct.Text = "Отчёт";
            this.btnReportProduct.UseVisualStyleBackColor = false;
            this.btnReportProduct.Click += new System.EventHandler(this.btnReportProduct_Click);
            this.btnReportProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnReportProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(466, 355);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(227, 48);
            this.btnDeleteProduct.TabIndex = 26;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            this.btnDeleteProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnDeleteProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnChangeProduct.Location = new System.Drawing.Point(233, 355);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(227, 48);
            this.btnChangeProduct.TabIndex = 25;
            this.btnChangeProduct.Text = "Изменить";
            this.btnChangeProduct.UseVisualStyleBackColor = false;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            this.btnChangeProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnChangeProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 355);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(227, 48);
            this.btnAddProduct.TabIndex = 24;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnAddProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnAddProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 48);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.Size = new System.Drawing.Size(693, 301);
            this.dataGridProduct.TabIndex = 23;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroUserControl1);
            this.metroTabPage4.Controls.Add(this.label4);
            this.metroTabPage4.Controls.Add(this.label3);
            this.metroTabPage4.Controls.Add(this.panel3);
            this.metroTabPage4.Controls.Add(this.label1);
            this.metroTabPage4.Controls.Add(this.label2);
            this.metroTabPage4.Controls.Add(this.panel2);
            this.metroTabPage4.Controls.Add(this.groupBoxFilterMadeProduct);
            this.metroTabPage4.Controls.Add(this.txtSearchMadeProduct);
            this.metroTabPage4.Controls.Add(this.btnReportMadeProduct);
            this.metroTabPage4.Controls.Add(this.panel1);
            this.metroTabPage4.Controls.Add(this.btnDeleteMadeProduct);
            this.metroTabPage4.Controls.Add(this.btnChangeMadeProduct);
            this.metroTabPage4.Controls.Add(this.btnAddMadeProduct);
            this.metroTabPage4.Controls.Add(this.dataGridMadeProduct);
            this.metroTabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(948, 430);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Приготовление";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // groupBoxFilterMadeProduct
            // 
            this.groupBoxFilterMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFilterMadeProduct.Controls.Add(this.groupBox1);
            this.groupBoxFilterMadeProduct.Controls.Add(this.groupBoxCountMadeProduct);
            this.groupBoxFilterMadeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilterMadeProduct.Location = new System.Drawing.Point(699, 3);
            this.groupBoxFilterMadeProduct.Name = "groupBoxFilterMadeProduct";
            this.groupBoxFilterMadeProduct.Size = new System.Drawing.Size(227, 253);
            this.groupBoxFilterMadeProduct.TabIndex = 38;
            this.groupBoxFilterMadeProduct.TabStop = false;
            this.groupBoxFilterMadeProduct.Text = "Фильтрация";
            // 
            // groupBoxCountMadeProduct
            // 
            this.groupBoxCountMadeProduct.Controls.Add(this.txtToCountMadeProduct);
            this.groupBoxCountMadeProduct.Controls.Add(this.txtFromCountMadeProduct);
            this.groupBoxCountMadeProduct.Location = new System.Drawing.Point(0, 36);
            this.groupBoxCountMadeProduct.Name = "groupBoxCountMadeProduct";
            this.groupBoxCountMadeProduct.Size = new System.Drawing.Size(227, 99);
            this.groupBoxCountMadeProduct.TabIndex = 0;
            this.groupBoxCountMadeProduct.TabStop = false;
            this.groupBoxCountMadeProduct.Text = "По количеству:";
            // 
            // txtToCountMadeProduct
            // 
            // 
            // 
            // 
            this.txtToCountMadeProduct.CustomButton.Image = null;
            this.txtToCountMadeProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtToCountMadeProduct.CustomButton.Name = "";
            this.txtToCountMadeProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtToCountMadeProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToCountMadeProduct.CustomButton.TabIndex = 1;
            this.txtToCountMadeProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToCountMadeProduct.CustomButton.UseSelectable = true;
            this.txtToCountMadeProduct.CustomButton.Visible = false;
            this.txtToCountMadeProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtToCountMadeProduct.Lines = new string[0];
            this.txtToCountMadeProduct.Location = new System.Drawing.Point(6, 61);
            this.txtToCountMadeProduct.MaxLength = 32767;
            this.txtToCountMadeProduct.Name = "txtToCountMadeProduct";
            this.txtToCountMadeProduct.PasswordChar = '\0';
            this.txtToCountMadeProduct.PromptText = "Максимум";
            this.txtToCountMadeProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToCountMadeProduct.SelectedText = "";
            this.txtToCountMadeProduct.SelectionLength = 0;
            this.txtToCountMadeProduct.SelectionStart = 0;
            this.txtToCountMadeProduct.ShortcutsEnabled = true;
            this.txtToCountMadeProduct.Size = new System.Drawing.Size(194, 30);
            this.txtToCountMadeProduct.TabIndex = 40;
            this.txtToCountMadeProduct.UseSelectable = true;
            this.txtToCountMadeProduct.WaterMark = "Максимум";
            this.txtToCountMadeProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToCountMadeProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToCountMadeProduct.TextChanged += new System.EventHandler(this.txtSearchMadeProduct_TextChanged);
            // 
            // txtFromCountMadeProduct
            // 
            // 
            // 
            // 
            this.txtFromCountMadeProduct.CustomButton.Image = null;
            this.txtFromCountMadeProduct.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtFromCountMadeProduct.CustomButton.Name = "";
            this.txtFromCountMadeProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFromCountMadeProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFromCountMadeProduct.CustomButton.TabIndex = 1;
            this.txtFromCountMadeProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFromCountMadeProduct.CustomButton.UseSelectable = true;
            this.txtFromCountMadeProduct.CustomButton.Visible = false;
            this.txtFromCountMadeProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFromCountMadeProduct.Lines = new string[0];
            this.txtFromCountMadeProduct.Location = new System.Drawing.Point(6, 25);
            this.txtFromCountMadeProduct.MaxLength = 32767;
            this.txtFromCountMadeProduct.Name = "txtFromCountMadeProduct";
            this.txtFromCountMadeProduct.PasswordChar = '\0';
            this.txtFromCountMadeProduct.PromptText = "Минимум";
            this.txtFromCountMadeProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFromCountMadeProduct.SelectedText = "";
            this.txtFromCountMadeProduct.SelectionLength = 0;
            this.txtFromCountMadeProduct.SelectionStart = 0;
            this.txtFromCountMadeProduct.ShortcutsEnabled = true;
            this.txtFromCountMadeProduct.Size = new System.Drawing.Size(194, 30);
            this.txtFromCountMadeProduct.TabIndex = 39;
            this.txtFromCountMadeProduct.UseSelectable = true;
            this.txtFromCountMadeProduct.WaterMark = "Минимум";
            this.txtFromCountMadeProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFromCountMadeProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromCountMadeProduct.TextChanged += new System.EventHandler(this.txtSearchMadeProduct_TextChanged);
            // 
            // txtSearchMadeProduct
            // 
            // 
            // 
            // 
            this.txtSearchMadeProduct.CustomButton.Image = null;
            this.txtSearchMadeProduct.CustomButton.Location = new System.Drawing.Point(665, 2);
            this.txtSearchMadeProduct.CustomButton.Name = "";
            this.txtSearchMadeProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchMadeProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchMadeProduct.CustomButton.TabIndex = 1;
            this.txtSearchMadeProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchMadeProduct.CustomButton.UseSelectable = true;
            this.txtSearchMadeProduct.CustomButton.Visible = false;
            this.txtSearchMadeProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchMadeProduct.Lines = new string[0];
            this.txtSearchMadeProduct.Location = new System.Drawing.Point(0, 3);
            this.txtSearchMadeProduct.MaxLength = 32767;
            this.txtSearchMadeProduct.Name = "txtSearchMadeProduct";
            this.txtSearchMadeProduct.PasswordChar = '\0';
            this.txtSearchMadeProduct.PromptText = "Поиск";
            this.txtSearchMadeProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchMadeProduct.SelectedText = "";
            this.txtSearchMadeProduct.SelectionLength = 0;
            this.txtSearchMadeProduct.SelectionStart = 0;
            this.txtSearchMadeProduct.ShortcutsEnabled = true;
            this.txtSearchMadeProduct.Size = new System.Drawing.Size(693, 30);
            this.txtSearchMadeProduct.TabIndex = 37;
            this.txtSearchMadeProduct.UseSelectable = true;
            this.txtSearchMadeProduct.WaterMark = "Поиск";
            this.txtSearchMadeProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchMadeProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchMadeProduct.TextChanged += new System.EventHandler(this.txtSearchMadeProduct_TextChanged);
            // 
            // btnReportMadeProduct
            // 
            this.btnReportMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportMadeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportMadeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMadeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportMadeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReportMadeProduct.Location = new System.Drawing.Point(699, 369);
            this.btnReportMadeProduct.Name = "btnReportMadeProduct";
            this.btnReportMadeProduct.Size = new System.Drawing.Size(227, 48);
            this.btnReportMadeProduct.TabIndex = 36;
            this.btnReportMadeProduct.Text = "Отчёт";
            this.btnReportMadeProduct.UseVisualStyleBackColor = false;
            this.btnReportMadeProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnReportMadeProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnDeleteMadeProduct
            // 
            this.btnDeleteMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteMadeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMadeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMadeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteMadeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDeleteMadeProduct.Location = new System.Drawing.Point(466, 369);
            this.btnDeleteMadeProduct.Name = "btnDeleteMadeProduct";
            this.btnDeleteMadeProduct.Size = new System.Drawing.Size(227, 48);
            this.btnDeleteMadeProduct.TabIndex = 35;
            this.btnDeleteMadeProduct.Text = "Удалить";
            this.btnDeleteMadeProduct.UseVisualStyleBackColor = false;
            this.btnDeleteMadeProduct.Click += new System.EventHandler(this.btnDeleteMadeProduct_Click);
            this.btnDeleteMadeProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnDeleteMadeProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnChangeMadeProduct
            // 
            this.btnChangeMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeMadeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMadeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMadeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeMadeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnChangeMadeProduct.Location = new System.Drawing.Point(233, 369);
            this.btnChangeMadeProduct.Name = "btnChangeMadeProduct";
            this.btnChangeMadeProduct.Size = new System.Drawing.Size(227, 48);
            this.btnChangeMadeProduct.TabIndex = 34;
            this.btnChangeMadeProduct.Text = "Изменить";
            this.btnChangeMadeProduct.UseVisualStyleBackColor = false;
            this.btnChangeMadeProduct.Click += new System.EventHandler(this.btnChangeMadeProduct_Click);
            this.btnChangeMadeProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnChangeMadeProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // btnAddMadeProduct
            // 
            this.btnAddMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMadeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMadeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMadeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMadeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddMadeProduct.Location = new System.Drawing.Point(0, 369);
            this.btnAddMadeProduct.Name = "btnAddMadeProduct";
            this.btnAddMadeProduct.Size = new System.Drawing.Size(227, 48);
            this.btnAddMadeProduct.TabIndex = 33;
            this.btnAddMadeProduct.Text = "Добавить";
            this.btnAddMadeProduct.UseVisualStyleBackColor = false;
            this.btnAddMadeProduct.Click += new System.EventHandler(this.btnAddMadeProduct_Click);
            this.btnAddMadeProduct.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnAddMadeProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // dataGridMadeProduct
            // 
            this.dataGridMadeProduct.AllowUserToAddRows = false;
            this.dataGridMadeProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridMadeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMadeProduct.Location = new System.Drawing.Point(0, 62);
            this.dataGridMadeProduct.Name = "dataGridMadeProduct";
            this.dataGridMadeProduct.ReadOnly = true;
            this.dataGridMadeProduct.Size = new System.Drawing.Size(693, 301);
            this.dataGridMadeProduct.TabIndex = 32;
            this.dataGridMadeProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMadeProduct_CellClick);
            this.dataGridMadeProduct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridMadeProduct_RowPrePaint);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnMakeBackUpBD);
            this.metroTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(951, 440);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Админ панель";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btnMakeBackUpBD
            // 
            this.btnMakeBackUpBD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeBackUpBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeBackUpBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeBackUpBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeBackUpBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMakeBackUpBD.Location = new System.Drawing.Point(3, 27);
            this.btnMakeBackUpBD.Name = "btnMakeBackUpBD";
            this.btnMakeBackUpBD.Size = new System.Drawing.Size(208, 48);
            this.btnMakeBackUpBD.TabIndex = 20;
            this.btnMakeBackUpBD.Text = "Резервное копирование БД";
            this.btnMakeBackUpBD.UseVisualStyleBackColor = false;
            this.btnMakeBackUpBD.Click += new System.EventHandler(this.btnMakeBackUpBD_Click);
            this.btnMakeBackUpBD.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnMakeBackUpBD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTimeNoMadeProduct);
            this.groupBox1.Controls.Add(this.checkBoxTimeLessMadeProduct);
            this.groupBox1.Controls.Add(this.checkBoxTimeIsMadeProduct);
            this.groupBox1.Location = new System.Drawing.Point(0, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 122);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Срок годности:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Location = new System.Drawing.Point(214, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(378, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Location = new System.Drawing.Point(546, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(404, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вот-вот истечёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(240, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ещё есть время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(572, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Окончен";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Пояснение (срок годности):";
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(788, 417);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 40;
            this.metroUserControl1.UseSelectable = true;
            // 
            // checkBoxTimeIsMadeProduct
            // 
            this.checkBoxTimeIsMadeProduct.AutoSize = true;
            this.checkBoxTimeIsMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTimeIsMadeProduct.DisplayFocus = true;
            this.checkBoxTimeIsMadeProduct.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checkBoxTimeIsMadeProduct.Location = new System.Drawing.Point(6, 25);
            this.checkBoxTimeIsMadeProduct.Name = "checkBoxTimeIsMadeProduct";
            this.checkBoxTimeIsMadeProduct.Size = new System.Drawing.Size(156, 25);
            this.checkBoxTimeIsMadeProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.checkBoxTimeIsMadeProduct.TabIndex = 0;
            this.checkBoxTimeIsMadeProduct.Text = "Ещё есть время";
            this.checkBoxTimeIsMadeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTimeIsMadeProduct.UseSelectable = true;
            // 
            // checkBoxTimeLessMadeProduct
            // 
            this.checkBoxTimeLessMadeProduct.AutoSize = true;
            this.checkBoxTimeLessMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTimeLessMadeProduct.DisplayFocus = true;
            this.checkBoxTimeLessMadeProduct.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checkBoxTimeLessMadeProduct.Location = new System.Drawing.Point(6, 50);
            this.checkBoxTimeLessMadeProduct.Name = "checkBoxTimeLessMadeProduct";
            this.checkBoxTimeLessMadeProduct.Size = new System.Drawing.Size(156, 25);
            this.checkBoxTimeLessMadeProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.checkBoxTimeLessMadeProduct.TabIndex = 1;
            this.checkBoxTimeLessMadeProduct.Text = "Вот-вот истечёт";
            this.checkBoxTimeLessMadeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTimeLessMadeProduct.UseSelectable = true;
            // 
            // checkBoxTimeNoMadeProduct
            // 
            this.checkBoxTimeNoMadeProduct.AutoSize = true;
            this.checkBoxTimeNoMadeProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTimeNoMadeProduct.DisplayFocus = true;
            this.checkBoxTimeNoMadeProduct.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checkBoxTimeNoMadeProduct.Location = new System.Drawing.Point(6, 74);
            this.checkBoxTimeNoMadeProduct.Name = "checkBoxTimeNoMadeProduct";
            this.checkBoxTimeNoMadeProduct.Size = new System.Drawing.Size(101, 25);
            this.checkBoxTimeNoMadeProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.checkBoxTimeNoMadeProduct.TabIndex = 2;
            this.checkBoxTimeNoMadeProduct.Text = "Окончен";
            this.checkBoxTimeNoMadeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTimeNoMadeProduct.UseSelectable = true;
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 566);
            this.Controls.Add(this.tabControll);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerMainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Таблицы";
            this.tabControll.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxWeight.ResumeLayout(false);
            this.groupBoxRealPrice.ResumeLayout(false);
            this.groupBoxOptimalPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.groupBoxFilterMadeProduct.ResumeLayout(false);
            this.groupBoxCountMadeProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMadeProduct)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTabControl tabControll;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnChangeEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnReportEmployee;
        private MetroFramework.Controls.MetroTextBox txtSearchEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private System.Windows.Forms.Button btnReportProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button btnMakeBackUpBD;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxOptimalPrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxWeight;
        private MetroFramework.Controls.MetroTextBox txtToWeightProduct;
        private MetroFramework.Controls.MetroTextBox txtFromWeightProduct;
        private System.Windows.Forms.GroupBox groupBoxRealPrice;
        private MetroFramework.Controls.MetroTextBox txtToRealPriceProduct;
        private MetroFramework.Controls.MetroTextBox txtFromRealPriceProduct;
        private MetroFramework.Controls.MetroTextBox txtToOptimalPriceProduct;
        private MetroFramework.Controls.MetroTextBox txtFromOptimalPriceProduct;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.GroupBox groupBoxFilterMadeProduct;
        private System.Windows.Forms.GroupBox groupBoxCountMadeProduct;
        private MetroFramework.Controls.MetroTextBox txtToCountMadeProduct;
        private MetroFramework.Controls.MetroTextBox txtFromCountMadeProduct;
        private MetroFramework.Controls.MetroTextBox txtSearchMadeProduct;
        private System.Windows.Forms.Button btnReportMadeProduct;
        private System.Windows.Forms.Button btnDeleteMadeProduct;
        private System.Windows.Forms.Button btnChangeMadeProduct;
        private System.Windows.Forms.Button btnAddMadeProduct;
        private System.Windows.Forms.DataGridView dataGridMadeProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroCheckBox checkBoxTimeIsMadeProduct;
        private MetroFramework.Controls.MetroCheckBox checkBoxTimeNoMadeProduct;
        private MetroFramework.Controls.MetroCheckBox checkBoxTimeLessMadeProduct;
    }
}