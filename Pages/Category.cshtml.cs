using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace List_To_Do.Pages
{
    public class CategoryModel : PageModel
    {
        public CategoryModel Input { get; set; }    
        public void OnGet()
        {
        }
    }
}
