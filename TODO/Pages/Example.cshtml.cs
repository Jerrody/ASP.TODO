using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODO.Pages
{
    public struct Person
    {
        public string Name;
        public uint Age;
    }

    public class ExampleModel : PageModel
    {
        public Person Person { get; private set; } = new();

        public void OnPost(string name, uint age)
        {
            Person = new Person()
            {
                Name = name,
                Age = age,
            };
        }
    }
}
