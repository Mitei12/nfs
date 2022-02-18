namespace nfs
{
    partial class FormMotivation
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
            this.lblMotivaciq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMotivaciq
            // 
            this.lblMotivaciq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivaciq.Location = new System.Drawing.Point(2, 19);
            this.lblMotivaciq.Name = "lblMotivaciq";
            this.lblMotivaciq.Size = new System.Drawing.Size(452, 52);
            this.lblMotivaciq.TabIndex = 0;
            this.lblMotivaciq.Text = "Koi me motivira - motivaciqta mi za tova prilojenie e bill gates i Starite pesni " +
    "na krisko";
            // 
            // FormMotivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 382);
            this.Controls.Add(this.lblMotivaciq);
            this.Name = "FormMotivation";
            this.Text = "Motivation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMotivaciq;
    }
}