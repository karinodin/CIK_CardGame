namespace ChicagoCardGame.Rules
{
    public interface IRule
    {
        bool ValidateRule(Hand hand);
    }
}