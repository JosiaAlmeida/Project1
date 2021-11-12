using Projeto1.Repository;
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
    public partial class Listar : Form
    {
        public Listar()
        {
            this.ShowList();
            InitializeComponent();
        }
        public void ShowList()
        {
            CandidatoRepository candidato = new CandidatoRepository();
            var ListData = candidato.Listar();
            List<string> candidatos1 = new List<string>();
            foreach (var item in ListData)
            {
                candidatos1.Add(item.Replace("-", " ").Replace(";", " "));
                GridViewGV.Rows.Add(item);
            }
            
        }
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar_Load(object sender, EventArgs e)
        {

        }
    }
}
