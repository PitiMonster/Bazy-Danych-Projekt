namespace Testosteron
{
    partial class FormMainPanelManager
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
            this.buttonCheckState = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddSupply = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckState
            // 
            this.buttonCheckState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckState.Location = new System.Drawing.Point(12, 167);
            this.buttonCheckState.Name = "buttonCheckState";
            this.buttonCheckState.Size = new System.Drawing.Size(258, 55);
            this.buttonCheckState.TabIndex = 8;
            this.buttonCheckState.Text = "Sprawdź stan";
            this.buttonCheckState.UseVisualStyleBackColor = true;
            this.buttonCheckState.Click += new System.EventHandler(this.buttonCheckState_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOrder.Location = new System.Drawing.Point(12, 89);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(258, 55);
            this.buttonAddOrder.TabIndex = 6;
            this.buttonAddOrder.Text = "Dodaj zamówienie";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddClient.Location = new System.Drawing.Point(12, 12);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(258, 55);
            this.buttonAddClient.TabIndex = 5;
            this.buttonAddClient.Text = "Dodaj Klienta";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddSupplier.Location = new System.Drawing.Point(290, 12);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(258, 55);
            this.buttonAddSupplier.TabIndex = 9;
            this.buttonAddSupplier.Text = "Dodaj dostawcę";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(290, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddSupply
            // 
            this.buttonAddSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddSupply.Location = new System.Drawing.Point(290, 167);
            this.buttonAddSupply.Name = "buttonAddSupply";
            this.buttonAddSupply.Size = new System.Drawing.Size(258, 55);
            this.buttonAddSupply.TabIndex = 11;
            this.buttonAddSupply.Text = "Dodaj dostawę";
            this.buttonAddSupply.UseVisualStyleBackColor = true;
            this.buttonAddSupply.Click += new System.EventHandler(this.buttonAddSupply_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(13, 241);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(257, 56);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormMainPanelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 309);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAddSupply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.buttonCheckState);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonAddClient);
            this.Name = "FormMainPanelManager";
            this.Text = "FormMainPanelManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckState;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddSupply;
        private System.Windows.Forms.Button buttonLogout;
    }
}