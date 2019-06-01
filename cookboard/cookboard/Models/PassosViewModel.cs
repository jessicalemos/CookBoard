using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookboard.Models
{
    public class PassosViewModel
    {
        public PassosViewModel(int numPasso, string passo, int prox, int ant, string type, int aux)
        {
            NumPassoProx = prox;
            NumPasso = numPasso;
            Passo = passo;
            Type = type;
            NumPassoAnt = ant;
            Auxiliar = aux;
        }

        public int Auxiliar { get; set; }
        public string Type { get; set; }
        public int NumPassoAnt { get; set; }
        public int NumPassoProx { get; set; }
        public int NumPasso { get; set; }
        public string Passo { get; set; }
    }
}
