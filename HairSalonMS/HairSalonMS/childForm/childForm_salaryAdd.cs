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
    public partial class childForm_salaryAdd : Form
    {
        public childForm_salaryAdd()
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
                numericUpDown_baseSalary.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[1].Value);
                numericUpDown_jiangjin.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[2].Value);
                numericUpDown_butie.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[3].Value);
                numericUpDown_jiabanfei.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[4].Value);
                numericUpDown_yingkou.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[5].Value);
                numericUpDown_yingfa.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[6].Value);
                numericUpDown_shuilv.Value = Convert.ToInt32((Convert.ToDouble(dataGridView_salary.Rows[index].Cells[7].Value)) * 100);
                numericUpDown_realsalary.Value = Convert.ToInt32(dataGridView_salary.Rows[index].Cells[8].Value);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string empNo = label_empNo.Text;
            string baseSalary = numericUpDown_baseSalary.Value.ToString();
            string jiangjin = numericUpDown_jiangjin.Value.ToString();
            string butie = numericUpDown_butie.Value.ToString();
            string jiabanfei = numericUpDown_jiabanfei.Value.ToString();
            string yingkou = numericUpDown_yingkou.Value.ToString();
            string yingfa = numericUpDown_yingfa.Value.ToString();
            string shuilv = (Convert.ToDouble(numericUpDown_shuilv.Value)/100).ToString();
            string realSalary = numericUpDown_realsalary.Value.ToString();


            string sqlStr_insert = "update t_salary set baseSalary ='" + baseSalary + "',bonus = '" + jiangjin + "',subsidies = '" + butie + "',overtimePay = '" + jiabanfei + "',deductPay= '" + yingkou + "',salary = '" + yingfa + "',rate = '" + shuilv + "',realSalary = '" + realSalary + "' where empNo = '" + empNo + "';";
            MessageBox.Show(sqlStr_insert);
            MySqlCommand sqlCommand = new MySqlCommand(sqlStr_insert, mySqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("录入薪资成功！");
            }
        }
    }
}
