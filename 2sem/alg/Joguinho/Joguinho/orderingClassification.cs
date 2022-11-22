using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Joguinho
{
    internal class orderingClassification
    {
        private string path = $"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\\Classification.txt";

        public Dictionary<string, double> dict;

        public orderingClassification()
        {
            using (StreamWriter w = File.AppendText(path));

            string[] textfile = File.ReadAllText(path).Split('\n');
            dict = new Dictionary<string, double>();

            foreach (string line in textfile)
            {
                string[] aux = line.Split('-');
                if (aux.Length == 2)
                {
                    dict.Add(aux[0], double.Parse(aux[1]));
                }
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public int total()
        {
            return dict.Count();
        }
    }
}
