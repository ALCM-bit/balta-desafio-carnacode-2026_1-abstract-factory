namespace AbstractFactory.Services.Interfaces;

public interface IPaymentValidator
{
    public bool ValidateCard(string cardNumber);
}