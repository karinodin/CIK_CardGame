namespace ChicagoCardGame.Rules
{
    public interface IRule
    {
        public bool ValidateRule(Hand hand);
    }
}