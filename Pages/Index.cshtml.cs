using List_To_Do.Model;
using List_To_Do.Services;
using List_To_Do.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace List_To_Do.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IToDoService _toDoService;

        public List<ToDo> toDoList { get; set; }
        [BindProperty]
        public IsDoneModel Input { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IToDoService toDoService)
        {
            _logger = logger;
            _toDoService= toDoService;
        }

        public IActionResult OnGet()
        {
            toDoList= _toDoService.GetToDoList();
            return Page();
        }
        //public IActionResult OnPostIsDone()
        //{
        //    _toDoService.ChangeIsDone(Input.Id, Input.IsDone);
        //    return new JsonResult("ok");
        //}
        public class IsDoneModel
        {
            public int Id { get; set;}
            public bool IsDone { get; set;}
        }
    }
}