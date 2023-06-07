using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4_Leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis

            string nome; string sobrenome;

            int idade;
            
            //nome
            
            Console.Write("digite seu nome: ");

            nome = Console.ReadLine();

            Console.Write("\n");

            //sobrenome
            
            Console.Write("Digite seu sobrenome: ");

            sobrenome = Console.ReadLine();

            Console.Write("\n");

            Console.Write("digite sua idade: ");

            idade = Int32.Parse( Console.ReadLine() );

            Console.Write("\n\n");

            //saudações

            Console.WriteLine($"seja bem vindo(a) {nome} {sobrenome}!");

            Console.WriteLine($"Daqui a 5 anos o(a) Sr(a) {sobrenome} vai ter {idade + 5} anos");

            Console.Write($"você nasceu em: {2023 - idade}");

            Console.ReadKey();
        
        }

        void Revisao() 
        
        { 
        
                       //lanches
            
            string x_tudo = "X-tudo"; string cachorro_quente = "Cachorro-quente cremoso"; string a_moda = "A moda da casa";

            //ingredientes

            float lanche = 8.00f; float salsicha = 1.50f; float hamburguer = 2.00f; float requeijao = 1.50f; float bacon = 2.00f;

            //valor dos lanches
            
            float soma = hamburguer + bacon + salsicha + lanche;

            float soma1 = requeijao + (2 * salsicha) + lanche;

            float soma2 = lanche + salsicha + hamburguer + requeijao + bacon;

            float combo = soma + soma1 + soma2;  

            //programa
            
            Console.WriteLine("Cardápio do contadito Lanxes");

            Console.WriteLine("Valores:");

            Console.WriteLine($"X-Tudo: hamburguer, bacon e salsicha - R${soma}");

            Console.WriteLine($"Cachorro-quente cremoso: 2 salsichas e requeijão - R${soma1}");

            Console.WriteLine($"A moda da casa: salsicha, hamburguer, requeijão e bacon - R${soma2}");

            Console.Write("\n\n\n");
            
            Console.WriteLine($"Combo: X-tudo + Cachorro-quente cremoso + A moda da casa - R${combo}");

            Console.ReadKey();        
        
        }

    }
}
