//Crie um Menu oferecendo prestacao de servicos
//Crie um cadastro para usuario solicitar
//Crie uma Lista de Produtos ecom respectivos precos
//permita uma promocao de vendas

internal class Program
{
  private static void Main(string[] args)
    {
        string[] nomes = new string[1];
        string[] servicos = new string[1];
        string[] ofertas = new string[1];
        string[] datas = new string[1]; //data = "dd/mm/aaaa"
        string[] escolha = new string[1];           
        }
        Console.WriteLine($"****Vamos ficar sempre lindas******");
        Console.WriteLine($"****Aproveite nossas Ofertas*****");
        Console.WriteLine($"****Podologia e manicure juntas******");

        //menu de opções
        Console.WriteLine($"*****Menu inicial*****");
        Console.WriteLine($"Selecione uma opção:");
        Console.WriteLine($"[1] - Cadastre seu Nome");
        Console.WriteLine($"[2] - Quero apenas Podologia");
        Console.WriteLine($"[3] - Quero apenas Manicure");
        Console.WriteLine($"[4] - Quero a oferta pologia com Manicure");
        Console.WriteLine($"[0] - Operacao invalida");

        escolha = Console.ReadLine();

        switch (servicos)
        {
            case "1":

                string resposta;

                do
                {
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Para cadastro, informe seu nome: ");
                        nomes[i] = Console.ReadLine();

                        Console.WriteLine($"Apenas Podologia: ");
                        podologia[i] = Console.ReadLine();

                        Console.WriteLine($"Apenas Manicure: ");
                        manicure[i] = Console.ReadLine();

                        Console.WriteLine($"Promocao Podologia com Manicure: ");
                        podologiaComManicure[i] = Console.ReadLine();

                        Console.WriteLine($"Informe a data desejada: ");
                        datas[i] = Console.ReadLine();
                    }

                    Console.WriteLine($"Gostaria agendar mais um servico ? s/n");
                    resposta = Console.ReadLine().ToLower();

                } while (resposta == "s");
                break;
            case "2":
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine(@$"
            -------------------
            Agendamento Efetuado

            Nome: {nomes[i]}
            Opcao:{Podologia[i]}
            Opcao:{manicure[i]}
            Opcao:{Oferta promocional Podologia com manicure}
            Data: {datas[i]}            
            ");
                }
                break;
            case "0":
                Console.WriteLine($"Aguardamos visita futura");
                break;
            default:
                Console.WriteLine($"Sua Opção foi inválida");
                break;  
    }
}  
