using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wa2_App
{
    public partial class FormP2 : Form
    {
        public FormP2()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FormP1 p1 = new FormP1();
            FormP2 p2 = new FormP2();
            p1.ShowDialog();
            this.Dispose();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recomendações", "Recomendações");
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Justificativa", "Justificativa");
        }
    }
}
