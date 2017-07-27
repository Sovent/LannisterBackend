using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
  public class UserDebtPreview
  {
    public UserDebtPreview(string userId, string userName, Uri avatar, double debtAmount)
    {
      UserId = userId;
      UserName = userName;
      Avatar = avatar;
      DebtAmount = debtAmount;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public string UserName { get; }

    [Required]
    public Uri Avatar { get; }

    [Required]
    public double DebtAmount { get; }
  }

  public class UserDebtPreviewsList
  {
    public UserDebtPreviewsList(string userId, UserDebtPreview[] debts)
    {
      UserId = userId;
      Debts = debts;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public UserDebtPreview[] Debts { get; }
  }

  public class TrackingDebts
  {
    public TrackingDebts(string trackingId, TrackingDebt[] debts)
    {
      TrackingId = trackingId;
      Debts = debts;
    }

    [Required]
    public string TrackingId { get; }

    [Required]
    public TrackingDebt[] Debts { get; }
  }

  public class TrackingDebt
  {
    public TrackingDebt(TrackingDebtOwner debtObject, TrackingDebtOwner debtSubject, double amount, string currencyCode)
    {
      DebtObject = debtObject;
      DebtSubject = debtSubject;
      Amount = amount;
      CurrencyCode = currencyCode;
    }

    [Required]
    public TrackingDebtOwner DebtObject { get; }

    [Required]
    public TrackingDebtOwner DebtSubject { get; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public double Amount { get; }

    [Required]
    public string CurrencyCode { get; }
  }

  public class TrackingDebtOwner
  {
    public TrackingDebtOwner(string userId, string name, Uri avatar)
    {
      UserId = userId;
      Name = name;
      Avatar = avatar;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public string Name { get; }

    [Required]
    public Uri Avatar { get; }
  }
}