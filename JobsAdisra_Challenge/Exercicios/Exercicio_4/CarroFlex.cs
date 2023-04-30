using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_4
{
    class CarroFlex : Carro
    {
        public int NumeroPortas { get; set; }

        public int Cilindrada { get; set; }

        public CarroFlex(int numeroPortas, int cilindrada, int numeroMotor, int numeroChassi, double custoProducao, double imposto) : base(numeroMotor, numeroChassi, custoProducao, imposto)
        {
            NumeroPortas = numeroPortas;
            Cilindrada = cilindrada;
            NumeroMotor = numeroMotor;
            NumeroChassi = numeroChassi;
            CustoProducao = custoProducao;
            Imposto = imposto;
        }
    }
}
