using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
    public class UserTransactionPreview
    {
        public UserTransactionPreview(string id, string userId, string userName, Uri userAvatar, float amount, DateTimeOffset date)
        {
            Id = id;
            UserId = userId;
            UserName = userName;
            UserAvatar = userAvatar;
            Amount = amount;
            Date = date;
        }

        [Required] public string Id { get; }
        [Required] public string UserId { get; }
        [Required] public string UserName { get; }
        [Required] public Uri UserAvatar { get; }
        [Required] public float Amount { get; }
        [Required] public DateTimeOffset Date { get; }
    }

    public class UserTransactionsList
    {
        public UserTransactionsList(string userId, UserTransactionPreview[] transactions)
        {
            UserId = userId;
            Transactions = transactions;
        }

        [Required] public string UserId { get; }
        [Required] public UserTransactionPreview[] Transactions { get; }
    }

    public class TrackingTransactionPreview
    {
        public TrackingTransactionPreview(string id, string senderId, Uri senderAvatar, string receiverId, Uri receiverAvatar, float amount, string currencyCode, DateTimeOffset date)
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

        [Required] public string Id { get; }
        [Required] public string SenderId { get; }
        [Required] public Uri SenderAvatar { get; }
        [Required] public string ReceiverId { get; }
        [Required] public Uri ReceiverAvatar { get; }
        [Required] [Range(0, Int32.MaxValue)] public float Amount { get; }
        [Required] public string CurrencyCode { get; }
        [Required] public DateTimeOffset Date { get; }
    }

    public class TrackingTransactionsList
    {
        public TrackingTransactionsList(string trackingId, TrackingTransactionPreview[] transactions)
        {
            TrackingId = trackingId;
            Transactions = transactions;
        }

        [Required] public string TrackingId { get; }
        [Required] public TrackingTransactionPreview[] Transactions { get; }
    }
}