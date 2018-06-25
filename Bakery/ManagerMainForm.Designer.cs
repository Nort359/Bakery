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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnMakeBackUpBD = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnChangeEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnReportEmployee = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(33, 85);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(922, 446);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtSearchEmployee);
            this.metroTabPage1.Controls.Add(this.btnReportEmployee);
            this.metroTabPage1.Controls.Add(this.btnMakeBackUpBD);
            this.metroTabPage1.Controls.Add(this.btnDeleteEmployee);
            this.metroTabPage1.Controls.Add(this.btnChangeEmployee);
            this.metroTabPage1.Controls.Add(this.btnAddEmployee);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(914, 404);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Сотрудники";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnMakeBackUpBD
            // 
            this.btnMakeBackUpBD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeBackUpBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeBackUpBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeBackUpBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeBackUpBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMakeBackUpBD.Location = new System.Drawing.Point(699, 46);
            this.btnMakeBackUpBD.Name = "btnMakeBackUpBD";
            this.btnMakeBackUpBD.Size = new System.Drawing.Size(208, 48);
            this.btnMakeBackUpBD.TabIndex = 20;
            this.btnMakeBackUpBD.Text = "Резервное копирование БД";
            this.btnMakeBackUpBD.UseVisualStyleBackColor = false;
            this.btnMakeBackUpBD.Click += new System.EventHandler(this.btnMakeBackUpBD_Click);
            this.btnMakeBackUpBD.MouseLeave += new System.EventHandler(this.btnAddEmployee_MouseLeave);
            this.btnMakeBackUpBD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddEmployee_MouseMove);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 301);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(907, 384);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Заказчики";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
            // txtSearchEmployee
            // 
            // 
            // 
            // 
            this.txtSearchEmployee.CustomButton.Image = null;
            this.txtSearchEmployee.CustomButton.Location = new System.Drawing.Point(665, 2);
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
            this.txtSearchEmployee.Size = new System.Drawing.Size(693, 30);
            this.txtSearchEmployee.TabIndex = 22;
            this.txtSearchEmployee.UseSelectable = true;
            this.txtSearchEmployee.WaterMark = "Поиск";
            this.txtSearchEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtNameEmployee_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 554);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerMainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ManagerMainForm";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMakeBackUpBD;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnChangeEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnReportEmployee;
        private MetroFramework.Controls.MetroTextBox txtSearchEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}