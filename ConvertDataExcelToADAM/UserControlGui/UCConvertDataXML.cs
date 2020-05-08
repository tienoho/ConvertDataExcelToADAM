using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using ConvertDataExcelToADAM.Tool;
using UploadPatronExcelAOF.Tool;
using ConvertDataExcelToADAM.Enitity;
using ConvertDataExcelToADAM.ADAMFormat;

namespace ConvertDataExcelToADAM.UserControlGui
{
    public partial class UCConvertDataXML : UserControl
    {
        #region Fields
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string[] files = null;
        private DataTable dataExcel = null;
        //private List<listID> list;
        private string txtFileName;
        private string pathFolder;
        private string src;
        private string directoryPath = StaticLocal.pathUserLog;
        private string url1 = "https://drive.google.com/file/d/1Rp6TEy-GC5BlmAqISliAeg0CDXYthsrb/view?usp=sharing";
        #endregion Fields
        public UCConvertDataXML()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
        private void UCConvertDataXML_Load(object sender, EventArgs e)
        {

        }
        private void CreateFolder(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //ChangeName();
            CreateADAMXML();
        }

        private void btnOpenDirectoryName_Click(object sender, EventArgs e)
        {
            openDirectory(lb_showDirectory);
        }
        private void openDirectory(ListBox lb)
        {
            lb.Items.Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowDialog();
            textBox2.Text = src = folderBrowserDialog.SelectedPath;
            int num = 0;
            try
            {
                files = Directory.GetFiles(src.Trim(), "*.*", SearchOption.AllDirectories);
                StaticLocal.files = files;
                for (int i = 0; i < files.Length; i++)
                {
                    lb.Items.Add(files[i]);
                    num++;
                }
                lb_tongfile.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                log.Error(ex.Message);
            }
        }

        private void ChangeName()
        {
            //if (list == null)
            //{
            //    readTxt();
            //}
            //int num = 0;
            //num = list.Count;
            //if (files == null)
            //{
            //    return;
            //}
            //string text = "";
            //string text2 = "";
            //int num2 = 0;
            //int num3 = 0;
            //int num4 = 0;
            ////Loading_FS.text = "\tĐang đưa dữ liệu ...";
            ////Loading_FS.ShowSplash();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < files.Length; i++)
            //{
            //    text = files[i];
            //    int num5 = text.LastIndexOf("\\");
            //    string text3 = text.Substring(num5 + 1);
            //    if (!text3.Contains("."))
            //    {
            //        continue;
            //    }
            //    text3 = text3.Substring(0, text3.LastIndexOf("."));
            //    string text4 = text.Substring(num5 + 1).Substring(text.Substring(num5 + 1).LastIndexOf("."));
            //    for (int j = 0; j < num; j++)
            //    {
            //        string str = list[j].id.ToString();
            //        string text5 = list[j].barcode.ToString();
            //        if (text5.Trim().ToUpper().Equals(text3.ToUpper()))
            //        {
            //            try
            //            {
            //                if (num3 == 1000)
            //                {
            //                    num3 = 0;
            //                    num4++;
            //                }
            //                string text6 = src + "\\Converter\\pic" + num4;
            //                if (!Directory.Exists(text6))
            //                {
            //                    Directory.CreateDirectory(text6);
            //                }
            //                text2 = text6 + "\\" + str + ".jpg";
            //                File.Move(text, text2);
            //                num3++; num2++;
            //            }
            //            catch (Exception ex)
            //            {
            //                log.Error(ex.Message);
            //                continue;
            //            }
            //            break;
            //        }
            //    }
            //}
            //stopwatch.Stop();
            ////Loading_FS.CloseSplash();
            //MessageBox.Show("Thành công: " + num2 + "\nTime: " + stopwatch.Elapsed.ToString() + "s", "Thông báo!");
            //files = null;
            //loadItems(lb_showDirectory);
        }

        private void loadItems(ListBox lb)
        {
            files = null;
            lb.Items.Clear();
            try
            {
                files = Directory.GetFiles(src.Trim(), "*.*", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    lb.Items.Add(files[i]);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void OpenFileExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel file |*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Chọn file excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileExcel.Text = openFileDialog.FileName;
            }
            if (txtFileExcel.Text != "")
            {
                //readExcel2();
                //lưu dữ liệu từ excel vào dataExcel
                dataExcel = new HandlingExcel().ReadFromExcelfile(txtFileExcel.Text, "First Sheet");
                dgvPatron.DataSource = dataExcel;
                //Thêm dữ liệu từ dataExcel vào DataDBLocal.ListPatronOrigin
                StaticLocal.AddDataOrigin = new ToolsAdam().AddData(dataExcel);
                //Thêm dữ liệu từ dataExcel vào DataDBLocal.ListPatronOrigin
                // StaticLocal.ListAdamOrigin = new ToolsAdam().AddDataAdam(StaticLocal.AddDataOrigin, StaticLocal.files);
                new HandlingExcel().CountColumnDataGridView(dgvPatron, lbCountListExcel);

                btnConvert.Enabled = true;
            }
        }

        private void BtnDataDemo_Click(object sender, EventArgs e)
        {
            StaticLocal.ListAdamOrigin = new ToolsAdam().AddDataAdam(StaticLocal.AddDataOrigin, StaticLocal.files);
            ViewSSh();
            // dgvPatron.DataSource = StaticLocal.ListAdamOrigin;
        }

        private void btnChooseExcel_Click(object sender, EventArgs e)
        {
            OpenFileExcel();
        }
        private void ViewSSh()
        {
            // Example list.
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "Column 1", "Column 2", "Column 3", "Column 4", "Column 5", "Column 6" });
            foreach (AdamEnitity adamEnitity in StaticLocal.ListAdamOrigin)
            {
                foreach (InfoFileEnitity infoFileEnitity in adamEnitity.infoFileEnitities)
                {
                    list.Add(new string[] { adamEnitity.SystemBib, adamEnitity.SubLibrary, infoFileEnitity.Sequence, infoFileEnitity.Filename, infoFileEnitity.Extension, infoFileEnitity.ObjectSize, });
                }
            }
            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(list);
            dgvPatron.DataSource = table;
        }
        DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
        private void CreateADAMXML()
        {
            string nameFile = "AOF-ADAM-" + Name + "-" + new ToolsAdam().getDate() + ".xml";
            string pathFile = pathFolder + "\\" + nameFile;
            using (FileStream fileStream = new FileStream(pathFile, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    try
                    {
                        StringBuilder sbAdam = new StringBuilder();
                        StringBuilder sbContent = new StringBuilder();
                        foreach (AdamEnitity adamEnitity in StaticLocal.ListAdamOrigin)
                        {
                            sbContent.Append(new RecordXML().getRecordXml(adamEnitity.SystemBib));
                            sbContent.Append(new ContentXML().getContentXML(adamEnitity));
                        }
                        sbAdam.Append(new HeaderXml().getHeaderXml(sbContent));
                        streamWriter.WriteLine(sbAdam.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBrowserSaveFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFolder = folderBrowserDialog1.SelectedPath;
                txtBrowserSaveFile.Text = pathFolder;
            }
        }
    }
}
