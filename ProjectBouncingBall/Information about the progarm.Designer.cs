namespace ProjectBouncingBall
{
    partial class Information_about_the_progarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information_about_the_progarm));
            this.SuspendLayout();
            // 
            // Information_about_the_progarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 782);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(852, 838);
            this.Name = "Information_about_the_progarm";
            this.Text = "Information about the progarm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Information_about_the_progarm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Information_about_the_progarm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}