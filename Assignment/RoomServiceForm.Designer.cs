﻿namespace Assignment
{
    partial class RoomServiceForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDS1 = new Assignment.CustomerDS();
            this.cbxFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstFood = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Assignment.CustomerDSTableAdapters.TableAdapterManager();
            this.tblCustomerTableAdapter1 = new Assignment.CustomerDSTableAdapters.tblCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.DataSource = this.tblCustomerBindingSource;
            this.cbxCustomer.DisplayMember = "name";
            this.cbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(69, 6);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(364, 21);
            this.cbxCustomer.TabIndex = 1;
            this.cbxCustomer.ValueMember = "idNumber";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.customerDS1;
            // 
            // customerDS1
            // 
            this.customerDS1.DataSetName = "CustomerDS";
            this.customerDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxFood
            // 
            this.cbxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFood.FormattingEnabled = true;
            this.cbxFood.Location = new System.Drawing.Point(69, 33);
            this.cbxFood.Name = "cbxFood";
            this.cbxFood.Size = new System.Drawing.Size(364, 21);
            this.cbxFood.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(69, 61);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(364, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // lstFood
            // 
            this.lstFood.FormattingEnabled = true;
            this.lstFood.Location = new System.Drawing.Point(9, 87);
            this.lstFood.Name = "lstFood";
            this.lstFood.Size = new System.Drawing.Size(466, 134);
            this.lstFood.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(9, 256);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(381, 23);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(204, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(315, 227);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblBookingDateTableAdapter = null;
            this.tableAdapterManager1.tblCustomerTableAdapter = this.tblCustomerTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Assignment.CustomerDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCustomerTableAdapter1
            // 
            this.tblCustomerTableAdapter1.ClearBeforeFill = true;
            // 
            // RoomServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 297);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstFood);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFood);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.label1);
            this.Name = "RoomServiceForm";
            this.Text = "Room Service Form";
            this.Load += new System.EventHandler(this.RoomServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.ComboBox cbxFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox lstFood;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private CustomerDS customerDS1;
        private CustomerDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private CustomerDSTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter1;
    }
}