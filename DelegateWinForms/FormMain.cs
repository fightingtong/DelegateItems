using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWinForms
{
    /// <summary>
    /// 委托定义
    /// </summary>
    /// <param name="word"></param>
    public delegate void MoreContactDelegate(string word);
    public partial class FormMain : Form
    {
        private readonly MoreContactDelegate _msg;
        public FormMain()
        {
            InitializeComponent();
            // 窗体实例化
            var f1 = new Form1();
            var f2 = new Form2();
            var f3 = new Form3();
            f1.Show();
            f2.Show();
            f3.Show();

            // 调用委托变量与方法联系到一起
            _msg = f1.Receive;
            _msg += f2.Receive;
            _msg += f3.Receive;
        }

        private string _word;
        // 通过单击调用委托实现固定的方法
        private void button1_Click(object sender, EventArgs e)
        {
            _word = textBox1.Text;
            _msg(_word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _word = "";
            _msg(_word);
            textBox1.Text = _word;
        }
    }
}
