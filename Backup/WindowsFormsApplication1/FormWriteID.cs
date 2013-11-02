using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
//using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class FormWriteID : Form
    {
        private SerialPort sp = new SerialPort();
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面
        //bool isOpen = false;
        bool isSetProperty = false;
        private bool sp_Listening = false;//是否没有执行完invoke相关操作
        private bool sp_Closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
        public FormWriteID()
        {
            InitializeComponent();
        }

        private void FormWriteID_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            labInformation.BackColor = Color.Transparent;
            //列出端口号
            for (int i = 0; i < 20; i++)
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;
            //检测哪些串口可有
            cbxCOMPort.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    SerialPort spJC = new SerialPort("COM" + (i + 1).ToString());
                    spJC.Open();
                    spJC.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                }
                catch (Exception)
                {
                    continue;  //
                }
            }

            btnSCID.Enabled = true;
            btnXRID.Enabled = true;

            
            //初始化SerialPort对象
            sp.NewLine = "\r\n";
            sp.RtsEnable = true;//根据实际情况吧
            //添加事件注册
            sp.ReceivedBytesThreshold = 16;       //接收字节的长度 根据编码进行修改
            sp.DataReceived += sp_DataReceived;   //
        }
        /*********************************************************************************/
        /*********************************串口接收部分************************************/
        /*********************************************************************************/
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp_Closing) return;//如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环
            try
            {
                sp_Listening = true;                //设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。
                int n = sp.BytesToRead;             //先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
                byte[] buf = new byte[n];           //声明一个临时数组存储当前来的串口数据
                sp.Read(buf, 0, n);//读取缓冲数据
                builder.Remove(0, builder.Length);  //清除字符串构造器的内容
                //因为要访问ui资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate
                {
                    
                    //直接按ASCII规则转换成字符串
                    builder.Append(Encoding.ASCII.GetString(buf));
                    //追加的形式添加到文本框末端，并滚动到最后
                    //this.txtJYID.AppendText(builder.ToString());
                    this.txtJYID.Text = "   " + builder.ToString();
                }));
                
            }
            catch (Exception)
            {
                this.Invoke((EventHandler)(delegate
                {
                   
                }));
                                  
            }
            finally
            {
                sp_Listening = false;//我用完了，ui可以关闭串口
            }
        }
        /***************************************************************************************************/
        /******************************检测串口下拉菜单是否为空  函数***************************************/
        /***************************************************************************************************/
        private bool CheckPortSetting()
        { //检测串口是否设置
            if (cbxCOMPort.Text.Trim() == "") return false;   //trim（）用于去掉前后空格
            return true;
        }
        /***************************************************************************************************/
        /**************************************设置串口参数 函数********************************************/
        /***************************************************************************************************/
        private void SetPortProperty()
        {
            //设置串口属性
            sp.PortName = cbxCOMPort.Text.Trim();
            //设置波特率
            sp.BaudRate = 9600;
            //设置停止位
            sp.StopBits = StopBits.One;
            //设置数据位
            sp.DataBits = 8;
            //设置奇偶校验位
            sp.Parity = Parity.None;
            //设置超时读取时间
            sp.ReadTimeout = -1;
            //打开串口
            try
            {
                sp.Close();
                //isOpen = true;
                sp.Open();
                labInformation.Text = cbxCOMPort.Text.Trim() + "打开成功！";     //LabelInformation控件
            }
            catch (Exception)
            {
                labInformation.Text = "打开串口时发生错误！";                    //LabelInformation控件
            }
        }

        private void btnOpenCOM_Click(object sender, EventArgs e)
        {
            if (!CheckPortSetting())
            {
                MessageBox.Show("串口未设置！", "错误提示");
                return;
            }
            if (!isSetProperty)
            {
                SetPortProperty();       // 其中将isopen设置成了True
                isSetProperty = true;
            }
           
        }
        /***************************************************/
        /*********************(1)生成ID**********************/
        /***************************************************/
        private void btnSCID_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            
            try
            {
                txtSCID.Text = "   " + string.Format("{0:yyyyMMddHHmmss}", currentTime) + "FF";
                labInformation.Text = "生成ID成功！";            //LabelInformation控件
            }
            catch (Exception)
            {
                labInformation.Text = "生成ID发生错误！";        //LabelInformation控件
            }
        }
        /****************************************************/
        /*********************(2)写入ID**********************/
        /***************************************************/
        private void btnXRID_Click(object sender, EventArgs e)
        {
            byte[] ID_Send = new byte[25];
            byte[] ID_Information = { 0x19, 0xA2, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01 };
            string txtID = txtSCID.Text.Trim();

            try
            {
                //依次添加到列表中
                for (int i = 0; i < 9; i++)
                {
                    ID_Send[i] = ID_Information[i];
                }
                for (int i = 9; i < 25; i++)
                {
                    ID_Send[i] = System.Convert.ToByte(txtID[i - 9]);    //
                    
                }
                sp.Write(ID_Send.ToArray(), 0, ID_Send.Count());
                labInformation.Text = "写入ID成功！";                   //LabelInformation控件
            }
            catch (Exception)
            {
                labInformation.Text = "写入ID发生错误！";               //LabelInformation控件
            }
        }
        /***************************************************/
        /*********************(3)读取ID*********************/
        /***************************************************/
        private void btnReadID_Click(object sender, EventArgs e)
        {
            byte[] IntSend = { 0x09, 0xA1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01 };
            //依次添加到列表中
            //for (int i = 0; i < 9; i++)
            //{
            //  IntSend[i] = byte.Parse(buf[i], System.Globalization.NumberStyles.HexNumber);
            //}         
            try
            {
                sp.Write(IntSend.ToArray(), 0, IntSend.Count());
                labInformation.Text = "校验ID成功！";            //LabelInformation控件
            }
            catch (Exception)
            {
                labInformation.Text = "校验ID发生错误！";        //LabelInformation控件
            }
        }
        /***************************************************/
        /*********************(4)校验ID************************/
        /***************************************************/
        private void btnJYID_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtSCID.Text.Trim(), txtJYID.Text.Trim()) == 0)
            {
                MessageBox.Show("ID操作成功，请进行下一个！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID操作失败，请重新操作！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /***************************************************************************************************/
        /***************************************** 退出系统-事件处理部分 ***********************************/
        /***************************************************************************************************/
        private void FormWriteID_FormClosing(object sender, FormClosingEventArgs e)
        {
            //捕捉窗体Close事件,关闭窗口时提示
            if (MessageBox.Show("请您确认是否退出(Y/N)", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    if (sp.IsOpen)            //说明sp已经定义并且打开
                    {
                        sp_Closing = true;
                        //isOpen = false;
                        while (sp_Listening) Application.DoEvents();//很重要，等待串口执行完，防止偶发性的死机
                        sp.Close();
                    }
                    else
                    {
                    }
                }
                catch (System.Exception error)
                {//串口卸载失败异常
                    MessageBox.Show(error.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                e.Cancel = false;//允许退出系统
            }
            else
            {
                e.Cancel = true;//阻止退出系统
            }

        }



    }
}
