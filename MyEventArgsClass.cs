using System;

namespace 事件_练习_02_事件登录案例
{
    /// <summary>
    /// 该类的作用是让主窗体能够调用到textbox中的username和password
    /// </summary>
    class MyEventArgsClass
    {
        public class MyEventArgs : EventArgs//自定义的EventArgs需要继承系统的EventArgs
        {
            public string Name { get; set; }//声明Name字段

            public string Pwd { get; set; }//声明密码字段

            public bool Flag { get; set; }//声明标记字段

            public MyEventArgs()//构造方法就默认flag是false
            {
                this.Flag = false;
            }
        }
    }
}