namespace DSharpPlus.SlashCommands.Entities {
    public class CommandInfo {
        public CommandInfo(string name, string description = "n/a", ulong guildId = 0) {
            Name = name;
            GuildId = guildId;
            Description = description;
        }

        public string Name { get; }
        public ulong GuildId { get; }
        public string Description { get; }
    }
}