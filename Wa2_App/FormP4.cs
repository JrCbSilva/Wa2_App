using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wa2_App
{
    public partial class FormP4 : Form
    {
        public FormP4()
        {
            InitializeComponent();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Publicar e divulgar a Política de Segurança da Informação e sua importância estratégica em meios de " +
                "comunicação oficiais, tais como a intranet, cartazes e jornais internos.\n\n2. Realizar uma campanha de divulgação da " +
                "Política de Segurança da Informação, composta por ações de Endomarketing e ciclos de palestras periódicos, conforme o " +
                "planejamento da campanha de conscientização.\n\nNota 1: se a Política de Segurança da Informação for distribuída também " +
                "fora da organização, devem ser tomados cuidados para não revelar informações sensíveis.Nota 2: é uma boa prática de " +
                "mercado abrir um canal de comunicação na organização para sugestões e esclarecimentos de dúvidas dos funcionários.", "Recomendações");
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Política de Segurança da Informação atinge os objetivos a que se propõe e agrega " +
                "valor ao negócio da organização somente quando os princípios e regras definidos são de conhecimento dos " +
                "funcionários e partes externas relevantes. Sua divulgação adequada permite a disseminação destes princípios e " +
                "regras, além da formação e consolidação de uma cultura de Segurança da Informação.", "Justificativa");
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            Resultado res = new Resultado();
            res.ShowDialog();
            this.Dispose();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FormP3 p3 = new FormP3();
            p3.ShowDialog();
            this.Dispose();
        }

        private void BtnTi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P4Ti = 1;
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P4Pi = 1;
        }

        private void BtnNi_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P4Ni = 1;
        }

        private void BtnNa_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.P4Na = 1;
        }
    }
}
