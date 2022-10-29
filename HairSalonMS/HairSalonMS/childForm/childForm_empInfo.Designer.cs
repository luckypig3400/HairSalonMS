namespace SHRMS.childForm
{
    partial class childForm_empInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_str = new System.Windows.Forms.TextBox();
            this.label_query = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_queryType = new System.Windows.Forms.Label();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.dataGridView_emp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 44);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "位置：教职工管理 > 职工信息";
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.groupBox1);
            this.panel_center.Controls.Add(this.btn_save);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Controls.Add(this.btn_delete);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_center.Location = new System.Drawing.Point(0, 44);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1060, 164);
            this.panel_center.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_str);
            this.groupBox1.Controls.Add(this.label_query);
            this.groupBox1.Controls.Add(this.comboBox_type);
            this.groupBox1.Controls.Add(this.label_queryType);
            this.groupBox1.Controls.Add(this.comboBox_dept);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 147);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // textBox_str
            // 
            this.textBox_str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_str.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_str.Location = new System.Drawing.Point(486, 41);
            this.textBox_str.Name = "textBox_str";
            this.textBox_str.Size = new System.Drawing.Size(141, 26);
            this.textBox_str.TabIndex = 49;
            // 
            // label_query
            // 
            this.label_query.AutoSize = true;
            this.label_query.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_query.Location = new System.Drawing.Point(332, 41);
            this.label_query.Name = "label_query";
            this.label_query.Size = new System.Drawing.Size(150, 25);
            this.label_query.TabIndex = 51;
            this.label_query.Text = "按职工编号查询:";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_type.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "按教师编号",
            "按教师姓名"});
            this.comboBox_type.Location = new System.Drawing.Point(149, 93);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(143, 33);
            this.comboBox_type.TabIndex = 48;
            // 
            // label_queryType
            // 
            this.label_queryType.AutoSize = true;
            this.label_queryType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_queryType.Location = new System.Drawing.Point(55, 97);
            this.label_queryType.Name = "label_queryType";
            this.label_queryType.Size = new System.Drawing.Size(107, 25);
            this.label_queryType.TabIndex = 50;
            this.label_queryType.Text = "查询类型：";
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Location = new System.Drawing.Point(149, 41);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(143, 29);
            this.comboBox_dept.TabIndex = 47;
            // 
            // btn_query
            // 
            this.btn_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.btn_query.FlatAppearance.BorderSize = 0;
            this.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_query.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_query.ForeColor = System.Drawing.Color.White;
            this.btn_query.Location = new System.Drawing.Point(486, 86);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(141, 40);
            this.btn_query.TabIndex = 31;
            this.btn_query.Text = "点击查询";
            this.btn_query.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "职工所在部门：";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(882, 56);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 46);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "保  存";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(695, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "注意：本表可修改和删除职工信息，请谨慎操作";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(713, 56);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 46);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "删  除";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.dataGridView_emp);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(0, 208);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1060, 502);
            this.panel_bottom.TabIndex = 54;
            // 
            // dataGridView_emp
            // 
            this.dataGridView_emp.AllowUserToAddRows = false;
            this.dataGridView_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_emp.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_emp.Name = "dataGridView_emp";
            this.dataGridView_emp.RowTemplate.Height = 23;
            this.dataGridView_emp.Size = new System.Drawing.Size(1060, 502);
            this.dataGridView_emp.TabIndex = 0;
            // 
            // childForm_empInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_empInfo";
            this.Text = "childForm_empInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_str;
        private System.Windows.Forms.Label label_query;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_queryType;
        private System.Windows.Forms.ComboBox comboBox_dept;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.DataGridView dataGridView_emp;
    }
}