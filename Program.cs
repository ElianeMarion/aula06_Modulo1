namespace Aula06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string emailDoUsuario = "", senhaDoUsuario = "";
			int opcao;
			do
			{
				Console.Clear();
				Console.WriteLine(@"
███████╗██╗░█████╗░██████╗░  ██████╗░░█████╗░███╗░░██╗░█████╗░████████╗██╗░█████╗░███╗░░██╗
██╔════╝██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║
█████╗░░██║███████║██████╔╝  ██║░░██║██║░░██║██╔██╗██║███████║░░░██║░░░██║██║░░██║██╔██╗██║
██╔══╝░░██║██╔══██║██╔═══╝░  ██║░░██║██║░░██║██║╚████║██╔══██║░░░██║░░░██║██║░░██║██║╚████║
██║░░░░░██║██║░░██║██║░░░░░  ██████╔╝╚█████╔╝██║░╚███║██║░░██║░░░██║░░░██║╚█████╔╝██║░╚███║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░░░░  ╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝

░██████╗██╗░░░██╗░██████╗████████╗███████╗███╗░░░███╗
██╔════╝╚██╗░██╔╝██╔════╝╚══██╔══╝██╔════╝████╗░████║
╚█████╗░░╚████╔╝░╚█████╗░░░░██║░░░█████╗░░██╔████╔██║
░╚═══██╗░░╚██╔╝░░░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║
██████╔╝░░░██║░░░██████╔╝░░░██║░░░███████╗██║░╚═╝░██║
╚═════╝░░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝");

				Console.WriteLine("Boas vindas ao FIAP Donation System!");
				Thread.Sleep(2000);

				Console.WriteLine("Digite 1 para registrar um novo usuário");
				Console.WriteLine("Digite 2 para se logar");
				Console.WriteLine("Digite 3 para finalizar o sistema");
				opcao = Convert.ToInt16(Console.ReadLine());

				switch (opcao)
				{

					case 1: //else if (opcao == 1)

						Console.WriteLine("**********************");
						Console.WriteLine("Registro de usuário");
						Console.WriteLine("**********************\n");
						Console.Write("Digite o nome do usuário que deseja registrar: ");
						string nomeDoUsuario = Console.ReadLine()!;
						Console.Write("Digite o telefone do usuário: ");
						string telefoneDoUsuario = Console.ReadLine()!;
						Console.Write("Digite o e-mail do usuário: ");
						emailDoUsuario = Console.ReadLine()!;
						Console.Write("Digite a senha do usuário: ");
						senhaDoUsuario = Console.ReadLine()!;
						Console.Write("Digite o apelido do usuário: ");
						string apelidoDoUsuario = Console.ReadLine()!;

						Console.WriteLine($"\n\nO usuário {nomeDoUsuario} foi registrado com sucesso!");
						break;
					case 2://else
						Console.WriteLine("Digite o email cadastrado");
						string email = Console.ReadLine()!;
						Console.WriteLine("Digite sua senha");
						string senha = Console.ReadLine()!;
						if (email.Equals(emailDoUsuario) && senha.Equals(senhaDoUsuario))
						{
							int opcaoSubMenu = 0;
							do
							{
								Console.WriteLine("Usuário logado com sucesso!! Bem vinda(o) ");
								Console.WriteLine("\nDigite 1 para registrar um produto");
								Console.WriteLine("Digite 2 para mostrar os produtos");
								Console.WriteLine("Digite 3 para avaliar um produto");
								Console.WriteLine("Digite 4 para exibir a média de um produto");
								Console.WriteLine("Digite 0 para voltar para o menu principal");
								opcaoSubMenu = Convert.ToInt16(Console.ReadLine());
								switch (opcaoSubMenu)
								{
									case 1:
										Console.WriteLine("Registrar um produto");
										break;
									case 2:
										Console.WriteLine("Mostrar produtos");
										break;
									case 3:
										Console.WriteLine("Avaliar produto");
										break;
									case 4:
										Console.WriteLine();
										break;
								}
							} while (opcaoSubMenu != 0);

						}
						else
							Console.WriteLine("Usuário ou senha inválidos ");
						break;
					case 3: //if (opcao == 0)
						Console.WriteLine("Obrigada por usar nosso sistema!!");
						break;
					default:
						Console.WriteLine("Opção inválida");
						break;

				}
				Thread.Sleep(3000);
			} while (opcao != 3);

			Console.Clear();
		}
	}
}