
namespace Wa2_App
{
    partial class FormP2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP2));
            this.BtnJ = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnAvancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnJ
            // 
            this.BtnJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnJ.Location = new System.Drawing.Point(70, 507);
            this.BtnJ.Name = "BtnJ";
            this.BtnJ.Size = new System.Drawing.Size(52, 42);
            this.BtnJ.TabIndex = 9;
            this.BtnJ.Text = "J";
            this.BtnJ.UseVisualStyleBackColor = true;
            this.BtnJ.Click += new System.EventHandler(this.BtnJ_Click);
            // 
            // BtnR
            // 
            this.BtnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnR.Location = new System.Drawing.Point(12, 507);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(52, 42);
            this.BtnR.TabIndex = 8;
            this.BtnR.Text = "R";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 273);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVoltar.Location = new System.Drawing.Point(716, 526);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnAvancar
            // 
            this.BtnAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAvancar.Location = new System.Drawing.Point(797, 526);
            this.BtnAvancar.Name = "BtnAvancar";
            this.BtnAvancar.Size = new System.Drawing.Size(75, 23);
            this.BtnAvancar.TabIndex = 5;
            this.BtnAvancar.Text = "Avançar";
            this.BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // FormP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BtnJ);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAvancar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "002";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnJ;
        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAvancar;
    }
}