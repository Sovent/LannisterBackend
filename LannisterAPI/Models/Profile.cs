using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
  public class ProfileOwnerProfile
  {
    public ProfileOwnerProfile(string userId, string name, string nickname, Uri avatar, DateTimeOffset registrationDate,
      double totalDebtAmount, CurrencySettings currencySettings, NotificationSettings notificationSettings)
    {
      UserId = userId;
      Name = name;
      Nickname = nickname;
      Avatar = avatar;
      RegistrationDate = registrationDate;
      TotalDebtAmount = totalDebtAmount;
      CurrencySettings = currencySettings;
      NotificationSettings = notificationSettings;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public bool IsProfileOwner => true;

    [Required]
    public string Name { get; }

    [Required]
    public string Nickname { get; }

    [Required]
    public Uri Avatar { get; }

    [Required]
    public DateTimeOffset RegistrationDate { get; }

    [Required]
    public double TotalDebtAmount { get; }

    [Required]
    public CurrencySettings CurrencySettings { get; }

    [Required]
    public NotificationSettings NotificationSettings { get; }
  }

  public class CurrencySettings
  {
    public CurrencySettings(string defaultCurrencyCode, CustomCurrencyRate[] customCurrencyRates)
    {
      DefaultCurrencyCode = defaultCurrencyCode;
      CustomCurrencyRates = customCurrencyRates;
    }

    [Required]
    public string DefaultCurrencyCode { get; }

    [Required]
    public CustomCurrencyRate[] CustomCurrencyRates { get; }
  }

  public class CustomCurrencyRate
  {
    public CustomCurrencyRate(string convertedUnitCurrencyCode, string measureUnitCurrencyCode, double rate)
    {
      ConvertedUnitCurrencyCode = convertedUnitCurrencyCode;
      MeasureUnitCurrencyCode = measureUnitCurrencyCode;
      Rate = rate;
    }

    public string ConvertedUnitCurrencyCode { get; }
    public string MeasureUnitCurrencyCode { get; }
    public double Rate { get; }
  }

  public class NotificationSettings
  {
  }

  public class UserProfile
  {
    public UserProfile(string userId, string name, string nickname, Uri avatar, UserProfileDebtsPreview[] debts)
    {
      UserId = userId;
      Name = name;
      Nickname = nickname;
      Avatar = avatar;
      Debts = debts;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public bool IsProfileOwner => false;

    [Required]
    public string Name { get; }

    [Required]
    public string Nickname { get; }

    [Required]
    public Uri Avatar { get; }

    [Required]
    public UserProfileDebtsPreview[] Debts { get; }
  }

  public class UserProfileDebtsPreview
  {
    public UserProfileDebtsPreview(string trackingId, string trackingName, double debt, string currencyCode)
    {
      TrackingId = trackingId;
      TrackingName = trackingName;
      Debt = debt;
      CurrencyCode = currencyCode;
    }

    [Required]
    public string TrackingId { get; }

    [Required]
    public string TrackingName { get; }

    [Required]
    public double Debt { get; }

    [Required]
    public string CurrencyCode { get; }
  }

  public class RespondOnTrackingInvitationRequest
  {
    [Required]
    public string TrackingId { get; set; }

    [Required]
    public bool AcceptInvitation { get; set; }
  }
}