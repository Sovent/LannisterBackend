using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
  public class UserTransactionPreview
  {
    public UserTransactionPreview(string id, string userId, string userName, Uri userAvatar, float amount,
      DateTimeOffset date)
    {
      Id = id;
      UserId = userId;
      UserName = userName;
      UserAvatar = userAvatar;
      Amount = amount;
      Date = date;
    }

    [Required]
    public string Id { get; }

    [Required]
    public string UserId { get; }

    [Required]
    public string UserName { get; }

    [Required]
    public Uri UserAvatar { get; }

    [Required]
    public float Amount { get; }

    [Required]
    public DateTimeOffset Date { get; }
  }

  public class UserTransactionsList
  {
    public UserTransactionsList(string userId, UserTransactionPreview[] transactions)
    {
      UserId = userId;
      Transactions = transactions;
    }

    [Required]
    public string UserId { get; }

    [Required]
    public UserTransactionPreview[] Transactions { get; }
  }

  public class TrackingTransactionPreview
  {
    public TrackingTransactionPreview(string id, string senderId, Uri senderAvatar, string receiverId,
      Uri receiverAvatar, float amount, string currencyCode, DateTimeOffset date)
    {
      Id = id;
      SenderId = senderId;
      SenderAvatar = senderAvatar;
      ReceiverId = receiverId;
      ReceiverAvatar = receiverAvatar;
      Amount = amount;
      CurrencyCode = currencyCode;
      Date = date;
    }

    [Required]
    public string Id { get; }

    [Required]
    public string SenderId { get; }

    [Required]
    public Uri SenderAvatar { get; }

    [Required]
    public string ReceiverId { get; }

    [Required]
    public Uri ReceiverAvatar { get; }

    [Required]
    [Range(0, int.MaxValue)]
    public float Amount { get; }

    [Required]
    public string CurrencyCode { get; }

    [Required]
    public DateTimeOffset Date { get; }
  }

  public class TrackingTransactionsList
  {
    public TrackingTransactionsList(string trackingId, TrackingTransactionPreview[] transactions)
    {
      TrackingId = trackingId;
      Transactions = transactions;
    }

    [Required]
    public string TrackingId { get; }

    [Required]
    public TrackingTransactionPreview[] Transactions { get; }
  }

  public class Transaction
  {
    public Transaction(string transactionId, double amount, string currencyCode, string senderUserId, string senderName,
      Uri senderAvatar, string receiverUserId, string receiverName, Uri receiverAvatar, DateTimeOffset date,
      Uri[] attachments)
    {
      TransactionId = transactionId;
      Amount = amount;
      CurrencyCode = currencyCode;
      SenderUserId = senderUserId;
      SenderName = senderName;
      SenderAvatar = senderAvatar;
      ReceiverUserId = receiverUserId;
      ReceiverName = receiverName;
      ReceiverAvatar = receiverAvatar;
      Date = date;
      Attachments = attachments;
    }

    [Required]
    public string TransactionId { get; }

    [Required]
    public double Amount { get; }

    [Required]
    public string CurrencyCode { get; }

    [Required]
    public string SenderUserId { get; }

    [Required]
    public string SenderName { get; }

    [Required]
    public Uri SenderAvatar { get; }

    [Required]
    public string ReceiverUserId { get; }

    [Required]
    public string ReceiverName { get; }

    [Required]
    public Uri ReceiverAvatar { get; }

    [Required]
    public DateTimeOffset Date { get; }

    [Required]
    public Uri[] Attachments { get; }
  }

  public class CreateTransactionRequest
  {
    [Required]
    public string ReceiverUserId { get; set; }

    [Required]
    public string TransactionId { get; set; }

    [Required]
    public double Amount { get; set; }

    [Required]
    public Uri[] Attachments { get; set; }
  }

  public class CreateTransactionResponse
  {
    public CreateTransactionResponse(string transactionId)
    {
      TransactionId = transactionId;
    }

    [Required]
    public string TransactionId { get; }
  }
}