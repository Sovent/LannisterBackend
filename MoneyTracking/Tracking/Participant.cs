using System;
using Common;
using LanguageExt;
using MoneyTracking.User;
using static LanguageExt.Prelude;

namespace MoneyTracking.Tracking
{
  public class Participant : Entity<UserId>
  {
    public Participant(
      Some<UserId> id,
      Some<TrackingId> trackingId, 
      DateTimeOffset invitationDate,
      bool isInvitationAccepted, 
      Option<DateTimeOffset> invitationAcceptedDate) : base(id)
    {
      TrackingId = trackingId;
      InvitationDate = invitationDate;
      IsInvitationAccepted = isInvitationAccepted;
      InvitationAcceptedDate = invitationAcceptedDate;
    }

    public static Participant Invite(Some<UserId> userId, Some<TrackingId> trackingId)
    {
      return new Participant(userId, trackingId, DateTimeOffset.UtcNow, false, None);
    }

    public Unit AcceptInvitation()
    {
      if (IsInvitationAccepted) return Unit.Default;

      IsInvitationAccepted = true;
      InvitationAcceptedDate = Some(DateTimeOffset.UtcNow);
      return Unit.Default;
    }

    public TrackingId TrackingId { get; }
    public DateTimeOffset InvitationDate { get; }
    public bool IsInvitationAccepted { get; private set; }
    public Option<DateTimeOffset> InvitationAcceptedDate { get; private set; }
  }
}