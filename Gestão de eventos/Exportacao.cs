using static System.Reflection.Metadata.BlobBuilder;

namespace Gestão_de_eventos
{
    public static class Exportacao
    {

        public static void DadosDeEvento()                                  //Função para exportar para arquivo txt
        {
            
            if (Cadastro.i == 0)                                        //Se não realizou o cadastro
            {

                Console.Clear();                                            //Limpa tudo escrito antes
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

                        
            else                                                       //Se já efetuou o cadastro
            {
                try                                                                //Confere se o código abaixo possui algum erro
                {
                    Console.Clear();                                                //Limpa tudo escrito antes
                    string evento = @"c:\Gerenciamento de Eventos";     //Criando uma variavel que recebe o nome de uma pasta                       

                    if (!Directory.Exists(evento))   //Confere se a pasta existe no computador do usuário, se não existir, então ele executa
                    {
                        Directory.CreateDirectory(evento);     //Cria uma pasta no computador do usuário           
                    }

                    StreamWriter sw;                   //Variável utilizada para escrever no arquivo de texto                                     
                    if (File.Exists(@"c:\Gerenciamento de Eventos\Evento.txt")) //Confere se o arquivo de texto existe no computador, se ele existir ele executa       
                    {
                        File.Delete(@"c:\Gerenciamento de Eventos\Evento.txt");   //Deleta o arquivo de texto do computador    
                    }

                    sw = new StreamWriter(@"c:\Gerenciamento de Eventos\Evento.txt");//Cria o arquivo de texto do computador dentro da pasta criada acima

                    //Obs: Fiz esses comandos acima para não repetir a listagem de eventos no arquivo toda vez que executar o programa, assim fazendo com que aparece os eventos apenas uma vez toda vez que executar o programa
                    Console.Write("Digite o ID do evento que deseja exportar para o arquivo txt: ");
                    long ID_desejado = long.Parse(Console.ReadLine()!);                     //Recebe o valor do ID que deseja exportar
                    Console.Clear();
                    bool sem_id = false;     // Atribuido valor falso
                    bool com_id = false;     // Atribuido valor falso

                    for (int i = 0; i < Cadastro.quant; i++)                //Estrura de repetição para escrever o evento no arquivo txt

                    {
                        if (ID_desejado.Equals(ID.id[i]))                  //Se o ID digitado é igual a um ID existente

                        {
                            sw.WriteLine("=========================================================");          //Listagem do evento
                            sw.WriteLine($"ID - {ID.id[i]}");
                            sw.WriteLine($"Título - {Evento.titulo[i]}");
                            sw.WriteLine($"Data - {Evento.data[i].ToString("dd/MM/yyyy")}");
                            sw.WriteLine($"Hora Inicial - {Evento.hora_inicial[i].ToString("HH:mm:ss")} horas");
                            sw.WriteLine($"Hora Final - {Evento.hora_final[i].ToString("HH:mm:ss")} horas");
                            sw.WriteLine($"Quantidade de pessoas - {Evento.quant_pessoas[i]} pessoas");
                            sw.WriteLine($"Publico alvo - {Evento.publico_alvo[i]}");
                            sw.WriteLine($"Descrição - {Evento.descricao[i]}");
                            sw.WriteLine($"Nome de contato - {Evento.nome[i]}");
                            sw.WriteLine($"Telefone de contato - {Evento.telefone[i]}");
                            sw.WriteLine($"E-mail de contato - {Evento.email[i]}");
                            sw.WriteLine("=========================================================\n");
                            com_id = true;          // Atribuido valor verdadeiro 
                            Console.WriteLine("Evento já foi exportado para o arquivo texto em c:Gerenciamento de Eventos:Evento.txt");

                        }

                        else if (!ID_desejado.Equals(Evento.data[i]))  //Se o ID digitato é diferente a um ID existente

                        {
                            sem_id = true;    // Atribuido valor verdadeiro 
                        }
                    }
                    

                    if (sem_id == true && com_id == true) { } // Se achar algum ID entre os eventos e também achar nenhum ID irá executar

                    else if (sem_id == true && com_id == false) // Se não achar algum ID entre os eventos irá executar

                    {
                        Console.WriteLine("O ID do evento não foi encontrada.");
                    }

                    else if (sem_id == false && com_id == true) { } // Se todos os eventos tiverem o mesmo ID irá executar

                    else if (Cadastro.quant == 0)  //Se não houver eventos cadastrados

                    {
                        Console.WriteLine("O ID do evento não foi encontrada.");
                    }
                    sw.Close();  //Fecha o arquivo txt
                }

                catch (Exception ex)                //Verifica se o código tem algum erro

                {
                    Console.Clear();                                    //Limpa tudo escrito antes
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");    //Escreve qual erro ocorreu
                }

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
            Console.ReadKey();
            Console.Clear();                                            //Limpa tudo escrito antes

        }

    }
}
