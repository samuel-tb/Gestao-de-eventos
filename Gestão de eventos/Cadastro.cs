using System.Linq.Expressions;
using System.Xml;

namespace Gestão_de_eventos
{
    public static class Cadastro                                    //Classe de cadastro
    {
        public static int i=0;                                      //Variável usada para repetição
        public static int quant;                                    //Variável para receber quantos eventos deseja cadastrar
       
        public static void Cadastrar()                              //Função para cadastrar os eventos
        {
            Console.Clear();                                        

            if (i == 0)                                             //Caso não tenha cadastrado 
            {
                try                                                              // Confere se o código abaixo possui algum erro
                {
                    Console.Clear();                                            //Limpa tudo escrito antes
                    Console.WriteLine(">>>>> Cadastro <<<<<");
                    Console.Write("Quantos eventos deseja cadastrar ? ");
                    quant = int.Parse(Console.ReadLine()!);                         //Recebe o valor de quantos eventos vai cadastrar
                    for (i = 0; i < quant; i++)                                     //Estrutura de repetição para cadastrar os eventos
                    {
                        Console.WriteLine("====================================================================");
                        Console.Write($"Digite o título do {i + 1}° evento: ");
                        Evento.titulo[i] = Console.ReadLine()!;                         //Recebe o valor de título

                        Console.Write($"Digite a data do {i + 1}° evento (ex:dd/MM/yyyy): ");
                        Evento.data[i] = DateTime.Parse(Console.ReadLine()!);           //Recebe o valor da data do evento
                        
                        Console.Write($"Digite a hora inicial do {i + 1}° evento (ex:HH:mm:ss): ");
                        Evento.hora_inicial[i] = DateTime.Parse(Console.ReadLine()!);               //Recebe o valor de hora inicial

                        Console.Write($"Digite a hora final do {i + 1}° evento (ex:HH:mm:ss): ");
                        Evento.hora_final[i] = DateTime.Parse(Console.ReadLine()!);             //Recebe o valor de hora final

                        Console.Write($"Digite a descrição do {i + 1}° evento: ");
                        Evento.descricao[i] = Console.ReadLine()!;                          //Recebe o valor de descrição
                            
                        Console.Write($"Digite a quantidade aproximada/prevista de pessoas do {i + 1}° evento: ");
                        Evento.quant_pessoas[i] = int.Parse(Console.ReadLine()!);           //Recebe o valor da quantidade de pessoas

                        Console.Write($"Digite o público alvo: ");
                        Evento.publico_alvo[i] = Console.ReadLine()!;                           //Recebe o valor de público alvo

                        Console.Write($"Digite o nome de contato do {i + 1}° evento: ");
                        Evento.nome[i] = Console.ReadLine()!;                                   //Recebe o valor do nome de contato

                        Console.Write($"Digite o telefone de contato do {i + 1}° evento: ");
                        Evento.telefone[i] = Console.ReadLine()!;                           //Recebe o valor de telefone de contato

                        Console.Write($"Digite o e-mail de contato do {i + 1}° evento: ");
                        Evento.email[i] = Console.ReadLine()!;                          //Recebe o valor de e-mail de contato

                        ID.GeradorDeId();
                        Console.WriteLine($"\nO ID correspondente ao evento {Evento.titulo[i]} é: {ID.id[i]}");     //Informa o ID correspondente ao evento informado
                        Console.WriteLine("====================================================================");  
                        Console.WriteLine("");                                                                      

                    }
                    Console.WriteLine("Cadastro Concluido.");
                }

                catch (Exception ex)                                    //Verifica se o código possui algum erro 

                {
                    Console.Clear();                                    
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");    //Escreve qual erro ocorreu
                    Console.WriteLine("\nFaça o cadastro novamente.");
                    i = 0;                                                  //Retorna o valor de i para começar o cadastro de novo
                }

            }

            else if (i != 0)                    //Caso tenha realizado o cadastro

            {
                Console.WriteLine("O cadastro já foi feito.");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                             
            Console.Clear();                                            
        }


    }

    


}
