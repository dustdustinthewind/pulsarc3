// DiscordJoinRequestEvent
using System;
using UnityEngine.Events;

[Serializable]
public class DiscordJoinRequestEvent : UnityEvent<DiscordRpc.DiscordUser>
{
}
