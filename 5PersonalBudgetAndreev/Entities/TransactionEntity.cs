using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PersonalBudgetAndreev.Entities;
public class TransactionEntity
{
    public int Id { get; set; } // идентификатор траты
    public string Title { get; set; } // заголовок траты
    public string Description { get; set; } // описание траты
    public decimal Amount { get; set; } // кол-во потраченных денег
    public DateTime CreatedAt { get; set; } // дата создания траты
    
    public TransactionEntity(
        string title,
        string description,
        decimal amount)
    {  Title = title; Description = description; Amount = amount; CreatedAt = DateTime.Now; }

}