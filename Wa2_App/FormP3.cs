using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wa2_App
{
    public partial class FormP3 : Form
    {
        public FormP3()
        {
            InitializeComponent();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborar e publicar mensagem ou carta do principal executivo da organização " +
                "endereçada a todos os funcionários e partes externas relevantes.) " +
                "\n\n2. Divulgar tal mensagem ou carta juntamente com a Política de Segurança da Informação." +
                "\n\nNota: uma das formas mais comuns para apresentar ostensivamente o apoio e comprometimento da " +
                "Direção é através de mensagens escritas, por meio da intranet da empresa, e-mail corporativo, " +
                "cartazes e jornais internos, mas também podem ser usadas fitas de vídeo ou DVDs com mensagens dos " +
                "principais dirigentes, videoconferências ao vivo ou animações feitas para computadores – dependendo " +
                "dos recursos disponíveis.", "Recomendações");
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Direção deve dar demonstração visível, clara e inequívoca de que apoia as metas e princípios da " +
                "Segurança da Informação nas várias áreas da organização, visando à continuidade das operações e à confiança da " +
                "omunidade que participa em seus processos.", "Justificativa");
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            FormP4 p4 = new FormP4();
            p4.ShowDialog();
            this.Dispose();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FormP2 p2 = new FormP2();
            p2.ShowDialog();
            this.Dispose();
        }

        private void BtnTi_Click_1(object sender, EventArgs e)
        {
            VariaveisGlobais.P3Ti = 1;
            FormP4 p4 = new FormP4();
            p4.ShowDialog();
            this.Dispose();
        }

        private void BtnPi_Click_1(object sender, EventArgs e)
        {
            VariaveisGlobais.P3Pi = 1;
            FormP4 p4 = new FormP4();
            p4.ShowDialog();
            this.Dispose();
        }

        private void BtnNi_Click_1(object sender, EventArgs e)
        {
            VariaveisGlobais.P3Ni = 1;
            FormP4 p4 = new FormP4();
            p4.ShowDialog();
            this.Dispose();
        }

        private void BtnNa_Click_1(object sender, EventArgs e)
        {
            VariaveisGlobais.P3Na = 1;
            FormP4 p4 = new FormP4();
            p4.ShowDialog();
            this.Dispose();
        }
    }
}
