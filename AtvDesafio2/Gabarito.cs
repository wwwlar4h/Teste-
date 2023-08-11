public class Gabarito
{
    public char[] gabCorreto = { 'A', 'E', 'C', 'D', 'A', 'C', 'D', 'A', 'B', 'C', 'D', 'E', 'B', 'C', 'E' };

    public char RespostaQuestao(int nQuestao)
    {
        return this.gabCorreto[nQuestao];
    }
}