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
    public partial class Lopsinhvien : Form
    {
        public Lopsinhvien()
        {
            InitializeComponent();
        }
        Boolean adLop = false;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            txtmalop.Text = "";
            txttenlop.Text = "";
            txtmalop.Enabled = true;
            txtmalop.Focus();
            adLop = true;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if(adLop)
            {
                dt.Lops_Insert(txtmalop.Text, txttenlop.Text);
                txtmalop.Enabled = false;
                adLop = false;
            }
            else
            {
                dt.Lops_Update(txtmalop.Text, txttenlop.Text);
            }
            Lopsinhvien_Load(sender,e);
        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
        QLDDataContext dt = new QLDDataContext();
        private void Lopsinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDDataSet.SinhVien);
            cboLop.DisplayMember="TenLop";
            cboLop.ValueMember="MaLop";
            cboLop.DataSource = dt.Lops_SelectAll();
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", cboLop.DataSource, "MaLop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", cboLop.DataSource, "TenLop");
        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            dt.Lops_Delete(cboLop.SelectedValue.ToString());
            Lopsinhvien_Load(sender, e);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgsinhvien.DataSource = dt.SinhVien_selectMalop(txtmalop.Text);
            txtmasv.DataBindings.Clear();
            txtmasv.DataBindings.Add("Text", dtgsinhvien.DataSource , "MaSV");
            txttensv.DataBindings.Clear();
            txttensv.DataBindings.Add("Text", dtgsinhvien.DataSource , "HoTen");
            dateTimengaysinh.DataBindings.Clear();
            dateTimengaysinh.DataBindings.Add("Text", dtgsinhvien.DataSource , "NgaySinh");
            txtgioitinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Add("Text", dtgsinhvien.DataSource , "GioiTinh");
            txtdantoc.DataBindings.Clear();
            txtdantoc.DataBindings.Add("Text", dtgsinhvien.DataSource , "DanToc");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", dtgsinhvien.DataSource , "NoiSinh");

        }
        Boolean adSV = false;
        private void btnthemsv_Click(object sender, EventArgs e)
        {
            txtmasv.Text= "";
            txttensv.Text = "";
            txtgioitinh.Text = "";
            dateTimengaysinh.Text = "";
            txtdantoc.Text = "";
            txtnoisinh.Text = "";
            txtmasv.Enabled = true;
            txtmasv.Focus();
            txtmasv.Focus();
            txtmasv.Focus();
            txtmasv.Focus();
            adSV = true;



        }

        private void btnluusv_Click(object sender, EventArgs e)
        {
            if(adSV)
            {
                dt.SinhVien_Insert(txtmasv.Text, txttensv.Text, dateTimengaysinh.Value, 
                    Convert.ToInt32(txtgioitinh.Text), txtnoisinh.Text, txtdantoc.Text, txtmalop.Text);
                adSV = false;
                txtmasv.Enabled = false;
                cboLop_SelectedIndexChanged(sender, e);
            }
            else
            {
                dt.SinhVien_Update(txtmasv.Text, txttensv.Text, dateTimengaysinh.Value,
                Convert.ToInt32(txtgioitinh.Text), txtnoisinh.Text, txtdantoc.Text);
                cboLop_SelectedIndexChanged(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dt.SinhVien_Delete(txtmasv.Text);
            cboLop_SelectedIndexChanged(sender, e);
        }

        private void txttimsv_TextChanged(object sender, EventArgs e)
        {
            dtgsinhvien.DataSource = dt.SinhViens.Where(x => x.HoTen.Contains(txttimsv.Text)).ToList();
          txtmasv.DataBindings.Clear();
          txtmasv.DataBindings.Add("Text", dtgsinhvien.DataSource, "MaSV");
          txttensv.DataBindings.Clear();
          txttensv.DataBindings.Add("Text", dtgsinhvien.DataSource, "HoTen");
          dateTimengaysinh.DataBindings.Clear();
          dateTimengaysinh.DataBindings.Add("Text", dtgsinhvien.DataSource, "NgaySinh");
          txtgioitinh.DataBindings.Clear();
          txtgioitinh.DataBindings.Add("Text", dtgsinhvien.DataSource, "GioiTinh");
          txtdantoc.DataBindings.Clear();
          txtdantoc.DataBindings.Add("Text", dtgsinhvien.DataSource, "DanToc");
          txtnoisinh.DataBindings.Clear();
          txtnoisinh.DataBindings.Add("Text", dtgsinhvien.DataSource, "NoiSinh");
        }

        private void btnThoatxl_Click(object sender, EventArgs e)
        {
            DialogResult dialg = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        }

       
    }

