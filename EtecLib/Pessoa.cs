using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecLib
{
    public abstract class Pessoa
    {
        private string nome;
        protected string Nome
        {
            get
            {
                return nome.ToUpper();
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Nome inválido!");
                }
                else if (value.Length > 2)
                {
                    nome = value.ToUpper();
                }
                else
                {
                    Console.WriteLine("Nome inválido!");
                }
            }
        }

        private int idade;
        protected int Idade
        { 
            get 
            { 
                return idade; 
            } 
            set 
            {
                idade = value; 
            } 
        }

        protected int Cpf { get; set; }

        private double peso;
        protected double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if (!value.Equals(null))
                {
                    peso = value;
                }
                else
                {
                    Console.WriteLine("Peso inválido!");
                }
            }
        }

        private double altura;
        protected double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (!value.Equals(null))
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("Altura inválido!");
                }
            }
        }

        protected virtual void cadastrar()
        {
            Console.WriteLine("Digite o nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            this.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF: ");
            this.Cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso: ");
            this.Peso = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite a altura: ");
            this.Altura = double.Parse(Console.ReadLine());
        }

        protected abstract void exibir();

        protected double calcularIMC(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        protected void statusIMC(double imc)
        {
            Console.WriteLine($"O seu IMC é: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Status IMC: Magro");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Status IMC: Normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Status IMC: Sobrepeso");
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                Console.WriteLine("Status IMC: Obesidade");
            }
            else
            {
                Console.WriteLine("Status IMC: Obesidade Grave");
            }
        }

    }
}
