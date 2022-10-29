namespace SHRMS.childForm
{
    partial class childForm_systemManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_addAdmin = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.label_query = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_done = new System.Windows.Forms.Button();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_dept = new System.Windows.Forms.CheckBox();
            this.checkBox_tea = new System.Windows.Forms.CheckBox();
            this.checkBox_emp = new System.Windows.Forms.CheckBox();
            this.checkBox_atten = new System.Windows.Forms.CheckBox();
            this.checkBox_salary = new System.Windows.Forms.CheckBox();
            this.checkBox_apply = new System.Windows.Forms.CheckBox();
            this.checkBox_info = new System.Windows.Forms.CheckBox();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel_top.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "位置：系统管理";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.button_addAdmin);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_pwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_uname);
            this.panel1.Controls.Add(this.label_query);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 666);
            this.panel1.TabIndex = 6;
            // 
            // button_addAdmin
            // 
            this.button_addAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button_addAdmin.FlatAppearance.BorderSize = 0;
            this.button_addAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addAdmin.ForeColor = System.Drawing.Color.White;
            this.button_addAdmin.Location = new System.Drawing.Point(189, 438);
            this.button_addAdmin.Name = "button_addAdmin";
            this.button_addAdmin.Size = new System.Drawing.Size(206, 37);
            this.button_addAdmin.TabIndex = 54;
            this.button_addAdmin.Text = "确认添加";
            this.button_addAdmin.UseVisualStyleBackColor = false;
            this.button_addAdmin.Click += new System.EventHandler(this.button_addAdmin_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_email.Location = new System.Drawing.Point(189, 329);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(206, 26);
            this.textBox_email.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(71, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "管理员邮箱:";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_pwd.Location = new System.Drawing.Point(189, 270);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(206, 26);
            this.textBox_pwd.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(71, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "管理员密码:";
            // 
            // textBox_uname
            // 
            this.textBox_uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_uname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_uname.Location = new System.Drawing.Point(189, 211);
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(206, 26);
            this.textBox_uname.TabIndex = 52;
            // 
            // label_query
            // 
            this.label_query.AutoSize = true;
            this.label_query.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_query.Location = new System.Drawing.Point(52, 212);
            this.label_query.Name = "label_query";
            this.label_query.Size = new System.Drawing.Size(131, 25);
            this.label_query.TabIndex = 53;
            this.label_query.Text = "管理员用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(158, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "添加管理员";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button_done);
            this.panel2.Controls.Add(this.comboBox_role);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(485, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 666);
            this.panel2.TabIndex = 7;
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button_done.FlatAppearance.BorderSize = 0;
            this.button_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_done.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_done.ForeColor = System.Drawing.Color.White;
            this.button_done.Location = new System.Drawing.Point(254, 520);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(250, 37);
            this.button_done.TabIndex = 54;
            this.button_done.Text = "确认授权";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // comboBox_role
            // 
            this.comboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_role.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "管理员",
            "教师",
            "教职工",
            "游客"});
            this.comboBox_role.Location = new System.Drawing.Point(254, 182);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(250, 29);
            this.comboBox_role.TabIndex = 2;
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(223, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "权限管理";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(62, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "请勾选要授予的权限：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(62, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "请选择要授权的角色:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBox_atten);
            this.groupBox1.Controls.Add(this.checkBox_info);
            this.groupBox1.Controls.Add(this.checkBox_emp);
            this.groupBox1.Controls.Add(this.checkBox_apply);
            this.groupBox1.Controls.Add(this.checkBox_salary);
            this.groupBox1.Controls.Add(this.checkBox_tea);
            this.groupBox1.Controls.Add(this.checkBox_dept);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(254, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 196);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限分配";
            // 
            // checkBox_dept
            // 
            this.checkBox_dept.AutoSize = true;
            this.checkBox_dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_dept.Location = new System.Drawing.Point(18, 35);
            this.checkBox_dept.Name = "checkBox_dept";
            this.checkBox_dept.Size = new System.Drawing.Size(93, 25);
            this.checkBox_dept.TabIndex = 56;
            this.checkBox_dept.Text = "部门管理";
            this.checkBox_dept.UseVisualStyleBackColor = true;
            // 
            // checkBox_tea
            // 
            this.checkBox_tea.AutoSize = true;
            this.checkBox_tea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_tea.Location = new System.Drawing.Point(18, 77);
            this.checkBox_tea.Name = "checkBox_tea";
            this.checkBox_tea.Size = new System.Drawing.Size(93, 25);
            this.checkBox_tea.TabIndex = 56;
            this.checkBox_tea.Text = "教师管理";
            this.checkBox_tea.UseVisualStyleBackColor = true;
            // 
            // checkBox_emp
            // 
            this.checkBox_emp.AutoSize = true;
            this.checkBox_emp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_emp.Location = new System.Drawing.Point(18, 119);
            this.checkBox_emp.Name = "checkBox_emp";
            this.checkBox_emp.Size = new System.Drawing.Size(109, 25);
            this.checkBox_emp.TabIndex = 56;
            this.checkBox_emp.Text = "教职工管理";
            this.checkBox_emp.UseVisualStyleBackColor = true;
            // 
            // checkBox_atten
            // 
            this.checkBox_atten.AutoSize = true;
            this.checkBox_atten.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_atten.Location = new System.Drawing.Point(18, 161);
            this.checkBox_atten.Name = "checkBox_atten";
            this.checkBox_atten.Size = new System.Drawing.Size(93, 25);
            this.checkBox_atten.TabIndex = 56;
            this.checkBox_atten.Text = "考勤管理";
            this.checkBox_atten.UseVisualStyleBackColor = true;
            // 
            // checkBox_salary
            // 
            this.checkBox_salary.AutoSize = true;
            this.checkBox_salary.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_salary.Location = new System.Drawing.Point(140, 35);
            this.checkBox_salary.Name = "checkBox_salary";
            this.checkBox_salary.Size = new System.Drawing.Size(93, 25);
            this.checkBox_salary.TabIndex = 56;
            this.checkBox_salary.Text = "薪资管理";
            this.checkBox_salary.UseVisualStyleBackColor = true;
            // 
            // checkBox_apply
            // 
            this.checkBox_apply.AutoSize = true;
            this.checkBox_apply.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_apply.Location = new System.Drawing.Point(140, 77);
            this.checkBox_apply.Name = "checkBox_apply";
            this.checkBox_apply.Size = new System.Drawing.Size(93, 25);
            this.checkBox_apply.TabIndex = 56;
            this.checkBox_apply.Text = "申请门户";
            this.checkBox_apply.UseVisualStyleBackColor = true;
            // 
            // checkBox_info
            // 
            this.checkBox_info.AutoSize = true;
            this.checkBox_info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_info.Location = new System.Drawing.Point(140, 119);
            this.checkBox_info.Name = "checkBox_info";
            this.checkBox_info.Size = new System.Drawing.Size(93, 25);
            this.checkBox_info.TabIndex = 56;
            this.checkBox_info.Text = "个人信息";
            this.checkBox_info.UseVisualStyleBackColor = true;
            // 
            // childForm_systemManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_systemManage";
            this.Text = "childForm_systemManage";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.Label label_query;
        private System.Windows.Forms.Button button_addAdmin;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_dept;
        private System.Windows.Forms.CheckBox checkBox_atten;
        private System.Windows.Forms.CheckBox checkBox_info;
        private System.Windows.Forms.CheckBox checkBox_emp;
        private System.Windows.Forms.CheckBox checkBox_apply;
        private System.Windows.Forms.CheckBox checkBox_salary;
        private System.Windows.Forms.CheckBox checkBox_tea;
    }
}