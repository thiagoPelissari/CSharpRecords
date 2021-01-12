using System;

namespace ConsoleRecords
{

    public class CPessoa
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }

        public CPessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string Nome, out string Sobrenome)
        {
            Nome = this.Nome;
            Sobrenome = this.Sobrenome;
        }
    }

    public record RPessoa(string Nome, string Sobrenome);

    public record RPessoa2(string Nome, string Sobrenome)
    {
        public string NomeCompleto { get => $"{Nome} {Sobrenome}"; }
    }

    public record RUser(int Id, string Nome, string Sobrenome) : RPessoa(Nome, Sobrenome);


    class Program
    {
        static void Main(string[] args)
        {
            //CLASSE
            CPessoa p1 = new CPessoa("Thiago", "Pelissari");
            CPessoa p2 = new CPessoa("Thiago", "Pelissari");
            CPessoa p3 = new CPessoa("Thiago", "Pellizzari");

            Console.WriteLine($"Visualizando Hash 1{ p1.GetHashCode()}");
            Console.WriteLine($"Visualizando Hash 2{ p2.GetHashCode()}");

            Console.WriteLine($"Resultado Classe: {p1.Nome} {p1.Sobrenome}");
            Console.WriteLine($"Verificando igualdade Classe: {Equals(p1, p3)}");
            Console.WriteLine($"Imprimindo OBjeto P1 String: {p1}");




            //Tupla 
            var (n2, s2) = p1;

            Console.WriteLine($"CLASSE Resultado Tupla. Nome:{n2} Sobrenome:{s2}");

            Console.WriteLine();



            //RECORDS
            RPessoa r1 = new RPessoa("Thiago", "Pelissari");
            RPessoa r2 = new RPessoa("Thiago", "Pelissari");
            RPessoa r3 = new RPessoa("Thiago", "Pellizzari");

            RPessoa2 r22 = new RPessoa2("Antonio", "Pelissari");
            Console.WriteLine(r22);

            Console.WriteLine($"Visualizando Hash 1{ r1.GetHashCode()}");
            Console.WriteLine($"Visualizando Hash 2{ r2.GetHashCode()}");
            Console.WriteLine($"Resultado Record: {r1.Nome} {r1.Sobrenome}");
            Console.WriteLine($"Verificando igualdade Record: {Equals(r1,r3)}");
            Console.WriteLine($"Imprimindo OBjeto R1 String: {r1}");


            //Tupla 
            var (n, s) = r1;

            Console.WriteLine($"RECORD Resultado Tupla. Nome:{n} Sobrenome:{s}");



        }

    }
}
