using LiteDB;

namespace IDETest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        private LiteDatabase db;

        public MainWindowViewModel()
        {
            db = new LiteDatabase("MyDb.db");
        }
    }
}