namespace Minecraft
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.rTBHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBHelp
            // 
            this.rTBHelp.Location = new System.Drawing.Point(53, 36);
            this.rTBHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTBHelp.Name = "rTBHelp";
            this.rTBHelp.ReadOnly = true;
            this.rTBHelp.Size = new System.Drawing.Size(951, 470);
            this.rTBHelp.TabIndex = 0;
            this.rTBHelp.Text = resources.GetString("rTBHelp.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.rTBHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBHelp;
    }
}