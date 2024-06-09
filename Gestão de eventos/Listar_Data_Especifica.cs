namespace Gestão_de_eventos
{
    public static class Listar_Data_Especifica         //Classe para listar evento por data especifica
    {

        public static void ListarPorDataEspecifica()   //Função para listar evento por data especifica
        {
            if (Cadastro.i == 0)         //Se não efetuou o cadastro dos eventos
            {

                Console.Clear();                        
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

            else                                          //Se já fez o cadastro dos eventos
            {
                try
                {
                    Console.Clear();                         
                    Console.Write("Digite a data do evento que deseja buscar: ");
                    DateTime data_desejada = DateTime.Parse(Console.ReadLine()!);//Variável para receber o valor da data que deseja buscar
                    Console.Clear();                                           
                    bool sem_data = false;   
                    bool com_data = false;   

                    for (int i = 0; i < Cadastro.quant; i++)       //Estrutura de repetição para listar o evento por data especifica
                        
                    {
                        if (data_desejada.Equals(Evento.data[i]))       //Se a data digitada é igual a data existente

                        {
                            Console.WriteLine($"O evento que corresponde a data {data_desejada.ToString("dd/MM/yyyy")} é: \n");
                            Console.WriteLine("=========================================================");  //Listagem do evento
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
                            com_data = true;  

                        }

                        else if (!data_desejada.Equals(Evento.data[i]))         //Se a data digitada é diferente da data existente

                        {
                            sem_data = true; 
                        }
                    }

                    if (sem_data == true && com_data == true) { }        // Se achar alguma data entre os eventos e também achar nenhuma data irá executar

                    else if (sem_data == true && com_data == false)     // Se não achar alguma data entre os eventos irá executar

                    {
                        Console.WriteLine("A data do evento não foi encontrada.");
                    }

                    else if (sem_data == false && com_data == true) { }     // Se todos os eventos tiverem a mesma data irá executar

                   }

                catch (Exception ex) //Verifica se o codigo tem algum erro

                {
                    Console.Clear();                                     
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");//Escreve qual erro ocorreu
                }

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
            Console.ReadKey();
            Console.Clear();                                                

        }  
    }
}
