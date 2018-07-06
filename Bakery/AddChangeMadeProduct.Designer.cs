namespace Bakery
{
    partial class AddChangeMadeProduct
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
            this.comboBoxProductMadeProduct = new MetroFramework.Controls.MetroComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMainEmployee = new System.Windows.Forms.Label();
            this.txtCountMadeProduct = new MetroFramework.Controls.MetroTextBox();
            this.txtDateMadeProduct = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSizeMadeProduct = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(196, 243);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(227, 48);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(390, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выбирите продукцию:";
            // 
            // comboBoxProductMadeProduct
            // 
            this.comboBoxProductMadeProduct.ItemHeight = 23;
            this.comboBoxProductMadeProduct.Location = new System.Drawing.Point(393, 135);
            this.comboBoxProductMadeProduct.Name = "comboBoxProductMadeProduct";
            this.comboBoxProductMadeProduct.Size = new System.Drawing.Size(263, 29);
            this.comboBoxProductMadeProduct.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxProductMadeProduct.TabIndex = 5;
            this.comboBoxProductMadeProduct.UseSelectable = true;
            this.comboBoxProductMadeProduct.Enter += new System.EventHandler(this.txtCountMadeProduct_Enter);
            this.comboBoxProductMadeProduct.Leave += new System.EventHandler(this.txtCountMadeProduct_Leave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(429, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 11;
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
            this.btnAdd.Location = new System.Drawing.Point(196, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMainEmployee
            // 
            this.lblMainEmployee.AutoSize = true;
            this.lblMainEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblMainEmployee.Location = new System.Drawing.Point(23, 78);
            this.lblMainEmployee.Name = "lblMainEmployee";
            this.lblMainEmployee.Size = new System.Drawing.Size(504, 25);
            this.lblMainEmployee.TabIndex = 0;
            this.lblMainEmployee.Text = "Введите все необходимые данные о сотруднике:";
            // 
            // txtCountMadeProduct
            // 
            // 
            // 
            // 
            this.txtCountMadeProduct.CustomButton.Image = null;
            this.txtCountMadeProduct.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtCountMadeProduct.CustomButton.Name = "";
            this.txtCountMadeProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCountMadeProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCountMadeProduct.CustomButton.TabIndex = 1;
            this.txtCountMadeProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCountMadeProduct.CustomButton.UseSelectable = true;
            this.txtCountMadeProduct.CustomButton.Visible = false;
            this.txtCountMadeProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCountMadeProduct.Lines = new string[0];
            this.txtCountMadeProduct.Location = new System.Drawing.Point(28, 135);
            this.txtCountMadeProduct.MaxLength = 4;
            this.txtCountMadeProduct.Name = "txtCountMadeProduct";
            this.txtCountMadeProduct.PasswordChar = '\0';
            this.txtCountMadeProduct.PromptText = "Количество";
            this.txtCountMadeProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCountMadeProduct.SelectedText = "";
            this.txtCountMadeProduct.SelectionLength = 0;
            this.txtCountMadeProduct.SelectionStart = 0;
            this.txtCountMadeProduct.ShortcutsEnabled = true;
            this.txtCountMadeProduct.Size = new System.Drawing.Size(263, 30);
            this.txtCountMadeProduct.TabIndex = 1;
            this.txtCountMadeProduct.UseSelectable = true;
            this.txtCountMadeProduct.WaterMark = "Количество";
            this.txtCountMadeProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCountMadeProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountMadeProduct.Enter += new System.EventHandler(this.txtCountMadeProduct_Enter);
            this.txtCountMadeProduct.Leave += new System.EventHandler(this.txtCountMadeProduct_Leave);
            // 
            // txtDateMadeProduct
            // 
            this.txtDateMadeProduct.CustomFormat = "";
            this.txtDateMadeProduct.Location = new System.Drawing.Point(28, 189);
            this.txtDateMadeProduct.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtDateMadeProduct.Name = "txtDateMadeProduct";
            this.txtDateMadeProduct.Size = new System.Drawing.Size(263, 29);
            this.txtDateMadeProduct.TabIndex = 3;
            this.txtDateMadeProduct.Enter += new System.EventHandler(this.txtCountMadeProduct_Enter);
            this.txtDateMadeProduct.Leave += new System.EventHandler(this.txtCountMadeProduct_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(390, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип измерения продукции:";
            // 
            // comboBoxSizeMadeProduct
            // 
            this.comboBoxSizeMadeProduct.ItemHeight = 23;
            this.comboBoxSizeMadeProduct.Location = new System.Drawing.Point(393, 188);
            this.comboBoxSizeMadeProduct.Name = "comboBoxSizeMadeProduct";
            this.comboBoxSizeMadeProduct.Size = new System.Drawing.Size(263, 29);
            this.comboBoxSizeMadeProduct.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxSizeMadeProduct.TabIndex = 7;
            this.comboBoxSizeMadeProduct.UseSelectable = true;
            this.comboBoxSizeMadeProduct.Enter += new System.EventHandler(this.txtCountMadeProduct_Enter);
            this.comboBoxSizeMadeProduct.Leave += new System.EventHandler(this.txtCountMadeProduct_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата приготовления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество:";
            // 
            // AddChangeMadeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSizeMadeProduct);
            this.Controls.Add(this.txtDateMadeProduct);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProductMadeProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMainEmployee);
            this.Controls.Add(this.txtCountMadeProduct);
            this.MaximizeBox = false;
            this.Name = "AddChangeMadeProduct";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Добавление/Измерение приготовления продукции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox comboBoxProductMadeProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMainEmployee;
        private MetroFramework.Controls.MetroTextBox txtCountMadeProduct;
        private MetroFramework.Controls.MetroDateTime txtDateMadeProduct;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBoxSizeMadeProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}