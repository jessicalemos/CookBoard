using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookboard.Models
{
    public class PassosViewModel
    {
        public PassosViewModel(int numPasso, string passo)
        {
            NumPasso = numPasso;
            Passo = passo;
        }

        public int NumPasso { get; set; }
        public string Passo { get; set; }
    }
}
