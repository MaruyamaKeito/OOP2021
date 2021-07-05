
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.TextBox5_3_4 = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.TextBox5_3_5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Location = new System.Drawing.Point(39, 123);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(112, 31);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "空白をカウント";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(79, 70);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(415, 31);
            this.inputStrText.TabIndex = 1;
            this.inputStrText.Text = "\"Jackdaws love my big sphinx of quartz\"";
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Location = new System.Drawing.Point(39, 207);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(112, 31);
            this.Button5_3_2.TabIndex = 2;
            this.Button5_3_2.Text = "big → small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(202, 207);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(373, 34);
            this.TextBoxWordChange.TabIndex = 3;
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(202, 123);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(304, 34);
            this.TextBoxSpaceCount.TabIndex = 3;
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Location = new System.Drawing.Point(39, 288);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(112, 31);
            this.Button5_3_3.TabIndex = 2;
            this.Button5_3_3.Text = "単語";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount.Location = new System.Drawing.Point(202, 285);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(373, 34);
            this.TextBoxWordCount.TabIndex = 3;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Location = new System.Drawing.Point(39, 351);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(112, 31);
            this.Button5_3_4.TabIndex = 2;
            this.Button5_3_4.Text = "4文字以下を列挙";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // TextBox5_3_4
            // 
            this.TextBox5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox5_3_4.Location = new System.Drawing.Point(202, 348);
            this.TextBox5_3_4.Name = "TextBox5_3_4";
            this.TextBox5_3_4.Size = new System.Drawing.Size(373, 34);
            this.TextBox5_3_4.TabIndex = 3;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Location = new System.Drawing.Point(39, 418);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(112, 31);
            this.Button5_3_5.TabIndex = 2;
            this.Button5_3_5.Text = "文字列連結";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // TextBox5_3_5
            // 
            this.TextBox5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox5_3_5.Location = new System.Drawing.Point(202, 415);
            this.TextBox5_3_5.Name = "TextBox5_3_5";
            this.TextBox5_3_5.Size = new System.Drawing.Size(373, 34);
            this.TextBox5_3_5.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.TextBox5_3_5);
            this.Controls.Add(this.TextBox5_3_4);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox TextBox5_3_4;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox TextBox5_3_5;
    }
}

