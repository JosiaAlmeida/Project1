using Projeto1.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto1.Formulario
{
    public partial class Inscrever : Form
    {
        public Inscrever()
        {
            InitializeComponent();
        }

        private void Inscrever_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inscreverbtn_Click(object sender, EventArgs e)
        {

            var path = @".\file.txt";
            InscreverClass inscrever = new InscreverClass();
            inscrever.inscreve(nametxt.Text, lastNametxt.Text, cursotxt.Text, idadeDUP.Text, sexoDUP.Text);
            StreamReader stream = new StreamReader(path);
            resultlb.Text = stream.ReadToEnd();
            stream.Dispose();
        }
    }
}
