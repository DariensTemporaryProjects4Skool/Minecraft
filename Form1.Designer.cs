namespace Minecraft
{
    partial class Form1
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
            this.LblR1Label = new System.Windows.Forms.Label();
            this.LblR2Label = new System.Windows.Forms.Label();
            this.LblR3Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblR1 = new System.Windows.Forms.Label();
            this.LblR2 = new System.Windows.Forms.Label();
            this.LblR3 = new System.Windows.Forms.Label();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.DancingMan = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblR1Label
            // 
            this.LblR1Label.AutoSize = true;
            this.LblR1Label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR1Label.Location = new System.Drawing.Point(59, 30);
            this.LblR1Label.Name = "LblR1Label";
            this.LblR1Label.Size = new System.Drawing.Size(248, 36);
            this.LblR1Label.TabIndex = 0;
            this.LblR1Label.Text = "Register 1 Value:";
            // 
            // LblR2Label
            // 
            this.LblR2Label.AutoSize = true;
            this.LblR2Label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR2Label.Location = new System.Drawing.Point(59, 74);
            this.LblR2Label.Name = "LblR2Label";
            this.LblR2Label.Size = new System.Drawing.Size(248, 36);
            this.LblR2Label.TabIndex = 1;
            this.LblR2Label.Text = "Register 2 Value:";
            // 
            // LblR3Label
            // 
            this.LblR3Label.AutoSize = true;
            this.LblR3Label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR3Label.Location = new System.Drawing.Point(59, 119);
            this.LblR3Label.Name = "LblR3Label";
            this.LblR3Label.Size = new System.Drawing.Size(248, 36);
            this.LblR3Label.TabIndex = 2;
            this.LblR3Label.Text = "Register 3 Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 3;
            // 
            // LblR1
            // 
            this.LblR1.AutoSize = true;
            this.LblR1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR1.Location = new System.Drawing.Point(313, 30);
            this.LblR1.Name = "LblR1";
            this.LblR1.Size = new System.Drawing.Size(32, 36);
            this.LblR1.TabIndex = 4;
            this.LblR1.Text = "0";
            // 
            // LblR2
            // 
            this.LblR2.AutoSize = true;
            this.LblR2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR2.Location = new System.Drawing.Point(313, 74);
            this.LblR2.Name = "LblR2";
            this.LblR2.Size = new System.Drawing.Size(32, 36);
            this.LblR2.TabIndex = 5;
            this.LblR2.Text = "0";
            // 
            // LblR3
            // 
            this.LblR3.AutoSize = true;
            this.LblR3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LblR3.Location = new System.Drawing.Point(313, 119);
            this.LblR3.Name = "LblR3";
            this.LblR3.Size = new System.Drawing.Size(32, 36);
            this.LblR3.TabIndex = 6;
            this.LblR3.Text = "0";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(65, 319);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(539, 57);
            this.BtnRun.TabIndex = 7;
            this.BtnRun.Text = "run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(65, 382);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(539, 57);
            this.BtnTest.TabIndex = 8;
            this.BtnTest.Text = "LD #5 R1 LD #30 R2 ADD R1 R2 R3";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Input";
            // 
            // picturebox1
            // 
            this.picturebox1.BackColor = System.Drawing.Color.IndianRed;
            this.picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox1.Location = new System.Drawing.Point(423, 74);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(100, 81);
            this.picturebox1.TabIndex = 15;
            this.picturebox1.TabStop = false;
            // 
            // DancingMan
            // 
            this.DancingMan.AutoSize = true;
            this.DancingMan.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.DancingMan.Location = new System.Drawing.Point(443, 97);
            this.DancingMan.Name = "DancingMan";
            this.DancingMan.Size = new System.Drawing.Size(33, 28);
            this.DancingMan.TabIndex = 16;
            this.DancingMan.Text = "...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(65, 200);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 113);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Location = new System.Drawing.Point(65, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "danger zone";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnReset.ForeColor = System.Drawing.Color.Red;
            this.BtnReset.Location = new System.Drawing.Point(160, 34);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(219, 37);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DancingMan);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.LblR3);
            this.Controls.Add(this.LblR2);
            this.Controls.Add(this.LblR1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblR3Label);
            this.Controls.Add(this.LblR2Label);
            this.Controls.Add(this.LblR1Label);
            this.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblR1Label;
        private System.Windows.Forms.Label LblR2Label;
        private System.Windows.Forms.Label LblR3Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblR1;
        private System.Windows.Forms.Label LblR2;
        private System.Windows.Forms.Label LblR3;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Label DancingMan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset;
    }
}

