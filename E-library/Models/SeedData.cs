using E_library.Data;
using Microsoft.EntityFrameworkCore;

namespace E_library.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new E_libraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<E_libraryContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        CallingNo=000,
                        Describtion = "Generalities"
                    },
                    new Book
                    {
                        CallingNo = 100,
                        Describtion = "Philosophy & psychology"
                    },
                    new Book
                    {
                        CallingNo = 200,
                        Describtion = "Religion"
                    },
                    new Book
                    {
                        CallingNo = 300,
                        Describtion = "Social sciences"
                    },
                    new Book
                    {
                        CallingNo = 400,
                        Describtion = "Language"
                    },
                    new Book
                    {
                        CallingNo = 500,
                        Describtion = "Natural sciences & mathematics"
                    },
                    new Book
                    {
                        CallingNo = 600,
                        Describtion = "Technology (Applied sciences)"
                    },
                    new Book
                    {
                        CallingNo = 700,
                        Describtion = "The arts"
                    },
                    new Book
                    {
                        CallingNo = 800,
                        Describtion = "Literature & rhetoric"
                    },
                    new Book
                    {
                        CallingNo = 900,
                        Describtion = "Geography & history"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
