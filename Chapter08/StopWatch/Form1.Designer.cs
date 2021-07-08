
namespace StopWatch {
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
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.stopbt = new System.Windows.Forms.Button();
            this.startbt = new System.Windows.Forms.Button();
            this.resetbt = new System.Windows.Forms.Button();
            this.lapbt = new System.Windows.Forms.Button();
            this.laplb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.Gray;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(38, 63);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(342, 57);
            this.lbTimerDisp.TabIndex = 0;
            // 
            // stopbt
            // 
            this.stopbt.Location = new System.Drawing.Point(230, 158);
            this.stopbt.Name = "stopbt";
            this.stopbt.Size = new System.Drawing.Size(150, 73);
            this.stopbt.TabIndex = 1;
            this.stopbt.Text = "stop";
            this.stopbt.UseVisualStyleBackColor = true;
            this.stopbt.Click += new System.EventHandler(this.stopbt_Click);
            // 
            // startbt
            // 
            this.startbt.Location = new System.Drawing.Point(40, 158);
            this.startbt.Name = "startbt";
            this.startbt.Size = new System.Drawing.Size(150, 73);
            this.startbt.TabIndex = 1;
            this.startbt.Text = "start";
            this.startbt.UseVisualStyleBackColor = true;
            this.startbt.Click += new System.EventHandler(this.startbt_Click);
            // 
            // resetbt
            // 
            this.resetbt.Location = new System.Drawing.Point(43, 286);
            this.resetbt.Name = "resetbt";
            this.resetbt.Size = new System.Drawing.Size(150, 73);
            this.resetbt.TabIndex = 1;
            this.resetbt.Text = "reset";
            this.resetbt.UseVisualStyleBackColor = true;
            this.resetbt.Click += new System.EventHandler(this.resetbt_Click);
            // 
            // lapbt
            // 
            this.lapbt.Location = new System.Drawing.Point(230, 286);
            this.lapbt.Name = "lapbt";
            this.lapbt.Size = new System.Drawing.Size(150, 73);
            this.lapbt.TabIndex = 1;
            this.lapbt.Text = "lap";
            this.lapbt.UseVisualStyleBackColor = true;
            this.lapbt.Click += new System.EventHandler(this.lapbt_Click);
            // 
            // laplb
            // 
            this.laplb.BackColor = System.Drawing.Color.Gray;
            this.laplb.FormattingEnabled = true;
            this.laplb.ItemHeight = 12;
            this.laplb.Location = new System.Drawing.Point(406, 63);
            this.laplb.Name = "laplb";
            this.laplb.Size = new System.Drawing.Size(348, 292);
            this.laplb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laplb);
            this.Controls.Add(this.resetbt);
            this.Controls.Add(this.startbt);
            this.Controls.Add(this.lapbt);
            this.Controls.Add(this.stopbt);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button stopbt;
        private System.Windows.Forms.Button startbt;
        private System.Windows.Forms.Button resetbt;
        private System.Windows.Forms.Button lapbt;
        private System.Windows.Forms.ListBox laplb;
    }
}

