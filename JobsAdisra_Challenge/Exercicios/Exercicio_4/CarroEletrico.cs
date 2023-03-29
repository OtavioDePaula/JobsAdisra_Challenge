using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_4
{
    class CarroEletrico : Carro
    {
        public double Potencia { get; set; }

        public int DuracaoBateria { get; set; }

        public CarroEletrico(double potencia, int duracaoBateria, int numeroMotor, int numeroChassi, double custoProducao, double imposto) : base(numeroMotor, numeroChassi, custoProducao, imposto)
        {
            Potencia = potencia;
            DuracaoBateria = duracaoBateria;
            NumeroMotor = numeroMotor;
            NumeroChassi = numeroChassi;
            CustoProducao = custoProducao;
            Imposto = imposto;
        }
    }
}
