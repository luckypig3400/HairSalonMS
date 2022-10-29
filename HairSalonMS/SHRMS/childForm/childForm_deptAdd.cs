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
    public partial class childForm_deptAdd : Form
    {
        public childForm_deptAdd()
        {
            InitializeComponent();
        }
        string conStr = GlobalData.connectionStr;
        private void btn_deptAdd_Click(object sender, EventArgs e)
        {
            string deptNo = textBox_deptNo.Text;
            string deptName = textBox_deptName.Text;
            string deptAddress = textBox_deptAddress.Text;
            string deptTelephone = textBox_deptphone.Text;
            if (deptNo != "" || deptName != "" || deptAddress != "" || deptTelephone != "")
            {
                MySqlConnection mySqlConnection = new MySqlConnection(conStr);//实例化连接
                mySqlConnection.Open();//打开链接
                string strSql = "insert into t_department(departmentNo,deptName,address,telephone) values('" + deptNo + "','" + deptName + "','" + deptAddress + "','" + deptTelephone + "');";
                //MessageBox.Show(strSql);
                MySqlCommand mySqlCommand = new MySqlCommand(strSql, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("添加部门成功", "添加成功");
                mySqlConnection.Close();//关闭连接
            }
            else
            {
                MessageBox.Show("请检查数据合法性！");
            }

        }
    }
}
