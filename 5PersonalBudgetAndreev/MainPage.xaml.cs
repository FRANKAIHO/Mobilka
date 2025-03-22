using System.Transactions;
using PersonalBudgetAndreev.DatabaseContext;
using PersonalBudgetAndreev.Entities;

namespace PersonalBudgetAndreev
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            RefreshCollectionView();
            CalculateSumAndCountOfAmount();
        }

        private void GoToAddTransactionPage(object sender, EventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(AddTransactionPage), true);
        }

        private void RefreshData(object sender, EventArgs e)
        {
            RefreshCollectionView();
            RefreshV.IsRefreshing = false;
        }

        private void RefreshCollectionView()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            TransactionCL.ItemsSource = dbContext.Transactions.ToList();
        }

        private void CalculateSumAndCountOfAmount()
        {
            var dbContext = new ApplicationDbContext();
            var transactionsList = dbContext.Transactions.ToList();

            var sumOfAmounts = transactionsList.Sum(x => x.Amount);
            var countOfAmounts = transactionsList.Count();

            CountOfAmountsLabel.Text = countOfAmounts.ToString();
            SumOfAmountsLabel.Text = sumOfAmounts.ToString();

        }
    }
}