using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FUngVien : Form
    {
        public FUngVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            FTaoCV fTaoCV = new FTaoCV();
            fTaoCV.Show();
        }
    }
}
