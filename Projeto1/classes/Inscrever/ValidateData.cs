using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.classes.Inscrever
{
    class ValidateData
    {
        public bool state { get; set; }
        public ValidateData() {
            this.state = false;
        }
        public bool SendMessageError()
        {
            MessageBox.Show("Falha", "Houve um erro ao fazer login");
            return state;
        }
        public void ValidateStringEmpty(string name, string lastName, string Cours, string yearsOld, string sexo, string numeroBi)
        {
            InscreverClass inscrever = new InscreverClass();
            try
            {
                if (!name.Contains(" ") && !lastName.Contains(" ") && Cours.Length >= 1 && !numeroBi.Contains(" "))
                {
                    state = false;
                    inscrever.inscreve(name, lastName, Cours, yearsOld, sexo, numeroBi);
                    MessageBox.Show("Inscrição", "Inscrição feita com sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    state = true;
                    SendMessageError();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
