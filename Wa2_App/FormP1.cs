using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wa2_App
{
    public partial class FormP1 : Form
    {
        public FormP1()
        {
            InitializeComponent();
        }


        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            FormP2 p2 = new FormP2();
            FormP1 p1 = new FormP1();
            p1.Show();
            p2.ShowDialog();
            
            this.Dispose();
        }

        private void BtnR_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Recomendações", "Recomendações");
        }

        private void BtnJ_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A Política de Segurança da Informação é um " +
                "conjunto de princípios que norteia a gestão da segurança das informações corporativas" +
                "e que deve ser observada e seguida por todos os funcionários e partes externas" +
                " relevantes para a proteção do negócio da organização.", "Justificativa");
        }
    }
}
