public class PesoIdealHomem : PesoIdealPessoa
{
    public override double GetPesoIdeal(double altura)
    {
        return (72.7 * altura) - 58;
    }
}
