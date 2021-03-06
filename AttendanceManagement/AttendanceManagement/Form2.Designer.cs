
namespace AttendanceManagement
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
            this.components = new System.ComponentModel.Container();
            this.btEndWork = new System.Windows.Forms.Button();
            this.btEndRest = new System.Windows.Forms.Button();
            this.btStartRest = new System.Windows.Forms.Button();
            this.btStartWork = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btBack1 = new System.Windows.Forms.Button();
            this.dgbtime = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEmpNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbNowTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbtime)).BeginInit();
            this.SuspendLayout();
            // 
            // btEndWork
            // 
            this.btEndWork.Location = new System.Drawing.Point(240, 69);
            this.btEndWork.Name = "btEndWork";
            this.btEndWork.Size = new System.Drawing.Size(94, 33);
            this.btEndWork.TabIndex = 12;
            this.btEndWork.Text = "退勤";
            this.btEndWork.UseVisualStyleBackColor = true;
            this.btEndWork.Click += new System.EventHandler(this.btEndWork_Click);
            // 
            // btEndRest
            // 
            this.btEndRest.Location = new System.Drawing.Point(355, 69);
            this.btEndRest.Name = "btEndRest";
            this.btEndRest.Size = new System.Drawing.Size(94, 33);
            this.btEndRest.TabIndex = 13;
            this.btEndRest.Text = "休憩out";
            this.btEndRest.UseVisualStyleBackColor = true;
            this.btEndRest.Click += new System.EventHandler(this.btEndRest_Click);
            // 
            // btStartRest
            // 
            this.btStartRest.Location = new System.Drawing.Point(356, 25);
            this.btStartRest.Name = "btStartRest";
            this.btStartRest.Size = new System.Drawing.Size(94, 33);
            this.btStartRest.TabIndex = 14;
            this.btStartRest.Text = "休憩in";
            this.btStartRest.UseVisualStyleBackColor = true;
            this.btStartRest.Click += new System.EventHandler(this.btStartRest_Click);
            // 
            // btStartWork
            // 
            this.btStartWork.Location = new System.Drawing.Point(240, 25);
            this.btStartWork.Name = "btStartWork";
            this.btStartWork.Size = new System.Drawing.Size(94, 33);
            this.btStartWork.TabIndex = 15;
            this.btStartWork.Text = "出勤";
            this.btStartWork.UseVisualStyleBackColor = true;
            this.btStartWork.Click += new System.EventHandler(this.btStartWork_Click);
            // 
            // btRegist
            // 
            this.btRegist.Location = new System.Drawing.Point(669, 270);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(119, 48);
            this.btRegist.TabIndex = 8;
            this.btRegist.Text = "登録";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(669, 216);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(119, 48);
            this.btNew.TabIndex = 9;
            this.btNew.Text = "新規";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btBack1
            // 
            this.btBack1.Location = new System.Drawing.Point(669, 162);
            this.btBack1.Name = "btBack1";
            this.btBack1.Size = new System.Drawing.Size(119, 48);
            this.btBack1.TabIndex = 11;
            this.btBack1.Text = "戻る";
            this.btBack1.UseVisualStyleBackColor = true;
            this.btBack1.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dgbtime
            // 
            this.dgbtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.EmpNo,
            this.StartWork,
            this.StartRest,
            this.EndRest,
            this.EndWork});
            this.dgbtime.Location = new System.Drawing.Point(12, 108);
            this.dgbtime.Name = "dgbtime";
            this.dgbtime.RowTemplate.Height = 21;
            this.dgbtime.Size = new System.Drawing.Size(643, 210);
            this.dgbtime.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.HeaderText = "名前";
            this.Name.Name = "Name";
            // 
            // EmpNo
            // 
            this.EmpNo.HeaderText = "番号";
            this.EmpNo.Name = "EmpNo";
            // 
            // StartWork
            // 
            this.StartWork.HeaderText = "出勤時間";
            this.StartWork.Name = "StartWork";
            // 
            // StartRest
            // 
            this.StartRest.HeaderText = "休憩開始時間";
            this.StartRest.Name = "StartRest";
            // 
            // EndRest
            // 
            this.EndRest.HeaderText = "休憩終了時間";
            this.EndRest.Name = "EndRest";
            // 
            // EndWork
            // 
            this.EndWork.HeaderText = "退勤時間";
            this.EndWork.Name = "EndWork";
            // 
            // tbEmpNo
            // 
            this.tbEmpNo.Location = new System.Drawing.Point(12, 57);
            this.tbEmpNo.Name = "tbEmpNo";
            this.tbEmpNo.Size = new System.Drawing.Size(200, 19);
            this.tbEmpNo.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowTime.Location = new System.Drawing.Point(526, 43);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(0, 59);
            this.lbNowTime.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "現在時刻";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNowTime);
            this.Controls.Add(this.btEndWork);
            this.Controls.Add(this.btEndRest);
            this.Controls.Add(this.btStartRest);
            this.Controls.Add(this.btStartWork);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btBack1);
            this.Controls.Add(this.dgbtime);
            this.Controls.Add(this.tbEmpNo);
            this.Controls.Add(this.dtpDate);
            //this.Name = "Form2";
            this.Text = "登録";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEndWork;
        private System.Windows.Forms.Button btEndRest;
        private System.Windows.Forms.Button btStartRest;
        private System.Windows.Forms.Button btStartWork;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btBack1;
        private System.Windows.Forms.DataGridView dgbtime;
        private System.Windows.Forms.TextBox tbEmpNo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWork;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.Label label1;
    }
}