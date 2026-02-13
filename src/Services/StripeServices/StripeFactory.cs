using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.StripeServices;

public class StripeFactory: IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymnetLogger()
    {
        return new StripeLogger();
    }

    public IPaymentProcessor CreatePaumentProcessor()
    {
        return new StripeProcessor();

    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new StripeValidator();
    }
}