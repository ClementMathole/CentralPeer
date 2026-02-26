using CentralPeer.Domain.Common;
using System;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Stores real time SignalR chat history between users
/// </summary>
public class ChatMessage : BaseEntity
{
    public Guid SenderId { get; set; }
    public User? Sender { get; set; }

    public Guid ReceiverId { get; set; }
    public User? Receiver { get; set; }

    public string Content { get; set; } = string.Empty; // the message

    public bool IsRead { get; set; } = false;
}