namespace Gestão_de_eventos
{
    public static class Listar_Evento
    {

        public static void Listar()             //Função para listar os eventos
        {
            if (Cadastro.i == 0)                //Caso não tenha cadastrado um evento
            {
                Console.Clear();                //Limpa tudo escrito antes
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

            else                                //Caso já tenha efetuado um cadastro
            {
                try                                         //Confere se o código possui algum erro
                {
                    Console.Clear();            //Limpa tudo escrito antes
                    Console.WriteLine("Veja quais eventos vão acontecer entre os periodos informados:\n");
                    Console.Write("Digite a data inicial (ex:dd/MM/yyyy): ");
                    DateTime Data_Inicial = DateTime.Parse(Console.ReadLine()!);     //Converte a data inicial digitada para date time
                    Console.Write("Digite a data final (ex:dd/MM/yyyy): ");
                    DateTime Data_Final = DateTime.Parse(Console.ReadLine()!);       //Converte a data final digitada para date time   
                    Console.Clear();
                    bool Fora_do_Intervalo = false;    // Atribuido valor falso
                    bool Dentro_do_Intervalo = false; // Atribuido valor falso          
                
                    for(int i= 0; i < Cadastro.quant; i++){    //Estrutura de repetição para listar todos as datas cadastradas
                        
                        if(Data_Inicial < Evento.data[i] && Data_Final > Evento.data[i]){  //Se a data for maior que a Data inicial informada e menor que a data final informada será mostrado o evento 

                            
                            Console.WriteLine($"Data: {Evento.data[i].ToString("dd/MM/yyyy")}\n"); 
                            Console.WriteLine("=========================================================");//Listagem do evento
                            Console.WriteLine($"ID - {ID.id[i]}");
                            Console.WriteLine($"Título - {Evento.titulo[i]}");
                            Console.WriteLine($"Hora Inicial - {Evento.hora_inicial[i].ToString("HH:mm:ss")} horas");
                            Console.WriteLine($"Hora Final - {Evento.hora_final[i].ToString("HH:mm:ss")} horas");
                            Console.WriteLine($"Quantidade de pessoas - {Evento.quant_pessoas[i]}  pessoas");
                            Console.WriteLine($"Publico alvo - {Evento.publico_alvo[i]}");
                            Console.WriteLine($"Descrição - {Evento.descricao[i]}");
                            Console.WriteLine($"Nome de contato - {Evento.nome[i]}");
                            Console.WriteLine($"Telefone de contato - {Evento.telefone[i]}");
                            Console.WriteLine($"E-mail de contato - {Evento.email[i]}");
                            Console.WriteLine("=========================================================\n");
                            Dentro_do_Intervalo = true;// Atribuido valor verdadeiro

                        }       

                        else //Se nenhuma data registrada for entre as datas informadas irá executar

                        {
                            Fora_do_Intervalo = true; // Atribuido valor verdadeiro
                        }
                    }

                    if (Fora_do_Intervalo == true && Dentro_do_Intervalo == true) { }// Se achar algum ID entre os eventos e também achar nenhum ID irá executar

                    else if (Fora_do_Intervalo == true && Dentro_do_Intervalo == false) // Se não achar algum ID entre os eventos irá executar
                        
                    {
                        Console.WriteLine("A data do evento não foi encontrada.");
                    }

                    else if (Fora_do_Intervalo == false && Dentro_do_Intervalo == true) { }// Se todos os eventos tiverem o mesmo ID irá executar

                    else if (Cadastro.quant == 0) //Se não houver eventos cadastrados

                    {
                        Console.WriteLine("A data do evento não foi encontrada.");
                    }

                }                         

                catch (Exception ex)  //Verifica se o codigo tem algum erro

                {
                    Console.Clear();   //Limpa tudo escrito antes
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");        //Informa qual erro ocorreu 

                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
            Console.ReadKey();
            Console.Clear();                            //Limpa tudo escrito antes
        }

    }
}
