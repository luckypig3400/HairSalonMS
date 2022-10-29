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
    public partial class childForm_deptInfo : Form
    {
        public childForm_deptInfo()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;
        MySqlDataAdapter mySqlDataAdapter;
        DataTable dataTable;
        DataSet dataSet = new DataSet();

        private void btn_allDeptInfo_Click(object sender, EventArgs e)
        {
            //while(this.dataGridView_dept.Rows.Count!=0){
            //    //this.dataGridView_dept.Rows.RemoveAt(0);

            //    //DataTable dt = this.dataGridView_dept.DataSource as DataTable;
            //    //dt.Rows.Clear();
            //    //this.dataGridView_dept.DataSource = dt;

            //    //this.dataGridView_dept.DataSource = null;
            //}
            //dataSet.Tables["t_department"].Clear();
            //dataGridView_dept.Rows.Clear();
            
            dataSet.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sql_str = "select * from t_department;";
            mySqlDataAdapter = new MySqlDataAdapter(sql_str, mySqlConnection);
            mySqlDataAdapter.Fill(dataSet, "t_department");
            dataTable = dataSet.Tables["t_department"];
            dataGridView_dept.DataSource = dataTable.DefaultView;
            dataGridView_dept.AutoResizeColumnHeadersHeight();
            dataGridView_dept.AutoResizeColumns();
            dataGridView_dept.AutoResizeRows();
            mySqlConnection.Close();
        }

        private void dataGridView_dept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView_dept.CurrentRow.Index;
            label_deptNo.Text = dataGridView_dept.Rows[index].Cells[0].Value.ToString();
            textBox_deptname.Text = dataGridView_dept.Rows[index].Cells[1].Value.ToString();
            textBox_address.Text = dataGridView_dept.Rows[index].Cells[2].Value.ToString();
            textBox_telephone.Text = dataGridView_dept.Rows[index].Cells[4].Value.ToString();
            label_count.Text = dataGridView_dept.Rows[index].Cells[3].Value.ToString() + " 人";
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_sType.Text = comboBox_type.Text + "查询:";
        }

        private void btn_selectDept_Click(object sender, EventArgs e)
        {
            //dataSet = new DataSet();
            dataSet.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);//实例化连接
            mySqlConnection.Open();//打开链接

            if (label_sType.Text == "按部门名称查询:")
            {
                string strSql = "select * from t_department where deptName like '%" + textBox_str.Text + "%';";
                MySqlCommand mySqlCommand = new MySqlCommand(strSql, mySqlConnection);

                mySqlDataAdapter = new MySqlDataAdapter(strSql, mySqlConnection);
                mySqlDataAdapter.Fill(dataSet, "t_department");
                dataGridView_dept.DataSource = dataSet.Tables["t_department"];
            }
            else if (label_sType.Text == "按部门编号查询:")
            {
                string strSql = "select * from t_department where departmentNo like '%" + textBox_str.Text + "%';";
                MySqlCommand mySqlCommand = new MySqlCommand(strSql, mySqlConnection);

                mySqlDataAdapter = new MySqlDataAdapter(strSql, mySqlConnection);
                mySqlDataAdapter.Fill(dataSet, "t_department");
                dataGridView_dept.DataSource = dataSet.Tables["t_department"];
            }
            dataGridView_dept.AutoResizeColumnHeadersHeight();
            dataGridView_dept.AutoResizeColumns();
            dataGridView_dept.AutoResizeRows();
            mySqlConnection.Close();//关闭连接
        }

        private void btn_modifyDept_Click(object sender, EventArgs e)
        {
            if (dataGridView_dept.Rows.Count == 0)
            {
                MessageBox.Show("抱歉，您还没有选择相应的部门！");
            }
            else
            {
                int index = dataGridView_dept.CurrentRow.Index;
                string deptNo = label_deptNo.Text;
                string deptname = textBox_deptname.Text;
                string deptaddress = textBox_address.Text;
                string depttelephone = textBox_telephone.Text;

                if (deptNo == "0000")
                {
                    MessageBox.Show("抱歉，您还没有选择相应的部门！");
                }
                else
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(conStr);//实例化连接
                    mySqlConnection.Open();//打开链接
                    string strSql = "UPDATE t_department SET deptName = '" + deptname + "',address = '" + deptaddress + "',telephone = '" + depttelephone + "' WHERE departmentNo = '" + deptNo + "';";
                    //MessageBox.Show(strSql);
                    MySqlCommand mySqlCommand = new MySqlCommand(strSql, mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("修改部门成功", "修改成功");
                    mySqlConnection.Close();//关闭连接 
                }
            }
        }

        private void btn_deleteDept_Click(object sender, EventArgs e)
        {
            if (dataGridView_dept.Rows.Count == 0)
            {
                MessageBox.Show("抱歉，您还没有选择相应的部门！");
            }
            else
            {
                int index = dataGridView_dept.CurrentRow.Index;
                string deptNo = label_deptNo.Text;

                if (deptNo == "0000")
                {
                    MessageBox.Show("抱歉，您还没有选择相应的部门！");
                }
                else
                {
                    DialogResult resault = MessageBox.Show("确认要删除该部门？\n删除该部门后则该部门的员工信息也将会被删除！", "删除警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (resault == DialogResult.Cancel)
                    {
                        MessageBox.Show("删除已取消！");
                        return;
                    }
                    MySqlConnection mySqlConnection = new MySqlConnection(conStr);//实例化连接
                    mySqlConnection.Open();//打开链接
                    string strSql = "DELETE FROM t_department WHERE departmentNo =  '" + deptNo + "';";
                    MessageBox.Show(strSql);
                    //MessageBox.Show(strSql);
                    MySqlCommand mySqlCommand = new MySqlCommand(strSql, mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("删除部门成功", "删除成功");
                    mySqlConnection.Close();//关闭连接 
                }
            }
        }
    }
}
