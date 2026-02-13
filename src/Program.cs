
using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPagoServices;
using AbstractFactory.Services.PagSeguroServices;
using AbstractFactory.Services.StripeServices;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

PaymentService paymentMercadoPagoService = new PaymentService(new MercadoPagoFactory());
paymentMercadoPagoService.ProcessPayment(200.000m, "1234567890123456");

Console.WriteLine("\n------------------------------------------------------------------------------\n");

PaymentService paymentPagSeguroService = new PaymentService(new PagSeguroFactory());
paymentPagSeguroService.ProcessPayment(100.000m, "5234567890123456");

Console.WriteLine("\n------------------------------------------------------------------------------\n");

PaymentService paymentStripeService = new PaymentService(new StripeFactory());
paymentStripeService.ProcessPayment(120.000m, "4234567890123456");

Console.WriteLine("\nDone.");