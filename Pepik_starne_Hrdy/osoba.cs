using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepik_starne_Hrdy
{
    internal class osoba
    {
        public int Age { get; private set; }
        public void Starnout() 
        {
            Age++;
        }
    }

}
