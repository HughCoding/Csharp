public class Treinamento
{
    public void Treinar(Militar[] militares)
    {
        foreach (var m in militares)
        {
            m.Operacao();
        }
    }
}