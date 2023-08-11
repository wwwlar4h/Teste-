class atv2
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Informe o nome do aluno: ");
            string nome = Convert.ToString(Console.ReadLine());

            Gabarito g = new Gabarito();
            Prova provaAluno = new Prova(g); //esse é o gabarito da prova.

            for (int i = 0; i < provaAluno.respostaAluno.Length; i++)
            {
                Console.Write($"Informe a resposta da questão {i + 1}: ");
                char resposta = Convert.ToChar(Console.ReadLine());
                provaAluno.RespostaAluno(char.ToUpper(resposta));
            }
            Console.WriteLine($"Quantidade de acertos: {provaAluno.Acertos()}");
            Console.WriteLine($"Nota: {provaAluno.Nota()}");

            Console.WriteLine("Deseja continuar? 1- Sim. 2- Não.");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 2)
            {
                break;
            }
        }
    }
}