using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SHRMS.childForm
{
    public partial class childForm_systemManage : Form
    {
        public childForm_systemManage()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;
        private void button_addAdmin_Click(object sender, EventArgs e)
        {
            string uname = textBox_uname.Text;
            string pwd = textBox_pwd.Text;
            string email = textBox_email.Text;

            if (uname == "" || pwd == "" || email == "")
            {
                MessageBox.Show("添加失败！请检查相关数据不能为空！");
            }
            else
            {
                MySqlConnection mySqlConnection = new MySqlConnection(conStr);
                mySqlConnection.Open();
                string sql_addStr = "insert into t_user(username,password,email,role) values('" + uname + "','" + pwd + "','" + email + "','管理员');";
                //MessageBox.Show(sql_addStr);
                MySqlCommand mySqlCommand = new MySqlCommand(sql_addStr, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("添加管理员【uname】成功！");
                }
                catch
                {
                    MessageBox.Show("添加管理员【uname】失败！请检查相关数据合法性！");
                }
                mySqlConnection.Close();
            }
        }

        private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = comboBox_role.Text;
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sql_selectStr = "select * from t_rolepower where role = '" + role + "';";
            //MessageBox.Show(sql_selectStr);
            MySqlCommand mySqlCommand = new MySqlCommand(sql_selectStr, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Read();

            checkBox_dept.Checked = (bool)(mySqlDataReader["manage_dept"]);
            checkBox_tea.Checked = (bool)(mySqlDataReader["manage_teacher"]);
            checkBox_emp.Checked = (bool)(mySqlDataReader["manage_emp"]);
            checkBox_atten.Checked = (bool)(mySqlDataReader["manege_attendance"]);
            checkBox_salary.Checked = (bool)(mySqlDataReader["manage_salary"]);
            checkBox_apply.Checked = (bool)(mySqlDataReader["apply"]);
            checkBox_info.Checked = (bool)(mySqlDataReader["personalInfo"]);
            mySqlDataReader.Close();
            mySqlConnection.Close();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            string role = comboBox_role.Text;
            if (role == "") { MessageBox.Show("抱歉，请选择你要授权的角色！","未选择角色",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            else
            {
                DialogResult resault = MessageBox.Show("Warning:您正在更改 " + role + " 的系统权限！\n请再次确认您要更改的权限是否合理！", "更改权限警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resault == DialogResult.Cancel)
                {
                    MessageBox.Show("修改权限已取消！");
                    return;
                }
                char dept_s = '0';
                char tea_s = '0';
                char emp_s = '0';
                char atten_s = '0';
                char salary_s = '0';
                char apply_s = '0';
                char info_s = '0';

                if (checkBox_dept.Checked == true) { dept_s = '1'; }
                if (checkBox_tea.Checked == true) { tea_s = '1'; }
                if (checkBox_emp.Checked == true) { emp_s = '1'; }
                if (checkBox_atten.Checked == true) { atten_s = '1'; }
                if (checkBox_salary.Checked == true) { salary_s = '1'; }
                if (checkBox_apply.Checked == true) { apply_s = '1'; }
                if (checkBox_info.Checked == true) { info_s = '1'; }

                MySqlConnection mySqlConnection = new MySqlConnection(conStr);
                mySqlConnection.Open();
                string sql_update = string.Format("update t_rolepower set manage_dept={0},manage_teacher={1},manage_emp={2},manege_attendance={3},manage_salary={4},apply={5},personalInfo={6} where role = '{7}';", dept_s, tea_s, emp_s, atten_s, salary_s, apply_s, info_s, role);
                //MessageBox.Show(sql_update);
                MySqlCommand mySqlCommand = new MySqlCommand(sql_update, mySqlConnection);

                try {
                    if(mySqlCommand.ExecuteNonQuery()>0)
                    MessageBox.Show("修改权限成功！");
                }
                catch {
                    MessageBox.Show("修改权限失败！未知错误！");
                }
                mySqlConnection.Close();
            }
        }
    }
}
