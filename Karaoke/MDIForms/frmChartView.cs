using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;

namespace Karaoke.MDIForms
{
    public partial class frmChartView : DevExpress.XtraEditors.XtraForm
    {
        public frmChartView()
        {
            InitializeComponent();
        }
        public frmChartView(DataTable data, string type, string[] listofName)
        {
            InitializeComponent();
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng! Xin vui lòng chọn lại dữ liệu", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.Close();
                return;
            }
            myInit();
            switch (type)
            {
                case "ByDate":
                    for(int j = 0; j<listofName.Length; j++){
                        string productName = listofName[j];
                        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series();
                        series.LegendText = productName;
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            DevExpress.XtraCharts.SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint();
                            point.Argument = Convert.ToString(data.Rows[i]["Ngayxuat"]);
                            double[] temp = new double[1];
                            if (!(data.Rows[i][productName] is DBNull))
                            {
                                temp[0] = Convert.ToDouble(data.Rows[i][productName]);
                            }
                            else
                                temp[0] = 0;
                            point.Values = temp;
                            series.Points.Add(point);
                            series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
                        }
                        chartControl1.Series.Add(series);
                    }
                    chartControl1.Titles[0].Text = "Sản phẩm bán thống kê theo ngày";
                    break;
                case "ByMonth":
                    for (int j = 0; j < listofName.Length; j++)
                    {
                        string productName = listofName[j];
                        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series();
                        series.LegendText = productName;
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            DevExpress.XtraCharts.SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint();
                            point.Argument = Convert.ToString(data.Rows[i]["Ngayxuat"]);
                            double[] temp = new double[1];
                            if (!(data.Rows[i][productName] is DBNull))
                            {
                                temp[0] = Convert.ToDouble(data.Rows[i][productName]);
                            }
                            else
                                temp[0] = 0;
                            point.Values = temp;
                            series.Points.Add(point);
                            //series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
                        }
                        chartControl1.Series.Add(series);
                    }
                    chartControl1.Titles[0].Text = "Sản phẩm bán thống kê theo tháng";
                    break;
                default:
                    break;
            }
        }
        public frmChartView(DataTable data, string type)
        {
            InitializeComponent();
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng! Xin vui lòng chọn lại dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.Close();
                return;
            }
            myInit();
            switch (type)
            {
                case "ByDate":
                        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series();
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            DevExpress.XtraCharts.SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint();
                            point.Argument = Convert.ToString(data.Rows[i]["Ngayxuat"]);
                            double[] temp = new double[1];
                            if (!(data.Rows[i]["ThanhTien"] is DBNull || (data.Rows[i]["ThanhTien"]).ToString() == ""))
                            {
                                temp[0] = Convert.ToDouble(data.Rows[i]["ThanhTien"]);
                            }
                            else
                                temp[0] = 0;
                            point.Values = temp;
                            series.Points.Add(point);
                            series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
                        }
                        chartControl1.Series.Add(series);
                    chartControl1.Titles[0].Text = "Sản phẩm bán thống kê theo ngày";
                    break;
                case "ByMonth":
                        DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
                        //series.LegendText = productName;
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            DevExpress.XtraCharts.SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint();
                            point.Argument = Convert.ToString(data.Rows[i]["Ngayxuat"]);
                            double[] temp = new double[1];
                            if (!(data.Rows[i]["ThanhTien"] is DBNull))
                            {
                                temp[0] = Convert.ToDouble(data.Rows[i]["ThanhTien"]);
                            }
                            else
                                temp[0] = 0;
                            point.Values = temp;
                            series1.Points.Add(point);
                        }
                        chartControl1.Series.Add(series1);
                    chartControl1.Titles[0].Text = "Sản phẩm bán thống kê theo tháng";
                    break;
                default:
                    break;
            }
        }
        private void myInit()
        {
            //Clear old data
            if (chartControl1.Series.Count > 0)
                chartControl1.Series.Clear();
            //chartControl1.Titles[0].Text = "Biều đồ sản phẩm bán!";
            
        }

        private void exportToXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo("XLS Document", "XLS Documents (*.xls)|*.xls", "XLS");
        }

        private void exportToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo("MHT Document", "MHT Documents (*.mht)|*.mht", "MHT");
        }

        private void exportToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo("PDF Document", "PDF Documents (*.pdf)|*.pdf", "PDF");
        }

        private void exportToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Png;
            ExportTo("PNG image", "PNG image (*.PNG)|*.PNG", "IMAGE", format, false);
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Jpeg;
            ExportTo("JPEG image", "JPEG image (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF", "IMAGE", format, false);
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Gif;
            ExportTo("GIF image", "GIF image (*.GIF)|*.GIF", "IMAGE", format, false);
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Bmp;
            ExportTo("BMP image", "BMP image (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE", "IMAGE", format, false);
        }

        private void printReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chartControl1 != null)
            {
                chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
                chartControl1.ShowPrintPreview();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chartControl1 != null)
            {
                chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
                chartControl1.Print();
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Helper
        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            string name = Application.ProductName;
            int n = name.LastIndexOf(".") + 1;
            if (n > 0) name = name.Substring(n, name.Length - n);
            dlg.Title = "Export To " + title;
            dlg.FileName = name;
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }
        private void OpenFile(string fileName)
        {
            if (XtraMessageBox.Show("Do you want to open this file?", "Export To...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    XtraMessageBox.Show("Cannot find an application on your system suitable for openning the file with exported data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExportTo(string title, string filter, string exportFormat)
        {
            ExportTo(title, filter, exportFormat, null, true);
        }
        private void ExportTo(string title, string filter, string exportFormat, ImageFormat format, bool checkPrinterAvailable)
        {
            //ChartControl chart = PrepeareForPrintOrExport(checkPrinterAvailable);
            if (chartControl1 == null)
                return;
            string fileName = ShowSaveFileDialog(title, filter);
            if (fileName != "")
            {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                switch (exportFormat)
                {
                    case "HTML":
                        chartControl1.ExportToHtml(fileName);
                        break;
                    case "MHT":
                        chartControl1.ExportToMht(fileName);
                        break;
                    case "PDF":
                        chartControl1.ExportToPdf(fileName);
                        break;
                    case "XLS":
                        chartControl1.ExportToXls(fileName);
                        break;
                    case "IMAGE":
                        chartControl1.ExportToImage(fileName, format);
                        break;
                }
                Cursor.Current = currentCursor;
                OpenFile(fileName);
            }
        }

        #endregion
    }
}