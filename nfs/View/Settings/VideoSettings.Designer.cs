namespace nfs.View.Settings
{
    partial class VideoSettings
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVideoExit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnGoToWelcomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cool button123";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVideoExit
            // 
            this.btnVideoExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoExit.Location = new System.Drawing.Point(1124, 534);
            this.btnVideoExit.Name = "btnVideoExit";
            this.btnVideoExit.Size = new System.Drawing.Size(74, 26);
            this.btnVideoExit.TabIndex = 1;
            this.btnVideoExit.Text = "Exit";
            this.btnVideoExit.UseVisualStyleBackColor = true;
            this.btnVideoExit.Click += new System.EventHandler(this.btnVideoExit_Click_1);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 149);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(841, 421);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click here to see something cool";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(997, 12);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(201, 61);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Go to history";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnGoToWelcomePage
            // 
            this.btnGoToWelcomePage.Location = new System.Drawing.Point(997, 79);
            this.btnGoToWelcomePage.Name = "btnGoToWelcomePage";
            this.btnGoToWelcomePage.Size = new System.Drawing.Size(201, 71);
            this.btnGoToWelcomePage.TabIndex = 5;
            this.btnGoToWelcomePage.Text = "Go to Welcome page ";
            this.btnGoToWelcomePage.UseVisualStyleBackColor = true;
            this.btnGoToWelcomePage.Click += new System.EventHandler(this.btnGoToWelcomePage_Click);
            // 
            // VideoSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 572);
            this.Controls.Add(this.btnGoToWelcomePage);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnVideoExit);
            this.Controls.Add(this.button1);
            this.Name = "VideoSettings";
            this.Text = "VideoSettings";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVideoExit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnGoToWelcomePage;
    }
}