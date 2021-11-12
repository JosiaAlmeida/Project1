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
using Projeto1.Formulario;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Consultarbtn_Click(object sender, EventArgs e)
        {
        }

        private void Listarbtn_Click(object sender, EventArgs e)
        {
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
        }

        private void Atualizarbtn_Click(object sender, EventArgs e)
        {
        }

        private void Estatisticabtn_Click(object sender, EventArgs e)
        {
        }

        private void Inscreverbtn_Click(object sender, EventArgs e)
        {
            Inscrever inscrever = new Inscrever();
            inscrever.Show();
        }

        private void ConsultarBtn_Click_1(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();
        }

        private void ListarBtn_Click_1(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.Show();
        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void EstatisticaBtn_Click_1(object sender, EventArgs e)
        {
            Estatistica estatistica = new Estatistica();
            estatistica.Show();
        }

        private void IntegrantesBtn_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarBtn_Click_1(object sender, EventArgs e)
        {
            Atualizar atualizar = new Atualizar();
            atualizar.Show();
        }
    }
}
