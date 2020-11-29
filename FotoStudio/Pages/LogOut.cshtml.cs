using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FotoStudio.Pages
{
    public class LogOutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            await HttpContext
            .SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect(Url.Content("~/"));
        }
    }
}
