using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.Lib;

namespace DLL_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            double imc;

            aluno.cadastrar();
            aluno.exibir();

            imc = aluno.calcularIMC(aluno.Peso, aluno.Altura);
            Console.WriteLine("O seu IMC é: " + imc);
            aluno.statusIMC(imc);
        }
    }
}
