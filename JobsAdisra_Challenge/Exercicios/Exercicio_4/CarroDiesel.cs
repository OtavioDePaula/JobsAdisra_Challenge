using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_4
{
    class CarroDiesel : Carro
    {
        public double CapacidadeCarga { get; set; }
        public int VolumeCarga { get; set; }

        public CarroDiesel(double capacidadeCarga, int volumeCarga, int numeroMotor, int numeroChassi, double custoProducao, double imposto) : base(numeroMotor, numeroChassi, custoProducao, imposto)
        {
            CapacidadeCarga = capacidadeCarga;
            VolumeCarga = volumeCarga;
            NumeroMotor = numeroMotor;
            NumeroChassi = numeroChassi;
            CustoProducao = custoProducao;
            Imposto = imposto;
        }

        

   
    }
}
