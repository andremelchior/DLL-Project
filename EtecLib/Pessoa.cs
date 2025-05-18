using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecLib
{
    public abstract class Pessoa
    {
        protected string nome;
        public string Nome
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

        protected int idade;
        public int Idade
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

        public int Cpf { get; set; }

        protected double peso;
        public double Peso
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

        protected double altura;
        public double Altura
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
    }
}
