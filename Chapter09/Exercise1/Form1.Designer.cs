
namespace Exercise1 {
    partial class btOpen {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.ofdOpenfile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.btReadAllLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenfile
            // 
            this.ofdOpenfile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(13, 73);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(699, 377);
            this.tbOutput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "開く";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(146, 47);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(129, 19);
            this.tbKeyWord.TabIndex = 2;
            // 
            // btReadAllLines
            // 
            this.btReadAllLines.Location = new System.Drawing.Point(281, 13);
            this.btReadAllLines.Name = "btReadAllLines";
            this.btReadAllLines.Size = new System.Drawing.Size(126, 54);
            this.btReadAllLines.TabIndex = 1;
            this.btReadAllLines.Text = "ReadAllLines";
            this.btReadAllLines.UseVisualStyleBackColor = true;
            this.btReadAllLines.Click += new System.EventHandler(this.btReadAllLines_Click);
            // 
            // btOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 462);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btReadAllLines);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOutput);
            this.Name = "btOpen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenfile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Button btReadAllLines;
    }
}

