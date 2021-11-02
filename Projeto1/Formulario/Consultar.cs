using Projeto1.classes.Consultar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Formulario
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchCandidato searchCandidato = new SearchCandidato();
            string Texto = searchCandidato.Search(int.Parse(searchIdTxt.Text));
            string strings = Texto.Replace(":"," ")
                .Replace(";"," ")
                .Replace("-"," ")
                .Replace(","," ");
            string[] Split = strings.Split(' ');
            nameTxt.Text = Split[1]+ " "+ Split[2];
            cursoTxt.Text = Split[3];
            IdadeTxt.Text = Split[4];
            SexoTxt.Text = Split[5];
            NumeroBiTxt.Text = Split[6];


        }
    }
}
