﻿
namespace AttendanceManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btEmployee = new System.Windows.Forms.Button();
            this.btManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEmployee
            // 
            this.btEmployee.Location = new System.Drawing.Point(93, 100);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(271, 184);
            this.btEmployee.TabIndex = 0;
            this.btEmployee.Text = "従業員用";
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btManage
            // 
            this.btManage.Location = new System.Drawing.Point(430, 100);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(271, 184);
            this.btManage.TabIndex = 1;
            this.btManage.Text = "管理用";
            this.btManage.UseVisualStyleBackColor = true;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(248, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "勤怠管理システム";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.btEmployee);
            this.Name = "Form1";
            this.Text = "勤怠管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Label label1;
    }
}

