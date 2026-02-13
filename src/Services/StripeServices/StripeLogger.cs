using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.StripeServices;

public class StripeLogger: IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}