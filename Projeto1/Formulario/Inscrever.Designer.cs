﻿
namespace Projeto1.Formulario
{
    partial class Inscrever
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
            this.inscreverbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MasculinoCB = new System.Windows.Forms.CheckBox();
            this.FemininoCB = new System.Windows.Forms.CheckBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.cursotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nBItxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idadeDUP = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.apelido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inscreverbtn
            // 
            this.inscreverbtn.Location = new System.Drawing.Point(191, 282);
            this.inscreverbtn.Name = "inscreverbtn";
            this.inscreverbtn.Size = new System.Drawing.Size(146, 33);
            this.inscreverbtn.TabIndex = 0;
            this.inscreverbtn.Text = "Inscrever";
            this.inscreverbtn.UseVisualStyleBackColor = true;
            this.inscreverbtn.Click += new System.EventHandler(this.inscreverbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MasculinoCB
            // 
            this.MasculinoCB.AutoSize = true;
            this.MasculinoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasculinoCB.Location = new System.Drawing.Point(16, 224);
            this.MasculinoCB.Name = "MasculinoCB";
            this.MasculinoCB.Size = new System.Drawing.Size(99, 24);
            this.MasculinoCB.TabIndex = 2;
            this.MasculinoCB.Text = "Masculino";
            this.MasculinoCB.UseVisualStyleBackColor = true;
            // 
            // FemininoCB
            // 
            this.FemininoCB.AutoSize = true;
            this.FemininoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemininoCB.Location = new System.Drawing.Point(125, 224);
            this.FemininoCB.Name = "FemininoCB";
            this.FemininoCB.Size = new System.Drawing.Size(99, 24);
            this.FemininoCB.TabIndex = 3;
            this.FemininoCB.Text = "Femenino";
            this.FemininoCB.UseVisualStyleBackColor = true;
            // 
            // nametxt
            // 
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Location = new System.Drawing.Point(79, 16);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(174, 20);
            this.nametxt.TabIndex = 4;
            // 
            // cursotxt
            // 
            this.cursotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cursotxt.Location = new System.Drawing.Point(17, 74);
            this.cursotxt.Name = "cursotxt";
            this.cursotxt.Size = new System.Drawing.Size(502, 20);
            this.cursotxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso";
            // 
            // nBItxt
            // 
            this.nBItxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nBItxt.Location = new System.Drawing.Point(17, 146);
            this.nBItxt.Name = "nBItxt";
            this.nBItxt.Size = new System.Drawing.Size(248, 20);
            this.nBItxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero do BI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idadeDUP
            // 
            this.idadeDUP.Items.Add("12");
            this.idadeDUP.Items.Add("13");
            this.idadeDUP.Items.Add("14");
            this.idadeDUP.Items.Add("15");
            this.idadeDUP.Items.Add("16");
            this.idadeDUP.Items.Add("17");
            this.idadeDUP.Items.Add("18");
            this.idadeDUP.Items.Add("19");
            this.idadeDUP.Items.Add("20");
            this.idadeDUP.Location = new System.Drawing.Point(345, 146);
            this.idadeDUP.Name = "idadeDUP";
            this.idadeDUP.Size = new System.Drawing.Size(174, 20);
            this.idadeDUP.TabIndex = 9;
            this.idadeDUP.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastNametxt
            // 
            this.lastNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNametxt.Location = new System.Drawing.Point(345, 16);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(174, 20);
            this.lastNametxt.TabIndex = 12;
            // 
            // apelido
            // 
            this.apelido.AutoSize = true;
            this.apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apelido.Location = new System.Drawing.Point(277, 16);
            this.apelido.Name = "apelido";
            this.apelido.Size = new System.Drawing.Size(62, 20);
            this.apelido.TabIndex = 11;
            this.apelido.Text = "Apelido";
            // 
            // Inscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 327);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.apelido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idadeDUP);
            this.Controls.Add(this.nBItxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cursotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.FemininoCB);
            this.Controls.Add(this.MasculinoCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inscreverbtn);
            this.Name = "Inscrever";
            this.Text = "Inscrever";
            this.Load += new System.EventHandler(this.Inscrever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inscreverbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox MasculinoCB;
        private System.Windows.Forms.CheckBox FemininoCB;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox cursotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nBItxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown idadeDUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.Label apelido;
    }
}