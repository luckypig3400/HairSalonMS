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
    public partial class childForm_attendanceInfo : Form
    {
        public childForm_attendanceInfo()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;



        private void btn_allInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            string sqlStr = "select * from t_attendance;";
            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlStr, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_attendance");
            dataGridView_att.DataSource = dataSet.Tables["t_attendance"];
            dataGridView_att.AutoResizeColumnHeadersHeight();
            dataGridView_att.AutoResizeColumns();
            dataGridView_att.AutoResizeRows();
            mySqlConnection.Close();

        }

        private void btn_selectA_Click(object sender, EventArgs e)
        {

            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            string sqlStr = "select * from t_attendance where empNo like '%" + textBox_str.Text + "%';";
            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlStr, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_attendance");
            dataGridView_att.DataSource = dataSet.Tables["t_attendance"];
            dataGridView_att.AutoResizeColumnHeadersHeight();
            dataGridView_att.AutoResizeColumns();
            dataGridView_att.AutoResizeRows();
            mySqlConnection.Close();
        }

        private void dataGridView_att_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView_att.CurrentRow.Index;
            string empNo = dataGridView_att.Rows[index].Cells[0].Value.ToString();
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            string sqlStr_getRole = "select role from t_user where empNo = '" + empNo + "';";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStr_getRole, mySqlConnection);
            string role = (string)sqlCommand.ExecuteScalar();

            if (role == "教师")
            {
                string sqlStr_getBaseInfo = @"select 
	tea.name,dept.deptName
from 
	t_teacher tea
join
	t_department dept
on
	tea.departmentNo = dept.departmentNo
where
	tea.teacherNo = '" + empNo + "';";
                MySqlCommand Command = new MySqlCommand(sqlStr_getBaseInfo, mySqlConnection);
                MySqlDataReader reader = Command.ExecuteReader();
                reader.Read();

                label_name.Text = reader[0].ToString();
                label_dept.Text = reader[1].ToString();

                label_empNo.Text = empNo;
                label_role.Text = role;

                label_overTime.Text = dataGridView_att.Rows[index].Cells[3].Value.ToString()+" 小时";
                label_late.Text = dataGridView_att.Rows[index].Cells[4].Value.ToString() + " 次";
                label_earlyLeave.Text = dataGridView_att.Rows[index].Cells[5].Value.ToString() + " 次";
                label_absenteeism.Text = dataGridView_att.Rows[index].Cells[6].Value.ToString() + " 次";
                label_shoudDay.Text = dataGridView_att.Rows[index].Cells[1].Value.ToString() + " 天";
                label_realDay.Text = dataGridView_att.Rows[index].Cells[2].Value.ToString() + " 天";
            }
            else
            {
                //职工信息、、未完善
            }
        }
    }
}
