using System;
using LanguageExt;
using MoneyTracking.Tracking;
using MoneyTracking.User;
using Xunit;

namespace MoneyTracking.UnitTests
{
  public class ParticipantTests
  {
    [Fact]
    public void AcceptInvitationThatIsAlreadyAccepted_DoesNotChangedAcceptInvitationDate()
    {
      var originalInvitationDate = DateTimeOffset.UtcNow;
      var participant = new Participant(UserId.New, TrackingId.New, DateTimeOffset.UtcNow, true, originalInvitationDate);

      participant.AcceptInvitation();

      Assert.Equal(originalInvitationDate, participant.InvitationAcceptedDate.IfNone(default(DateTimeOffset)));
    }

    [Fact]
    public void AcceptInvitationThatIsNotAccepted_SetsAcceptInvitationDate()
    {
      var participant = new Participant(UserId.New, TrackingId.New, DateTimeOffset.UtcNow, false, Option<DateTimeOffset>.None);

      participant.AcceptInvitation();

      Assert.True(participant.IsInvitationAccepted);
      Assert.True(participant.InvitationAcceptedDate.IsSome);
    }
  }
}