namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var store = new StudentStore();

            store.Add(new Student { Id = 1, Name = "Youssef" });
            store.Add(new Student { Id = 2, Name = "Ahmed" });
            store.Add(new Student { Id = 3, Name = "Omar" });

            var student = store.GetById(2);

            Console.WriteLine($"Found: {student?.Name}");

            Console.WriteLine("All students:");

            foreach (var item in store.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }

            store.Remove(2);

            Console.WriteLine("After removing student 2:");

            foreach (var item in store.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
        }
    }
}
