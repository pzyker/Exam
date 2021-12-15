
namespace WindowsFormsApp1
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
            this.villiKontrolli1 = new WindowsFormsControlLibrary1.VilliKontrolli();
            this.SuspendLayout();
            // 
            // villiKontrolli1
            // 
            this.villiKontrolli1.Location = new System.Drawing.Point(25, 22);
            this.villiKontrolli1.Name = "villiKontrolli1";
            this.villiKontrolli1.Rauhoita = false;
            this.villiKontrolli1.Size = new System.Drawing.Size(154, 196);
            this.villiKontrolli1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 348);
            this.Controls.Add(this.villiKontrolli1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.VilliKontrolli villiKontrolli1;
    }
}

