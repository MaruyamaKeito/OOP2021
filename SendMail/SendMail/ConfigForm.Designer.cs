
namespace SendMail
{
    partial class ConfigForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btDefault = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "サーバ情報";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 19);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "送信サーバー";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 19);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "送信サーバー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "送信サーバー";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 19);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "送信サーバー";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSsl);
            this.groupBox2.Controls.Add(this.tbPass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbUserName);
            this.groupBox2.Controls.Add(this.tbHost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "サーバ情報";
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Location = new System.Drawing.Point(287, 68);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(68, 16);
            this.cbSsl.TabIndex = 2;
            this.cbSsl.Text = "SSL有効";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(287, 41);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(109, 19);
            this.tbPass.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "パスワード";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(287, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(109, 19);
            this.tbPort.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "ポート";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "ユーザー名";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(82, 41);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(109, 19);
            this.tbUserName.TabIndex = 1;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(82, 16);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(109, 19);
            this.tbHost.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "送信サーバー";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSender);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ユーザー情報";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(82, 18);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(182, 19);
            this.tbSender.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "送信元";
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(13, 168);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(75, 23);
            this.btDefault.TabIndex = 2;
            this.btDefault.Text = "デフォルト";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(217, 167);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(298, 168);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(379, 168);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 2;
            this.btApply.Text = "適用";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 201);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btDefault);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSsl;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
    }
}