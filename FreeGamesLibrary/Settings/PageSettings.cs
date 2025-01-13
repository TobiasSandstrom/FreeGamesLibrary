using MudBlazor;

namespace Settings
{
    public class PageSettings
    {
        public MudTheme Palette { get; } = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "rgb(220, 215, 201)",
                Secondary = "rgb(162, 123, 92)",
                TextPrimary = "rgb(220, 215, 201)",
                TextSecondary = "rgb(162, 123, 92)",
                AppbarBackground = "rgba(0, 0, 0, 0)",
                DrawerBackground = "rgb(44, 54, 57)",
                DrawerText = "rgb(0, 0, 0)",
                Background = "rgb(60, 91, 93)",
                
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "rgb(220, 215, 201)",
                Secondary = "rgb(162, 123, 92)",
                TextPrimary = "rgb(220, 215, 201)",
                TextSecondary = "rgb(162, 123, 92)",
                AppbarBackground = "rgba(0, 0, 0, 0)",
                DrawerBackground = "rgb(44, 54, 57)",
                DrawerText = "rgb(0, 0, 0)",
                Background = "rgb(60, 91, 93)",
            },

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"
            }
        };

    }
}
