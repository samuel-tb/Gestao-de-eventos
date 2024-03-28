namespace Gestão_de_eventos
{
    public static class Editar                      //Classe de editar um evento
    {
        public static long editar;               //Váriavel usada para receber o ID do evento que deseja editar
        public static int opcao;                 //Váriavel que vai receber o valor da opção informada
        public static string valor_editado;      //Variável usada para receber o valor que será alterado
        public static DateTime data_hora_editada;   //Variável usada para receber a data alterada
        public static void EditarUmEvento()             //Função para editar evento
        {
            if (Cadastro.i == 0)                                                //Caso não tenha cadastrado um evento
            {

                Console.Clear();                                                        //Limpa tudo escrito antes
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

            else                                                                //Caso já tenha cadastrado um evento
            {
                try                                                             // Confere se o código abaixo possui algum erro
                {
                    Console.Clear();                                            //Limpa tudo escrito antes
                    Console.Write("Qual o ID do evento que deseja editar? ");
                    editar = long.Parse(Console.ReadLine()!);                   //Recebe o valor do id do evento para editar
                    int Posicao_editar = Array.IndexOf(ID.id, editar);    //Recebe a posição no array correspondente ao id informado
                    Console.Clear();                                                 //Limpa tudo escrito antes
                    Console.WriteLine("========================================");          //Opções do menu
                    Console.WriteLine("1 - Título");
                    Console.WriteLine("2 - Data");
                    Console.WriteLine("3 - Hora inicial");
                    Console.WriteLine("4 - Hora final");
                    Console.WriteLine("5 - Descrição");
                    Console.WriteLine("6 - Quantidade de pessoas");
                    Console.WriteLine("7 - Público alvo");
                    Console.WriteLine("8 - Nome de contato");
                    Console.WriteLine("9 - Telefone de contato");
                    Console.WriteLine("10 - E-mail de contato");
                    Console.WriteLine("========================================");
                    Console.Write($"\nQual informação do evento {editar} deseja editar? ");
                    opcao = int.Parse(Console.ReadLine()!);                                         //Recebe o valor da opção
                    switch (opcao)                                                                  //Armazena a opção
                    {
                        case 1:                                                                     //Caso a opção for 1

                            Console.Clear();                                                        //Limpa tudo escrito antes
                            Console.Write("Informe o novo título do evento: ");
                            valor_editado = Console.ReadLine()!;                                    //Recebe o valor novo
                            Evento.titulo[Posicao_editar] = valor_editado;                  //O Titulo recebe o novo valor
                            Console.WriteLine("Título alterado com sucesso.");
                            break;

                        case 2:                                                                     //Caso a opção for 2

                            Console.Clear();                                                        //Limpa tudo escrito antes
                            Console.Write("Informe a nova data do evento (ex:dd/MM/yyyy): ");
                            data_hora_editada = DateTime.Parse(Console.ReadLine()!);                //Recebe o valor novo
                            Evento.data[Posicao_editar] = data_hora_editada;                     //Data recebe o novo valor
                            Console.WriteLine("Data alterada com sucesso.");
                            break;

                        case 3:                                                                     //Caso a opção for 3

                            Console.Clear();                                                        //Limpa tudo escrito antes
                            Console.Write("Informe a nova hora inicial do evento (ex:HH:mm:ss): ");
                            data_hora_editada = DateTime.Parse(Console.ReadLine()!);                //Recebe o valor novo
                            Evento.hora_inicial[Posicao_editar] = data_hora_editada;            //Hora inicial recebe o novo valor
                            Console.WriteLine("Hora inicial alterada com sucesso.");
                            break;

                        case 4:                                                                     //Caso a opção for 4

                            Console.Clear();                                                        //Limpa tudo escrito antes
                            Console.Write("Informe a nova hora final do evento (ex:HH:mm:ss): ");
                            data_hora_editada = DateTime.Parse(Console.ReadLine()!);                //Recebe o valor novo
                            Evento.hora_final[Posicao_editar] = data_hora_editada;           //Hora final recebe o novo valor
                            Console.WriteLine("Hora final alterada com sucesso.");
                            break;

                        case 5:                                                                 //Caso a opção 5

                            Console.Clear();                                                    //Limpa tudo escrito antes
                            Console.Write("Informe a nova descrição do evento: ");
                            valor_editado = Console.ReadLine()!;                                //Recebe o valor novo
                            Evento.descricao[Posicao_editar] = valor_editado;                      //Descrição recebe o novo valor
                            Console.WriteLine("Descrição alterada com sucesso.");
                            break;

                        case 6:                                                                     //Caso a opção for 6

                            Console.Clear();                                                        //Limpa tudo escrito antes
                            Console.Write("Informe a nova quantidade de pessoas do evento: ");
                            valor_editado = Console.ReadLine()!;                                    //Recebe o valor novo
                            Evento.quant_pessoas[Posicao_editar] = int.Parse(valor_editado);        //Quantidade de pessoas recebe um 
                            Console.WriteLine("Quantidade de pessoas alterada com sucesso.");       // novo valor
                            break;

                        case 7:                                                                 //Caso a opção for 7

                            Console.Clear();                                                    //Limpa tudo escrito antes
                            Console.Write("Informe o novo público alvo do evento: ");
                            valor_editado = Console.ReadLine()!;                                //Recebe o valor novo
                            Evento.publico_alvo[Posicao_editar] = valor_editado;                 //Público alvo recebe um novo valor
                            Console.WriteLine("Publico alvo alterado com sucesso.");
                            break;

                        case 8:                                                             //Caso a opção for 8

                            Console.Clear();                                                //Limpa tudo escrito antes
                            Console.Write("Informe o novo nome de contato do evento: ");
                            valor_editado = Console.ReadLine()!;                            //Recebe o valor novo
                            Evento.nome[Posicao_editar] = valor_editado;                     //Nome de contato recebe um novo valor
                            Console.WriteLine("Nome de contato alterado com sucesso.");
                            break;

                        case 9:                                                             //Caso a opção for 9

                            Console.Clear();                                                 //Limpa tudo escrito antes
                            Console.Write("Informe o novo telefone de contato do evento: ");
                            valor_editado = Console.ReadLine()!;                                //Recebe o valor novo
                            Evento.telefone[Posicao_editar] = valor_editado;         //Telefone de contato recebe um novo valor
                            Console.WriteLine("Telefone de contato alterado com sucesso.");
                            break;

                        case 10:                                                            //Caso a opção for 10               

                            Console.Clear();                                                //Limpa tudo escrito antes
                            Console.Write("Informe o novo e-mail de contato do evento: ");
                            valor_editado = Console.ReadLine()!;                            //Recebe o valor novo
                            Evento.email[Posicao_editar] = valor_editado;                    //E-mail de contato recebe um novo valor
                            Console.WriteLine("E-mail de contato alterado com sucesso.");
                            break;

                        default:                                                                //Caso não for nenhuma das opções

                            Console.Clear();                                                    //Limpa tudo escrito antes
                            Console.WriteLine("Essa opção não existe.");
                            break;

                    }
                    
                }

                catch (Exception ex)                                                         //Verifica se o codigo tem algum erro

                {
                    Console.Clear();                                                                //Limpa tudo escrito antes
                    Console.WriteLine($"O ID do evento não foi encontrada.");                   //Informa que não encontrou o ID

                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
            Console.ReadKey();
            Console.Clear();                                                                    //Limpa tudo escrito antes
        }
    }
}
