using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODOS.Pages
{
    public sealed class MyHomeModel : PageModel
    {
        public List<Todo> Todos { get; private set; } = new();

        public void OnPost(string title, string content)
        {
            var dbLayer = DBLayer.Instance;

            var todo = new Todo(title, content);
            dbLayer.Todos.Add(todo);
            dbLayer.SaveChanges();

            Todos = DBLayer.Instance.Todos.ToList();
        }

        public void OnGet()
        {
            Todos = DBLayer.Instance.Todos.ToList();
        }
    }
}
