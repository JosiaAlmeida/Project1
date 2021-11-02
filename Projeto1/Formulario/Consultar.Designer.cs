
namespace Projeto1.Formulario
{
    partial class Consultar
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.cursoTxt = new System.Windows.Forms.TextBox();
            this.NumeroBiTxt = new System.Windows.Forms.TextBox();
            this.IdadeTxt = new System.Windows.Forms.TextBox();
            this.SexoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(144, 227);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(126, 26);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Buscar Candidato";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o numero de candidatura";
            // 
            // searchIdTxt
            // 
            this.searchIdTxt.Location = new System.Drawing.Point(305, 10);
            this.searchIdTxt.Name = "searchIdTxt";
            this.searchIdTxt.Size = new System.Drawing.Size(100, 20);
            this.searchIdTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero do BI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sexo";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(305, 41);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 8;
            // 
            // cursoTxt
            // 
            this.cursoTxt.Location = new System.Drawing.Point(305, 69);
            this.cursoTxt.Name = "cursoTxt";
            this.cursoTxt.Size = new System.Drawing.Size(100, 20);
            this.cursoTxt.TabIndex = 9;
            // 
            // NumeroBiTxt
            // 
            this.NumeroBiTxt.Location = new System.Drawing.Point(305, 95);
            this.NumeroBiTxt.Name = "NumeroBiTxt";
            this.NumeroBiTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroBiTxt.TabIndex = 10;
            // 
            // IdadeTxt
            // 
            this.IdadeTxt.Location = new System.Drawing.Point(305, 121);
            this.IdadeTxt.Name = "IdadeTxt";
            this.IdadeTxt.Size = new System.Drawing.Size(100, 20);
            this.IdadeTxt.TabIndex = 11;
            // 
            // SexoTxt
            // 
            this.SexoTxt.Location = new System.Drawing.Point(305, 148);
            this.SexoTxt.Name = "SexoTxt";
            this.SexoTxt.Size = new System.Drawing.Size(100, 20);
            this.SexoTxt.TabIndex = 12;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 265);
            this.Controls.Add(this.SexoTxt);
            this.Controls.Add(this.IdadeTxt);
            this.Controls.Add(this.NumeroBiTxt);
            this.Controls.Add(this.cursoTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox cursoTxt;
        private System.Windows.Forms.TextBox NumeroBiTxt;
        private System.Windows.Forms.TextBox IdadeTxt;
        private System.Windows.Forms.TextBox SexoTxt;
    }
}