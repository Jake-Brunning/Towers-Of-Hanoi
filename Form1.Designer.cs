namespace Forms_test_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.AmountOfRingsLabel = new System.Windows.Forms.Label();
            this.AmountOfRingsSelector = new System.Windows.Forms.NumericUpDown();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PauseTimeInfo = new System.Windows.Forms.Label();
            this.PauseTimeGet = new System.Windows.Forms.TextBox();
            this.NoMovesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfRingsSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.Lime;
            this.Start.Location = new System.Drawing.Point(980, 394);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(178, 55);
            this.Start.TabIndex = 0;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AmountOfRingsLabel
            // 
            this.AmountOfRingsLabel.AutoSize = true;
            this.AmountOfRingsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountOfRingsLabel.ForeColor = System.Drawing.Color.Lime;
            this.AmountOfRingsLabel.Location = new System.Drawing.Point(12, 9);
            this.AmountOfRingsLabel.Name = "AmountOfRingsLabel";
            this.AmountOfRingsLabel.Size = new System.Drawing.Size(394, 40);
            this.AmountOfRingsLabel.TabIndex = 1;
            this.AmountOfRingsLabel.Text = "ENTER AMOUNT OF RINGS:";
            // 
            // AmountOfRingsSelector
            // 
            this.AmountOfRingsSelector.BackColor = System.Drawing.Color.Black;
            this.AmountOfRingsSelector.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountOfRingsSelector.ForeColor = System.Drawing.Color.Lime;
            this.AmountOfRingsSelector.Location = new System.Drawing.Point(21, 52);
            this.AmountOfRingsSelector.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.AmountOfRingsSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountOfRingsSelector.Name = "AmountOfRingsSelector";
            this.AmountOfRingsSelector.Size = new System.Drawing.Size(120, 39);
            this.AmountOfRingsSelector.TabIndex = 2;
            this.AmountOfRingsSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.TimeLabel.Location = new System.Drawing.Point(483, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeLabel.Size = new System.Drawing.Size(349, 40);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "ENTER PAUSE TIME(ms):";
            // 
            // PauseTimeInfo
            // 
            this.PauseTimeInfo.AutoSize = true;
            this.PauseTimeInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PauseTimeInfo.ForeColor = System.Drawing.Color.Lime;
            this.PauseTimeInfo.Location = new System.Drawing.Point(483, 52);
            this.PauseTimeInfo.Name = "PauseTimeInfo";
            this.PauseTimeInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PauseTimeInfo.Size = new System.Drawing.Size(466, 25);
            this.PauseTimeInfo.TabIndex = 5;
            this.PauseTimeInfo.Text = "Leave blank for computer to custom set pause time";
            // 
            // PauseTimeGet
            // 
            this.PauseTimeGet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PauseTimeGet.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PauseTimeGet.ForeColor = System.Drawing.Color.Lime;
            this.PauseTimeGet.Location = new System.Drawing.Point(483, 80);
            this.PauseTimeGet.Name = "PauseTimeGet";
            this.PauseTimeGet.Size = new System.Drawing.Size(112, 35);
            this.PauseTimeGet.TabIndex = 6;
            // 
            // NoMovesLabel
            // 
            this.NoMovesLabel.AutoSize = true;
            this.NoMovesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoMovesLabel.ForeColor = System.Drawing.Color.Lime;
            this.NoMovesLabel.Location = new System.Drawing.Point(12, 563);
            this.NoMovesLabel.Name = "NoMovesLabel";
            this.NoMovesLabel.Size = new System.Drawing.Size(243, 45);
            this.NoMovesLabel.TabIndex = 7;
            this.NoMovesLabel.Text = "NoMovesLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1464, 617);
            this.Controls.Add(this.NoMovesLabel);
            this.Controls.Add(this.PauseTimeGet);
            this.Controls.Add(this.PauseTimeInfo);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.AmountOfRingsSelector);
            this.Controls.Add(this.AmountOfRingsLabel);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfRingsSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start;
        private Label AmountOfRingsLabel;
        private NumericUpDown AmountOfRingsSelector;
        private Label TimeLabel;
        private Label PauseTimeInfo;
        private TextBox PauseTimeGet;
        private Label NoMovesLabel;
    }
}