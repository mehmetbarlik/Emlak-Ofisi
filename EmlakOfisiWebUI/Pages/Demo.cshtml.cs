using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmlakOfisiWebUI.Pages
{
    public class DemoModel : PageModel
    {
        public String? FullName => HttpContext?.Session?.GetString("name") ?? "User";
        public void OnGet()
        {

        }

        public void OnPost([FromForm] string name)
        {
            //FullName =name;
            HttpContext.Session.SetString("name", name);
        }

    }
}
