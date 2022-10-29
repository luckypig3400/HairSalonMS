namespace SHRMS
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_bigMenu = new System.Windows.Forms.Panel();
            this.btn_systemManage = new System.Windows.Forms.Button();
            this.btn_personalInfo = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.panel_salarySubMenu = new System.Windows.Forms.Panel();
            this.sbtn_salaryReport = new System.Windows.Forms.Button();
            this.sbtn_salaryAdd = new System.Windows.Forms.Button();
            this.sbtn_salaryInfo = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.panel_attendanceSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_attendanceAdd = new System.Windows.Forms.Button();
            this.sbtn_attendanceInfo = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.panel_empSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_empAdd = new System.Windows.Forms.Button();
            this.sbtn_empFamily = new System.Windows.Forms.Button();
            this.sbtn_empInfo = new System.Windows.Forms.Button();
            this.btn_emp = new System.Windows.Forms.Button();
            this.panel_teacherSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_teaAdd = new System.Windows.Forms.Button();
            this.sbtn_teaFamily = new System.Windows.Forms.Button();
            this.sbtn_teaInfo = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.panel_deptSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_deptAdd = new System.Windows.Forms.Button();
            this.sbtn_deptInfo = new System.Windows.Forms.Button();
            this.btn_dept = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label_userRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_logOut = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_bigMenu.SuspendLayout();
            this.panel_salarySubMenu.SuspendLayout();
            this.panel_attendanceSubMenu.SuspendLayout();
            this.panel_empSubMenu.SuspendLayout();
            this.panel_teacherSubMenu.SuspendLayout();
            this.panel_deptSubMenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel_top.Controls.Add(this.label8);
            this.panel_top.Controls.Add(this.pictureBox2);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_max);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1280, 50);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.label8.Location = new System.Drawing.Point(61, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Geek高校人力资源管理系统";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(1132, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 0;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(1181, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 0;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1230, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseMove);
            // 
            // panel_bigMenu
            // 
            this.panel_bigMenu.AutoScroll = true;
            this.panel_bigMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.panel_bigMenu.Controls.Add(this.btn_systemManage);
            this.panel_bigMenu.Controls.Add(this.btn_personalInfo);
            this.panel_bigMenu.Controls.Add(this.btn_apply);
            this.panel_bigMenu.Controls.Add(this.panel_salarySubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_salary);
            this.panel_bigMenu.Controls.Add(this.panel_attendanceSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_attendance);
            this.panel_bigMenu.Controls.Add(this.panel_empSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_emp);
            this.panel_bigMenu.Controls.Add(this.panel_teacherSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_teacher);
            this.panel_bigMenu.Controls.Add(this.panel_deptSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_dept);
            this.panel_bigMenu.Controls.Add(this.btn_home);
            this.panel_bigMenu.Controls.Add(this.panel_logo);
            this.panel_bigMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bigMenu.Location = new System.Drawing.Point(0, 50);
            this.panel_bigMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bigMenu.Name = "panel_bigMenu";
            this.panel_bigMenu.Size = new System.Drawing.Size(220, 750);
            this.panel_bigMenu.TabIndex = 0;
            // 
            // btn_systemManage
            // 
            this.btn_systemManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_systemManage.FlatAppearance.BorderSize = 0;
            this.btn_systemManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_systemManage.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_systemManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_systemManage.Image = ((System.Drawing.Image)(resources.GetObject("btn_systemManage.Image")));
            this.btn_systemManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_systemManage.Location = new System.Drawing.Point(0, 1190);
            this.btn_systemManage.Name = "btn_systemManage";
            this.btn_systemManage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_systemManage.Size = new System.Drawing.Size(203, 55);
            this.btn_systemManage.TabIndex = 14;
            this.btn_systemManage.Text = "  系统管理";
            this.btn_systemManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_systemManage.UseVisualStyleBackColor = true;
            this.btn_systemManage.Click += new System.EventHandler(this.btn_systemManage_Click);
            // 
            // btn_personalInfo
            // 
            this.btn_personalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personalInfo.FlatAppearance.BorderSize = 0;
            this.btn_personalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personalInfo.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_personalInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_personalInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_personalInfo.Image")));
            this.btn_personalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personalInfo.Location = new System.Drawing.Point(0, 1135);
            this.btn_personalInfo.Name = "btn_personalInfo";
            this.btn_personalInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_personalInfo.Size = new System.Drawing.Size(203, 55);
            this.btn_personalInfo.TabIndex = 13;
            this.btn_personalInfo.Text = "  个人信息";
            this.btn_personalInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personalInfo.UseVisualStyleBackColor = true;
            this.btn_personalInfo.Click += new System.EventHandler(this.btn_personalInfo_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_apply.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_apply.Image = ((System.Drawing.Image)(resources.GetObject("btn_apply.Image")));
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(0, 1080);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_apply.Size = new System.Drawing.Size(203, 55);
            this.btn_apply.TabIndex = 12;
            this.btn_apply.Text = "  申请门户";
            this.btn_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // panel_salarySubMenu
            // 
            this.panel_salarySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryReport);
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryAdd);
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryInfo);
            this.panel_salarySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_salarySubMenu.Location = new System.Drawing.Point(0, 930);
            this.panel_salarySubMenu.Name = "panel_salarySubMenu";
            this.panel_salarySubMenu.Size = new System.Drawing.Size(203, 150);
            this.panel_salarySubMenu.TabIndex = 11;
            // 
            // sbtn_salaryReport
            // 
            this.sbtn_salaryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryReport.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryReport.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryReport.Location = new System.Drawing.Point(0, 100);
            this.sbtn_salaryReport.Name = "sbtn_salaryReport";
            this.sbtn_salaryReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryReport.Size = new System.Drawing.Size(203, 50);
            this.sbtn_salaryReport.TabIndex = 2;
            this.sbtn_salaryReport.Text = "财务报表";
            this.sbtn_salaryReport.UseVisualStyleBackColor = true;
            this.sbtn_salaryReport.Click += new System.EventHandler(this.sbtn_salaryReport_Click);
            // 
            // sbtn_salaryAdd
            // 
            this.sbtn_salaryAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryAdd.Location = new System.Drawing.Point(0, 50);
            this.sbtn_salaryAdd.Name = "sbtn_salaryAdd";
            this.sbtn_salaryAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryAdd.Size = new System.Drawing.Size(203, 50);
            this.sbtn_salaryAdd.TabIndex = 1;
            this.sbtn_salaryAdd.Text = "录入薪资";
            this.sbtn_salaryAdd.UseVisualStyleBackColor = true;
            this.sbtn_salaryAdd.Click += new System.EventHandler(this.sbtn_salaryAdd_Click);
            // 
            // sbtn_salaryInfo
            // 
            this.sbtn_salaryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_salaryInfo.Name = "sbtn_salaryInfo";
            this.sbtn_salaryInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryInfo.Size = new System.Drawing.Size(203, 50);
            this.sbtn_salaryInfo.TabIndex = 0;
            this.sbtn_salaryInfo.Text = "薪资信息";
            this.sbtn_salaryInfo.UseVisualStyleBackColor = true;
            this.sbtn_salaryInfo.Click += new System.EventHandler(this.sbtn_salaryInfo_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_salary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_salary.Image = ((System.Drawing.Image)(resources.GetObject("btn_salary.Image")));
            this.btn_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.Location = new System.Drawing.Point(0, 875);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_salary.Size = new System.Drawing.Size(203, 55);
            this.btn_salary.TabIndex = 10;
            this.btn_salary.Text = "  薪资管理";
            this.btn_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // panel_attendanceSubMenu
            // 
            this.panel_attendanceSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_attendanceSubMenu.Controls.Add(this.sbtn_attendanceAdd);
            this.panel_attendanceSubMenu.Controls.Add(this.sbtn_attendanceInfo);
            this.panel_attendanceSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_attendanceSubMenu.Location = new System.Drawing.Point(0, 775);
            this.panel_attendanceSubMenu.Name = "panel_attendanceSubMenu";
            this.panel_attendanceSubMenu.Size = new System.Drawing.Size(203, 100);
            this.panel_attendanceSubMenu.TabIndex = 9;
            // 
            // sbtn_attendanceAdd
            // 
            this.sbtn_attendanceAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_attendanceAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_attendanceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_attendanceAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_attendanceAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_attendanceAdd.Location = new System.Drawing.Point(0, 50);
            this.sbtn_attendanceAdd.Name = "sbtn_attendanceAdd";
            this.sbtn_attendanceAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_attendanceAdd.Size = new System.Drawing.Size(203, 50);
            this.sbtn_attendanceAdd.TabIndex = 1;
            this.sbtn_attendanceAdd.Text = "录入考勤";
            this.sbtn_attendanceAdd.UseVisualStyleBackColor = true;
            this.sbtn_attendanceAdd.Click += new System.EventHandler(this.sbtn_attendanceAdd_Click);
            // 
            // sbtn_attendanceInfo
            // 
            this.sbtn_attendanceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_attendanceInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_attendanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_attendanceInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_attendanceInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_attendanceInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_attendanceInfo.Name = "sbtn_attendanceInfo";
            this.sbtn_attendanceInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_attendanceInfo.Size = new System.Drawing.Size(203, 50);
            this.sbtn_attendanceInfo.TabIndex = 0;
            this.sbtn_attendanceInfo.Text = "考勤信息";
            this.sbtn_attendanceInfo.UseVisualStyleBackColor = true;
            this.sbtn_attendanceInfo.Click += new System.EventHandler(this.sbtn_attendanceInfo_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_attendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_attendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance.Image")));
            this.btn_attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendance.Location = new System.Drawing.Point(0, 720);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_attendance.Size = new System.Drawing.Size(203, 55);
            this.btn_attendance.TabIndex = 8;
            this.btn_attendance.Text = "  考勤管理";
            this.btn_attendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_attendance.UseVisualStyleBackColor = true;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // panel_empSubMenu
            // 
            this.panel_empSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_empSubMenu.Controls.Add(this.sbtn_empAdd);
            this.panel_empSubMenu.Controls.Add(this.sbtn_empFamily);
            this.panel_empSubMenu.Controls.Add(this.sbtn_empInfo);
            this.panel_empSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empSubMenu.Location = new System.Drawing.Point(0, 570);
            this.panel_empSubMenu.Name = "panel_empSubMenu";
            this.panel_empSubMenu.Size = new System.Drawing.Size(203, 150);
            this.panel_empSubMenu.TabIndex = 7;
            // 
            // sbtn_empAdd
            // 
            this.sbtn_empAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_empAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empAdd.Location = new System.Drawing.Point(0, 100);
            this.sbtn_empAdd.Name = "sbtn_empAdd";
            this.sbtn_empAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empAdd.Size = new System.Drawing.Size(203, 50);
            this.sbtn_empAdd.TabIndex = 2;
            this.sbtn_empAdd.Text = "添加职工";
            this.sbtn_empAdd.UseVisualStyleBackColor = true;
            this.sbtn_empAdd.Click += new System.EventHandler(this.sbtn_empAdd_Click);
            // 
            // sbtn_empFamily
            // 
            this.sbtn_empFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empFamily.FlatAppearance.BorderSize = 0;
            this.sbtn_empFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empFamily.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empFamily.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empFamily.Location = new System.Drawing.Point(0, 50);
            this.sbtn_empFamily.Name = "sbtn_empFamily";
            this.sbtn_empFamily.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empFamily.Size = new System.Drawing.Size(203, 50);
            this.sbtn_empFamily.TabIndex = 1;
            this.sbtn_empFamily.Text = "      职工家庭关系";
            this.sbtn_empFamily.UseVisualStyleBackColor = true;
            this.sbtn_empFamily.Click += new System.EventHandler(this.sbtn_empFamily_Click);
            // 
            // sbtn_empInfo
            // 
            this.sbtn_empInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_empInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_empInfo.Name = "sbtn_empInfo";
            this.sbtn_empInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empInfo.Size = new System.Drawing.Size(203, 50);
            this.sbtn_empInfo.TabIndex = 0;
            this.sbtn_empInfo.Text = "职工信息";
            this.sbtn_empInfo.UseVisualStyleBackColor = true;
            this.sbtn_empInfo.Click += new System.EventHandler(this.sbtn_empInfo_Click);
            // 
            // btn_emp
            // 
            this.btn_emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_emp.FlatAppearance.BorderSize = 0;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_emp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp.Image")));
            this.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emp.Location = new System.Drawing.Point(0, 515);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_emp.Size = new System.Drawing.Size(203, 55);
            this.btn_emp.TabIndex = 6;
            this.btn_emp.Text = "  教职工管理";
            this.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emp.UseVisualStyleBackColor = true;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // panel_teacherSubMenu
            // 
            this.panel_teacherSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_teacherSubMenu.Controls.Add(this.sbtn_teaAdd);
            this.panel_teacherSubMenu.Controls.Add(this.sbtn_teaFamily);
            this.panel_teacherSubMenu.Controls.Add(this.sbtn_teaInfo);
            this.panel_teacherSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_teacherSubMenu.Location = new System.Drawing.Point(0, 365);
            this.panel_teacherSubMenu.Name = "panel_teacherSubMenu";
            this.panel_teacherSubMenu.Size = new System.Drawing.Size(203, 150);
            this.panel_teacherSubMenu.TabIndex = 5;
            // 
            // sbtn_teaAdd
            // 
            this.sbtn_teaAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_teaAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_teaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_teaAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_teaAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_teaAdd.Location = new System.Drawing.Point(0, 100);
            this.sbtn_teaAdd.Name = "sbtn_teaAdd";
            this.sbtn_teaAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_teaAdd.Size = new System.Drawing.Size(203, 50);
            this.sbtn_teaAdd.TabIndex = 2;
            this.sbtn_teaAdd.Text = "添加教师";
            this.sbtn_teaAdd.UseVisualStyleBackColor = true;
            this.sbtn_teaAdd.Click += new System.EventHandler(this.sbtn_teaAdd_Click);
            // 
            // sbtn_teaFamily
            // 
            this.sbtn_teaFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_teaFamily.FlatAppearance.BorderSize = 0;
            this.sbtn_teaFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_teaFamily.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_teaFamily.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_teaFamily.Location = new System.Drawing.Point(0, 50);
            this.sbtn_teaFamily.Name = "sbtn_teaFamily";
            this.sbtn_teaFamily.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_teaFamily.Size = new System.Drawing.Size(203, 50);
            this.sbtn_teaFamily.TabIndex = 1;
            this.sbtn_teaFamily.Text = "      教师家庭关系";
            this.sbtn_teaFamily.UseVisualStyleBackColor = true;
            this.sbtn_teaFamily.Click += new System.EventHandler(this.sbtn_teaFamily_Click);
            // 
            // sbtn_teaInfo
            // 
            this.sbtn_teaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_teaInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_teaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_teaInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_teaInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_teaInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_teaInfo.Name = "sbtn_teaInfo";
            this.sbtn_teaInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_teaInfo.Size = new System.Drawing.Size(203, 50);
            this.sbtn_teaInfo.TabIndex = 0;
            this.sbtn_teaInfo.Text = "教师信息";
            this.sbtn_teaInfo.UseVisualStyleBackColor = true;
            this.sbtn_teaInfo.Click += new System.EventHandler(this.sbtn_teaInfo_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_teacher.FlatAppearance.BorderSize = 0;
            this.btn_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_teacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_teacher.Image = ((System.Drawing.Image)(resources.GetObject("btn_teacher.Image")));
            this.btn_teacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher.Location = new System.Drawing.Point(0, 310);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_teacher.Size = new System.Drawing.Size(203, 55);
            this.btn_teacher.TabIndex = 4;
            this.btn_teacher.Text = "  教师管理";
            this.btn_teacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // panel_deptSubMenu
            // 
            this.panel_deptSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_deptSubMenu.Controls.Add(this.sbtn_deptAdd);
            this.panel_deptSubMenu.Controls.Add(this.sbtn_deptInfo);
            this.panel_deptSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_deptSubMenu.Location = new System.Drawing.Point(0, 210);
            this.panel_deptSubMenu.Name = "panel_deptSubMenu";
            this.panel_deptSubMenu.Size = new System.Drawing.Size(203, 100);
            this.panel_deptSubMenu.TabIndex = 3;
            // 
            // sbtn_deptAdd
            // 
            this.sbtn_deptAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_deptAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_deptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_deptAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_deptAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_deptAdd.Location = new System.Drawing.Point(0, 50);
            this.sbtn_deptAdd.Name = "sbtn_deptAdd";
            this.sbtn_deptAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_deptAdd.Size = new System.Drawing.Size(203, 50);
            this.sbtn_deptAdd.TabIndex = 1;
            this.sbtn_deptAdd.Text = "添加部门";
            this.sbtn_deptAdd.UseVisualStyleBackColor = true;
            this.sbtn_deptAdd.Click += new System.EventHandler(this.sbtn_deptAdd_Click);
            // 
            // sbtn_deptInfo
            // 
            this.sbtn_deptInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_deptInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_deptInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_deptInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_deptInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_deptInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_deptInfo.Name = "sbtn_deptInfo";
            this.sbtn_deptInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_deptInfo.Size = new System.Drawing.Size(203, 50);
            this.sbtn_deptInfo.TabIndex = 0;
            this.sbtn_deptInfo.Text = "部门信息";
            this.sbtn_deptInfo.UseVisualStyleBackColor = true;
            this.sbtn_deptInfo.Click += new System.EventHandler(this.sbtn_deptInfo_Click);
            // 
            // btn_dept
            // 
            this.btn_dept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dept.FlatAppearance.BorderSize = 0;
            this.btn_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dept.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dept.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dept.Image = ((System.Drawing.Image)(resources.GetObject("btn_dept.Image")));
            this.btn_dept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dept.Location = new System.Drawing.Point(0, 155);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_dept.Size = new System.Drawing.Size(203, 55);
            this.btn_dept.TabIndex = 2;
            this.btn_dept.Text = "  部门管理";
            this.btn_dept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dept.UseVisualStyleBackColor = true;
            this.btn_dept.Click += new System.EventHandler(this.btn_dept_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 100);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(203, 55);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "  首 页";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(203, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geek HRMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.panel_bottom.Controls.Add(this.label_time);
            this.panel_bottom.Controls.Add(this.label_userRole);
            this.panel_bottom.Controls.Add(this.label2);
            this.panel_bottom.Controls.Add(this.label_logOut);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(220, 760);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1060, 40);
            this.panel_bottom.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(799, 10);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(92, 21);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "HH:MM:SS";
            // 
            // label_userRole
            // 
            this.label_userRole.AutoSize = true;
            this.label_userRole.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userRole.ForeColor = System.Drawing.Color.White;
            this.label_userRole.Location = new System.Drawing.Point(89, 10);
            this.label_userRole.Name = "label_userRole";
            this.label_userRole.Size = new System.Drawing.Size(137, 21);
            this.label_userRole.TabIndex = 0;
            this.label_userRole.Text = "root (系统管理员)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "当前用户:";
            // 
            // label_logOut
            // 
            this.label_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_logOut.AutoSize = true;
            this.label_logOut.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_logOut.ForeColor = System.Drawing.Color.White;
            this.label_logOut.Location = new System.Drawing.Point(974, 9);
            this.label_logOut.Name = "label_logOut";
            this.label_logOut.Size = new System.Drawing.Size(74, 21);
            this.label_logOut.TabIndex = 0;
            this.label_logOut.Text = "退出登录";
            this.label_logOut.Click += new System.EventHandler(this.label_logOut_Click);
            this.label_logOut.MouseLeave += new System.EventHandler(this.label_logOut_MouseLeave);
            this.label_logOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_logOut_MouseMove);
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(220, 50);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1060, 710);
            this.panel_childForm.TabIndex = 0;
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_bigMenu);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_bigMenu.ResumeLayout(false);
            this.panel_salarySubMenu.ResumeLayout(false);
            this.panel_attendanceSubMenu.ResumeLayout(false);
            this.panel_empSubMenu.ResumeLayout(false);
            this.panel_teacherSubMenu.ResumeLayout(false);
            this.panel_deptSubMenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bigMenu;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_deptSubMenu;
        private System.Windows.Forms.Button sbtn_deptInfo;
        private System.Windows.Forms.Button sbtn_deptAdd;
        private System.Windows.Forms.Panel panel_salarySubMenu;
        private System.Windows.Forms.Button sbtn_salaryReport;
        private System.Windows.Forms.Button sbtn_salaryAdd;
        private System.Windows.Forms.Button sbtn_salaryInfo;
        private System.Windows.Forms.Panel panel_attendanceSubMenu;
        private System.Windows.Forms.Button sbtn_attendanceAdd;
        private System.Windows.Forms.Button sbtn_attendanceInfo;
        private System.Windows.Forms.Panel panel_empSubMenu;
        private System.Windows.Forms.Button sbtn_empAdd;
        private System.Windows.Forms.Button sbtn_empFamily;
        private System.Windows.Forms.Button sbtn_empInfo;
        private System.Windows.Forms.Panel panel_teacherSubMenu;
        private System.Windows.Forms.Button sbtn_teaAdd;
        private System.Windows.Forms.Button sbtn_teaFamily;
        private System.Windows.Forms.Button sbtn_teaInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Label label_logOut;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btn_dept;
        public System.Windows.Forms.Button btn_apply;
        public System.Windows.Forms.Button btn_salary;
        public System.Windows.Forms.Button btn_attendance;
        public System.Windows.Forms.Button btn_emp;
        public System.Windows.Forms.Button btn_teacher;
        public System.Windows.Forms.Button btn_personalInfo;
        public System.Windows.Forms.Button btn_systemManage;
        public System.Windows.Forms.Label label_userRole;

    }
}