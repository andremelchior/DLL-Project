using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.Lib;

namespace DLL_Project
{
    internal class Aluno : Pessoa
    {
        private int rm;
        private string curso;
        private string periodo;

        public override void cadastrar()
        {
            base.cadastrar();

            Console.WriteLine("Digite o RM: ");
            this.rm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o curso: ");
            this.curso = Console.ReadLine();
            Console.WriteLine("Digite o periodo: ");
            this.periodo = Console.ReadLine();
        }
        public override void exibir()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"RM: {this.rm}");
            Console.WriteLine($"Curso: {this.curso}");
            Console.WriteLine($"Periodo: {this.periodo}");
        }
    }
}