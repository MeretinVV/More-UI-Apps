namespace Color_Palette
{
    partial class MainWindow
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
            System.Windows.Forms.Label redLbl;
            System.Windows.Forms.Label greenLbl;
            System.Windows.Forms.Label blueLbl;
            System.Windows.Forms.Label minValueRed;
            System.Windows.Forms.Label minValueGreen;
            System.Windows.Forms.Label minValueBlue;
            System.Windows.Forms.Label maxValueRed;
            System.Windows.Forms.Label maxValueGreen;
            System.Windows.Forms.Label maxValueBlue;
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.hintLbl = new System.Windows.Forms.Label();
            this.palette = new System.Windows.Forms.Panel();
            redLbl = new System.Windows.Forms.Label();
            greenLbl = new System.Windows.Forms.Label();
            blueLbl = new System.Windows.Forms.Label();
            minValueRed = new System.Windows.Forms.Label();
            minValueGreen = new System.Windows.Forms.Label();
            minValueBlue = new System.Windows.Forms.Label();
            maxValueRed = new System.Windows.Forms.Label();
            maxValueGreen = new System.Windows.Forms.Label();
            maxValueBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // redLbl
            // 
            redLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            redLbl.AutoSize = true;
            redLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            redLbl.ForeColor = System.Drawing.Color.Red;
            redLbl.Location = new System.Drawing.Point(199, 31);
            redLbl.Name = "redLbl";
            redLbl.Size = new System.Drawing.Size(43, 20);
            redLbl.TabIndex = 5;
            redLbl.Text = "Red:";
            // 
            // greenLbl
            // 
            greenLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            greenLbl.AutoSize = true;
            greenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            greenLbl.ForeColor = System.Drawing.Color.Green;
            greenLbl.Location = new System.Drawing.Point(199, 85);
            greenLbl.Name = "greenLbl";
            greenLbl.Size = new System.Drawing.Size(58, 20);
            greenLbl.TabIndex = 6;
            greenLbl.Text = "Green:";
            // 
            // blueLbl
            // 
            blueLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            blueLbl.AutoSize = true;
            blueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            blueLbl.ForeColor = System.Drawing.Color.Blue;
            blueLbl.Location = new System.Drawing.Point(199, 136);
            blueLbl.Name = "blueLbl";
            blueLbl.Size = new System.Drawing.Size(45, 20);
            blueLbl.TabIndex = 7;
            blueLbl.Text = "Blue:";
            // 
            // minValueRed
            // 
            minValueRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueRed.AutoSize = true;
            minValueRed.BackColor = System.Drawing.SystemColors.Control;
            minValueRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueRed.Location = new System.Drawing.Point(268, 56);
            minValueRed.Name = "minValueRed";
            minValueRed.Size = new System.Drawing.Size(16, 17);
            minValueRed.TabIndex = 8;
            minValueRed.Text = "0";
            // 
            // minValueGreen
            // 
            minValueGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueGreen.AutoSize = true;
            minValueGreen.BackColor = System.Drawing.SystemColors.Control;
            minValueGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueGreen.Location = new System.Drawing.Point(268, 113);
            minValueGreen.Name = "minValueGreen";
            minValueGreen.Size = new System.Drawing.Size(16, 17);
            minValueGreen.TabIndex = 9;
            minValueGreen.Text = "0";
            // 
            // minValueBlue
            // 
            minValueBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueBlue.AutoSize = true;
            minValueBlue.BackColor = System.Drawing.SystemColors.Control;
            minValueBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueBlue.Location = new System.Drawing.Point(268, 161);
            minValueBlue.Name = "minValueBlue";
            minValueBlue.Size = new System.Drawing.Size(16, 17);
            minValueBlue.TabIndex = 10;
            minValueBlue.Text = "0";
            // 
            // maxValueRed
            // 
            maxValueRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueRed.AutoSize = true;
            maxValueRed.BackColor = System.Drawing.SystemColors.Control;
            maxValueRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueRed.Location = new System.Drawing.Point(431, 56);
            maxValueRed.Name = "maxValueRed";
            maxValueRed.Size = new System.Drawing.Size(32, 17);
            maxValueRed.TabIndex = 11;
            maxValueRed.Text = "255";
            // 
            // maxValueGreen
            // 
            maxValueGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueGreen.AutoSize = true;
            maxValueGreen.BackColor = System.Drawing.SystemColors.Control;
            maxValueGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueGreen.Location = new System.Drawing.Point(431, 113);
            maxValueGreen.Name = "maxValueGreen";
            maxValueGreen.Size = new System.Drawing.Size(32, 17);
            maxValueGreen.TabIndex = 12;
            maxValueGreen.Text = "255";
            // 
            // maxValueBlue
            // 
            maxValueBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueBlue.AutoSize = true;
            maxValueBlue.BackColor = System.Drawing.SystemColors.Control;
            maxValueBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueBlue.Location = new System.Drawing.Point(431, 161);
            maxValueBlue.Name = "maxValueBlue";
            maxValueBlue.Size = new System.Drawing.Size(32, 17);
            maxValueBlue.TabIndex = 13;
            maxValueBlue.Text = "255";
            // 
            // redTrack
            // 
            this.redTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redTrack.BackColor = System.Drawing.SystemColors.Control;
            this.redTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redTrack.Location = new System.Drawing.Point(263, 31);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(200, 45);
            this.redTrack.TabIndex = 2;
            this.redTrack.TickFrequency = 25;
            this.redTrack.Value = 125;
            this.redTrack.Scroll += new System.EventHandler(this.colorTrack_Scroll);
            // 
            // greenTrack
            // 
            this.greenTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenTrack.BackColor = System.Drawing.SystemColors.Control;
            this.greenTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenTrack.Location = new System.Drawing.Point(263, 85);
            this.greenTrack.Maximum = 255;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(200, 45);
            this.greenTrack.TabIndex = 3;
            this.greenTrack.TickFrequency = 25;
            this.greenTrack.Value = 125;
            this.greenTrack.Scroll += new System.EventHandler(this.colorTrack_Scroll);
            // 
            // blueTrack
            // 
            this.blueTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueTrack.BackColor = System.Drawing.SystemColors.Control;
            this.blueTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueTrack.Location = new System.Drawing.Point(263, 136);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(200, 45);
            this.blueTrack.TabIndex = 4;
            this.blueTrack.TickFrequency = 25;
            this.blueTrack.Value = 125;
            this.blueTrack.Scroll += new System.EventHandler(this.colorTrack_Scroll);
            // 
            // hintLbl
            // 
            this.hintLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hintLbl.AutoSize = true;
            this.hintLbl.BackColor = System.Drawing.Color.Wheat;
            this.hintLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintLbl.Location = new System.Drawing.Point(26, 8);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(85, 20);
            this.hintLbl.TabIndex = 14;
            this.hintLbl.Text = "Color code";
            this.hintLbl.Visible = false;
            // 
            // palette
            // 
            this.palette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.palette.Location = new System.Drawing.Point(28, 31);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(155, 150);
            this.palette.TabIndex = 0;
            this.palette.BackColorChanged += new System.EventHandler(this.palette_BackColorChanged);
            this.palette.MouseLeave += new System.EventHandler(this.palette_MouseLeave);
            this.palette.MouseHover += new System.EventHandler(this.palette_MouseHover);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.hintLbl);
            this.Controls.Add(maxValueBlue);
            this.Controls.Add(maxValueGreen);
            this.Controls.Add(maxValueRed);
            this.Controls.Add(minValueBlue);
            this.Controls.Add(minValueGreen);
            this.Controls.Add(minValueRed);
            this.Controls.Add(blueLbl);
            this.Controls.Add(greenLbl);
            this.Controls.Add(redLbl);
            this.Controls.Add(this.blueTrack);
            this.Controls.Add(this.greenTrack);
            this.Controls.Add(this.redTrack);
            this.Controls.Add(this.palette);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainWindow";
            this.Text = "Color Pallete";
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.Panel palette;
    }
}

