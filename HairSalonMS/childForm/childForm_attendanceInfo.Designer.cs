namespace SHRMS.childForm
{
    partial class childForm_attendanceInfo
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_realDay = new System.Windows.Forms.Label();
            this.label_shoudDay = new System.Windows.Forms.Label();
            this.label_absenteeism = new System.Windows.Forms.Label();
            this.label_earlyLeave = new System.Windows.Forms.Label();
            this.label_late = new System.Windows.Forms.Label();
            this.label_overTime = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_empNo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_str = new System.Windows.Forms.TextBox();
            this.btn_allInfo = new System.Windows.Forms.Button();
            this.btn_selectA = new System.Windows.Forms.Button();
            this.label_QType = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.dataGridView_att = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_att)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1060, 44);
            this.panel_top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "位置：考勤管理 > 考勤信息";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.panel_left.Controls.Add(this.groupBox2);
            this.panel_left.Controls.Add(this.groupBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 44);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(505, 666);
            this.panel_left.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox2.Controls.Add(this.label_realDay);
            this.groupBox2.Controls.Add(this.label_shoudDay);
            this.groupBox2.Controls.Add(this.label_absenteeism);
            this.groupBox2.Controls.Add(this.label_earlyLeave);
            this.groupBox2.Controls.Add(this.label_late);
            this.groupBox2.Controls.Add(this.label_overTime);
            this.groupBox2.Controls.Add(this.label_dept);
            this.groupBox2.Controls.Add(this.label_role);
            this.groupBox2.Controls.Add(this.label_name);
            this.groupBox2.Controls.Add(this.label_empNo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 448);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工考勤信息";
            // 
            // label_realDay
            // 
            this.label_realDay.AutoSize = true;
            this.label_realDay.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_realDay.Location = new System.Drawing.Point(389, 279);
            this.label_realDay.Name = "label_realDay";
            this.label_realDay.Size = new System.Drawing.Size(50, 27);
            this.label_realDay.TabIndex = 6;
            this.label_realDay.Text = "0 天";
            // 
            // label_shoudDay
            // 
            this.label_shoudDay.AutoSize = true;
            this.label_shoudDay.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_shoudDay.Location = new System.Drawing.Point(389, 229);
            this.label_shoudDay.Name = "label_shoudDay";
            this.label_shoudDay.Size = new System.Drawing.Size(50, 27);
            this.label_shoudDay.TabIndex = 6;
            this.label_shoudDay.Text = "0 天";
            // 
            // label_absenteeism
            // 
            this.label_absenteeism.AutoSize = true;
            this.label_absenteeism.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_absenteeism.Location = new System.Drawing.Point(389, 181);
            this.label_absenteeism.Name = "label_absenteeism";
            this.label_absenteeism.Size = new System.Drawing.Size(50, 27);
            this.label_absenteeism.TabIndex = 6;
            this.label_absenteeism.Text = "0 次";
            // 
            // label_earlyLeave
            // 
            this.label_earlyLeave.AutoSize = true;
            this.label_earlyLeave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_earlyLeave.Location = new System.Drawing.Point(389, 132);
            this.label_earlyLeave.Name = "label_earlyLeave";
            this.label_earlyLeave.Size = new System.Drawing.Size(50, 27);
            this.label_earlyLeave.TabIndex = 6;
            this.label_earlyLeave.Text = "0 次";
            // 
            // label_late
            // 
            this.label_late.AutoSize = true;
            this.label_late.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_late.Location = new System.Drawing.Point(389, 85);
            this.label_late.Name = "label_late";
            this.label_late.Size = new System.Drawing.Size(50, 27);
            this.label_late.TabIndex = 6;
            this.label_late.Text = "0 次";
            // 
            // label_overTime
            // 
            this.label_overTime.AutoSize = true;
            this.label_overTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_overTime.Location = new System.Drawing.Point(139, 280);
            this.label_overTime.Name = "label_overTime";
            this.label_overTime.Size = new System.Drawing.Size(70, 27);
            this.label_overTime.TabIndex = 6;
            this.label_overTime.Text = "0 小时";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_dept.Location = new System.Drawing.Point(139, 228);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(57, 27);
            this.label_dept.TabIndex = 6;
            this.label_dept.Text = "×××";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_role.Location = new System.Drawing.Point(139, 182);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(57, 27);
            this.label_role.TabIndex = 6;
            this.label_role.Text = "×××";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(139, 133);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 27);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "×××";
            // 
            // label_empNo
            // 
            this.label_empNo.AutoSize = true;
            this.label_empNo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_empNo.Location = new System.Drawing.Point(139, 84);
            this.label_empNo.Name = "label_empNo";
            this.label_empNo.Size = new System.Drawing.Size(60, 27);
            this.label_empNo.TabIndex = 6;
            this.label_empNo.Text = "0000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 21);
            this.label14.TabIndex = 6;
            this.label14.Text = "所在部门：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "加班小时数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "实际出勤天数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "旷到次数：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "早退次数：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "迟到次数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "应出勤天数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "员工编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "员工职务：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "员工姓名：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.textBox_str);
            this.groupBox1.Controls.Add(this.btn_allInfo);
            this.groupBox1.Controls.Add(this.btn_selectA);
            this.groupBox1.Controls.Add(this.label_QType);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查询";
            // 
            // textBox_str
            // 
            this.textBox_str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_str.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_str.Location = new System.Drawing.Point(166, 51);
            this.textBox_str.Name = "textBox_str";
            this.textBox_str.Size = new System.Drawing.Size(125, 26);
            this.textBox_str.TabIndex = 5;
            // 
            // btn_allInfo
            // 
            this.btn_allInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_allInfo.FlatAppearance.BorderSize = 0;
            this.btn_allInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_allInfo.ForeColor = System.Drawing.Color.White;
            this.btn_allInfo.Location = new System.Drawing.Point(283, 114);
            this.btn_allInfo.Name = "btn_allInfo";
            this.btn_allInfo.Size = new System.Drawing.Size(185, 40);
            this.btn_allInfo.TabIndex = 3;
            this.btn_allInfo.Text = "查看所有考勤信息";
            this.btn_allInfo.UseVisualStyleBackColor = false;
            this.btn_allInfo.Click += new System.EventHandler(this.btn_allInfo_Click);
            // 
            // btn_selectA
            // 
            this.btn_selectA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_selectA.FlatAppearance.BorderSize = 0;
            this.btn_selectA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectA.ForeColor = System.Drawing.Color.White;
            this.btn_selectA.Location = new System.Drawing.Point(327, 43);
            this.btn_selectA.Name = "btn_selectA";
            this.btn_selectA.Size = new System.Drawing.Size(141, 40);
            this.btn_selectA.TabIndex = 3;
            this.btn_selectA.Text = "点击查询";
            this.btn_selectA.UseVisualStyleBackColor = false;
            this.btn_selectA.Click += new System.EventHandler(this.btn_selectA_Click);
            // 
            // label_QType
            // 
            this.label_QType.AutoSize = true;
            this.label_QType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_QType.Location = new System.Drawing.Point(14, 51);
            this.label_QType.Name = "label_QType";
            this.label_QType.Size = new System.Drawing.Size(150, 25);
            this.label_QType.TabIndex = 6;
            this.label_QType.Text = "按员工编号查询:";
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.dataGridView_att);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(505, 44);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(555, 666);
            this.panel_right.TabIndex = 6;
            // 
            // dataGridView_att
            // 
            this.dataGridView_att.AllowUserToAddRows = false;
            this.dataGridView_att.AllowUserToDeleteRows = false;
            this.dataGridView_att.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_att.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_att.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_att.Name = "dataGridView_att";
            this.dataGridView_att.ReadOnly = true;
            this.dataGridView_att.RowTemplate.Height = 23;
            this.dataGridView_att.Size = new System.Drawing.Size(555, 666);
            this.dataGridView_att.TabIndex = 0;
            this.dataGridView_att.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_att_CellClick);
            // 
            // childForm_attendanceInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_attendanceInfo";
            this.Text = "childForm_attendanceInfo";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_att)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.DataGridView dataGridView_att;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_str;
        private System.Windows.Forms.Button btn_allInfo;
        private System.Windows.Forms.Button btn_selectA;
        private System.Windows.Forms.Label label_QType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_empNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_realDay;
        private System.Windows.Forms.Label label_shoudDay;
        private System.Windows.Forms.Label label_absenteeism;
        private System.Windows.Forms.Label label_earlyLeave;
        private System.Windows.Forms.Label label_late;
        private System.Windows.Forms.Label label_overTime;
    }
}