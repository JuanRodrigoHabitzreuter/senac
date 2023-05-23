using System;

namespace IntroCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("Escolha uma opção a seguir: ");
                Console.WriteLine("[1] Exercício 1");
                Console.WriteLine("[2] Exercício 2");
                Console.WriteLine("[3] Exercício 3");
                Console.WriteLine("[4] Exercício 4");
                Console.WriteLine("[5] Exercício 5");
                Console.WriteLine("[6] Use a sua criatividade");
                Console.WriteLine("[7] Encerrar");
                op = Convert.ToInt32(Console.ReadLine());


                switch (op)
                {

                    case 1:
                        {
                            Tabuada.CalculeATabuada();

                            break;
                        };
                    case 2:
                        {
                            Imc.CalculeOIMC();
							
                            break;
                        };
                    case 3:
                        {

                            double factoryCost, dealer, taxes, endValue;

                            Console.WriteLine("Inform facory cost: ");
                            factoryCost = Convert.ToDouble(Console.ReadLine());

                            dealer = factoryCost * (28 % 100) / 100;
                            Console.WriteLine($"dealer is:{dealer}");

                            taxes = factoryCost * (45 % 100) / 100;
                            Console.WriteLine($"taxes :{taxes}");

                            Console.WriteLine((2));
                            endValue = factoryCost + dealer + taxes;
                            Console.WriteLine($"End value is:{Math.Round(endValue,2)}");

                            Console.WriteLine();

                            break;
                        };
                    case 4:
                        {

                            double weight, totalweight = 0;
                            int person = 0;

                            do
                            {
                                Console.WriteLine("Report your weight:");
                                weight = Convert.ToDouble(Console.ReadLine());
                                person++;
                                totalweight += weight;
                                Console.WriteLine($"Total weight: {totalweight} kg tlack: {180 - totalweight} kg");
                            } while (totalweight <= 180);
                            Console.WriteLine($"maximum weight reached!");
                            Console.WriteLine($"{person}people enterred");

                            Console.WriteLine();

                            break;
                        };
                    case 5:
                        {

                            int[] aleatory = new int[15];
                            Random random = new Random();
                            
                            for (int i = 0; i < 15; i++)
                            {
                                aleatory[i] = random.Next(100);;
                                Console.WriteLine($"Number {i + 1} = {aleatory[i]}");
                            }

                            break;
                        };
                    case 6:
                        {
                            Console.WriteLine("Sendo criativo");
                            break;
                        };
                    case 7:
                        {
                            Console.WriteLine("Finalizando");
                            break;
                        };
                    default:
                        {
                            Console.WriteLine("Opção inválida");
                            break;
                        }
                }
            } while (op != 7);
            Console.WriteLine("Até mais");
        }
    }
}