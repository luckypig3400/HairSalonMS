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
    public partial class childForm_salaryInfo : Form
    {
        public childForm_salaryInfo()
        {
            InitializeComponent();
        }

        string conStr = GlobalData.connectionStr;

        private void btn_query_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            string sqlStr = "select * from t_salary where empNo like '%" + textBox_str.Text + "%';";
            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlStr, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_salary");
            dataGridView_salary.DataSource = dataSet.Tables["t_salary"];
            dataGridView_salary.AutoResizeColumnHeadersHeight();
            dataGridView_salary.AutoResizeColumns();
            dataGridView_salary.AutoResizeRows();
            mySqlConnection.Close();
        }

        private void btn_allInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sqlStr = "select * from t_salary where empNo;";
            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlStr, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_salary");
            dataGridView_salary.DataSource = dataSet.Tables["t_salary"];
            dataGridView_salary.AutoResizeColumnHeadersHeight();
            dataGridView_salary.AutoResizeColumns();
            dataGridView_salary.AutoResizeRows();
            mySqlConnection.Close();
        }

        private void dataGridView_salary_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dataGridView_salary.CurrentRow.Index;
            string empNo = dataGridView_salary.Rows[index].Cells[0].Value.ToString();
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
                label_baseSalary.Text = dataGridView_salary.Rows[index].Cells[1].Value.ToString()+" 元";
                label_jiangjin.Text = dataGridView_salary.Rows[index].Cells[2].Value.ToString() + " 元";
                label_butie.Text = dataGridView_salary.Rows[index].Cells[3].Value.ToString() + " 元";
                label_jiabanfei.Text = dataGridView_salary.Rows[index].Cells[4].Value.ToString() + " 元";
                label_yingkou.Text = dataGridView_salary.Rows[index].Cells[5].Value.ToString() + " 元";
                label_yingfa.Text = dataGridView_salary.Rows[index].Cells[6].Value.ToString() + " 元";
                label_shuilv.Text = (Convert.ToDouble(dataGridView_salary.Rows[index].Cells[7].Value)*100) .ToString() + "%";
                label_realSalary.Text = dataGridView_salary.Rows[index].Cells[8].Value.ToString() + " 元";
            }
        }
    }
}
