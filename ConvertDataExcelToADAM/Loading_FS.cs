using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertDataExcelToADAM
{
    public partial class Loading_FS : Form
    {
        public Loading_FS()
        {
            InitializeComponent();
            label1.Text = text;
        }
        public static string text;
        private readonly MethodInvoker method;

        public Loading_FS(MethodInvoker action)
        {
            InitializeComponent();
            method = action;
        }
        public static void InvokeAction(Control control, MethodInvoker action)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }
        private void Loading_FS_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                method.Invoke();
                InvokeAction(this, Dispose);
            }).Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
