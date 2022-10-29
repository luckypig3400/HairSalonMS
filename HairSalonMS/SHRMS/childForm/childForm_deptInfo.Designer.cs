namespace SHRMS.childForm
{
    partial class childForm_deptInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_allDeptInfo = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_str = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.btn_modifyDept = new System.Windows.Forms.Button();
            this.btn_deleteDept = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_deptNo = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_deptname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_selectDept = new System.Windows.Forms.Button();
            this.label_sType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_datagridview = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_dept = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dept)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Text = "位置：部门管理 > 部门信息";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 44);
            this.panel1.TabIndex = 1;
            // 
            // btn_allDeptInfo
            // 
            this.btn_allDeptInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_allDeptInfo.FlatAppearance.BorderSize = 0;
            this.btn_allDeptInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allDeptInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_allDeptInfo.ForeColor = System.Drawing.Color.White;
            this.btn_allDeptInfo.Location = new System.Drawing.Point(13, 133);
            this.btn_allDeptInfo.Name = "btn_allDeptInfo";
            this.btn_allDeptInfo.Size = new System.Drawing.Size(185, 40);
            this.btn_allDeptInfo.TabIndex = 3;
            this.btn_allDeptInfo.Text = "查看所有部门信息";
            this.btn_allDeptInfo.UseVisualStyleBackColor = false;
            this.btn_allDeptInfo.Click += new System.EventHandler(this.btn_allDeptInfo_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "按部门编号",
            "按部门名称"});
            this.comboBox_type.Location = new System.Drawing.Point(88, 54);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(110, 29);
            this.comboBox_type.TabIndex = 4;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // textBox_str
            // 
            this.textBox_str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_str.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_str.Location = new System.Drawing.Point(328, 57);
            this.textBox_str.Name = "textBox_str";
            this.textBox_str.Size = new System.Drawing.Size(141, 26);
            this.textBox_str.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(567, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 666);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox2.Controls.Add(this.textBox_telephone);
            this.groupBox2.Controls.Add(this.btn_modifyDept);
            this.groupBox2.Controls.Add(this.btn_deleteDept);
            this.groupBox2.Controls.Add(this.textBox_address);
            this.groupBox2.Controls.Add(this.label_deptNo);
            this.groupBox2.Controls.Add(this.label_count);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_deptname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 442);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "部门信息";
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_telephone.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_telephone.Location = new System.Drawing.Point(191, 245);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(242, 26);
            this.textBox_telephone.TabIndex = 5;
            // 
            // btn_modifyDept
            // 
            this.btn_modifyDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.btn_modifyDept.FlatAppearance.BorderSize = 0;
            this.btn_modifyDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifyDept.ForeColor = System.Drawing.Color.White;
            this.btn_modifyDept.Location = new System.Drawing.Point(300, 369);
            this.btn_modifyDept.Name = "btn_modifyDept";
            this.btn_modifyDept.Size = new System.Drawing.Size(133, 40);
            this.btn_modifyDept.TabIndex = 3;
            this.btn_modifyDept.Text = "点击修改部门";
            this.btn_modifyDept.UseVisualStyleBackColor = false;
            this.btn_modifyDept.Click += new System.EventHandler(this.btn_modifyDept_Click);
            // 
            // btn_deleteDept
            // 
            this.btn_deleteDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_deleteDept.FlatAppearance.BorderSize = 0;
            this.btn_deleteDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteDept.ForeColor = System.Drawing.Color.White;
            this.btn_deleteDept.Location = new System.Drawing.Point(54, 369);
            this.btn_deleteDept.Name = "btn_deleteDept";
            this.btn_deleteDept.Size = new System.Drawing.Size(134, 40);
            this.btn_deleteDept.TabIndex = 3;
            this.btn_deleteDept.Text = "删除该部门";
            this.btn_deleteDept.UseVisualStyleBackColor = false;
            this.btn_deleteDept.Click += new System.EventHandler(this.btn_deleteDept_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_address.Location = new System.Drawing.Point(191, 177);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(242, 26);
            this.textBox_address.TabIndex = 5;
            // 
            // label_deptNo
            // 
            this.label_deptNo.AutoSize = true;
            this.label_deptNo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_deptNo.Location = new System.Drawing.Point(187, 42);
            this.label_deptNo.Name = "label_deptNo";
            this.label_deptNo.Size = new System.Drawing.Size(60, 27);
            this.label_deptNo.TabIndex = 6;
            this.label_deptNo.Text = "0000";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_count.Location = new System.Drawing.Point(187, 300);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(50, 27);
            this.label_count.TabIndex = 6;
            this.label_count.Text = "0 人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "该部门员工数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "该部门电话号码：";
            // 
            // textBox_deptname
            // 
            this.textBox_deptname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deptname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_deptname.Location = new System.Drawing.Point(191, 109);
            this.textBox_deptname.Name = "textBox_deptname";
            this.textBox_deptname.Size = new System.Drawing.Size(242, 26);
            this.textBox_deptname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "该部门所在地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "部门编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "部门名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.textBox_str);
            this.groupBox1.Controls.Add(this.btn_allDeptInfo);
            this.groupBox1.Controls.Add(this.btn_selectDept);
            this.groupBox1.Controls.Add(this.label_sType);
            this.groupBox1.Controls.Add(this.comboBox_type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查询";
            // 
            // btn_selectDept
            // 
            this.btn_selectDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_selectDept.FlatAppearance.BorderSize = 0;
            this.btn_selectDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectDept.ForeColor = System.Drawing.Color.White;
            this.btn_selectDept.Location = new System.Drawing.Point(328, 133);
            this.btn_selectDept.Name = "btn_selectDept";
            this.btn_selectDept.Size = new System.Drawing.Size(141, 40);
            this.btn_selectDept.TabIndex = 3;
            this.btn_selectDept.Text = "点击查询";
            this.btn_selectDept.UseVisualStyleBackColor = false;
            this.btn_selectDept.Click += new System.EventHandler(this.btn_selectDept_Click);
            // 
            // label_sType
            // 
            this.label_sType.AutoSize = true;
            this.label_sType.Location = new System.Drawing.Point(202, 58);
            this.label_sType.Name = "label_sType";
            this.label_sType.Size = new System.Drawing.Size(126, 21);
            this.label_sType.TabIndex = 6;
            this.label_sType.Text = "按部门编号查询:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "查询类型：";
            // 
            // panel_datagridview
            // 
            this.panel_datagridview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_datagridview.Location = new System.Drawing.Point(561, 44);
            this.panel_datagridview.Name = "panel_datagridview";
            this.panel_datagridview.Size = new System.Drawing.Size(6, 666);
            this.panel_datagridview.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_dept);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 666);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView_dept
            // 
            this.dataGridView_dept.AllowUserToAddRows = false;
            this.dataGridView_dept.AllowUserToDeleteRows = false;
            this.dataGridView_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dept.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_dept.Name = "dataGridView_dept";
            this.dataGridView_dept.ReadOnly = true;
            this.dataGridView_dept.RowTemplate.Height = 23;
            this.dataGridView_dept.Size = new System.Drawing.Size(561, 666);
            this.dataGridView_dept.TabIndex = 0;
            this.dataGridView_dept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dept_CellClick);
            // 
            // childForm_deptInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_datagridview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_deptInfo";
            this.Text = "childForm_deptInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_allDeptInfo;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_str;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_datagridview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_deptname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_selectDept;
        private System.Windows.Forms.Label label_sType;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_modifyDept;
        private System.Windows.Forms.Button btn_deleteDept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_dept;
        private System.Windows.Forms.Label label_deptNo;
    }
}