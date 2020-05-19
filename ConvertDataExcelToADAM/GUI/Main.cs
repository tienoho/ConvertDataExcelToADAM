using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using ConvertDataExcelToADAM.UserControlGui;

namespace ConvertDataExcelToADAM.GUI
{
    public partial class Main : Form
    {
        private string urlFileExcel = "https://drive.google.com/file/d/1qxPbpKE_9EnSdrb4_Bkg82k7LSsfqMzW/view?usp=sharing";
        public Main()
        {
            InitializeComponent();
            LoadForm();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //ButtonFontBold(btnAddPatron, FontStyle.Bold, Color.Green);
            //ButtonFontBold(btnOpenBlock, FontStyle.Regular, Color.Black);
            //ButtonFontBold(btnRenamePic, FontStyle.Regular, Color.Black);

            _pnlRight.Controls.Clear();
            UCConvertDataXML uC = new UCConvertDataXML();
            _pnlRight.Controls.Add(uC);
            uC.Show();
        }
        public void LoadForm()
        {
            _pnlRight.Controls.Clear();
            UCConvertDataXML uC = new UCConvertDataXML();
            _pnlRight.Controls.Add(uC);
            uC.Show();
           // lblInformation.Text = "Chức năng: Thêm người đùng";
        }
        private void MouseChangeColorBackgroundImage(Button btn, Color color, Image image = null)
        {
            btn.BackColor = color;
            btn.BackgroundImage = image;
        }
        private void ButtonFontBold(Button btn, FontStyle fontStyle, Color color)
        {
            btn.ForeColor = color;
            btn.Font = new Font(btn.Font.Name, btn.Font.Size, fontStyle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFileDemo_Click(object sender, EventArgs e)
        {
            Process.Start(urlFileExcel);
        }
    }
}
