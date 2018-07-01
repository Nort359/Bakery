namespace Bakery
{
    partial class AddChangeProduct
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
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeProduct = new MetroFramework.Controls.MetroComboBox();
            this.txtRealPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtOptimalPriceProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTimeTillDownProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtWeightProduct = new MetroFramework.Controls.MetroTextBox();
            this.lblMainEmployee = new System.Windows.Forms.Label();
            this.txtTitleProduct = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(167, 330);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(227, 48);
            this.btnChange.TabIndex = 58;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(19, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Сотрудник:";
            // 
            // comboBoxEmployeeProduct
            // 
            this.comboBoxEmployeeProduct.ItemHeight = 23;
            this.comboBoxEmployeeProduct.Location = new System.Drawing.Point(23, 254);
            this.comboBoxEmployeeProduct.Name = "comboBoxEmployeeProduct";
            this.comboBoxEmployeeProduct.Size = new System.Drawing.Size(263, 29);
            this.comboBoxEmployeeProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.comboBoxEmployeeProduct.TabIndex = 51;
            this.comboBoxEmployeeProduct.UseSelectable = true;
            // 
            // txtRealPriceProduct
            // 
            // 
            // 
            // 
            this.txtRealPriceProduct.CustomButton.Image = null;
            this.txtRealPriceProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtRealPriceProduct.CustomButton.Name = "";
            this.txtRealPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRealPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRealPriceProduct.CustomButton.TabIndex = 1;
            this.txtRealPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRealPriceProduct.CustomButton.UseSelectable = true;
            this.txtRealPriceProduct.CustomButton.Visible = false;
            this.txtRealPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRealPriceProduct.Lines = new string[0];
            this.txtRealPriceProduct.Location = new System.Drawing.Point(328, 162);
            this.txtRealPriceProduct.MaxLength = 32767;
            this.txtRealPriceProduct.Name = "txtRealPriceProduct";
            this.txtRealPriceProduct.PasswordChar = '\0';
            this.txtRealPriceProduct.PromptText = "Розничная цена";
            this.txtRealPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRealPriceProduct.SelectedText = "";
            this.txtRealPriceProduct.SelectionLength = 0;
            this.txtRealPriceProduct.SelectionStart = 0;
            this.txtRealPriceProduct.ShortcutsEnabled = true;
            this.txtRealPriceProduct.Size = new System.Drawing.Size(263, 30);
            this.txtRealPriceProduct.TabIndex = 48;
            this.txtRealPriceProduct.UseSelectable = true;
            this.txtRealPriceProduct.WaterMark = "Розничная цена";
            this.txtRealPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRealPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRealPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightProduct_KeyPress);
            // 
            // txtOptimalPriceProduct
            // 
            // 
            // 
            // 
            this.txtOptimalPriceProduct.CustomButton.Image = null;
            this.txtOptimalPriceProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtOptimalPriceProduct.CustomButton.Name = "";
            this.txtOptimalPriceProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtOptimalPriceProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOptimalPriceProduct.CustomButton.TabIndex = 1;
            this.txtOptimalPriceProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOptimalPriceProduct.CustomButton.UseSelectable = true;
            this.txtOptimalPriceProduct.CustomButton.Visible = false;
            this.txtOptimalPriceProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOptimalPriceProduct.Lines = new string[0];
            this.txtOptimalPriceProduct.Location = new System.Drawing.Point(328, 126);
            this.txtOptimalPriceProduct.MaxLength = 32767;
            this.txtOptimalPriceProduct.Name = "txtOptimalPriceProduct";
            this.txtOptimalPriceProduct.PasswordChar = '\0';
            this.txtOptimalPriceProduct.PromptText = "Оптимальная цена";
            this.txtOptimalPriceProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOptimalPriceProduct.SelectedText = "";
            this.txtOptimalPriceProduct.SelectionLength = 0;
            this.txtOptimalPriceProduct.SelectionStart = 0;
            this.txtOptimalPriceProduct.ShortcutsEnabled = true;
            this.txtOptimalPriceProduct.Size = new System.Drawing.Size(263, 30);
            this.txtOptimalPriceProduct.TabIndex = 47;
            this.txtOptimalPriceProduct.UseSelectable = true;
            this.txtOptimalPriceProduct.WaterMark = "Оптимальная цена";
            this.txtOptimalPriceProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOptimalPriceProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOptimalPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightProduct_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(400, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(167, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 48);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTimeTillDownProduct
            // 
            // 
            // 
            // 
            this.txtTimeTillDownProduct.CustomButton.Image = null;
            this.txtTimeTillDownProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtTimeTillDownProduct.CustomButton.Name = "";
            this.txtTimeTillDownProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTimeTillDownProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeTillDownProduct.CustomButton.TabIndex = 1;
            this.txtTimeTillDownProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeTillDownProduct.CustomButton.UseSelectable = true;
            this.txtTimeTillDownProduct.CustomButton.Visible = false;
            this.txtTimeTillDownProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTimeTillDownProduct.Lines = new string[0];
            this.txtTimeTillDownProduct.Location = new System.Drawing.Point(23, 198);
            this.txtTimeTillDownProduct.MaxLength = 32767;
            this.txtTimeTillDownProduct.Name = "txtTimeTillDownProduct";
            this.txtTimeTillDownProduct.PasswordChar = '\0';
            this.txtTimeTillDownProduct.PromptText = "Срок годности (сут.)";
            this.txtTimeTillDownProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeTillDownProduct.SelectedText = "";
            this.txtTimeTillDownProduct.SelectionLength = 0;
            this.txtTimeTillDownProduct.SelectionStart = 0;
            this.txtTimeTillDownProduct.ShortcutsEnabled = true;
            this.txtTimeTillDownProduct.Size = new System.Drawing.Size(263, 30);
            this.txtTimeTillDownProduct.TabIndex = 41;
            this.txtTimeTillDownProduct.UseSelectable = true;
            this.txtTimeTillDownProduct.WaterMark = "Срок годности (сут.)";
            this.txtTimeTillDownProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeTillDownProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTimeTillDownProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightProduct_KeyPress);
            // 
            // txtWeightProduct
            // 
            // 
            // 
            // 
            this.txtWeightProduct.CustomButton.Image = null;
            this.txtWeightProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtWeightProduct.CustomButton.Name = "";
            this.txtWeightProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWeightProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeightProduct.CustomButton.TabIndex = 1;
            this.txtWeightProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeightProduct.CustomButton.UseSelectable = true;
            this.txtWeightProduct.CustomButton.Visible = false;
            this.txtWeightProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWeightProduct.Lines = new string[0];
            this.txtWeightProduct.Location = new System.Drawing.Point(23, 162);
            this.txtWeightProduct.MaxLength = 32767;
            this.txtWeightProduct.Name = "txtWeightProduct";
            this.txtWeightProduct.PasswordChar = '\0';
            this.txtWeightProduct.PromptText = "Вес (гр.)";
            this.txtWeightProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeightProduct.SelectedText = "";
            this.txtWeightProduct.SelectionLength = 0;
            this.txtWeightProduct.SelectionStart = 0;
            this.txtWeightProduct.ShortcutsEnabled = true;
            this.txtWeightProduct.Size = new System.Drawing.Size(263, 30);
            this.txtWeightProduct.TabIndex = 40;
            this.txtWeightProduct.UseSelectable = true;
            this.txtWeightProduct.WaterMark = "Вес (гр.)";
            this.txtWeightProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeightProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeightProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightProduct_KeyPress);
            // 
            // lblMainEmployee
            // 
            this.lblMainEmployee.AutoSize = true;
            this.lblMainEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblMainEmployee.Location = new System.Drawing.Point(18, 74);
            this.lblMainEmployee.Name = "lblMainEmployee";
            this.lblMainEmployee.Size = new System.Drawing.Size(504, 25);
            this.lblMainEmployee.TabIndex = 39;
            this.lblMainEmployee.Text = "Введите все необходимые данные о сотруднике:";
            // 
            // txtTitleProduct
            // 
            // 
            // 
            // 
            this.txtTitleProduct.CustomButton.Image = null;
            this.txtTitleProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtTitleProduct.CustomButton.Name = "";
            this.txtTitleProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTitleProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitleProduct.CustomButton.TabIndex = 1;
            this.txtTitleProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitleProduct.CustomButton.UseSelectable = true;
            this.txtTitleProduct.CustomButton.Visible = false;
            this.txtTitleProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitleProduct.Lines = new string[0];
            this.txtTitleProduct.Location = new System.Drawing.Point(23, 126);
            this.txtTitleProduct.MaxLength = 32767;
            this.txtTitleProduct.Name = "txtTitleProduct";
            this.txtTitleProduct.PasswordChar = '\0';
            this.txtTitleProduct.PromptText = "Наименование";
            this.txtTitleProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitleProduct.SelectedText = "";
            this.txtTitleProduct.SelectionLength = 0;
            this.txtTitleProduct.SelectionStart = 0;
            this.txtTitleProduct.ShortcutsEnabled = true;
            this.txtTitleProduct.Size = new System.Drawing.Size(263, 30);
            this.txtTitleProduct.TabIndex = 38;
            this.txtTitleProduct.UseSelectable = true;
            this.txtTitleProduct.WaterMark = "Наименование";
            this.txtTitleProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitleProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitleProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitleProduct_KeyPress);
            // 
            // AddChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 401);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmployeeProduct);
            this.Controls.Add(this.txtRealPriceProduct);
            this.Controls.Add(this.txtOptimalPriceProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimeTillDownProduct);
            this.Controls.Add(this.txtWeightProduct);
            this.Controls.Add(this.lblMainEmployee);
            this.Controls.Add(this.txtTitleProduct);
            this.Name = "AddChangeProduct";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Действия над продуктом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox comboBoxEmployeeProduct;
        private MetroFramework.Controls.MetroTextBox txtRealPriceProduct;
        private MetroFramework.Controls.MetroTextBox txtOptimalPriceProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTimeTillDownProduct;
        private MetroFramework.Controls.MetroTextBox txtWeightProduct;
        private System.Windows.Forms.Label lblMainEmployee;
        private MetroFramework.Controls.MetroTextBox txtTitleProduct;
    }
}