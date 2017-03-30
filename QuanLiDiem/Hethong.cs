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
    public partial class frmHethong : Form
    {
        public frmHethong()
        {
            InitializeComponent();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            Lopsinhvien lsv = new Lopsinhvien();
            lsv.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void btDiemHP_Click(object sender, EventArgs e)
        {
            Tinhdiem td = new Tinhdiem();
            td.ShowDialog();
        }
    }
}
