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
using System.Threading;
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
        private string pathFolder;
        private string src;
        private string directoryPath = StaticLocal.pathUserLog;

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
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                Loading_FS.text = "Đang chuyển đổi dữ liệu";
                new Loading_FS(() => ConvertData()).ShowDialog();
                btnCreatFileXml.Enabled = true;
            }
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

        private void ConvertData()
        {
            if (StaticLocal.AddDataOrigin.Count > 0 && StaticLocal.files.Length > 0)
            {
                StaticLocal.ListAdamOrigin = new ToolsAdam().AddDataAdam(StaticLocal.AddDataOrigin, StaticLocal.files);
                //ViewSSh();                
                Thread.Sleep(2000);
                MessageBox.Show("Đã chuyển đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            }
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
                dgvPatron.DataSource = StaticLocal.AddDataOrigin;
                //Thêm dữ liệu từ dataExcel vào DataDBLocal.ListPatronOrigin
                // StaticLocal.ListAdamOrigin = new ToolsAdam().AddDataAdam(StaticLocal.AddDataOrigin, StaticLocal.files);
                new HandlingExcel().CountColumnDataGridView(dgvPatron, lbCountListExcel);

                btnConvert.Enabled = true;
            }
        }

        private void BtnDataDemo_Click(object sender, EventArgs e)
        {
            //StaticLocal.ListAdamOrigin = new ToolsAdam().AddDataAdam(StaticLocal.AddDataOrigin, StaticLocal.files);
            ////ViewSSh();
            //dgvPatron.DataSource = StaticLocal.ListAdamOrigin;

            new Loading_FS(() => ConvertData()).ShowDialog();

            //dgvPatron.DataSource = StaticLocal.ListAdamOrigin;
            btnCreatFileXml.Enabled = true;
            btnConvert.Enabled = false;

        }
        private void btnChooseExcel_Click(object sender, EventArgs e)
        {
            OpenFileExcel();
        }
        private void ViewSSh()
        {
            // Example list.
            List<string[]> list = new List<string[]>();
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
                            if (adamEnitity.infoFileEnitities.Count > 0)
                            {
                                sbContent.Append(new RecordXML().getRecordXml(adamEnitity.SystemBib));
                                sbContent.Append(new ContentXML().getContentXML(adamEnitity));
                            }
                        }
                        sbAdam.Append(new HeaderXml().getHeaderXml(sbContent));
                        streamWriter.WriteLine(sbAdam.ToString());

                        MessageBox.Show("Tạo người thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                btnConvert.Enabled = true;
            }
        }

        private void btnExportExcelAddPatron_Click(object sender, EventArgs e)
        {
            if (StaticLocal.ListAdamOrigin.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn lưu lại danh sách không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new HandlingExcel().GetPathDirectoryAndWriteExcel(StaticLocal.ListAdamOrigin);
                }
            }
        }

        private void btnCreatFileXml_Click(object sender, EventArgs e)
        {
            if (StaticLocal.ListAdamOrigin.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn tạo ADAM không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Loading_FS.text = "Đang tạo File Adam";
                    new Loading_FS(() => CreateADAMXML()).ShowDialog();
                    MessageBox.Show("Đã tạo File thành công", "Thông báo", MessageBoxButtons.OK);
                    btnCreatFileXml.Enabled = false;
                    btnConvert.Enabled = false;
                }
            }
        }
    }
}
