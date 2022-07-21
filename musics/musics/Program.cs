using System;

namespace musics
{
    class Program
    {
        enum Opcao { Consultar = 1, Adicionar, Deletar }
        static void Main(string[] args)
        {
            Console.WriteLine("Você está no melhor programa de músicas!\n\nDigite o número da opção desejada: ");
            Console.WriteLine("1-Consultar lista de músicas\n2-Adicionar música à lista\n3-Deletar música da lista\n");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            if (index == 1)
            {
                Console.WriteLine("*****lista de musicas do banco de dados*****");
            }
            else if(index == 2)
            {
                Console.WriteLine("Digite o nome da música que você quer adicionar à lista:");
                Console.ReadLine(); //captar aqui o que for digitado pelo usuário e armazenar no bd
                string index2 = Console.ReadLine();
                if (index2 == /*qualquer música do bd*/)
                {
                    Console.WriteLine("Essa música já está na lista! Aproveite!");
                }
                else
                {
                    /*adiciona música no bd*/
                    Console.WriteLine("Música adicionada! Deseja visualizar a lista completa novamente?\n\nDigite 1 para SIM\nDigite 2 para NÃO");
                    int index3 = int.Parse(Console.ReadLine());
                    if (index3 == 1)
                    {
                        Console.WriteLine("*****Lista atualizada de músicas*****");
                    }
                    else if (index3 == 2)
                    {
                        Console.WriteLine("Tudo bem! Aproveite sua lista super hiper mega legal de músicas!");
                    }
                    else
                    {
                        Console.WriteLine("Você quer um café? Parece estar meio dormindo aí...");
                    }
                }
            }
            else if(index == 3)
            {
                Console.WriteLine("Qual música você quer deletar da lista?");
                Console.ReadLine(); //captar novamente o nome inserido
                string index4 = Console.ReadLine(); 
                if (index4 == /*a alguma música do bd*/)
                {
                    Console.WriteLine("Música localizada! Deseja mesmo excluí-la?\nDigite 1 para SIM\n Digite 2 para NÂO");
                    Console.ReadLine();
                    int index5 = int.Parse(Console.ReadLine());
                    if (index5 == 1)
                    {
                        /*exclui música do bd*/
                        Console.WriteLine("Música fora da lista! Eu não gostava dela mesmo...");
                    }
                    else if (index5 == 2)
                    {
                        Console.WriteLine("Mudou de ideia, né? Deixa ela aí então.");
                    }
                    else
                    {
                        Console.WriteLine("Você quer um café? Parece estar meio dormindo aí...");
                    }
                }
            }
            else
            {
                Console.WriteLine("Olha, não sei o que você quer...");
            }
            Console.ReadLine();
        }
    }
}
