using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.classes
{
    public class InscreverClass
    {
        public void inscreve(string name, string lasname, string curso, string sexo, string numeBi)
        {
            List<string> candidatoData = new List<string>();
            candidatoData.Add(name);
            candidatoData.Add(lasname);
            candidatoData.Add(curso);
            candidatoData.Add(sexo);
            candidatoData.Add(numeBi);
            gravarficheiro stream = new gravarficheiro();
            stream.RecordFilesInscritos(candidatoData);
        }
    }
}
