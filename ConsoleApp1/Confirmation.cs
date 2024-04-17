using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // deklarasi class confirmation
    internal class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public Confirmation() { }

        // constructor confirmation
        public Confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
