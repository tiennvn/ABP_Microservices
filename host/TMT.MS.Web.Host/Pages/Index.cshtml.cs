using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TMT.MS.Pages;

public class IndexModel : MSPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
