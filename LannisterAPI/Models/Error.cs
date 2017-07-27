using System;
using System.ComponentModel.DataAnnotations;

namespace LannisterAPI.Models
{
  public class Error
  {
    public Error(Guid conversationId, ErrorCode errorCode, string description)
    {
      ConversationId = conversationId;
      ErrorCode = errorCode;
      Description = description;
    }

    [Required]
    public Guid ConversationId { get; }

    [Required]
    public ErrorCode ErrorCode { get; }

    [Required]
    public string Description { get; }
  }

  public enum ErrorCode
  {
    Unknown = 0,
    UserNotFound = 1000,
    UserUnauthorized = 1001
  }
}