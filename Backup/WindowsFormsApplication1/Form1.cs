using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FormWriteID f_WriteID = null;
        FormHistory f_History = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        /***************************************************************************************************/
        /***************************************** 系统概述 ***********************************/
        /***************************************************************************************************/
        private void btnXTGS_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.panel1.Controls)//关闭panel1容器中所有已经打开的窗体
            {
                ct.Dispose();
            }
            this.panel1.Controls.Clear();    //一定放在foreach（）语句后面
            panel1.Visible = false;
        }
        /***************************************************************************************************/
        /***************************************** ID号生成窗口***********************************/
        /***************************************************************************************************/

        private void btnWriteID_Click(object sender, EventArgs e)
        {
            f_WriteID = new FormWriteID();
            f_WriteID.Show();

        }
        /***************************************************************************************************/
        /*****************************************操作记录窗口 ***********************************/
        /***************************************************************************************************/
        private void btnHistory_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.panel1.Controls)//关闭panel1容器中所有已经打开的窗体
            {
                ct.Dispose();
            }
            this.panel1.Controls.Clear();    //一定放在foreach（）语句后面
            panel1.Visible = true;
            f_History = new FormHistory();
            f_History.TopLevel = false;      //Form.TopLevel 获取或设置一个值，该值指示是否将窗体显示为顶级窗口; Form.TopMost 获取或设置一个值，指示该窗体是否应显示为最顶层窗体. 
            f_History.Show();
            panel1.Controls.Add(f_History);
        }
        /***************************************************************************************************/
        /***************************************** 退出系统-事件处理部分 ***********************************/
        /***************************************************************************************************/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //捕捉窗体Close事件,关闭窗口时提示
            if (MessageBox.Show("请您确认是否退出(Y/N)", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;    //允许退出系统
            }
            else
            {
                e.Cancel = true;     //阻止退出系统
            }

        }

        private void btnTCXT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出系统ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 系统概述ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormToolMenuYFDW f = new FormToolMenuYFDW();
            f.Show();
        }

    }
}
