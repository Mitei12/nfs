namespace nfs.View.Settings
{
    partial class dzSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dzSettings));
            this.btnVideoSettings = new System.Windows.Forms.Button();
            this.btnSettExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideoSettings
            // 
            this.btnVideoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoSettings.Location = new System.Drawing.Point(12, 160);
            this.btnVideoSettings.Name = "btnVideoSettings";
            this.btnVideoSettings.Size = new System.Drawing.Size(143, 44);
            this.btnVideoSettings.TabIndex = 1;
            this.btnVideoSettings.Text = "Video Settings";
            this.btnVideoSettings.UseVisualStyleBackColor = true;
            this.btnVideoSettings.Click += new System.EventHandler(this.btnVideoSettings_Click);
            // 
            // btnSettExit
            // 
            this.btnSettExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettExit.Location = new System.Drawing.Point(781, 467);
            this.btnSettExit.Name = "btnSettExit";
            this.btnSettExit.Size = new System.Drawing.Size(100, 34);
            this.btnSettExit.TabIndex = 3;
            this.btnSettExit.Text = "Exit";
            this.btnSettExit.UseVisualStyleBackColor = true;
            this.btnSettExit.Click += new System.EventHandler(this.btnSettExit_Click);
            // 
            // dzSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 513);
            this.Controls.Add(this.btnSettExit);
            this.Controls.Add(this.btnVideoSettings);
            this.Name = "dzSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVideoSettings;
        private System.Windows.Forms.Button btnSettExit;
    }
}