using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LANraragi_Plus.Pages;

[Authorize("Admin")]
public class BackupModel() : PageModel
{
    public void OnGet()
    {
        
    }
}
