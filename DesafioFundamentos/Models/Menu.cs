namespace DesafioFundamentos.Models
{
    public class Menu {
        public static void exibirMenu(Estacionamento e)
        {
            string opcao = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("X - Encerrar");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        e.AdicionarVeiculo();
                        break;

                    case "2":
                        e.RemoverVeiculo();
                        break;

                    case "3":
                        e.ListarVeiculos();
                        break;

                    case "X":
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            } while (opcao != "X");
        }
    }
}