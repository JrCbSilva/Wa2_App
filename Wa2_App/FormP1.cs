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
            p2.ShowDialog();
            this.Dispose();
        }

        private void BtnR_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborar uma Política de Segurança da Informação para a organização. Esta Política deve conter:"+
                            "\n\nA. Definição de Segurança da Informação, suas metas globais, escopo e a importância da segurança como um mecanismo que habilita o compartilhamento da informação."+
                            "\n\nB. Declaração do comprometimento da direção, apoiando as metas e princípios da Segurança da Informação, alinhada com os objetivos e estratégias do negócio."+
                            "\n\nC. Estrutura para estabelecer os objetivos de controle e os controles, incluindo a estrutura de Análise / Avaliação e Gerenciamento de Risco."+
                            "\n\nD. Breve explanação da Diretriz, Normas, Procedimentos e requisitos de conformidade de Segurança da Informação específica para a organização, incluindo:"+
                            "\n\n– conformidade com a legislação e com requisitos regulamentares e contratuais;"+
                            "\n\n– requisitos de conscientização, treinamento e educação em Segurança da Informação;"+
                            "\n\n– Gestão de Continuidade de Negócios;"+
                            "\n\n– consequências das violações na Política de Segurança da Informação."+
                            "\n\nE. Definição das responsabilidades gerais e específicas na gestão da Segurança da Informação, incluindo o registro dos incidentes de Segurança da Informação."+
                            "\n\nF. Referências à documentação que possam apoiar a Política, por exemplo, Normas e Procedimentos de Segurança mais detalhados de sistemas de informação específicos ou regras de segurança que os usuários devem seguir.", "Recomendações");
        }

        private void BtnJ_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A Política de Segurança da Informação é um " +
                "conjunto de princípios que norteia a gestão da segurança das informações corporativas" +
                "e que deve ser observada e seguida por todos os funcionários e partes externas" +
                " relevantes para a proteção do negócio da organização.", "Justificativa");
        }

        private void BtnTi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P1Ti = 1;
            FormP2 p2 = new FormP2();
            p2.ShowDialog();
            this.Dispose();
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P1Pi = 1;
            FormP2 p2 = new FormP2();
            p2.ShowDialog();
            this.Dispose();
        }

        private void BtnNi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P1Ni = 1;
            FormP2 p2 = new FormP2();
            p2.ShowDialog();
            this.Dispose();
        }

        private void BtnNa_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P1Na = 1;
            FormP2 p2 = new FormP2();
            p2.ShowDialog();
            this.Dispose();
        }
    }
}
