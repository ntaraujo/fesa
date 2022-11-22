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
            orderingClassification ordering = new orderingClassification();
            int length = ordering.getDict().Count();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{length+1}:{name}-{points}");
            }
        }
    }
}
