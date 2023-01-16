using Hamburguesa_KevinRosero.Data;
namespace Hamburguesa_KevinRosero;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        string dbPath = FileAccessHelper.GetLocalFilePath("burger.db3");
        builder.Services.AddSingleton<BurgerDatabaseKR>(s => ActivatorUtilities.CreateInstance<BurgerDatabaseKR>(s, dbPath));
        return builder.Build();
	}
}
