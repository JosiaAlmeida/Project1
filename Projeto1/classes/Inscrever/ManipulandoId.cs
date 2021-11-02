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
        private string textSearch {get;set;}
        StreamReader streamread = new StreamReader(@".\file.txt");
        public ManipulandoId()
        {
            this.textSearch= "vazio";
        }
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
            string[] text = textStream.Split(' ');
           /* foreach(var item in text){
                if (text.Contains(id.ToString()))
                {
                    textSearch = item.ToString();
                }
                else textSearch = item.ToString();
            }*/
            streamread.Dispose();
            return id < text.Length ? text[id - 1]: "Candidato inexistente";
        }
    }
}
