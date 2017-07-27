using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
  public class TrackingCheckoutPreview
  {
    public TrackingCheckoutPreview(string checkoutId, string name, float amount, string currencyCode,
      string checkoutMakerId, string checkoutMakerAvatar)
    {
      CheckoutId = checkoutId;
      Name = name;
      Amount = amount;
      CurrencyCode = currencyCode;
      CheckoutMakerId = checkoutMakerId;
      CheckoutMakerAvatar = checkoutMakerAvatar;
    }

    [Required]
    public string CheckoutId { get; }

    [Required]
    public string Name { get; }

    [Required]
    public float Amount { get; }

    [Required]
    public string CurrencyCode { get; }

    [Required]
    public string CheckoutMakerId { get; }

    [Required]
    public string CheckoutMakerAvatar { get; }
  }

  public class TrackingCheckoutPreviewList
  {
    public TrackingCheckoutPreviewList(string trackingId, TrackingCheckoutPreview[] checkouts)
    {
      TrackingId = trackingId;
      Checkouts = checkouts;
    }

    [Required]
    public string TrackingId { get; }

    [Required]
    public TrackingCheckoutPreview[] Checkouts { get; }
  }

  public class Checkout
  {
    public Checkout(string checkoutId, string name, string trackingId, string trackingName, double sum,
      string currencyCode, string authorId, string authorName, Uri authorAvatar, Uri[] attachments,
      ExcludedFromCheckoutUser[] excludedUsers)
    {
      CheckoutId = checkoutId;
      Name = name;
      TrackingId = trackingId;
      TrackingName = trackingName;
      Sum = sum;
      CurrencyCode = currencyCode;
      AuthorId = authorId;
      AuthorName = authorName;
      AuthorAvatar = authorAvatar;
      Attachments = attachments;
      ExcludedUsers = excludedUsers;
    }

    [Required]
    public string CheckoutId { get; }

    [Required]
    public string Name { get; }

    [Required]
    public string TrackingId { get; }

    [Required]
    public string TrackingName { get; }

    [Required]
    public double Sum { get; }

    [Required]
    public string CurrencyCode { get; }

    [Required]
    public string AuthorId { get; }

    [Required]
    public string AuthorName { get; }

    [Required]
    public Uri AuthorAvatar { get; }

    [Required]
    public Uri[] Attachments { get; }

    [Required]
    public ExcludedFromCheckoutUser[] ExcludedUsers { get; }
  }

  public class ExcludedFromCheckoutUser
  {
    public ExcludedFromCheckoutUser(string userId, Uri avatar)
    {
      UserId = userId;
      Avatar = avatar;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public Uri Avatar { get; }
  }

  public class CreateCheckoutRequest
  {
    [Required]
    public string Name { get; set; }

    [Required]
    public string TrackingId { get; set; }

    [Required]
    public double Amount { get; set; }

    [Required]
    public string[] ExcludedUserIds { get; set; }

    [Required]
    public Uri[] Attachments { get; set; }
  }

  public class CreateCheckoutResponse
  {
    public CreateCheckoutResponse(string checkoutId)
    {
      CheckoutId = checkoutId;
    }

    [Required]
    public string CheckoutId { get; }
  }
}