
namespace Projeto1.Formulario
{
    partial class Listar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDoBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridViewGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridViewGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Curso,
            this.Idade,
            this.NumeroDoBi,
            this.Sexo});
            this.GridViewGV.DoubleBuffered = true;
            this.GridViewGV.EnableHeadersVisualStyles = false;
            this.GridViewGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GridViewGV.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.GridViewGV.Location = new System.Drawing.Point(1, 12);
            this.GridViewGV.Name = "GridViewGV";
            this.GridViewGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridViewGV.Size = new System.Drawing.Size(518, 380);
            this.GridViewGV.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 67;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            // 
            // NumeroDoBi
            // 
            this.NumeroDoBi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumeroDoBi.HeaderText = "Numero Do BI";
            this.NumeroDoBi.Name = "NumeroDoBi";
            this.NumeroDoBi.Width = 111;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(520, 389);
            this.Controls.Add(this.GridViewGV);
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid GridViewGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDoBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}