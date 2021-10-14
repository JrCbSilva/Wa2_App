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
            p1.ShowDialog();
            this.Dispose();
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P2Pi = 1;
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnNi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P2Ni = 1;
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnNa_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P2Na = 1;
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnTi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P2Ti = 1;
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnR_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Definir um processo formal de revisão de documentos onde a aprovação final de documentos estratégicos seja de responsabilidade da direção da organização." +
                "\nNota: esse processo deve seguir as regras de controle de documentação usadas pela organização.", "Recomendações");
        }

        private void BtnJ_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A Direção deve demonstrar comprometimento e apoio à Política de Segurança da Informação como instrumento para a " +
                "proteção das informações organizacionais, visando à continuidade das operações e a confiança da comunidade envolvida em seus processos.", "Justificativa");
        }

        private void FormP2_Load(object sender, EventArgs e)
        {

        }
    }
}
