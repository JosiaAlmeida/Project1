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
        protected long id { get; set; }
        public gravarficheiro()
        {
            StreamReader streamread = new StreamReader(@".\file.txt");
            var textStream = streamread.ReadToEnd();
            string[] Split = textStream.Split(' '); 
            this.id = Split.Length;
            streamread.Dispose();
        }
        public void RecordFile()
        {
           StreamWriter ficheiro = new StreamWriter(@".\file.txt", true, Encoding.Default);
        }
        public void RecordFilesInscritos(List<string> inscrever)
        {
            var path = @".\file.txt";
            ConvertId _id = new ConvertId();
            StreamWriter ficheiro = new StreamWriter(path, true, Encoding.Default);
            ficheiro.Write((_id.IDVerific(id.ToString()) + 1) + "-");
            foreach (var item in inscrever)
            {
                ficheiro.Write(item +";");
            }
            ficheiro.Write(" \n");
            ficheiro.Dispose();
        }
    }
}
