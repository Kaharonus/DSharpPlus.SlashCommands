using System;

namespace DSharpPlus.SlashCommands.Attributes {
    [AttributeUsage(AttributeTargets.Method)]
    public class DynamicSlashCommandAttribute : Attribute  {
        
        public ulong GuildId { get; }
        public DynamicSlashCommandAttribute(ulong guildId) {
            GuildId = guildId;
        }
    }
}