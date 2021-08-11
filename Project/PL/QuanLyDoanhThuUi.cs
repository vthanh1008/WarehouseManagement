using Project.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.PL
{
    public partial class QuanLyDoanhThuUi : Form
    {
        public QuanLyDoanhThuUi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void QuanLyDoanhThuUi_Load(object sender, EventArgs e)
        {
            int doanhthu=0;
            int lai = 0;
            dgvDoanhThu.DataSource = null;
            dgvDoanhThu.DataSource = HoaDonDAL.GetAllKhachHang();
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                doanhthu+= Convert.ToInt32(row.Cells["TongTien"].Value.ToString());
                lai+= Convert.ToInt32(row.Cells["Lai"].Value.ToString());
            }
            txtDoanhThu.Text = doanhthu.ToString();
            txtLai.Text = lai.ToString();


        }

        private void ddlTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            dgvDoanhThu.DataSource = null;
            dgvDoanhThu.DataSource = HoaDonDAL.GetAllDataBetween(date1, date2);
            int doanhthu = 0;
            int lai = 0;
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                doanhthu += Convert.ToInt32(row.Cells["TongTien"].Value.ToString());
                lai += Convert.ToInt32(row.Cells["Lai"].Value.ToString());
            }
            txtDoanhThu.Text = doanhthu.ToString();
            txtLai.Text = lai.ToString();
        }
    }
}
