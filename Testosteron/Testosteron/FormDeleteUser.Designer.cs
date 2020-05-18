namespace Testosteron
{
    partial class FormDeleteUser
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 430);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(307, 38);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToAddRows = false;
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.AllowUserToOrderColumns = true;
            this.dataGridViewAll.AllowUserToResizeColumns = false;
            this.dataGridViewAll.AllowUserToResizeRows = false;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewAll.MultiSelect = false;
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.Size = new System.Drawing.Size(309, 398);
            this.dataGridViewAll.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(343, 43);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(401, 29);
            this.textBoxLogin.TabIndex = 23;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(338, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 25);
            this.labelLogin.TabIndex = 22;
            this.labelLogin.Text = "Login";
            // 
            // buttonDelete
            // 
            this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(343, 89);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(307, 38);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 484);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewAll);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.Load += new System.EventHandler(this.FormDeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonDelete;
    }
}