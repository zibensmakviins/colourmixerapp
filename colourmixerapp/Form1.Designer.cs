namespace colourmixerapp
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
            this.Redbulb = new System.Windows.Forms.PictureBox();
            this.Greenbulb = new System.Windows.Forms.PictureBox();
            this.Bluebulb = new System.Windows.Forms.PictureBox();
            this.SetColorsButton = new System.Windows.Forms.Button();
            this.GreenValue = new System.Windows.Forms.TextBox();
            this.BlueValue = new System.Windows.Forms.TextBox();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Redbulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greenbulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebulb)).BeginInit();
            this.SuspendLayout();
            // 
            // Redbulb
            // 
            this.Redbulb.Location = new System.Drawing.Point(73, 74);
            this.Redbulb.Name = "Redbulb";
            this.Redbulb.Size = new System.Drawing.Size(140, 140);
            this.Redbulb.TabIndex = 0;
            this.Redbulb.TabStop = false;
            this.Redbulb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Greenbulb
            // 
            this.Greenbulb.Location = new System.Drawing.Point(230, 74);
            this.Greenbulb.Name = "Greenbulb";
            this.Greenbulb.Size = new System.Drawing.Size(140, 140);
            this.Greenbulb.TabIndex = 1;
            this.Greenbulb.TabStop = false;
            // 
            // Bluebulb
            // 
            this.Bluebulb.Location = new System.Drawing.Point(391, 74);
            this.Bluebulb.Name = "Bluebulb";
            this.Bluebulb.Size = new System.Drawing.Size(140, 140);
            this.Bluebulb.TabIndex = 2;
            this.Bluebulb.TabStop = false;
            // 
            // SetColorsButton
            // 
            this.SetColorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetColorsButton.Location = new System.Drawing.Point(73, 230);
            this.SetColorsButton.Name = "SetColorsButton";
            this.SetColorsButton.Size = new System.Drawing.Size(458, 50);
            this.SetColorsButton.TabIndex = 3;
            this.SetColorsButton.Text = "Set Colours";
            this.SetColorsButton.UseVisualStyleBackColor = true;
            this.SetColorsButton.Click += new System.EventHandler(this.SetColorsButton_Click);
            // 
            // GreenValue
            // 
            this.GreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.GreenValue.Location = new System.Drawing.Point(230, 42);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(140, 26);
            this.GreenValue.TabIndex = 4;
            this.GreenValue.Text = "255";
            // 
            // BlueValue
            // 
            this.BlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BlueValue.Location = new System.Drawing.Point(391, 42);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(140, 26);
            this.BlueValue.TabIndex = 5;
            this.BlueValue.Text = "255";
            // 
            // RedValue
            // 
            this.RedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RedValue.Location = new System.Drawing.Point(73, 42);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(140, 26);
            this.RedValue.TabIndex = 6;
            this.RedValue.Text = "255";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(260, 298);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset colour";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 449);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.SetColorsButton);
            this.Controls.Add(this.Bluebulb);
            this.Controls.Add(this.Greenbulb);
            this.Controls.Add(this.Redbulb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Redbulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greenbulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Redbulb;
        private System.Windows.Forms.PictureBox Greenbulb;
        private System.Windows.Forms.PictureBox Bluebulb;
        private System.Windows.Forms.Button SetColorsButton;
        private System.Windows.Forms.TextBox GreenValue;
        private System.Windows.Forms.TextBox BlueValue;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.Button Reset;
    }
}

