using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPagoServices;

public class MercadoPagoFactory: IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymnetLogger()
    {
        return new MercadoPagoLogger();
    }

    public IPaymentProcessor CreatePaumentProcessor()
    {
        return new MercadoPagoProcessor();

    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new MercadoPagoValidator();
    }
}