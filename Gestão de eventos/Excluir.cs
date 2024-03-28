namespace Gestão_de_eventos
{
    public static class Excluir                                                     //Classe de excluir evento
    {
        public static long excluir;                                   //Várivel para receber o valor do ID do evento para excluir
        public static void ExcluirEventoPorId()                                         //Função de excluir evento
        {
            if (Cadastro.i == 0)                                                    //Se não efetuou o cadastro 
            {

                Console.Clear();                                                    //Limpa tudo escrito antes
                Console.WriteLine("O cadastro dos eventos ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum evento.");
            }

            else                                                                    //Se realizou o cadastro
            {
                try                                                                      // Confere se o código abaixo possui algum erro
                {
                    Console.Clear();                                                //Limpa tudo escrito antes
                    Console.Write("Qual o ID do evento que deseja excluir? ");
                    excluir = long.Parse(Console.ReadLine()!);              //Recebe o ID do evento que deseja excluir
                    int Posicao_excluir = Array.IndexOf(ID.id, excluir);  //Recebe a posição no array que corresponde ao ID informado

                    for (int i = Posicao_excluir; i < Cadastro.quant - 1; i++)       //Estrutura de repetição para excluir um evento
                    {
                        ID.id[i] = ID.id[i + 1];                         //ID atual recebe o ID da próxima posição
                        Evento.titulo[i] = Evento.titulo[i + 1];         //Título atual recebe o título da próxima posição
                        Evento.data[i] = Evento.data[i + 1];             //Data atual recebe a data da próxima posição
                        Evento.hora_inicial[i] = Evento.hora_inicial[i + 1];//Hora inicial atual recebe a hora inicial da próxima posição
                        Evento.hora_final[i] = Evento.hora_final[i + 1];      //Hora final atual recebe a hora final da próxima posição
                        Evento.descricao[i] = Evento.descricao[i + 1];              //Descrição atual recebe a descrição da próxima posição
                        Evento.quant_pessoas[i] = Evento.quant_pessoas[i + 1]; //Quantidade atual recebe a quantidade da próxima posição
                        Evento.publico_alvo[i] = Evento.publico_alvo[i + 1];  //Público alvo atual recebe o público alvo da próxima posição
                        Evento.nome[i] = Evento.nome[i + 1];                  //Nome atual recebe o nome próxima posição
                        Evento.telefone[i] = Evento.telefone[i + 1];          //Telefone atual recebe o telefone da próxima posição
                        Evento.email[i] = Evento.email[i + 1];                //E-mail atual recebe o e-mail da próxima posição

                    }
                                          
                    Cadastro.quant--;
                    Console.Clear();                                                            //Limpa tudo escrito antes
                    Console.WriteLine($"Evento com o ID {excluir} foi excluido com sucesso.");
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
