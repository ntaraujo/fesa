using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Joguinho
{
    internal class SavingPoints
    {
        private string path = $"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\\Classification.txt";
        public void savingPoints(string name, int points)
        {
            int total = new orderingClassification().total();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{total+1}:{name}-{points}");
            }
        }
    }
}
