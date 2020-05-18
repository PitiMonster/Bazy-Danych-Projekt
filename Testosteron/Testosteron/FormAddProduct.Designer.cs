namespace Testosteron
{
    partial class FormAddProduct
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
            this.buttonAddWPC = new System.Windows.Forms.Button();
            this.buttonAddSuplement = new System.Windows.Forms.Button();
            this.buttonAddAccessory = new System.Windows.Forms.Button();
            this.buttonAddOther = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddWPC
            // 
            this.buttonAddWPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddWPC.Location = new System.Drawing.Point(12, 12);
            this.buttonAddWPC.Name = "buttonAddWPC";
            this.buttonAddWPC.Size = new System.Drawing.Size(258, 55);
            this.buttonAddWPC.TabIndex = 10;
            this.buttonAddWPC.Text = "Dodaj białko";
            this.buttonAddWPC.UseVisualStyleBackColor = true;
            this.buttonAddWPC.Click += new System.EventHandler(this.buttonAddWPC_Click);
            // 
            // buttonAddSuplement
            // 
            this.buttonAddSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddSuplement.Location = new System.Drawing.Point(12, 82);
            this.buttonAddSuplement.Name = "buttonAddSuplement";
            this.buttonAddSuplement.Size = new System.Drawing.Size(258, 55);
            this.buttonAddSuplement.TabIndex = 11;
            this.buttonAddSuplement.Text = "Dodaj suplement";
            this.buttonAddSuplement.UseVisualStyleBackColor = true;
            this.buttonAddSuplement.Click += new System.EventHandler(this.buttonAddSuplement_Click);
            // 
            // buttonAddAccessory
            // 
            this.buttonAddAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddAccessory.Location = new System.Drawing.Point(12, 231);
            this.buttonAddAccessory.Name = "buttonAddAccessory";
            this.buttonAddAccessory.Size = new System.Drawing.Size(258, 55);
            this.buttonAddAccessory.TabIndex = 12;
            this.buttonAddAccessory.Text = "Dodaj akcesoria";
            this.buttonAddAccessory.UseVisualStyleBackColor = true;
            this.buttonAddAccessory.Click += new System.EventHandler(this.buttonAddAccessory_Click);
            // 
            // buttonAddOther
            // 
            this.buttonAddOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOther.Location = new System.Drawing.Point(12, 158);
            this.buttonAddOther.Name = "buttonAddOther";
            this.buttonAddOther.Size = new System.Drawing.Size(258, 55);
            this.buttonAddOther.TabIndex = 13;
            this.buttonAddOther.Text = "Dodaj odżywkę";
            this.buttonAddOther.UseVisualStyleBackColor = true;
            this.buttonAddOther.Click += new System.EventHandler(this.buttonAddOther_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 318);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(212, 55);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 385);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOther);
            this.Controls.Add(this.buttonAddAccessory);
            this.Controls.Add(this.buttonAddSuplement);
            this.Controls.Add(this.buttonAddWPC);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddWPC;
        private System.Windows.Forms.Button buttonAddSuplement;
        private System.Windows.Forms.Button buttonAddAccessory;
        private System.Windows.Forms.Button buttonAddOther;
        private System.Windows.Forms.Button buttonCancel;
    }
}