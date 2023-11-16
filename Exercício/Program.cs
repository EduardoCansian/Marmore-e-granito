namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cadastro[] cadastro = new Cadastro[999];        // Atribuindo uma nova variável para chamar as variáveis do struct

            int opcao = 0;
            int quant = 0;

                Console.WriteLine("Bem vindo(a) ao sistema de gestão de blocos da Max Rochas e Produtos Ornamentais!");
                Console.WriteLine("");
            while (opcao != 5)          // Estrutura de repetição para retornar para o menu quando acabar cada opção exceto a 5 (Sair)
            {
                Console.WriteLine(">>>>>>> MENU <<<<<<<");      // Aqui está o menu principal com as opções
                Console.WriteLine("O que você deseja?");
                Console.WriteLine("1 - Cadastrar Blocos \n2 - Listar Blocos \n3 - Buscar bloco por código \n4 - Buscar bloco por pedreira \n5 - Sair");
                Console.Write("Escolha uma opção:");
                opcao = int.Parse(Console.ReadLine()!);

                if (opcao != 1)
                {
                    Console.Clear();
                    Console.WriteLine("Desculpe, ainda não há nenhum bloco cadastrado.");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    switch (opcao)
                    {
                        case 1:                  // Opção para cadastrar os blocos e suas informações (quantidade, nome, código, valor etc)
                            Console.Clear();
                            CadastarBloco();
                            break;
                        case 2:                 // Opção para listar os blocos cadastrados com suas informações inseridas
                            Console.Clear();
                            ListarBloco();
                            break;
                        case 3:                     // Opção para encontrar um bloco específico pelo seu código
                            Console.Clear();
                            BuscarBlocoPorCodigo();
                            break;
                        case 4:                     // Opção para listar os blocos pela sua pedreira
                            Console.Clear();
                            ListarBlocoPorPedreira();
                            break;
                        case 5:                     // Opção para sair do programa
                            Console.Clear();
                            Sair();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida, pressione qualquer tecla para retornar ao menu.");
                            Console.ReadKey();
                            Console.WriteLine("");
                            Console.Clear();
                            break;
                    }
                }
            }
            void CadastarBloco()
            {
                Console.WriteLine("----- CADASTRO DE BLOCOS -----");
                Console.WriteLine("Quantos blocos deseja cadastrar?");
                quant = int.Parse(Console.ReadLine()!);
                Console.Clear();
                for (int i = 0; i < quant; i++)
                {
                    Console.WriteLine($">>> {i + 1}º Cadastro <<<");
                    Console.Write("Insira o nome do bloco: ");
                    cadastro[i].nome = Console.ReadLine()!;

                    cadastro[i].codigo = new Random().Next(0, 99999);
                    cadastro[i].nbloco = new Random().Next(0, 999);

                    Console.WriteLine("");
                    Console.Write("Digite o tipo do bloco (Mármore ou Granito): ");
                    cadastro[i].tipo = Console.ReadLine()!;
                    Console.WriteLine("");
                    Console.Write("Insira as medidas de comprimento do bloco: ");
                    cadastro[i].medida_comp = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("");
                    Console.Write("Insira as medidas de largura do bloco: ");
                    cadastro[i].medida_lar = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("");
                    Console.Write("Agora as medidas de altura do bloco: ");
                    cadastro[i].medida_alt = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("");
                    Console.Write("Insira uma descrição do bloco: ");
                    cadastro[i].descricao = Console.ReadLine()!;
                    Console.WriteLine("");
                    Console.Write("Insira o valor de compra deste bloco: ");
                    cadastro[i].vcompra = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("");
                    Console.Write("Agora insira o valor de venda deste bloco: ");
                    cadastro[i].vvenda = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("");
                    Console.Write("Digite a pedreira onde se extraiu este bloco: ");
                    cadastro[i].pedreira = Console.ReadLine()!;

                    cadastro[i].medidatotal = cadastro[i].medida_comp * cadastro[i].medida_lar * cadastro[i].medida_lar;
                    Console.Clear();
                }
                Console.WriteLine("");
                Console.WriteLine("Cadastro realizado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial.");
                Console.ReadKey();
                Console.Clear();


            }
            void ListarBloco()
            {
                Console.WriteLine("----- LISTA DE BLOCOS -----");
                Console.WriteLine("");
                for(int i = 0; i < quant; i++)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"{i + 1}º Bloco Cadastrado:");
                    Console.WriteLine($"Nome: {cadastro[i].nome}");
                    Console.WriteLine($"Código: {cadastro[i].codigo}");
                    Console.WriteLine($"Número: Nº {cadastro[i].nbloco}");
                    Console.WriteLine($"Tipo: {cadastro[i].tipo}");
                    Console.WriteLine($"Medida: {cadastro[i].medidatotal}m³");
                    Console.WriteLine($"Descrição: {cadastro[i].descricao}");
                    Console.WriteLine($"Valor para compra: R$ {cadastro[i].vcompra}");
                    Console.WriteLine($"Valor para venda: R$ {cadastro[i].vvenda}");
                    Console.WriteLine($"Pedreira: {cadastro[i].pedreira}");
                }

                Console.WriteLine("");
                Console.WriteLine("Listamento relizado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial.");
                Console.ReadKey();
                Console.Clear();
            }

            void BuscarBlocoPorCodigo()
            {
                int novocodigo;
                Console.WriteLine(">>>>>>> ENCONTRAR BLOCO POR CÓDIGO <<<<<<<");
                Console.WriteLine("Insira o código do bloco que deseja encontrar:");
                novocodigo = int.Parse(Console.ReadLine()!);
                
                for (int i = 0; i < quant; i++)
                {
                    if (novocodigo == cadastro[i].codigo)
                    {
                        Console.WriteLine($"Bloco encontrado: \n--> Nome: {cadastro[i].nome} ({i+1}º Bloco)");
                        Console.WriteLine($"Código: {cadastro[i].codigo}");
                        Console.WriteLine($"Número: Nº {cadastro[i].nbloco}");
                        Console.WriteLine($"Tipo: {cadastro[i].tipo}");
                        Console.WriteLine($"Medida: {cadastro[i].medidatotal} m³");
                        Console.WriteLine($"Descrição: {cadastro[i].descricao}");
                        Console.WriteLine($"Valor para compra: R$ {cadastro[i].vcompra}");
                        Console.WriteLine($"Valor para venda: R$ {cadastro[i].vvenda}");
                        Console.WriteLine($"Pedreira: {cadastro[i].pedreira}");
                    }
                    else if(novocodigo != cadastro[i].codigo && i < quant-1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Desculpe, nenhum bloco cadastrado possui este código.");
                    }
                    
                }
                    Console.WriteLine("");
                    Console.WriteLine("Busca finalizada.");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial.");
                    Console.ReadKey();
                    Console.Clear();
            }
                

            void ListarBlocoPorPedreira()
            {
                Console.WriteLine(">>>>>>> LISTAR BLOCOS POR PEDREIRA <<<<<<<");
                Console.WriteLine("");

                for(int i = 0; i < quant; i++)
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine($"Pedreira: {cadastro[i].pedreira}");
                    Console.WriteLine($"Bloco encontrado nesta pedreira: {cadastro[i].nome} ({i+1}º Bloco)");
                    Console.WriteLine($"--- Informações principais --- \nCódigo: {cadastro[i].codigo}");
                    Console.WriteLine($"Número: Nº {cadastro[i].nbloco}");
                    Console.WriteLine($"Tipo: {cadastro[i].tipo}");
                    Console.WriteLine($"Medida: {cadastro[i].medidatotal} m³");
                    Console.WriteLine($"Preço para compra: R$ {cadastro[i].vcompra}");
                    Console.WriteLine($"Preço para venda: R$ {cadastro[i].vvenda}");

                }
                Console.WriteLine("");
                Console.WriteLine("Listamento relizado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial.");
                Console.ReadKey();
                Console.Clear();
            }

            void Sair()
            {
                Console.WriteLine("Obrigado por preferir a Max Rochas e Produtos Ornamentais!");
                Console.WriteLine("Tenha um ótimo dia e volte sempre! :D");
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
                Console.Clear();
                
            }
        }

        public struct Cadastro
        {
            public string nome;
            public int codigo;
            public int nbloco;
            public string tipo;
            public string descricao;
            public string pedreira;
            public decimal vcompra;
            public decimal vvenda;
            public decimal medida_alt;
            public decimal medida_lar;
            public decimal medida_comp;
            public decimal medidatotal;
        }

    }

}
