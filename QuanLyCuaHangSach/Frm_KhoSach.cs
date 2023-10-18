using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class Frm_KhoSach : Form
    {
        public Frm_KhoSach()
        {
            InitializeComponent();

        }

        private void Frm_KhoSach_Load(object sender, EventArgs e)
        {
            lbMaSach.Parent = pictureBox1;
            lbMaSach.BackColor = Color.Transparent;

        }
    }
}
