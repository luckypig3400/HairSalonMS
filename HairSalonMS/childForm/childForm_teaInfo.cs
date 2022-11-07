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
    public partial class childForm_teaInfo : Form
    {
        public childForm_teaInfo()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;

        private void btn_query_Click(object sender, EventArgs e)
        {
            string deptNo = string.Empty;
            string queryType = string.Empty;
            string SQLstr_select = string.Empty;

            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();

            if (comboBox_dept.Text != "")
            {
                string deptName = comboBox_dept.Text;
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
            }

            if (comboBox_type.Text != "")
            {
                queryType = comboBox_type.Text;
            }

            if (deptNo != string.Empty)
            {
                if (queryType != string.Empty)
                {
                    if (queryType == "按教师编号")
                    {
                        SQLstr_select = "select * from t_teacher where departmentNo = '" + deptNo + "' and teacherNo like '%" + textBox_str.Text + "%';";
                        //MessageBox.Show(SQLstr_select);
                    }
                    else
                    {
                        SQLstr_select = "select * from t_teacher where departmentNo = '" + deptNo + "' and name like '%" + textBox_str.Text + "%';";
                        //MessageBox.Show(SQLstr_select);
                    }
                }
                else
                {
                    SQLstr_select = "select * from t_teacher where departmentNo = '" + deptNo + "';";
                    //MessageBox.Show(SQLstr_select);
                }
            }
            else
            {
                if (queryType != string.Empty)
                {
                    if (queryType == "按教师编号")
                    {
                        SQLstr_select = "select * from t_teacher where teacherNo like '%" + textBox_str.Text + "%';";
                        //MessageBox.Show(SQLstr_select);
                    }
                    else
                    {
                        SQLstr_select = "select * from t_teacher where name like '%" + textBox_str.Text + "%';";
                        //MessageBox.Show(SQLstr_select);
                    }
                }
                else
                {
                    SQLstr_select = "select * from t_teacher;";
                    //MessageBox.Show(SQLstr_select);
                }
            }
            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(SQLstr_select, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_teacher");
            dataGridView_tea.DataSource = dataSet.Tables["t_teacher"];
            dataGridView_tea.AutoResizeColumnHeadersHeight();
            dataGridView_tea.AutoResizeColumns();
            dataGridView_tea.AutoResizeRows();
            mySqlConnection.Close();
        }

        private void childForm_teaInfo_Load(object sender, EventArgs e)
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

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_query.Text = comboBox_type.Text + "查询:";
        }
    }
}
