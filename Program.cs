using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //informações
            string [] produtos = new string[10]; 
            float[] precos = new float [10];
            bool[] promocoes = new bool[10];

        Console.Clear();

            //declarações
            int escolha;
            int contador =0;
                do
                {
                    Console.WriteLine("Bem Vindo! Escolha entre as opções abaixo:");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("[1]- Cadastrar Produtos e preços");
                    Console.WriteLine("[2]- Listar Produtos");
                    Console.WriteLine("[3]- Mostrar Produtos em promoção");
                    Console.WriteLine("[0]- Sair");
                    escolha = int.Parse(Console.ReadLine());

                   switch (escolha)
                   {
                       case 1:
                        Console.WriteLine("Cadastrar Produtos");
                        Console.WriteLine("--------------------------");
                        do
                        {
                            if(contador <=10){
                                Console.WriteLine($"Escreva o nome do produto: ");
                                produtos[contador] = Console.ReadLine();

                                Console.WriteLine($"Digite o preço do produto:");
                                precos[contador] = float.Parse(Console.ReadLine());

                                Console.WriteLine($"Defina os produtos em promoção:");
                                promocoes[contador] = bool.Parse(Console.ReadLine());

                                contador++;
                            } else{
                                Console.WriteLine("Limite cadastramento de produtos excedido!");
                            }

                            
                        } while ();
                        break;  

                        case 2:
                        Console.WriteLine("Listagem de produtos");
                        Console.WriteLine("----------------------------");

                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Listagem: {produtos[i]}, Valores{precos[i]}, Ofertas{promocoes[i]}  ");
                        }

                        break;

                        case 3:
                        Console.WriteLine("Mostrar os produtos que vão estar em promoção");
                        Console.WriteLine("-----------------------------------------------");

                        
                           
                    default:
                        Console.WriteLine("");
                         break;
                      
                   }
                } while ();
           
        }
    }
}
