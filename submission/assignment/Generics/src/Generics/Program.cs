namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // Store<Student>
            // =========================

            var store = new Store<Student>();

            store.Add(new Student { Id = 1, Name = "Youssef" });
            store.Add(new Student { Id = 2, Name = "Ahmed" });
            store.Add(new Student { Id = 3, Name = "Omar" });

            // Test duplicate ID
            try
            {
                store.Add(new Student { Id = 2, Name = "Mohamed" });
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Duplicate error: {ex.Message}");
            }

            // Test GetById
            var student = store.GetById(2);

            Console.WriteLine($"Found: {student?.Name}");

            // Test GetAll
            Console.WriteLine("All students:");

            foreach (var item in store.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }

            // Test Page
            Console.WriteLine("Page 2 (size 2):");

            foreach (var item in store.GetAll().Page(2, 2))
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }

            // Test Remove
            store.Remove(2);

            Console.WriteLine("After removing student 2:");

            foreach (var item in store.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }


            // =========================
            // Store<Course>
            // =========================

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

            // Test GetById
            var course = courseStore.GetById(2);

            Console.WriteLine($"Found: {course?.Title} - {course?.Price}");

            // Test GetAll
            Console.WriteLine("All courses:");

            foreach (var item in courseStore.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Title} - {item.Price}");
            }


            // =========================
            // Extension Methods
            // =========================

            var courseList = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Title = "C#",
                    Price = 1500m
                },
                new Course
                {
                    Id = 2,
                    Title = "ASP.NET Core",
                    Price = 2000m
                },
                new Course
                {
                    Id = 3,
                    Title = "SQL",
                    Price = 1200m
                }
            };

            // Test FindById
            var foundCourse = courseList.FindById(2);

            Console.WriteLine($"FindById: {foundCourse?.Title}");

            // Test ToIdDictionary
            var courseDictionary = courseList.ToIdDictionary();

            Console.WriteLine("Course dictionary:");

            foreach (var item in courseDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Title}");
            }


            // Test Remove
            courseStore.Remove(2);

            Console.WriteLine("After removing course 2:");

            foreach (var item in courseStore.GetAll())
            {
                Console.WriteLine($"{item.Id}: {item.Title} - {item.Price}");
            }
        }
    }
}