namespace Testosteron
{
    partial class FormMainPanelWorker
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
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonCheckState = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddClient.Location = new System.Drawing.Point(12, 12);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(258, 55);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Dodaj Klienta";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOrder.Location = new System.Drawing.Point(12, 83);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(258, 55);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Dodaj zamówienie";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonCheckState
            // 
            this.buttonCheckState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckState.Location = new System.Drawing.Point(12, 155);
            this.buttonCheckState.Name = "buttonCheckState";
            this.buttonCheckState.Size = new System.Drawing.Size(258, 55);
            this.buttonCheckState.TabIndex = 4;
            this.buttonCheckState.Text = "Sprawdź stan";
            this.buttonCheckState.UseVisualStyleBackColor = true;
            this.buttonCheckState.Click += new System.EventHandler(this.buttonCheckState_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(12, 228);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(257, 56);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormMainPanelWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 296);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonCheckState);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonAddClient);
            this.Name = "FormMainPanelWorker";
            this.Text = "Panel Pracownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonCheckState;
        private System.Windows.Forms.Button buttonLogout;
    }
}