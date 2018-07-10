using System;
using System.Windows.Forms;

namespace 事件_练习_02_事件登录案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Evt += UserControl11_Evt;//左边是控件.事件,右边是事件方法
        }

        private void UserControl11_Evt(object sender, EventArgs e)
        {
            //MessageBox.Show(System.DateTime.Now.ToString(CultureInfo.CurrentCulture), @"当前时间", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //将系统的EventArgse转换为MyEventArgsClass中的myEventArgs(as关键字安全转换)
            MyEventArgsClass.MyEventArgs myEventArgs = e as MyEventArgsClass.MyEventArgs;

            if (myEventArgs?.Name == "yty" && myEventArgs.Pwd == "yty")//如果事件不为空,且username和密码都正确
            {
                MessageBox.Show(@"登陆成功...", @"消息", MessageBoxButtons.OK, MessageBoxIcon.Information);//提示消息
                myEventArgs.Flag = true;//改变flag的bool值
            }
            else
            {
                MessageBox.Show(@"登录失败....", @"消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);//提示消息

                if (myEventArgs != null)
                {
                    myEventArgs.Flag = false;//改变flag的bool值
                }
            }
        }
    }
}
