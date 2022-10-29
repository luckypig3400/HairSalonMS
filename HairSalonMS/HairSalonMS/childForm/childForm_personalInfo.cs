using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace SHRMS.childForm
{
    public partial class childForm_personalInfo : Form
    {
        public childForm_personalInfo()
        {
            InitializeComponent();
            panel_changePwd02.Visible = false;
        }

        string conStr = GlobalData.connectionStr;

        private void btn_showCPwd_Click(object sender, EventArgs e)
        {
            panel_changePwd02.Visible = true;
            panel_changePwd01.Visible = false;
        }

        private void btn_cPwdDone_Click(object sender, EventArgs e)
        {
            string oldPwd = textBox_oldPwd.Text;
            string newPwd01 = textBox_newPwd01.Text;
            string newPwd02 = textBox_newPwd02.Text;
            if (newPwd01 != newPwd02)
            {
                MessageBox.Show("您输入的新密码不一致！请确认后再输入！");
                return;
            }
            else
            {
                MySqlConnection mySqlConnection = new MySqlConnection(conStr);
                mySqlConnection.Open();
                string sqlStr_getoldPwd = "select password from t_user where username = '" + GlobalData.username + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(sqlStr_getoldPwd, mySqlConnection);
                if (oldPwd != (string)mySqlCommand.ExecuteScalar())
                {
                    MessageBox.Show("你输入的旧密码不正确，请确认后重试！");
                    return;
                }
                else
                {
                    string sqlstr_update = "update t_user set password='" + newPwd01 + "' where username = '" + GlobalData.username + "';";
                    //MessageBox.Show(sqlstr_update);
                    mySqlCommand.CommandText = sqlstr_update;
                    if (mySqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改密码成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！未知错误");
                    }
                }
                mySqlConnection.Close();
            }

        }

        private void button_cPwdCancel_Click(object sender, EventArgs e)
        {
            panel_changePwd02.Visible = false;
            panel_changePwd01.Visible = true;
        }

        private void childForm_personalInfo_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            label_hello.Text = "Hello  " + GlobalData.username + "!";
            label_uname.Text = GlobalData.username;
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            string sqlStr_getRole = "select empNo,role,email from t_user where username = '" + GlobalData.username + "';";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStr_getRole, mySqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            string empNo = reader["empNo"].ToString();
            string email = reader["email"].ToString();
            string role = reader["role"].ToString();
            reader.Close();
            mySqlConnection.Close();
            label_empNo.Text = empNo;
            label_email.Text = email;
            label_role.Text = role;

            List<Task> tasklist = new List<Task>();//创建多线程列表

            //封装委托，并创建线程任务、读取t_attendance表
            Task task_att = new Task(() =>
            {
                MySqlConnection mySqlConnection01 = new MySqlConnection(conStr);
                mySqlConnection01.Open();
                string sqlStr_att = "select * from t_attendance where empNo = '" + empNo + "';";
                MySqlCommand mySqlCommand_att = new MySqlCommand(sqlStr_att, mySqlConnection01);
                MySqlDataReader reader_att = mySqlCommand_att.ExecuteReader();
                reader_att.Read();

                label_late.Text = reader_att["lateNumber"].ToString() + " 次";
                label_earlyLeave.Text = reader_att["earlyLeaveNumber"].ToString() + " 次";
                label_kuang.Text = reader_att["absenteeism"].ToString() + " 次";
                label_shouldDay.Text = reader_att["attendanceDays"].ToString() + " 天";
                label_realDay.Text = reader_att["actualDays"].ToString() + " 天";
                label_overTime.Text = reader_att["overtimeHours"].ToString() + " 小时";
                reader_att.Close();
                mySqlConnection01.Close();
            });

            //封装委托，并创建线程任务、读取t_salary表
            Task task_sal = new Task(() =>
            {
                MySqlConnection mySqlConnection02 = new MySqlConnection(conStr);
                mySqlConnection02.Open();

                string sqlStr_sal = "select * from t_salary where empNo = '" + empNo + "';";
                MySqlCommand mySqlCommand_sal = new MySqlCommand(sqlStr_sal, mySqlConnection02);
                MySqlDataReader reader_sal = mySqlCommand_sal.ExecuteReader();
                reader_sal.Read();

                label_baseSalary.Text = reader_sal["baseSalary"].ToString() + " 元";
                label_jiangjin.Text = reader_sal["bonus"].ToString() + " 元";
                label_butie.Text = reader_sal["subsidies"].ToString() + " 元";
                label_jiabanfei.Text = reader_sal["overtimePay"].ToString() + " 元";
                label_yingkou.Text = reader_sal["deductPay"].ToString() + " 元";
                label_yingfa.Text = reader_sal["salary"].ToString() + " 元";
                label_shuilv.Text = (Convert.ToDouble(reader_sal["rate"]) * 100).ToString() + " %";
                label_realSalary.Text = reader_sal["realSalary"].ToString() + " 元";
                reader_sal.Close();
                mySqlConnection02.Close();
            });

            //封装委托，并创建线程任务、进行联表查询获取基本信息
            Task task_Info = new Task(() =>
            {
                MySqlConnection mySqlConnection03 = new MySqlConnection(conStr);
                mySqlConnection03.Open();

                string sqlStr_Info = @"select 
	tea.name,dept.deptName,tea.gender,tea.age
from 
	t_teacher tea
join
	t_department dept
on
	tea.departmentNo = dept.departmentNo
where
	tea.teacherNo = '" + empNo + "';";
                MySqlCommand mySqlCommand_Info = new MySqlCommand(sqlStr_Info, mySqlConnection03);
                MySqlDataReader reader_Info = mySqlCommand_Info.ExecuteReader();
                reader_Info.Read();

                label_name.Text = reader_Info[0].ToString();
                label_dept.Text = reader_Info[1].ToString();
                label_gender.Text = reader_Info[2].ToString();
                label_age.Text = reader_Info[3].ToString();
                reader_Info.Close();
                mySqlConnection03.Close();
            });

            //向线程列表里添加多线程任务
            tasklist.Add(task_att);
            tasklist.Add(task_sal);
            tasklist.Add(task_Info);

            //启动创建的多线程任务
            task_att.Start();
            task_sal.Start();
            task_Info.Start();

            //Task.WaitAll(tasklist.ToArray());
        }
    }
}
