# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

The original `ShippingCostCalculator` used a switch statement with a separate case for each shipping carrier. Adding a new carrier required modifying the existing calculator class.

- What did you change?

I introduced the `IShippingCostCalculator` abstraction and created a separate implementation for each carrier. `ShippingCostCalculator` now depends on the abstraction instead of containing carrier-specific logic. I also added `Bosta` as a new carrier without modifying the existing carrier classes.

---

## OrderProcessor

- What was the problem?

The original `OrderProcessor` directly created `SqlOrderRepository` and `SmtpEmailSender` inside the `Process` method. This created tight coupling to concrete implementations.

- What did you change?

I introduced `IOrderRepository` and `INotification` abstractions and used constructor injection to provide their implementations. `OrderProcessor` now depends on abstractions instead of concrete classes.

---

## Notifications

- What was the problem?

The original design used inheritance to represent combinations of notification channels, urgency, and scheduling. This resulted in separate classes such as `UrgentEmailNotification`, `UrgentSmsNotification`, and `UrgentScheduledEmailNotification`.

- What did you change?

I replaced the inheritance-based combinations with composition. `Notification` contains an `IChannel`, while urgency and scheduling are handled independently. This allows the same channel to be used as normal, urgent, scheduled, or urgent and scheduled without creating a separate class for each combination.

I also added `WhatsAppNotification` as a new notification channel without modifying the existing notification classes.

---

## Proof

- New carrier file(s): `Bosta`
- New notification channel file(s): `WhatsAppNotification`
- Existing classes left unchanged? **Yes**
