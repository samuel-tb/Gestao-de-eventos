namespace Gestão_de_eventos
{
    public static class ID    //Classe ID
    {

        public static long[] id = new long[999]; //Variável para receber o ID do evento

        public static void GeradorDeId()            //Função para gerar ID
        {
            Random random = new Random();                   
            id[Cadastro.i] = random.Next(100000, 999999);       //Gera um ID aleatório de 6 dígitos
        }

        
    }

}

