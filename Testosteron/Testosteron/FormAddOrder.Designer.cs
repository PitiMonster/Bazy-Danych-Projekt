﻿namespace Testosteron
{
    partial class FormAddOrder
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
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.labelNIP = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToAddRows = false;
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.AllowUserToOrderColumns = true;
            this.dataGridViewAll.AllowUserToResizeColumns = false;
            this.dataGridViewAll.AllowUserToResizeRows = false;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(13, 29);
            this.dataGridViewAll.MultiSelect = false;
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.Size = new System.Drawing.Size(309, 398);
            this.dataGridViewAll.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAmount});
            this.dataGridViewProducts.Location = new System.Drawing.Point(328, 29);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProducts.Size = new System.Drawing.Size(240, 556);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_RowHeaderMouseDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id_produktu";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Ilość";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNIP.Location = new System.Drawing.Point(578, 56);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(200, 29);
            this.textBoxNIP.TabIndex = 2;
            // 
            // labelNIP
            // 
            this.labelNIP.AutoSize = true;
            this.labelNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNIP.Location = new System.Drawing.Point(574, 29);
            this.labelNIP.Name = "labelNIP";
            this.labelNIP.Size = new System.Drawing.Size(85, 24);
            this.labelNIP.TabIndex = 4;
            this.labelNIP.Text = "ID klienta";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(574, 130);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 24);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Data";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOrder.Location = new System.Drawing.Point(574, 501);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(200, 38);
            this.buttonAddOrder.TabIndex = 6;
            this.buttonAddOrder.Text = "Dodaj";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(574, 548);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 38);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(578, 168);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 433);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(309, 152);
            this.dataGridView1.TabIndex = 18;
            // 
            // FormAddOrder
            // 
            this.AcceptButton = this.buttonAddOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNIP);
            this.Controls.Add(this.textBoxNIP);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.dataGridViewAll);
            this.Name = "FormAddOrder";
            this.Text = "Nowe zamówienie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.Label labelNIP;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}