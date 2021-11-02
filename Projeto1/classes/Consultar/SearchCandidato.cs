using Projeto1.classes.Inscrever;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.classes.Consultar
{
    class SearchCandidato
    {
        public string Search(int id)
        {
            ManipulandoId manipulandoId = new ManipulandoId();
            return manipulandoId.SearchId(id);
        }
    }
}
