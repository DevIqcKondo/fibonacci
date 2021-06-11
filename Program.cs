using System;
using Figgle;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //A sequência de Fibonacci começa com 0 e 1, os números sequintes são sempre a soma dos dois números anteriores
            //Variável para armazenar o numero 0 e 1 
            //Variavel para armazenar o número de linhas da sequencia q o usuário escolher
            
            string opcao = "";
            string f = "Programa finalizado!";
            do{
                Console.WriteLine("__________________________");
                Console.WriteLine("| Sequência de Fibonacci |");
                Console.WriteLine("|________________________|");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Digite 1 para iniciar o programa.");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Digite 0 para sair.");
                Console.ResetColor();
                Console.Write("Digite sua opção --> ");
                opcao = Convert.ToString(Console.ReadLine());

                if(opcao == "1"){
                    fibonacci();

                }

            } while (opcao!="0");
                Console.WriteLine(FiggleFonts.Standard.Render(f));

        }
        static void fibonacci(){
            int c1=1;
            int c2=0;
            int c3=0;
            int x=0;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite a quantidade de números para serem exibidos da sequência de Fibonacci.");
            Console.Write("--> ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            for(int i=0;i<x;i++){
                Console.WriteLine(c2);
                c3 = c2;
                c2 = c1;
                c1 = c3 + c2;
            }
            Console.ReadLine();
            Console.Beep();

        }
    }
}
