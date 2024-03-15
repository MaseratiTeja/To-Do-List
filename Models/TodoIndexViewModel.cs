namespace To_Do_List.Models
{
    public class TodoIndexViewModel
    {
        public Todo? Todo { get; set; }

        public IEnumerable<Todo>? Todoes { get; set; }
    }
}
