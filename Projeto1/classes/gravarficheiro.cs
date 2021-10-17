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
            var path = @".\file.txt";
            //ConvertId _id = new ConvertId();
            //StreamReader streamread = new StreamReader(path);
            //var textStream = streamread.ReadToEnd();
            //streamread.Dispose();

            StreamWriter ficheiro = new StreamWriter(path, true, Encoding.Default);
            //if (!textStream.Equals("") || textStream !=" " || textStream != null)
            //{
                //string id = split[0];
                //ficheiro.Write((_id.IDVerific(id) + 1) + " ");
            //}else
            //{
           //     string id = "0 ";
           //     ficheiro.Write("1 ");
           // }
            foreach (var item in inscrever)
            {
                ficheiro.Write(item +" ");
            }
            ficheiro.Write("\n");
            ficheiro.Dispose();
        }
    }
}
