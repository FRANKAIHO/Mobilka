using PersonalBudgetAndreev.DatabaseContext;
using PersonalBudgetAndreev.Entities;

namespace PersonalBudgetAndreev;

public partial class AddTransactionPage : ContentPage
{
    public AddTransactionPage()
    {
        InitializeComponent();
    }

    private void AddTransaction(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TitleEntry.Text))
        {
            AppShell.Current.DisplayAlert("������", "��������� �� ����� ���� ������!", "��");
            return;
        }

        if (string.IsNullOrWhiteSpace(DescriptionEntry.Text))
        {
            AppShell.Current.DisplayAlert("������", "�������� ����� �� ����� ���� ������!", "��");
            return;
        }

        if (string.IsNullOrWhiteSpace(AmountEntry.Text))
        {
            AppShell.Current.DisplayAlert("������", "���-�� ����������� ����� �� ����� ���� ������!", "��");
            return;
        }

        decimal amountConvertedToDecimal = Convert.ToDecimal(AmountEntry.Text);
        if (amountConvertedToDecimal < 0)
        {
            AppShell.Current.DisplayAlert("������", "���-�� ����������� ����� �� ����� ���� �������������!", "��");
            return;
        }

        ApplicationDbContext dbContext = new ApplicationDbContext();
        dbContext.Transactions.Add(new TransactionEntity(TitleEntry.Text, DescriptionEntry.Text, amountConvertedToDecimal));
        dbContext.SaveChanges();

        AppShell.Current.DisplayAlert("�����", "������� ������� ���������.", "��");
        AppShell.Current.GoToAsync("..", true);
    }
}