namespace AbstractFactory.Services.Interfaces;

public interface IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber);
}