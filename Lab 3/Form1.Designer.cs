namespace Lab_3
{
    partial class lab3
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
            this.SuspendLayout();
            // 
            // lab3
            // 
            this.ClientSize = new System.Drawing.Size(378, 344);
            this.Name = "lab3";
            this.Text = "Lab 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label radiusOfSphereLbl;
        private System.Windows.Forms.TextBox radiusOfSphereTxtBox;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label diameterOutputLbl;
        private System.Windows.Forms.Label surfaceAreaOutputLbl;
        private System.Windows.Forms.Label volumeOutputLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.PictureBox ballAndSphere1;
        private System.Windows.Forms.PictureBox ballAndSphere2;
    }
}

