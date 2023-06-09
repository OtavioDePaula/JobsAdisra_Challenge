﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_2
{
    internal class MaisParesOuImpares
    {
        public string MaiorQuantidade(int[,] matriz, int numeroLinhas, int numeroColunas)
        {
            int contadorPar = 0;
            int contadorImpar = 0;

            foreach (var item in matriz)
            {
                if (item % 2 == 0)
                {
                    contadorPar++;
                }
                else
                {
                    contadorImpar++;
                }
            }

            if (contadorPar > contadorImpar)
            {
                return $"Possui {contadorPar} números pares.";
            }
            else
            {
                return $"Possui {contadorImpar} números ímpares.";
            }
        }
    }
}
