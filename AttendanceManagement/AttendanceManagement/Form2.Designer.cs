
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
            this.btEndWork = new System.Windows.Forms.Button();
            this.btEndRest = new System.Windows.Forms.Button();
            this.btStartRest = new System.Windows.Forms.Button();
            this.btStartWork = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btBack1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEmpNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(669, 216);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(119, 48);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(668, 162);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(119, 48);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "編集";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btBack1
            // 
            this.btBack1.Location = new System.Drawing.Point(669, 108);
            this.btBack1.Name = "btBack1";
            this.btBack1.Size = new System.Drawing.Size(119, 48);
            this.btBack1.TabIndex = 11;
            this.btBack1.Text = "戻る";
            this.btBack1.UseVisualStyleBackColor = true;
            this.btBack1.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.EmpNo,
            this.StartWork,
            this.StartRest,
            this.EndRest,
            this.EndWork});
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(643, 210);
            this.dataGridView1.TabIndex = 7;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.btEndWork);
            this.Controls.Add(this.btEndRest);
            this.Controls.Add(this.btStartRest);
            this.Controls.Add(this.btStartWork);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btBack1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbEmpNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "登録";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEndWork;
        private System.Windows.Forms.Button btEndRest;
        private System.Windows.Forms.Button btStartRest;
        private System.Windows.Forms.Button btStartWork;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btBack1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbEmpNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWork;
    }
}