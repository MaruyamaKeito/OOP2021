
namespace RssReader
{
    partial class Form2
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
            this.btBack = new System.Windows.Forms.Button();
            this.btAdvance = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(25, 22);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btAdvance
            // 
            this.btAdvance.Location = new System.Drawing.Point(106, 22);
            this.btAdvance.Name = "btAdvance";
            this.btAdvance.Size = new System.Drawing.Size(75, 23);
            this.btAdvance.TabIndex = 0;
            this.btAdvance.Text = "進む";
            this.btAdvance.UseVisualStyleBackColor = true;
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(25, 52);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(751, 386);
            this.wbBrowser.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btAdvance);
            this.Controls.Add(this.btBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btAdvance;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}