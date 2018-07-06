namespace Bakery
{
    partial class AddChangeOrder
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
            this.btnChangeEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtCount = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMainEmployee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEnableDatesOrders = new MetroFramework.Controls.MetroComboBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.comboBoxProduct = new MetroFramework.Controls.MetroComboBox();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceForOne = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIds = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWeightForOne = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnChangeEmployee
            // 
            this.btnChangeEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.btnChangeEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeEmployee.Location = new System.Drawing.Point(135, 372);
            this.btnChangeEmployee.Name = "btnChangeEmployee";
            this.btnChangeEmployee.Size = new System.Drawing.Size(227, 48);
            this.btnChangeEmployee.TabIndex = 17;
            this.btnChangeEmployee.Text = "Изменить";
            this.btnChangeEmployee.UseVisualStyleBackColor = false;
            this.btnChangeEmployee.Click += new System.EventHandler(this.btnChangeEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Продукция:";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(333, 243);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Общая стоимость";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(263, 30);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Общая стоимость";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // txtCount
            // 
            // 
            // 
            // 
            this.txtCount.CustomButton.Image = null;
            this.txtCount.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtCount.CustomButton.Name = "";
            this.txtCount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCount.CustomButton.TabIndex = 1;
            this.txtCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCount.CustomButton.UseSelectable = true;
            this.txtCount.CustomButton.Visible = false;
            this.txtCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCount.Lines = new string[0];
            this.txtCount.Location = new System.Drawing.Point(22, 296);
            this.txtCount.MaxLength = 32767;
            this.txtCount.Name = "txtCount";
            this.txtCount.PasswordChar = '\0';
            this.txtCount.PromptText = "Количество";
            this.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCount.SelectedText = "";
            this.txtCount.SelectionLength = 0;
            this.txtCount.SelectionStart = 0;
            this.txtCount.ShortcutsEnabled = true;
            this.txtCount.Size = new System.Drawing.Size(263, 30);
            this.txtCount.TabIndex = 7;
            this.txtCount.UseSelectable = true;
            this.txtCount.WaterMark = "Количество";
            this.txtCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.txtCount.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(368, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 19;
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
            this.btnAdd.Location = new System.Drawing.Point(135, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 48);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMainEmployee
            // 
            this.lblMainEmployee.AutoSize = true;
            this.lblMainEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblMainEmployee.Location = new System.Drawing.Point(23, 71);
            this.lblMainEmployee.Name = "lblMainEmployee";
            this.lblMainEmployee.Size = new System.Drawing.Size(504, 25);
            this.lblMainEmployee.TabIndex = 0;
            this.lblMainEmployee.Text = "Введите все необходимые данные о сотруднике:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Заказчик:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.ItemHeight = 23;
            this.comboBoxCustomer.Location = new System.Drawing.Point(22, 190);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(263, 29);
            this.comboBoxCustomer.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxCustomer.TabIndex = 3;
            this.comboBoxCustomer.UseSelectable = true;
            this.comboBoxCustomer.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.comboBoxCustomer.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(19, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Доступные даты изготовления:";
            // 
            // comboBoxEnableDatesOrders
            // 
            this.comboBoxEnableDatesOrders.ItemHeight = 23;
            this.comboBoxEnableDatesOrders.Location = new System.Drawing.Point(22, 243);
            this.comboBoxEnableDatesOrders.Name = "comboBoxEnableDatesOrders";
            this.comboBoxEnableDatesOrders.Size = new System.Drawing.Size(263, 29);
            this.comboBoxEnableDatesOrders.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxEnableDatesOrders.TabIndex = 5;
            this.comboBoxEnableDatesOrders.UseSelectable = true;
            this.comboBoxEnableDatesOrders.SelectedValueChanged += new System.EventHandler(this.comboBoxEnableDatesOrders_SelectedValueChanged);
            this.comboBoxEnableDatesOrders.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.comboBoxEnableDatesOrders.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblRest.Location = new System.Drawing.Point(20, 275);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(81, 18);
            this.lblRest.TabIndex = 8;
            this.lblRest.Text = "Осталось:";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.ItemHeight = 23;
            this.comboBoxProduct.Location = new System.Drawing.Point(22, 137);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(263, 29);
            this.comboBoxProduct.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxProduct.TabIndex = 1;
            this.comboBoxProduct.UseSelectable = true;
            this.comboBoxProduct.SelectedValueChanged += new System.EventHandler(this.comboBoxProduct_SelectedValueChanged);
            this.comboBoxProduct.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.comboBoxProduct.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // txtWeight
            // 
            // 
            // 
            // 
            this.txtWeight.CustomButton.Image = null;
            this.txtWeight.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtWeight.CustomButton.Name = "";
            this.txtWeight.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeight.CustomButton.TabIndex = 1;
            this.txtWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeight.CustomButton.UseSelectable = true;
            this.txtWeight.CustomButton.Visible = false;
            this.txtWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWeight.Lines = new string[0];
            this.txtWeight.Location = new System.Drawing.Point(332, 297);
            this.txtWeight.MaxLength = 32767;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PromptText = "Общий вес";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeight.SelectedText = "";
            this.txtWeight.SelectionLength = 0;
            this.txtWeight.SelectionStart = 0;
            this.txtWeight.ShortcutsEnabled = true;
            this.txtWeight.Size = new System.Drawing.Size(263, 30);
            this.txtWeight.TabIndex = 15;
            this.txtWeight.UseSelectable = true;
            this.txtWeight.WaterMark = "Общий вес";
            this.txtWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.txtWeight.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(330, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Общий вес (гр.):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(330, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена за штуку:";
            // 
            // txtPriceForOne
            // 
            // 
            // 
            // 
            this.txtPriceForOne.CustomButton.Image = null;
            this.txtPriceForOne.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtPriceForOne.CustomButton.Name = "";
            this.txtPriceForOne.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPriceForOne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceForOne.CustomButton.TabIndex = 1;
            this.txtPriceForOne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceForOne.CustomButton.UseSelectable = true;
            this.txtPriceForOne.CustomButton.Visible = false;
            this.txtPriceForOne.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPriceForOne.Lines = new string[0];
            this.txtPriceForOne.Location = new System.Drawing.Point(332, 136);
            this.txtPriceForOne.MaxLength = 32767;
            this.txtPriceForOne.Name = "txtPriceForOne";
            this.txtPriceForOne.PasswordChar = '\0';
            this.txtPriceForOne.PromptText = "Цена за штуку";
            this.txtPriceForOne.ReadOnly = true;
            this.txtPriceForOne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceForOne.SelectedText = "";
            this.txtPriceForOne.SelectionLength = 0;
            this.txtPriceForOne.SelectionStart = 0;
            this.txtPriceForOne.ShortcutsEnabled = true;
            this.txtPriceForOne.Size = new System.Drawing.Size(263, 30);
            this.txtPriceForOne.TabIndex = 9;
            this.txtPriceForOne.UseSelectable = true;
            this.txtPriceForOne.WaterMark = "Цена за штуку";
            this.txtPriceForOne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceForOne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPriceForOne.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.txtPriceForOne.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(330, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Общая стоимость (руб.):";
            // 
            // comboBoxIds
            // 
            this.comboBoxIds.ItemHeight = 23;
            this.comboBoxIds.Location = new System.Drawing.Point(23, 340);
            this.comboBoxIds.Name = "comboBoxIds";
            this.comboBoxIds.Size = new System.Drawing.Size(263, 29);
            this.comboBoxIds.Style = MetroFramework.MetroColorStyle.Orange;
            this.comboBoxIds.TabIndex = 20;
            this.comboBoxIds.UseSelectable = true;
            this.comboBoxIds.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(330, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Вес на шт. (гр.):";
            // 
            // txtWeightForOne
            // 
            // 
            // 
            // 
            this.txtWeightForOne.CustomButton.Image = null;
            this.txtWeightForOne.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.txtWeightForOne.CustomButton.Name = "";
            this.txtWeightForOne.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWeightForOne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeightForOne.CustomButton.TabIndex = 1;
            this.txtWeightForOne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeightForOne.CustomButton.UseSelectable = true;
            this.txtWeightForOne.CustomButton.Visible = false;
            this.txtWeightForOne.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWeightForOne.Lines = new string[0];
            this.txtWeightForOne.Location = new System.Drawing.Point(332, 190);
            this.txtWeightForOne.MaxLength = 32767;
            this.txtWeightForOne.Name = "txtWeightForOne";
            this.txtWeightForOne.PasswordChar = '\0';
            this.txtWeightForOne.PromptText = "Вес на штуку";
            this.txtWeightForOne.ReadOnly = true;
            this.txtWeightForOne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeightForOne.SelectedText = "";
            this.txtWeightForOne.SelectionLength = 0;
            this.txtWeightForOne.SelectionStart = 0;
            this.txtWeightForOne.ShortcutsEnabled = true;
            this.txtWeightForOne.Size = new System.Drawing.Size(263, 30);
            this.txtWeightForOne.TabIndex = 11;
            this.txtWeightForOne.UseSelectable = true;
            this.txtWeightForOne.WaterMark = "Вес на штуку";
            this.txtWeightForOne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeightForOne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeightForOne.Enter += new System.EventHandler(this.comboBoxProduct_Enter);
            this.txtWeightForOne.Leave += new System.EventHandler(this.comboBoxProduct_Leave);
            // 
            // AddChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 445);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWeightForOne);
            this.Controls.Add(this.comboBoxIds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriceForOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEnableDatesOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.btnChangeEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMainEmployee);
            this.MaximizeBox = false;
            this.Name = "AddChangeOrder";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Добавить/Изменить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangeEmployee;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMainEmployee;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBoxEnableDatesOrders;
        private System.Windows.Forms.Label lblRest;
        private MetroFramework.Controls.MetroComboBox comboBoxProduct;
        private MetroFramework.Controls.MetroTextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtPriceForOne;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox comboBoxIds;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtWeightForOne;
    }
}