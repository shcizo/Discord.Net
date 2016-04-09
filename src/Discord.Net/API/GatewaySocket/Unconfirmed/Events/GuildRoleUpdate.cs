﻿using Newtonsoft.Json;

namespace Discord.API.GatewaySocket
{
    public class GuildRoleUpdateEvent
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
        [JsonProperty("role")]
        public Role Data { get; set; }
    }
}