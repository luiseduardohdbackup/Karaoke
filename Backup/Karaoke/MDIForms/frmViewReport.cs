using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Karaoke.ReportTemplate;
using Karaoke.DataSets;
using Karaoke.Resources.ReportTemplate;
namespace Karaoke.MDIForms
{
    public partial class frmViewReport : DevExpress.XtraEditors.XtraForm
    {
        private dataSetNewDetailReport ds1;
        private DataSetTienVon ds2;
        private DataSetTonKho ds3;
        private DataSetHoaDon ds4;
        private DataSetDetailReportDSBH ds5;
        private DataSetTKHD ds6;
        private DataSetHoaDon ds7;
        private DataSetThongKeVanDe ds8;
        private int mode = 0;
        public frmViewReport()
        {
            InitializeComponent();
        }
        public frmViewReport(dataSetNewDetailReport _ds)
        {
            InitializeComponent();
            mode = 1;
            ds1 = _ds;
        }
        public frmViewReport(DataSetTienVon _ds)
        {
            InitializeComponent();
            mode = 2;
            ds2 = _ds;
        }
        public frmViewReport(DataSetTonKho _ds)
        {
            InitializeComponent();
            mode = 3;
            ds3 = _ds;
        }
        public frmViewReport(DataSetHoaDon _ds)
        {
            InitializeComponent();
            mode = 4;
            ds4 = _ds;
        }
        public frmViewReport(DataSetDetailReportDSBH _ds)
        {
            InitializeComponent();
            mode = 5;
            ds5 = _ds;
        }
        public frmViewReport(DataSetTKHD _ds)
        {
            InitializeComponent();
            mode = 6;
            ds6 = _ds;
        }
        public frmViewReport(DataSetHoaDon _ds, bool kind)
        {
            InitializeComponent();
            if (kind)
                mode = 7;
            else
                mode = 9;
            ds7 = _ds;
        }
        public frmViewReport(DataSetThongKeVanDe _ds)
        {
            InitializeComponent();
            mode = 8;
            ds8 = _ds;
        }
        private void printControl1_Load(object sender, EventArgs e)
        {
             initData();
        }
        private void initData()
        {
            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    if (ds1 != null)
                    {
                        DetailReport detailRPT = new DetailReport();
                        detailRPT.DataSource = ds1;
                        this.Text = "Bao cao chi tiet";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        detailRPT.PrintingSystem = printingSystem1;
                        detailRPT.CreateDocument();
                    }
                    break;
                case 2:
                    if (ds2 != null)
                    {
                        TienVonReport rpt = new TienVonReport();
                        rpt.DataSource = ds2;
                        this.Text = "Báo cáo tiền vốn";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 3:
                    if (ds3 != null)
                    {
                        TonKhoReport rpt = new TonKhoReport();
                        rpt.DataSource = ds3;
                        this.Text = "Báo cáo tồn kho";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 4:
                    if (ds4 != null)
                    {
                        Hoadon rpt = new Hoadon();
                        rpt.DataSource = ds4;
                        this.Text = "Hóa đơn";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 5:
                    if (ds5 != null)
                    {
                        DetailReportDSBH rpt = new DetailReportDSBH();
                        rpt.DataSource = ds5;
                        this.Text = "Doanh số bán hàng";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 6:
                    if (ds6 != null)
                    {
                        ThongKeHoaDon rpt = new ThongKeHoaDon();
                        rpt.DataSource = ds6;
                        this.Text = "Thống kê hóa đơn xuất";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 7:
                    if (ds7 != null)
                    {
                        Hoadonbep rpt = new Hoadonbep();
                        rpt.DataSource = ds7;
                        this.Text = "Phiếu gọi món";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 8:
                    if (ds8 != null)
                    {
                        DetailThongKeVanDe rpt = new DetailThongKeVanDe();
                        rpt.DataSource = ds8;
                        this.Text = "Thống kê hóa đơn xuất";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                case 9:
                    if (ds7 != null)
                    {
                        XuatKho rpt = new XuatKho();
                        rpt.DataSource = ds7;
                        this.Text = "Phiếu Xuất Kho";
                        this.printingSystem1.ClearContent();
                        Invalidate();
                        Update();
                        rpt.PrintingSystem = printingSystem1;
                        rpt.CreateDocument();
                    }
                    break;
                default:
                    break;
            }
        }

        private void printPreviewBarItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }


    }
}