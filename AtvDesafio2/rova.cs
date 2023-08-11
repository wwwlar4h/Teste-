public class Prova
{

    public char[] respostaAluno = new char[15];
    private Gabarito gab;

    public Prova(Gabarito gab)
    {
        this.gab = gab;
    }
    public void RespostaAluno(char resposta)
    {
        for (int i = 0; i < this.respostaAluno.Length; i++)
        {
            if (this.respostaAluno[i] == 0)
            {
                this.respostaAluno[i] = resposta;
                break;
            }
        }
    }
    public int Acertos()
    {
        int quantAcertos = 0;

        for (int i = 0; i < this.respostaAluno.Length; i++)
        {
            if (respostaAluno[i] == gab.RespostaQuestao(i))
            {
                quantAcertos += 1;
            }
        }
        return quantAcertos;
    }
    public double Nota()
    {
        double nota = 0;

        for (int i = 0; i < this.respostaAluno.Length; i++)
        {
            if (this.respostaAluno[i] == gab.RespostaQuestao(i))
            {
                if (i < 10)
                {
                    nota += 0.5;
                }
                else
                {
                    nota += 1;
                }
            }
        }
        return nota;
    }
}