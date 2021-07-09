using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Windows;

namespace woodcalc_00
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(
                typeof(FrameworkElement),
                new FrameworkPropertyMetadata(
                    System.Windows.Markup.XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
            using var db = new LogContext();
            db.Database.Migrate();
        }
    }
}
