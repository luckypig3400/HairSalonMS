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
using SHRMS.childForm;

namespace SHRMS
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            panel_initialize();
            timer_time.Start();
            childForm_home frm = new childForm_home();
            openChildForm(frm);

        }

        private void panel_initialize()
        {
            panel_attendanceSubMenu.Visible = false;
            panel_deptSubMenu.Visible = false;
            panel_empSubMenu.Visible = false;
            panel_salarySubMenu.Visible = false;
            panel_teacherSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_attendanceSubMenu.Visible == true)
                panel_attendanceSubMenu.Visible = false;
            if (panel_deptSubMenu.Visible == true)
                panel_deptSubMenu.Visible = false;
            if (panel_empSubMenu.Visible == true)
                panel_empSubMenu.Visible = false;
            if (panel_salarySubMenu.Visible == true)
                panel_salarySubMenu.Visible = false;
            if (panel_teacherSubMenu.Visible == true)
                panel_teacherSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        Button btn_temp = new Button();
        Button btn_temp_sub = new Button();

        private void selectedBackground(Button selectedButton)
        {
            btn_temp_sub.BackColor = Color.FromArgb(57, 62, 70);
            btn_temp.BackColor = Color.FromArgb(42, 54, 59);
            btn_temp = selectedButton;
            btn_temp.BackColor = Color.FromArgb(0, 120, 215);
        }
        private void selectedBackground_sub(Button selectedButton)
        {
            btn_temp.BackColor = Color.FromArgb(42, 54, 59);
            btn_temp_sub.BackColor = Color.FromArgb(57, 62, 70);
            btn_temp_sub = selectedButton;
            btn_temp_sub.BackColor = Color.FromArgb(0, 120, 215);
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

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void openChildForm(Form childForm)
        {
            foreach (Control item in this.panel_childForm.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            childForm.TopLevel = false;
            //panel_childForm.Controls.Add(childForm);
            //childForm.MdiParent = this;
            childForm.Parent = this.panel_childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_home);
            hideSubMenu();
            childForm_home frm = new childForm_home();
            openChildForm(frm);
        }

        private void btn_dept_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_dept);
            showSubMenu(panel_deptSubMenu);
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_teacher);
            showSubMenu(panel_teacherSubMenu);
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_emp);
            showSubMenu(panel_empSubMenu);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_attendance);
            showSubMenu(panel_attendanceSubMenu);
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_salary);
            showSubMenu(panel_salarySubMenu);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_apply);
            hideSubMenu();
            childForm_apply frm = new childForm_apply();
            openChildForm(frm);

        }

        private void btn_personalInfo_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_personalInfo);
            hideSubMenu();
            childForm_personalInfo frm = new childForm_personalInfo();
            openChildForm(frm);
        }

        private void btn_systemManage_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_systemManage);
            hideSubMenu();
            childForm_systemManage frm = new childForm_systemManage();
            openChildForm(frm);
        }

        private void sbtn_deptInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_deptInfo);
            childForm_deptInfo frm = new childForm_deptInfo();
            openChildForm(frm);
        }

        private void sbtn_deptAdd_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_deptAdd);
            childForm_deptAdd frm = new childForm_deptAdd();
            openChildForm(frm);
        }

        private void sbtn_teaInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_teaInfo);
            childForm_teaInfo frm = new childForm_teaInfo();
            openChildForm(frm);
        }

        private void sbtn_teaFamily_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_teaFamily);
            childForm_teaFamily frm = new childForm_teaFamily();
            openChildForm(frm);
        }

        private void sbtn_teaAdd_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_teaAdd);
            childForm_teaAdd frm = new childForm_teaAdd();
            openChildForm(frm);
        }

        private void sbtn_empInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_empInfo);
            childForm_empInfo frm = new childForm_empInfo();
            openChildForm(frm);
        }

        private void sbtn_empFamily_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_empFamily);
            childForm_empFamily frm = new childForm_empFamily();
            openChildForm(frm);
        }

        private void sbtn_empAdd_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_empAdd);
            childForm_empAdd frm = new childForm_empAdd();
            openChildForm(frm);
        }

        private void sbtn_attendanceInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_attendanceInfo);
            childForm_attendanceInfo frm = new childForm_attendanceInfo();
            openChildForm(frm);
        }

        private void sbtn_attendanceAdd_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_attendanceAdd);
            childForm_attendanceAdd frm = new childForm_attendanceAdd();
            openChildForm(frm);
        }

        private void sbtn_salaryInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_salaryInfo);
            childForm_salaryInfo frm = new childForm_salaryInfo();
            openChildForm(frm);
        }

        private void sbtn_salaryAdd_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_salaryAdd);
            childForm_salaryAdd frm = new childForm_salaryAdd();
            openChildForm(frm);
        }

        private void sbtn_salaryReport_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_salaryReport);
            childForm_salaryReport frm = new childForm_salaryReport();
            openChildForm(frm);
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            label_time.Text = nowTime.ToString();
        }

        private void label_logOut_Click(object sender, EventArgs e)
        {
            Form_sign frm_sign = new Form_sign();
            frm_sign.Show();//不能用ShowDialog()
            //Application.Exit();//全部关闭？
            this.Close();
            this.Dispose();
        }

        private void label_logOut_MouseMove(object sender, MouseEventArgs e)
        {
            label_logOut.ForeColor = Color.Red;
        }

        private void label_logOut_MouseLeave(object sender, EventArgs e)
        {
            label_logOut.ForeColor = Color.White;
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(255, 22, 93);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(34, 40, 49);
        }

    }
}
