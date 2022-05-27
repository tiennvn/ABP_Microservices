using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace TMT.MS.Web.Menus;

public class MSMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(MSMenus.Prefix, displayName: "MS", "~/MS", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
