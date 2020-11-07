using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReplacement
{
    class Coder
    {

        List<Element> table { get; set; }

        public Coder(string alp, string rep)
        {
            string[] alphabet = alp.Split(new char[] { ' ' });
            string[] replacment = rep.Split(new char[] { ' ' });
            table = new List<Element>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                Element adding = new Element(Convert.ToChar(alphabet[i]), Convert.ToChar( replacment[i]));
                table.Add(adding);

            }
        }

        public void ClearTeble ()
        {
            table.Clear();
        }

        public string Encode (string text)
        {
            if (table.Count==0)
            {
                throw new Exception("Table is empty");

            }
            char code;
            string chipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    if (table.Find(x => x.symbol == text[i])== null)
                    {
                       throw new Exception("Symbols is not find");
                    }
                    else
                    {
                        code = table.Find(x => x.symbol == text[i]).code;
                        chipher += code;

                    }
                }
                catch
                {
                    chipher = "0";
                    break;
                }
            }
            return chipher;
        }

        public string Decode(string codingText)
        {
            if (table.Count == 0)
            {
                throw new Exception("Table is empty");

            }
            char decode;
            string text = "";
            for (int i = 0; i < codingText.Length; i++)
            {
                try
                {
                    decode = table.Find(x => x.code == codingText[i]).symbol;
                    text += decode;
                }
                catch
                {
                    text = "0";
                    break;
                }
            }
            return text;
        }
    }
}
