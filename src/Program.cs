
using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPagoServices;

Console.WriteLine("Starting...\n");

PaymentService paymentMercadoPagoService = new PaymentService(new MercadoPagoFactory());
paymentMercadoPagoService.ProcessPayment(200.000m, "1234567890123456");

Console.WriteLine("\nDone.");