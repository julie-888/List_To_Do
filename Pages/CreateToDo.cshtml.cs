using List_To_Do.Model;
using List_To_Do.Services;
using List_To_Do.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace List_To_Do.Pages
{
    public class CreateToDoModel : PageModel
    {
        private readonly IToDoService _toDoService;
        [BindProperty]
        public ToDo ToDo { get; set; }

        public CreateToDoModel(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost(ToDo toDo)
        {
            if (!ModelState.IsValid)
                return Page();
            _toDoService.AddToDo(toDo);
            return RedirectToPage("Index");
        }


    }
}
