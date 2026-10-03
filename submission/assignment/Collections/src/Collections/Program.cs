namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var phoneTests = new[]
            {
              ("01012345678", true),
              ("+201512345678", true),
              ("01312345678", false),
              ("0101234567", false),
              ("0101234567a", false)
            };

            var nationalIdTests = new[]
            {
              ("29901011234567", true),
              ("19901011234567", false),
              ("2990101123456", false)
            };

            Console.WriteLine("=== Egyptian Phone Validation ===");

            foreach (var test in phoneTests)
            {
                var result = test.Item1.IsValidEgyptianPhone();

                Console.WriteLine(
                    $"{test.Item1} => Expected: {test.Item2}, Actual: {result}"
                );
            }

            Console.WriteLine();

            Console.WriteLine("=== Egyptian National ID Validation ===");

            foreach (var test in nationalIdTests)
            {
                var result = test.Item1.IsValidEgyptianNationalId();

                Console.WriteLine(
                    $"{test.Item1} => Expected: {test.Item2}, Actual: {result}"
                );
            }
        }
    }
}
