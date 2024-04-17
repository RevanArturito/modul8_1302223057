
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankTransferConfig
    {
        public string lang {  get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }
         
        public BankTransferConfig() { }


        public BankTransferConfig(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
