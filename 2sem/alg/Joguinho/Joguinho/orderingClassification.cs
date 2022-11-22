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

        public Dictionary<string, double> getDict()
        {
            using (StreamWriter w = File.AppendText(path));

            string[] textfile = File.ReadAllText(path).Split('\n');
            Dictionary<string, double> classDict = new Dictionary<string, double>();

            foreach (string line in textfile)
            {
                string[] aux = line.Split('-');
                if (aux.Length == 2)
                {
                    classDict.Add(aux[0], double.Parse(aux[1]));
                }
            }

            classDict = classDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, double> item in classDict)
            {
                Console.WriteLine(" {0} {1} ", item.Key, item.Value);
            }

            return classDict;
        }
}
}
