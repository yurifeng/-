using System;
using System.Drawing;
using System.Windows.Forms;

namespace 事件_练习_02_事件登录案例
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//自定义控件可以得到按钮的各项属性
        {
            //自定义的控件,需要判断用户名和密码

            //占位

            if (Evt != null)//如果事件不为空
            {
                MyEventArgsClass.MyEventArgs myEventArgs = new MyEventArgsClass.MyEventArgs//创建MyEventArgsClass类的对象
                {
                    Name = textBox1.Text,//将textbox1中的值赋值给name
                    Pwd = textBox2.Text//将textbox2中的值赋值给password
                };

                Evt(this, myEventArgs);//Evt事件调用

                this.BackColor = myEventArgs.Flag ? Color.Green : Color.Red;//将自定义空间的背景颜色根据Flag的值而改变
            }
        }

        public event EventHandler Evt;//声明事件(userControl1 点 就能使用事件)

        ///// <summary>
        ///// 输入完密码按确认直接出发按钮事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '\r')
        //    {
        //        button1_Click(sender, e);

        //    }
        //}

        ///// <summary>
        ///// 退出按钮
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(
        //        @"确定退出?", @"警告",
        //        MessageBoxButtons.OKCancel,
        //        MessageBoxIcon.Question,
        //        MessageBoxDefaultButton.Button2);

        //    if (dialogResult == DialogResult.OK)
        //    {
        //        Application.ExitThread();
        //    }
        //}
    }
}
