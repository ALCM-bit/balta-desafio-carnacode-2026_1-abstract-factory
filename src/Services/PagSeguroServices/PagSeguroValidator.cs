using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguroServices;

public class PagSeguroValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}