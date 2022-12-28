using ADOP_Project_Part_B_Weather.Models;
using ADOP_Project_Part_B_Weather.Views;

namespace ADOP_Project_Part_B_Weather;

public partial class AppShell : Shell
{
    
	public AppShell()
	{
		InitializeComponent();

        foreach(CityPicture city in CityPicture.List)
        {
            var sc = new ShellContent
            {
                Title = city.Name,
                Route = city.ImageSrc.ToLower().Replace(".jpg", null),
                ContentTemplate = new DataTemplate(() => new ForecastPage(city))
            };
            this.Items.Add(sc);
        }
    }
}
