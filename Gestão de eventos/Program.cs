namespace Gestão_de_eventos
{
    public static class Program
    {
        static int opcao;                                                                   //Váriavel para receber a opção
        static void Main(string[] args)
        {

            try                                                                             // Confere se o código abaixo possui algum erro
            { 
            Console.WriteLine("Bem-vindo a gerenciamento de eventos.");  
                while (!opcao.Equals(8))                                                    //Estrutura de repetição para repetir o menu
                {
                    Console.Clear();
                    Console.WriteLine("================= Menu =================");          //Menu de opções
                    Console.WriteLine("1 - Cadastrar Evento");
                    Console.WriteLine("2 - Listar Evento por período");
                    Console.WriteLine("3 - Pesquisar evento por data");
                    Console.WriteLine("4 - Editar informação de um evento");
                    Console.WriteLine("5 - Pesquisar um contato cadastrado");
                    Console.WriteLine("6 - Excluir um evento");
                    Console.WriteLine("7 - Exportar um evento para arquivo .txt");
                    Console.WriteLine("8 - Sair");
                    Console.WriteLine("========================================");
                    Console.Write("\nEscolha uma opção: ");
                    opcao = int.Parse(Console.ReadLine()!);                                 //Recebe o valor da opção


                    switch (opcao)                                                          //Armazena o valor da opção
                    {
                        case 1:                                                             //Caso a opção for 1

                            Cadastro.Cadastrar();                                           //Puxa a função de Cadastro
                            break;

                        case 2:                                                             //Caso a opção for 2

                            Listar_Evento.ListarEventoPorPeriodo();                         //Puxa a função de listar por período
                            break;

                        case 3:                                                             //Caso a opção for 3

                            Listar_Data_Especifica.ListarPorDataEspecifica();               //Puxa a função de listar por data especifica
                            break;

                        case 4:                                                             //Caso a opção for 4

                            Editar.EditarUmEvento();                                        //Puxa a função de editar um evento
                            break;

                        case 5:                                                             //Caso a opção for 5

                            Buscar_Por_Contato.BuscaContato();                              //Puxa a função de buscar contato
                            break;

                        case 6:                                                             //Caso a opção for 6

                            Excluir.ExcluirEventoPorId();                                   //Puxa a função de excluir um evento
                            break;

                        case 7:                                                             //Caso a opção for 7

                            Exportacao.DadosDeEvento();                                     //Puxa a função de exportação de dados
                            break;

                        case 8:                                                             //Caso a opção for 8

                            Console.Clear();                                                //Limpa tudo escrito antes
                            Console.WriteLine("Encerrando sistema...");
                            Console.WriteLine("\nPressione qualquer tecla para encerrar.");
                            Console.ReadKey();                                                                                     
                            Console.Clear();                                                //Limpa tudo escrito antes                                                                                      
                            break;

                        default:                                                            //Caso não for nenhum opção

                            Console.Clear();                                                //Limpa tudo escrito antes
                            Console.WriteLine("Essa opção não existe.");                     
                            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");          
                            Console.ReadKey();                                                             
                            Console.Clear();                                                //Limpa tudo escrito antes    
                            break;
                    }

                }
                
            }
            catch (Exception ex)                                                             // Verifica o código possui algum erro 

            {
                Console.Clear();                                                            //Limpa tudo escrito antes 
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");                        //Escreve qual erro ocorreu
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
                Console.ReadKey();
            }

        }
    }
}