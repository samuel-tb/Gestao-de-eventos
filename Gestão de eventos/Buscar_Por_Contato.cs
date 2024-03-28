namespace Gestão_de_eventos
{
    public static class Buscar_Por_Contato          //Classe para buscar evento por contato
    {
        public static void BuscaContato()           //Função para buscar o contato
        {
            if (Cadastro.i == 0)                    //Se não tiver realizado o cadastro 
            {

                Console.Clear();
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

            else                                    // Se tiver realizado o cadastro
            {
                try                                 //Confere se o código possui algum erro
                {
                    Console.Clear();                //Limpa tudo escrito antes
                    Console.Write("Digite o nome do contato que deseja buscar: ");
                    string contato_desejado = Console.ReadLine()!;
                    Console.Clear();                //Limpa tudo escrito antes
                    bool sem_contato = false; // Atribuido valor falso
                    bool com_contato = false;// Atribuido valor falso

                    for (int i = 0; i < Cadastro.quant; i++)   //Estrutura de repetição para exibir o evento de acordo com o contato digitado

                    {
                        
                        if (contato_desejado.Equals(Evento.nome[i])) //Se o contato digitado é igual ao contato existente

                        {
                            Console.WriteLine($"O evento correspondente a o {contato_desejado} é: \n");
                            Console.WriteLine("========================================================="); //Listagem de evento
                            Console.WriteLine($"ID - {ID.id[i]}");
                            Console.WriteLine($"Título - {Evento.titulo[i]}");
                            Console.WriteLine($"Data - {Evento.data[i].ToString("dd/MM/yyyy")}"); 
                            Console.WriteLine($"Hora Inicial - {Evento.hora_inicial[i].ToString("HH:mm:ss")} horas");
                            Console.WriteLine($"Hora Final - {Evento.hora_final[i].ToString("HH:mm:ss")} horas");
                            Console.WriteLine($"Quantidade de pessoas - {Evento.quant_pessoas[i]} pessoas");
                            Console.WriteLine($"Publico alvo - {Evento.publico_alvo[i]}");
                            Console.WriteLine($"Descrição - {Evento.descricao[i]}");
                            Console.WriteLine($"Telefone de contato - {Evento.telefone[i]}");
                            Console.WriteLine($"E-mail de contato - {Evento.email[i]}");
                            Console.WriteLine("=========================================================\n");
                            com_contato = true; // Atribuido valor verdadeiro

                        }

                        else if (!contato_desejado.Equals(Evento.nome[i]))     //Se o contato digitado for diferente do contato existente

                        {
                            sem_contato = true;
                        }
                    }

                    if (sem_contato == true && com_contato == true) { } // Se achar algum contato entre os eventos e também achar nenhum contato irá executar

                    else if (sem_contato == true && com_contato == false) // Se não achar algum contato entre os eventos irá executar

                    {
                        Console.WriteLine("O contato não foi encontrado.");
                    }

                    else if (sem_contato == false && com_contato == true) { } // Se todos os eventos tiverem o mesmo contato irá executar

                    else if (Cadastro.quant == 0)                   //Se não houver eventos cadastrados
                        
                    {
                        Console.WriteLine("O contato não foi encontrado.");
                    }

                }

                catch (Exception ex)            //Se tiver algum erro no código

                {
                    Console.Clear();            //Limpa tudo escrito antes
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções");
            Console.ReadKey();
            Console.Clear();                    //Limpa tudo escrito antes

        }
    }
}
