namespace Bakery
{
    partial class AddChangeMaterial
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
            this.comboBoxProduct = new MetroFramework.Controls.MetroComboBox();
            this.txtPriceMaterial = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTimeTillDownMaterial = new MetroFramework.Controls.MetroTextBox();
            this.txtCountMaterial = new MetroFramework.Controls.MetroTextBox();
            this.lblMainEmployee = new System.Windows.Forms.Label();
            this.txtTitleMaterial = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(133, 322);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(227, 48);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(325, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Продукция:";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.ItemHeight = 23;
            this.comboBoxProduct.Location = new System.Drawing.Point(328, 260);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(263, 29);
            this.comboBoxProduct.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxProduct.TabIndex = 11;
            this.comboBoxProduct.UseSelectable = true;
            this.comboBoxProduct.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.comboBoxProduct.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // txtPriceMaterial
            // 
            // 
            // 
            // 
            this.txtPriceMaterial.CustomButton.Image = null;
            this.txtPriceMaterial.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtPriceMaterial.CustomButton.Name = "";
            this.txtPriceMaterial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPriceMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceMaterial.CustomButton.TabIndex = 1;
            this.txtPriceMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceMaterial.CustomButton.UseSelectable = true;
            this.txtPriceMaterial.CustomButton.Visible = false;
            this.txtPriceMaterial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPriceMaterial.Lines = new string[0];
            this.txtPriceMaterial.Location = new System.Drawing.Point(328, 206);
            this.txtPriceMaterial.MaxLength = 5;
            this.txtPriceMaterial.Name = "txtPriceMaterial";
            this.txtPriceMaterial.PasswordChar = '\0';
            this.txtPriceMaterial.PromptText = "Общая стоимость";
            this.txtPriceMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceMaterial.SelectedText = "";
            this.txtPriceMaterial.SelectionLength = 0;
            this.txtPriceMaterial.SelectionStart = 0;
            this.txtPriceMaterial.ShortcutsEnabled = true;
            this.txtPriceMaterial.Size = new System.Drawing.Size(263, 30);
            this.txtPriceMaterial.TabIndex = 9;
            this.txtPriceMaterial.UseSelectable = true;
            this.txtPriceMaterial.WaterMark = "Общая стоимость";
            this.txtPriceMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPriceMaterial.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.txtPriceMaterial.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(366, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(133, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 48);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTimeTillDownMaterial
            // 
            // 
            // 
            // 
            this.txtTimeTillDownMaterial.CustomButton.Image = null;
            this.txtTimeTillDownMaterial.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtTimeTillDownMaterial.CustomButton.Name = "";
            this.txtTimeTillDownMaterial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTimeTillDownMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeTillDownMaterial.CustomButton.TabIndex = 1;
            this.txtTimeTillDownMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeTillDownMaterial.CustomButton.UseSelectable = true;
            this.txtTimeTillDownMaterial.CustomButton.Visible = false;
            this.txtTimeTillDownMaterial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTimeTillDownMaterial.Lines = new string[0];
            this.txtTimeTillDownMaterial.Location = new System.Drawing.Point(328, 152);
            this.txtTimeTillDownMaterial.MaxLength = 4;
            this.txtTimeTillDownMaterial.Name = "txtTimeTillDownMaterial";
            this.txtTimeTillDownMaterial.PasswordChar = '\0';
            this.txtTimeTillDownMaterial.PromptText = "Срок годности (сут.)";
            this.txtTimeTillDownMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeTillDownMaterial.SelectedText = "";
            this.txtTimeTillDownMaterial.SelectionLength = 0;
            this.txtTimeTillDownMaterial.SelectionStart = 0;
            this.txtTimeTillDownMaterial.ShortcutsEnabled = true;
            this.txtTimeTillDownMaterial.Size = new System.Drawing.Size(263, 30);
            this.txtTimeTillDownMaterial.TabIndex = 7;
            this.txtTimeTillDownMaterial.UseSelectable = true;
            this.txtTimeTillDownMaterial.WaterMark = "Срок годности (сут.)";
            this.txtTimeTillDownMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeTillDownMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTimeTillDownMaterial.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.txtTimeTillDownMaterial.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // txtCountMaterial
            // 
            // 
            // 
            // 
            this.txtCountMaterial.CustomButton.Image = null;
            this.txtCountMaterial.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtCountMaterial.CustomButton.Name = "";
            this.txtCountMaterial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCountMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCountMaterial.CustomButton.TabIndex = 1;
            this.txtCountMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCountMaterial.CustomButton.UseSelectable = true;
            this.txtCountMaterial.CustomButton.Visible = false;
            this.txtCountMaterial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCountMaterial.Lines = new string[0];
            this.txtCountMaterial.Location = new System.Drawing.Point(23, 206);
            this.txtCountMaterial.MaxLength = 4;
            this.txtCountMaterial.Name = "txtCountMaterial";
            this.txtCountMaterial.PasswordChar = '\0';
            this.txtCountMaterial.PromptText = "Количество";
            this.txtCountMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCountMaterial.SelectedText = "";
            this.txtCountMaterial.SelectionLength = 0;
            this.txtCountMaterial.SelectionStart = 0;
            this.txtCountMaterial.ShortcutsEnabled = true;
            this.txtCountMaterial.Size = new System.Drawing.Size(263, 30);
            this.txtCountMaterial.TabIndex = 3;
            this.txtCountMaterial.UseSelectable = true;
            this.txtCountMaterial.WaterMark = "Количество";
            this.txtCountMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCountMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountMaterial.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.txtCountMaterial.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // lblMainEmployee
            // 
            this.lblMainEmployee.AutoSize = true;
            this.lblMainEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblMainEmployee.Location = new System.Drawing.Point(18, 89);
            this.lblMainEmployee.Name = "lblMainEmployee";
            this.lblMainEmployee.Size = new System.Drawing.Size(504, 25);
            this.lblMainEmployee.TabIndex = 0;
            this.lblMainEmployee.Text = "Введите все необходимые данные о сотруднике:";
            // 
            // txtTitleMaterial
            // 
            // 
            // 
            // 
            this.txtTitleMaterial.CustomButton.Image = null;
            this.txtTitleMaterial.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtTitleMaterial.CustomButton.Name = "";
            this.txtTitleMaterial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTitleMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitleMaterial.CustomButton.TabIndex = 1;
            this.txtTitleMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitleMaterial.CustomButton.UseSelectable = true;
            this.txtTitleMaterial.CustomButton.Visible = false;
            this.txtTitleMaterial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitleMaterial.Lines = new string[0];
            this.txtTitleMaterial.Location = new System.Drawing.Point(23, 152);
            this.txtTitleMaterial.MaxLength = 30;
            this.txtTitleMaterial.Name = "txtTitleMaterial";
            this.txtTitleMaterial.PasswordChar = '\0';
            this.txtTitleMaterial.PromptText = "Наименование";
            this.txtTitleMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitleMaterial.SelectedText = "";
            this.txtTitleMaterial.SelectionLength = 0;
            this.txtTitleMaterial.SelectionStart = 0;
            this.txtTitleMaterial.ShortcutsEnabled = true;
            this.txtTitleMaterial.Size = new System.Drawing.Size(263, 30);
            this.txtTitleMaterial.TabIndex = 1;
            this.txtTitleMaterial.UseSelectable = true;
            this.txtTitleMaterial.WaterMark = "Наименование";
            this.txtTitleMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitleMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitleMaterial.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.txtTitleMaterial.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(20, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип измерения:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.ItemHeight = 23;
            this.comboBoxType.Location = new System.Drawing.Point(23, 260);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(263, 29);
            this.comboBoxType.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.UseSelectable = true;
            this.comboBoxType.Enter += new System.EventHandler(this.txtTitleMaterial_Enter);
            this.comboBoxType.Leave += new System.EventHandler(this.txtTitleMaterial_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(324, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срок годности:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(324, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Общая стоимость:";
            // 
            // AddChangeMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 393);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.txtPriceMaterial);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimeTillDownMaterial);
            this.Controls.Add(this.txtCountMaterial);
            this.Controls.Add(this.lblMainEmployee);
            this.Controls.Add(this.txtTitleMaterial);
            this.MaximizeBox = false;
            this.Name = "AddChangeMaterial";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Добавление/Изменение сырья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox comboBoxProduct;
        private MetroFramework.Controls.MetroTextBox txtPriceMaterial;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTimeTillDownMaterial;
        private MetroFramework.Controls.MetroTextBox txtCountMaterial;
        private System.Windows.Forms.Label lblMainEmployee;
        private MetroFramework.Controls.MetroTextBox txtTitleMaterial;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}