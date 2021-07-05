
namespace Exercise4 {
    partial class Form1 {
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
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputStrData
            // 
            this.inputStrData.Location = new System.Drawing.Point(13, 13);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(514, 19);
            this.inputStrData.TabIndex = 0;
            // 
            // Button5_4
            // 
            this.Button5_4.Location = new System.Drawing.Point(560, 8);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(194, 23);
            this.Button5_4.TabIndex = 1;
            this.Button5_4.Text = "出力";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // outputStrData
            // 
            this.outputStrData.Location = new System.Drawing.Point(12, 38);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(514, 75);
            this.outputStrData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.inputStrData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.Button Button5_4;
        private System.Windows.Forms.TextBox outputStrData;
    }
}

