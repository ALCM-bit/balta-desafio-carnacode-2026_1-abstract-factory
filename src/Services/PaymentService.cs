using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services;

public class PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
{
    private IPaymentGatewayFactory _paymentGatewayFactory = paymentGatewayFactory;

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        var logger = _paymentGatewayFactory.CreatePaymnetLogger();
        
        if (!_paymentGatewayFactory.CreatePaymentValidator().ValidateCard(cardNumber))
        {
            logger.Log("Cartão inválido");
            return;
        }

        var result = _paymentGatewayFactory.CreatePaumentProcessor().ProcessTransaction(amount, cardNumber);
        logger.Log($"Transação processada: {result}");
    }
}