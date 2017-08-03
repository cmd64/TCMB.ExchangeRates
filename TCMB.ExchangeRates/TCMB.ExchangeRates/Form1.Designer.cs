namespace TCMB.ExchangeRates
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxLanguages = new System.Windows.Forms.ComboBox();
            this.lstViewCurrency = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Languages :";
            // 
            // cmbBoxLanguages
            // 
            this.cmbBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLanguages.FormattingEnabled = true;
            this.cmbBoxLanguages.Location = new System.Drawing.Point(561, 12);
            this.cmbBoxLanguages.Name = "cmbBoxLanguages";
            this.cmbBoxLanguages.Size = new System.Drawing.Size(107, 21);
            this.cmbBoxLanguages.TabIndex = 3;
            this.cmbBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLanguages_SelectedIndexChanged);
            // 
            // lstViewCurrency
            // 
            this.lstViewCurrency.FullRowSelect = true;
            this.lstViewCurrency.GridLines = true;
            this.lstViewCurrency.Location = new System.Drawing.Point(8, 39);
            this.lstViewCurrency.MultiSelect = false;
            this.lstViewCurrency.Name = "lstViewCurrency";
            this.lstViewCurrency.Scrollable = false;
            this.lstViewCurrency.Size = new System.Drawing.Size(660, 372);
            this.lstViewCurrency.TabIndex = 6;
            this.lstViewCurrency.UseCompatibleStateImageBehavior = false;
            this.lstViewCurrency.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 423);
            this.Controls.Add(this.lstViewCurrency);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxLanguages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxLanguages;
        private System.Windows.Forms.ListView lstViewCurrency;
    }
}

