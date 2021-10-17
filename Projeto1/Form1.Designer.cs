
namespace Projeto1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Consultarbtn = new System.Windows.Forms.Button();
            this.Listarbtn = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.Atualizarbtn = new System.Windows.Forms.Button();
            this.Estatisticabtn = new System.Windows.Forms.Button();
            this.Integrantebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inscrever";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultarbtn
            // 
            this.Consultarbtn.Location = new System.Drawing.Point(172, 87);
            this.Consultarbtn.Name = "Consultarbtn";
            this.Consultarbtn.Size = new System.Drawing.Size(95, 23);
            this.Consultarbtn.TabIndex = 1;
            this.Consultarbtn.Text = "Consultar";
            this.Consultarbtn.UseVisualStyleBackColor = true;
            this.Consultarbtn.Click += new System.EventHandler(this.Consultarbtn_Click);
            // 
            // Listarbtn
            // 
            this.Listarbtn.Location = new System.Drawing.Point(172, 141);
            this.Listarbtn.Name = "Listarbtn";
            this.Listarbtn.Size = new System.Drawing.Size(95, 23);
            this.Listarbtn.TabIndex = 2;
            this.Listarbtn.Text = "Listar";
            this.Listarbtn.UseVisualStyleBackColor = true;
            this.Listarbtn.Click += new System.EventHandler(this.Listarbtn_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Location = new System.Drawing.Point(172, 188);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(95, 23);
            this.Eliminarbtn.TabIndex = 3;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // Atualizarbtn
            // 
            this.Atualizarbtn.Location = new System.Drawing.Point(172, 234);
            this.Atualizarbtn.Name = "Atualizarbtn";
            this.Atualizarbtn.Size = new System.Drawing.Size(95, 23);
            this.Atualizarbtn.TabIndex = 4;
            this.Atualizarbtn.Text = "Atualizar";
            this.Atualizarbtn.UseVisualStyleBackColor = true;
            this.Atualizarbtn.Click += new System.EventHandler(this.Atualizarbtn_Click);
            // 
            // Estatisticabtn
            // 
            this.Estatisticabtn.Location = new System.Drawing.Point(172, 274);
            this.Estatisticabtn.Name = "Estatisticabtn";
            this.Estatisticabtn.Size = new System.Drawing.Size(95, 23);
            this.Estatisticabtn.TabIndex = 5;
            this.Estatisticabtn.Text = "Estatistica";
            this.Estatisticabtn.UseVisualStyleBackColor = true;
            this.Estatisticabtn.Click += new System.EventHandler(this.Estatisticabtn_Click);
            // 
            // Integrantebtn
            // 
            this.Integrantebtn.Location = new System.Drawing.Point(341, 141);
            this.Integrantebtn.Name = "Integrantebtn";
            this.Integrantebtn.Size = new System.Drawing.Size(95, 23);
            this.Integrantebtn.TabIndex = 6;
            this.Integrantebtn.Text = "Integrantes";
            this.Integrantebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 321);
            this.Controls.Add(this.Integrantebtn);
            this.Controls.Add(this.Estatisticabtn);
            this.Controls.Add(this.Atualizarbtn);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Listarbtn);
            this.Controls.Add(this.Consultarbtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Consultarbtn;
        private System.Windows.Forms.Button Listarbtn;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button Atualizarbtn;
        private System.Windows.Forms.Button Estatisticabtn;
        private System.Windows.Forms.Button Integrantebtn;
    }
}

