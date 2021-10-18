using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.classes.Inscrever
{
    class ManipulandoId
    {
        StreamReader streamread = new StreamReader(@".\file.txt");
        public int GerarId()
        {
            var textStream = streamread.ReadToEnd();
            string[] Split = textStream.Split(' ');
            streamread.Dispose();
            return Split.Length;
        }
        public string SearchId(int id)
        {
            var textStream = streamread.ReadToEnd();
            return textStream.Contains(id.ToString()).ToString();
        }
    }
}
