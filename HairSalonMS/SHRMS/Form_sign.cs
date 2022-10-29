using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace SHRMS
{
    public partial class Form_sign : Form
    {
        public Form_sign()
        {
            InitializeComponent();
            panel_signUp.Visible = false;
        }

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minsize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_close.ForeColor = Color.Red;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            this.btn_close.ForeColor = Color.FromArgb(47, 101, 189);
        }



        private void label_register_Click(object sender, EventArgs e)
        {
            //panel_signIn.Visible = false;
            panel_signUp.Visible = true;
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            //panel_signIn.Visible = true;
            panel_signUp.Visible = false;
        }


        private void label_sign_MouseHover(object sender, EventArgs e)
        {
            this.label_login.ForeColor = Color.FromArgb(0, 0, 64);
            this.label_register.ForeColor = Color.FromArgb(0, 0, 64);
        }
        private void label_sign_MouseLeave(object sender, EventArgs e)
        {
            this.label_login.ForeColor = Color.FromArgb(47, 101, 189);
            this.label_register.ForeColor = Color.FromArgb(47, 101, 189);
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string uname = textBox_username.Text;
            string upwd = textBox_password.Text;
            string rolename = string.Empty;
            string conStr = GlobalData.connectionStr;
            MySqlConnection mySqlConnection = new MySqlConnection(conStr);
            mySqlConnection.Open();
            string sql_str = "select role,username from t_user where username = '" + uname + "' and password = '" + upwd + "';";
            //MessageBox.Show(sql_str);
            MySqlCommand mySqlCommand = new MySqlCommand(sql_str, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
           
            if (mySqlDataReader.Read())
            {
                rolename = mySqlDataReader["role"].ToString();
                string uname_temp = mySqlDataReader["username"].ToString();
                mySqlDataReader.Close();
                GlobalData.username = uname_temp;
               
                this.Hide();
                Form_Main frm_main = new Form_Main();
                frm_main.Tag = FindForm();
                string sqlstr_role = "SELECT * FROM `t_rolepower` WHERE role = '" + rolename + "';";
                //MessageBox.Show(sqlstr_role);

                MySqlDataReader dr;
                mySqlCommand.CommandText = sqlstr_role;
                dr = mySqlCommand.ExecuteReader();
                dr.Read();

                frm_main.btn_dept.Visible = (bool)(dr["manage_dept"]);
                frm_main.btn_teacher.Visible = (bool)(dr["manage_teacher"]);
                frm_main.btn_emp.Visible = (bool)(dr["manage_emp"]);
                frm_main.btn_attendance.Visible = (bool)(dr["manege_attendance"]);
                frm_main.btn_salary.Visible = (bool)(dr["manage_salary"]);
                frm_main.btn_apply.Visible = (bool)(dr["apply"]);
                frm_main.btn_personalInfo.Visible = (bool)(dr["personalInfo"]);
                frm_main.btn_systemManage.Visible = (bool)(dr["managesystem"]);
                frm_main.label_userRole.Text = uname_temp + " (" + rolename + ")";
                frm_main.ShowDialog();
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码有误，请确认后再输入！");
            }

            mySqlConnection.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name_r = textBox_Rusername.Text;
            string pwd01_r = textBox_Rpwd01.Text;
            string pwd02_r = textBox_Rpwd02.Text;
            string email_r = textBox_Remail.Text;

            if (name_r == "" || pwd01_r == "" || pwd02_r == "" || email_r == "")
            {
                MessageBox.Show("检查数据合法性");
                return;
            }
            else
            {
                try
                {
                    if (Regex.IsMatch(email_r, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase))
                    {
                        // Successful match
                        if (pwd01_r == pwd02_r)
                        {
                            try
                            {
                                string conStr = GlobalData.connectionStr;
                                MySqlConnection mySqlConnection = new MySqlConnection(conStr);
                                mySqlConnection.Open();
                                string sql_str = "insert into t_user(username,password,email,role) values('" + name_r + "','" + pwd01_r + "','" + email_r + "','游客');";
                                //MessageBox.Show(sql_str);
                                MySqlCommand mySqlCommand = new MySqlCommand(sql_str, mySqlConnection);
                                mySqlCommand.ExecuteNonQuery();
                                MessageBox.Show("注册成功！快去登录吧！", "注册成功");
                            }
                            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                        }
                        else
                        {
                            MessageBox.Show("您两次输入的密码不相同，请确认后再输入");
                            return;
                        }
                    }
                    else
                    {
                        // Match attempt failed
                        MessageBox.Show("请输入正确的邮箱地址！", "邮箱地址不合法");
                        return;
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
