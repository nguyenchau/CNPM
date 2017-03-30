using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiem
{
    public partial class Tinhdiem : Form
    {
        public Tinhdiem()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool Check = true;//Mặc định đúng
            //Xử lí điểm chuyên cần
            try
            {
                double ChuyenCan = double.Parse(txtCC.Text);
            }
            catch
            {
                Check = false;//lỗi
                MessageBox.Show("Kiểu dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Xử lí điểm giữa kì
            try
            {
                double GiuaKi = double.Parse(txtGK.Text);
            }
            catch
            {
                Check = false;//lỗi
                MessageBox.Show("Kiểu dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Xử lí điểm cuối kì
            try
            {

                double CuoiKi = double.Parse(txtCK.Text);
            }
            catch
            {
                Check = false;//lỗi
                MessageBox.Show("Kiểu dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // chỉ xử lí khi tất cả đều đúng
            if (Check == true)
            {

                Diem.CUOIKI = double.Parse(txtCK.Text);
                Diem.GIUAKI = double.Parse(txtGK.Text);
                Diem.CHUYENCAN = double.Parse(txtCC.Text);
                Check = Diem.KiemTraDiem();
                if (Check == false)
                {
                    MessageBox.Show("Điểm bạn nhập không đúng! Xin kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSo.Enabled = true;//Mở ra 
                    txtChu.Enabled = true;//Mở ra 



                    txtSo.Text = Diem.TinhDiemThang10().ToString();
                    txtChu.Text = Diem.TinhDiemChu().ToString();
                    lblNote.Text = Diem.Note().ToString();



                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCC.Text = "";
            txtGK.Text = "";
            txtCK.Text = "";
            txtSo.Text = "";
            txtChu.Text = "";
            lblNote.Text = "";
        }
    }
}
