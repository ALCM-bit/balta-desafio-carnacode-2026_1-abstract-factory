using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguroServices;

public class PagSeguroFactory: IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymnetLogger()
    {
        return new PagSeguroLogger();
    }

    public IPaymentProcessor CreatePaumentProcessor()
    {
        return new PagSeguroProcessor();

    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new PagSeguroValidator();
    }
}