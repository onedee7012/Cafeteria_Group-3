using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafeteria.DTO;
using MenuDTO = Cafeteria.DTO.Menu;

namespace Cafeteria
{
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadReport(int billID, string tableName, DateTime checkin, DateTime checkout, string staff, string memberName, float price, int discount, float total, float point, List<MenuDTO> menuList)
        {
            reportViewer1.LocalReport.ReportPath = "Receipt.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DatasetReceipt", menuList);
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] parameters = new ReportParameter[]
            {
            new ReportParameter("MaHoaDon", billID.ToString()),
            new ReportParameter("TenBan", tableName),
            new ReportParameter("GioVao", checkin.ToString("dd/MM/yyyy HH:mm:ss")),
            new ReportParameter("GioRa", checkout.ToString("dd/MM/yyyy HH:mm:ss")),
            new ReportParameter("NhanVien", staff),
            new ReportParameter("TenKhachHang", memberName),
            new ReportParameter("ThanhTien", price.ToString("#,0.000") + " VNĐ"),
            new ReportParameter("GiamGia", discount.ToString() + " %"),
            new ReportParameter("TongTien", total.ToString("#,0.000") + " VNĐ"),
            new ReportParameter("Diem", point.ToString("0.##")),
            };

            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }
    }
}
