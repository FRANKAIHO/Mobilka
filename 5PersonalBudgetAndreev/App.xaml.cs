using PersonalBudgetAndreev.DatabaseContext;

namespace PersonalBudgetAndreev
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        //protected override void OnStart()
        //{
        //    var dbContext = new ApplicationDbContext();
        //    dbContext.Database.EnsureCreated();
        //}
    }
}
