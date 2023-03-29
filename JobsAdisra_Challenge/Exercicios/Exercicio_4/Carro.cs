using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_4
{
    abstract class Carro
    {
        
        public int NumeroMotor { get; set; }
        public int NumeroChassi { get; set; }
        public double CustoProducao { get; set; }
        public double Imposto { get; set; }
        public double ValorVenda { get; set; }

        protected Carro(int numeroMotor, int numeroChassi, double custoProducao, double imposto)
        {
            NumeroMotor = numeroMotor;
            NumeroChassi = numeroChassi;
            CustoProducao = custoProducao;
            Imposto = imposto;
            setValorVenda();
        }

        public void setValorVenda()
        {
            double fabricaLucro = 25;
            fabricaLucro = CustoProducao * (fabricaLucro / 100);

            double valorImposto = CustoProducao * (Imposto / 100);
            double custoVenda = CustoProducao + valorImposto + fabricaLucro;
            ValorVenda = custoVenda;
        }
    }
}
