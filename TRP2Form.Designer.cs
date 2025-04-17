namespace Minecraft
{
    partial class TRP2Form
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
            this.lblTrap2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrap2
            // 
            this.lblTrap2.AutoSize = true;
            this.lblTrap2.Location = new System.Drawing.Point(41, 71);
            this.lblTrap2.Name = "lblTrap2";
            this.lblTrap2.Size = new System.Drawing.Size(224, 16);
            this.lblTrap2.TabIndex = 22;
            this.lblTrap2.Text = "Input value for Trap 2 command here";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(92, 90);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 176);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 24);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TRP2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 271);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTrap2);
            this.Controls.Add(this.txtValue);
            this.Name = "TRP2Form";
            this.Text = "TRP2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrap2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSubmit;
    }
}