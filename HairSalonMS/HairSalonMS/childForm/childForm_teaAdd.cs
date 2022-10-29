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
    public partial class childForm_teaAdd : Form
    {
        public childForm_teaAdd()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;
        string deptNo = string.Empty;
        string birthday = string.Empty;
        private void childForm_teaAdd_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sqlStr = "select deptName from t_department;";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlStr, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                comboBox_dept.Items.Add(mySqlDataReader["deptName"]);
            }
            mySqlDataReader.Close();
            mySqlConnection.Close();
        }

        private void btn_teaAdd_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;

            if (radioButton_man.Checked)
            {
                gender = "男";
            }
            else if (radioButton_woman.Checked)
            {
                gender = "女";
            }
            else
            {
                MessageBox.Show("抱歉，您还没有选择性别！");
                return;
            }

            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sqlStr = "insert into t_user(username,password,email,role,empNo) values('" + textBox_uName.Text + "','" + textBox_uPwd.Text + "','" + textBox_email.Text + "','教师','" + numericUpDown_No.Value.ToString() + "');";
            //MessageBox.Show(sqlStr);

            MySqlCommand mySqlCommand = new MySqlCommand(sqlStr, mySqlConnection);
            int n = mySqlCommand.ExecuteNonQuery();
            if (n > 0)
            {
                string sqlStr_insert = @"insert into t_teacher(teacherNo,departmentNo,name,gender,age,stuStatus,education,birthday,teaching,IDcardNo,bankCardNo,status) values
('" + numericUpDown_No.Value.ToString() + "','" + deptNo + "','" + textBox_Name.Text + "','" + gender + "','" + numericUpDown_age.Value.ToString() + "','" + textBox_stuS.Text + "','" + comboBox_edu.Text + @"',
'" + birthday + "','" + textBox_teaching.Text + "','" + numericUpDown_ID.Value.ToString() + "','" + numericUpDown_bankCardNo.Value.ToString() + "','在职')";
                //MessageBox.Show(sqlStr_insert);
                mySqlCommand.CommandText = sqlStr_insert;
                int m = mySqlCommand.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("添加教师成功！");
                }
            }
            mySqlConnection.Close();
        }

        private void comboBox_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deptName = comboBox_dept.Text;
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sqlStr = "select departmentNo,deptName from t_department;";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlStr, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                if (mySqlDataReader["deptName"].ToString() == deptName)
                {
                    deptNo = mySqlDataReader["departmentNo"].ToString();
                }
            }
            mySqlDataReader.Close();
            mySqlConnection.Close();
        }

        private void monthCalendar_birthday_DateChanged(object sender, DateRangeEventArgs e)
        {
            birthday = monthCalendar_birthday.SelectionStart.ToShortDateString();
            label_birthday.Text = birthday;
        }
    }
}
