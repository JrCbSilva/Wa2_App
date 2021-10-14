using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Wa2_App
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Controle de Conformidade");
                worksheet.Cell("B1").Value = "Implementado";
                worksheet.Cell("C1").Value = "Parcialmente Implementado";
                worksheet.Cell("D1").Value = "Não Implementado";
                worksheet.Cell("E1").Value = "Não Aplicável";

                worksheet.Cell("A2").Value = "Questão 1";
                worksheet.Cell("A3").Value = "Questão 2";
                worksheet.Cell("A4").Value = "Questão 3";
                worksheet.Cell("A5").Value = "Questão 4";

                worksheet.Cell("B2").Value = VariaveisGlobais.P1Ti;
                worksheet.Cell("C2").Value = VariaveisGlobais.P1Pi;
                worksheet.Cell("D2").Value = VariaveisGlobais.P1Ni;
                worksheet.Cell("E2").Value = VariaveisGlobais.P1Na;

                worksheet.Cell("B3").Value = VariaveisGlobais.P2Ti;
                worksheet.Cell("C3").Value = VariaveisGlobais.P2Pi;
                worksheet.Cell("D3").Value = VariaveisGlobais.P2Ni;
                worksheet.Cell("E3").Value = VariaveisGlobais.P2Na;

                worksheet.Cell("B4").Value = VariaveisGlobais.P3Ti;
                worksheet.Cell("C4").Value = VariaveisGlobais.P3Pi;
                worksheet.Cell("D4").Value = VariaveisGlobais.P3Ni;
                worksheet.Cell("E4").Value = VariaveisGlobais.P3Na;

                worksheet.Cell("B5").Value = VariaveisGlobais.P4Ti;
                worksheet.Cell("C5").Value = VariaveisGlobais.P4Pi;
                worksheet.Cell("D5").Value = VariaveisGlobais.P4Ni;
                worksheet.Cell("E5").Value = VariaveisGlobais.P4Na;

                workbook.SaveAs(@"c:\temp\TesteExcel.xlsx");
            }
        }
    }
}
