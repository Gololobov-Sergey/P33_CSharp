using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    class CreditCard
    {
        public event Action<string> ChangePIN;

        string pin;
        public string PIN 
        {
            get { return pin; }
            set 
            { 
                if(value.Length == 4 && int.TryParse(value, out _))
                {
                    pin = value;
                    if(ChangePIN != null)
                    {
                        ChangePIN("PIN changed");
                    }

                }
            } 
        }
        

    }
}
