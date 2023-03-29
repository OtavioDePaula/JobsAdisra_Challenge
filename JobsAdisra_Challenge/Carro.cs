using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge
{
    abstract class Carro
    {
        public int NumeroMotor { get; set; }
        public int NumeroChassi { get; set; }
        public double CustoProducao { get; set; }

        private double calculoCustoProducao()
        {
            return 5;
        }
    }
}
