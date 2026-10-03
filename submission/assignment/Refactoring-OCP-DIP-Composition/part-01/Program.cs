using RefactoringLab;

var aramex = new ShippingCostCalculator(new Aramex());
var fedEx = new ShippingCostCalculator(new FedEx());
var dhl = new ShippingCostCalculator(new DHL());
var bosta = new ShippingCostCalculator(new Bosta());

Console.WriteLine($"Aramex 2kg → {aramex.Calculate(2)}");
Console.WriteLine($"FedEx 2kg  → {fedEx.Calculate(2)}");
Console.WriteLine($"DHL 2kg  → {dhl.Calculate(2)}");
Console.WriteLine($"Bosta 2kg  → {bosta.Calculate(2)}");
Console.WriteLine();

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender()); 
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new Notification(
    new EmailNotification(),
    isUrgent: true,
    isScheduled: true,
    sendAt: DateTime.Today.AddHours(18)
)
.Send("customer@example.com", "Your order ships tomorrow");

new Notification(
    new SmsNotification(),
    isUrgent: true
)
.Send("+201000000000", "OTP 4821");

new Notification(
    new WhatsAppNotification(),
    isUrgent: true,
    isScheduled: true,
    sendAt: DateTime.Today.AddHours(20)
)
.Send("+201000000000", "Your order is ready");