# Part 02 — answers

---

## Reports

- What was the problem?

The three report exporters duplicated the same export workflow: loading the data, validating it, formatting it, and saving the result. Only the formatting step was different between CSV, JSON, and Text reports.

- What did you change?

I introduced an abstract `ReportExporter` base class using the Template Method pattern. The `Export` method now contains the common steps in one place: `Load`, `Validate`, `Format`, and `Save`. The concrete exporters only implement the `Format` method.

- Why did you choose that approach?

The Template Method pattern is suitable because the export algorithm and its order are the same for all exporters, while only one step varies. It prevents duplication and ensures that the export steps remain consistent.

---

## Enrollment

- What was the problem?

The enrollment process required the caller to directly create and coordinate several services, such as the payment gateway, seat inventory, invoice generator, and email service.

- What did you change?

I introduced an `EnrollmentFacade` that provides a single entry point for the enrollment process. The Facade creates and coordinates the existing services internally, while the caller only needs to make one `Enroll` call.

- Why did you choose that approach?

The Facade pattern simplifies the interaction with a complex subsystem by providing a simple interface. It reduces coupling in the caller and hides the internal coordination between the enrollment services.
