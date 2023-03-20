using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Game
    {
        private int code;
        private string name;
        private string category;
        private DateTime releaseDate;

        public int GetCode() => code;
        public void SetCode(int code)
        {
            if (code <= 0)
            {
                throw new Exception("Code cannot be less than 0 (zero)");
            }
            else
            {
                this.code = code;
            }
        }
        public string GetName() => name;
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            else
            {
                this.name = name;
            }
        }
        public string GetCategory() => category;
        public void SetCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                throw new Exception("Category cannot be empty");
            }
            else
            {
                this.category = category;
            }
        }
        public DateTime GetReleaseDate() => releaseDate;
        public void SetReleaseDate(DateTime date)
        {
            this.releaseDate = date;
        }
    }
}
