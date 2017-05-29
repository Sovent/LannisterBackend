using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
    public class TrackingPreview
    {
        public TrackingPreview(string id, string name, float currentBalance, int personsCount, string currencyCode, bool isEnabled)
        {
            Id = id;
            Name = name;
            CurrentBalance = currentBalance;
            PersonsCount = personsCount;
            CurrencyCode = currencyCode;
            IsEnabled = isEnabled;
        }

        [Required] public string Id { get; }
        [Required] public string Name { get; }
        [Required] public float CurrentBalance { get; }
        [Required] public int PersonsCount { get; }
        [Required] public string CurrencyCode { get; }
        [Required] public bool IsEnabled { get; }
    }

    public class TrackingList
    {
        public TrackingList(string userId, TrackingPreview[] trackings)
        {
            UserId = userId;
            Trackings = trackings;
        }

        [Required] public string UserId { get; }
        [Required] public TrackingPreview[] Trackings { get; }
    }

    public class Tracking
    {
        public Tracking(string id, string name, string currencyCode, TrackingParticipant[] participants, string creatorId, DateTimeOffset creationDate, DateTimeOffset? closedDate)
        {
            Id = id;
            Name = name;
            CurrencyCode = currencyCode;
            Participants = participants;
            CreatorId = creatorId;
            CreationDate = creationDate;
            ClosedDate = closedDate;
        }

        [Required] public string Id { get; }
        [Required] public string Name { get; }
        [Required] public string CurrencyCode { get; }
        [Required] public TrackingParticipant[] Participants { get; }
        [Required] public string CreatorId { get; }
        [Required] public DateTimeOffset CreationDate { get; }
        public DateTimeOffset? ClosedDate { get; }
    }

    public class TrackingParticipant
    {
        public TrackingParticipant(string id, string name, string nickname, Uri avatar, bool acceptedInvite)
        {
            Id = id;
            Name = name;
            Nickname = nickname;
            Avatar = avatar;
            AcceptedInvite = acceptedInvite;
        }

        [Required] public string Id { get; }
        [Required] public string Name { get; }
        [Required] public string Nickname { get; }
        [Required] public Uri Avatar { get; }
        [Required] public bool AcceptedInvite { get; }
    }

    public class CreateTrackingRequest
    {
        [Required] public string TrackingName { get; set; }
        public string Currency { get; set; }
    }

    public class CreateTrackingResponse
    {
        public CreateTrackingResponse(string trackingId)
        {
            TrackingId = trackingId;
        }

        public string TrackingId { get; }
    }
}
