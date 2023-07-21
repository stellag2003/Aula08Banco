using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula08
{
    class Program
    {
        static List<string> nomes = new List<string>();


        static void Main(string[] args)
        {

            int posicao;
         
            Console.WriteLine("Cadastro de usuarios:");
            Console.WriteLine("-1 Cadastrar");
            Console.WriteLine("-2 Buscar");
            Console.WriteLine("-3 Deletar");
            Console.WriteLine("-4 Alterar");
            Console.WriteLine("-5 Lista usuários cadastrados");
            Console.WriteLine("Digite uma das opcoes acima");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o seu nome");
                nomes.Add(Console.ReadLine());
                Console.WriteLine("Nome cadastrado com sucesso!");
            }


            if (opcao == 2)
            {
                
                if (nomes.Count == 0)
                {
                    Console.WriteLine("A lista ainda esta vazia");
                    Main(null);
                }

                Console.WriteLine("Qual a posicao do nome que deseja buscar?");
                posicao = int.Parse(Console.ReadLine());


                if (posicao > nomes.Count -1)
                {
                    Console.WriteLine("Essa posicao nao existe");
                    Main(null);
                    Console.ReadKey();
                }

                Console.WriteLine($"{nomes[posicao]}");
                Main(null);
                return;
            }


            if (opcao == 3)
            {
                Console.WriteLine("Para deletar um item da lista digite a posição dele");
                posicao = int.Parse(Console.ReadLine());


                if (posicao > nomes.Count-1)
                {
                    Console.WriteLine("Essa posicao nao existe");
                }

                else
                {
                    string itemRemovido = nomes[posicao];
                    nomes.RemoveAt(posicao);
                    Console.WriteLine($"Registro '{itemRemovido}' deletado com sucesso");
                }

            }

            if(opcao == 4)
            {
                Console.WriteLine("Digite o nome de alguém de dentro da lista:");
                string nome1 = Console.ReadLine();

                if (nomes.Contains(nome1))
                {

                    nomes.Remove(nome1);
                    Console.WriteLine("Agora digite o novo nome:");
                    nomes.Add(Console.ReadLine());

                    Console.WriteLine($"Nome adicionado com sucesso!");

                }

                else
                {
                    Console.WriteLine("Digite um nome válido.");
                    Main(null);
                    return;
                }

                
            }

            if(opcao == 5)
            {
                Console.WriteLine($"Esses são os nomes contidos na lista:"); ;
                int contador = 0;
                while(contador < nomes.Count)
                {
                    Console.WriteLine(nomes[contador]);
                   contador++;                  

                }

                
            }





            Main(null);
            return;


        }
    }
}
