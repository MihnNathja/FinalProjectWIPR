﻿using System;
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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void pcUserAvatar_Click(object sender, EventArgs e)
        {
            FUngVien fUngVien = new FUngVien();
            fUngVien.ShowDialog();
        }
    }
}
