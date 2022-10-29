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
    public partial class childForm_attendanceAdd : Form
    {
        public childForm_attendanceAdd()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;
        private void btn_AllInfo_Click(object sender, EventArgs e)
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

        private void btn_query_Click(object sender, EventArgs e)
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

                numericUpDown_overTime.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[3].Value);
                numericUpDown_late.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[4].Value);
                numericUpDown_earlyLeave.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[5].Value);
                numericUpDown_absenteeism.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[6].Value);
                numericUpDown_shouldDay.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[1].Value);
                numericUpDown_realDay.Value = Convert.ToInt32(dataGridView_att.Rows[index].Cells[2].Value);
            }
        }

        private void btn_modifyAtt_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string empNo = label_empNo.Text;
            string overtime = numericUpDown_overTime.Value.ToString();
            string late = numericUpDown_late.Value.ToString();
            string earlyLeave = numericUpDown_earlyLeave.Value.ToString();
            string absenteeism = numericUpDown_absenteeism.Value.ToString();
            string shouldDay = numericUpDown_shouldDay.Value.ToString();
            string realDay = numericUpDown_realDay.Value.ToString();

            string sqlStr_insert = "update t_attendance set attendanceDays ='" + shouldDay + "',actualDays = '" + realDay + "',overtimeHours = '" + overtime + "',lateNumber = '" + late + "',earlyLeaveNumber= '" + earlyLeave + "',absenteeism = '" + absenteeism + "' where empNo = '" + empNo + "';";
            //MessageBox.Show(sqlStr_insert);
            MySqlCommand sqlCommand = new MySqlCommand(sqlStr_insert, mySqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("录入考勤成功！");
            }
        }
    }
}
