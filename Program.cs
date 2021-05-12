using System;

namespace Ex_passagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopSenha = true;
            do
            {
                Console.WriteLine("Insira a senha");
                string senha = Console.ReadLine();

                if (senha == "123456")
                {
                    string[] nomeP;
                    nomeP = new string[5];
                    string[] origem;
                    origem = new string[5];
                    string[] dest;
                    dest = new string[5];
                    string[] data;
                    data = new string[5];
                    int i = 0;

                    bool loop = true;
                    while (loop == true)
                    {
                        Console.WriteLine("qual opção deseja:");
                        Console.WriteLine("1- Cadastrar passagem");
                        Console.WriteLine("2- Listar Passagens");
                        Console.WriteLine("0- Sair");
                        string escolhaMenu = Console.ReadLine().Substring(0, 1).ToLower();

                        switch (escolhaMenu)
                        {
                            case "c":
                            case "1":

                                for (i = 0; i <= 5;)
                                {
                                    Console.WriteLine("Nome do passageiro:");
                                    nomeP[i] = Console.ReadLine();

                                    Console.WriteLine("Origem:");
                                    origem[i] = Console.ReadLine();

                                    Console.WriteLine("Destino:");
                                    dest[i] = Console.ReadLine();

                                    Console.WriteLine("Data do voo:");
                                    data[i] = Console.ReadLine();
                                    
                                    Console.WriteLine("Deseja cadastrar outra passagem?(s/n)");
                                    string resposta = Console.ReadLine().ToLower().Substring(0, 1);

                                    if (resposta == "n")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }

                                break;

                            case "l":
                            case "2":

                                for (var c = 0; c <= i; c++)
                                {
                                    Console.WriteLine($"nome:{nomeP[c]} | origem:{origem[c]} | destino:{dest[c]} | data:{data[c]}");
                                }
                                break;

                            case "s":
                            case "0":
                                loop = false;
                                break;

                            default:
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("senha incorreta");
                }
            } while (loopSenha == true);
        }
    }
}
