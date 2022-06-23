namespace MyMDIApp
{
    partial class frmChildForm
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
            this.mnuOpen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mnuOpen
            // 
            this.mnuOpen.AutoSize = true;
            this.mnuOpen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuOpen.Location = new System.Drawing.Point(246, 129);
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.mnuOpen.Size = new System.Drawing.Size(316, 32);
            this.mnuOpen.TabIndex = 0;
            this.mnuOpen.Text = "This is Child Form";
            this.mnuOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // frmChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuOpen);
            this.Name = "frmChildForm";
            this.Text = "frmChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mnuOpen;
    }
}