namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var store = new Store<Student>();

            store.Add(new Student { Id = 1, Name = "Youssef" });
            store.Add(new Student { Id = 2, Name = "Ahmed" });
            store.Add(new Student { Id = 3, Name = "Omar" });

            try
            {
                store.Add(new Student { Id = 2, Name = "Mohamed" });
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Duplicate error: {ex.Message}");
            }

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

            var courseStore = new Store<Course>();

            courseStore.Add(new Course
            {
                Id = 1,
                Title = "C#",
                Price = 1500m
            });

            courseStore.Add(new Course
            {
                Id = 2,
                Title = "ASP.NET Core",
                Price = 2000m
            });

            courseStore.Add(new Course
            {
                Id = 3,
                Title = "SQL",
                Price = 1200m
            });

            var course = courseStore.GetById(2);

            Console.WriteLine($"Found: {course?.Title} - {course?.Price}");

            Console.WriteLine("All courses:");

            foreach (var item in courseStore.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Title} - {item.Price}");
            }

            courseStore.Remove(2);

            Console.WriteLine("After removing course 2:");

            foreach (var item in courseStore.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Title} - {item.Price}");
            }
        }
    }
}
