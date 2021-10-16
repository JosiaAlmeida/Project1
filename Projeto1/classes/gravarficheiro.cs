using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto1.classes
{
    public class gravarficheiro
    {
        public void RecordFile()
        {
           StreamWriter ficheiro = new StreamWriter(@".\file.txt", true, Encoding.Default);
        }
        public void RecordFilesInscritos(List<string> inscrever)
        {
            StreamWriter ficheiro = new StreamWriter(@".\file.txt", true, Encoding.Default);
            foreach (var item in inscrever)
            {
                ficheiro.WriteLine(item);
            }
            ficheiro.Dispose();
        }
    }
}
