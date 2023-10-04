namespace ComboBox_kontrola
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
            this.izbornik = new System.Windows.Forms.ComboBox();
            this.ispis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // izbornik
            // 
            this.izbornik.FormattingEnabled = true;
            this.izbornik.Items.AddRange(new object[] {
            "IT menagment",
            "aplikativno programiranje",
            "internet programiranje",
            "informacioni sistemi"});
            this.izbornik.Location = new System.Drawing.Point(79, 34);
            this.izbornik.Name = "izbornik";
            this.izbornik.Size = new System.Drawing.Size(584, 21);
            this.izbornik.TabIndex = 0;
            this.izbornik.SelectedIndexChanged += new System.EventHandler(this.izbornik_SelectedIndexChanged);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(93, 129);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(557, 20);
            this.ispis.TabIndex = 1;
            this.ispis.TextChanged += new System.EventHandler(this.ispis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.izbornik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox izbornik;
        private System.Windows.Forms.TextBox ispis;
    }
}

