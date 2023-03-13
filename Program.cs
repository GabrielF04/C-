using System;

namespace Calculator
{
    class Program   
    {
        static void Main(string[] args)
        {
            Menu();  
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Opções para serem utilizadas: ");
            Console.WriteLine("1- Soma:");
            Console.WriteLine("2- Subtração: ");
            Console.WriteLine("3- Divisão: ");
            Console.WriteLine("4- Multiplicação: ");
            Console.WriteLine("5- Sair");

            Console.WriteLine("___________");
            Console.WriteLine("Selecione uma das opções que deseja utilzar: ");
            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }



        }

        static void Soma()
        {
            Console.Clear();
           
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("");
            float Resultado = v1 + v2;
            Console.WriteLine("Resultado da soma é " + Resultado);
            //Console.WriteLine($"O resultado da soma é {Resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}"); 
            Console.ReadKey();
             Menu();          
            
            
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float s1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float s2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        
        float Result = s1-s2;
        //Console.WriteLine("O resultado da subtração é: " + Resultado);
        Console.WriteLine($"O resultado da subtração é:{Result}");
        Console.ReadKey();
         Menu(); 
        
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float d1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Primeiro valor: ");
        float d2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float Division = d1/d2;
        Console.WriteLine($"O resultado da divisão é {Division}");
        Console.ReadKey();
         Menu(); 

    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float m1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Primeiro valor: ");
         float m2 = float.Parse(Console.ReadLine());

         Console.WriteLine("");

         float multiplication = m1*m2;
         Console.WriteLine($"O resultado da multiplicação é {multiplication}");
         Console.ReadKey();
          Menu(); 
    }
 }
}