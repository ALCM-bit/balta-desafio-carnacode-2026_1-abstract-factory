namespace AbstractFactory.Services.Interfaces;

public interface IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymnetLogger();
    public IPaymentProcessor CreatePaumentProcessor();
    public IPaymentValidator CreatePaymentValidator();
}