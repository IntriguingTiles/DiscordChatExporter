﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiscordChatExporter.Core.Models;

namespace DiscordChatExporter.Core.Services
{
    public interface IDataService
    {
        Task<Guild> GetGuildAsync(string token, string guildId);

        Task<Channel> GetChannelAsync(string token, string channelId);

        Task<IReadOnlyList<Guild>> GetUserGuildsAsync(string token);

        Task<IReadOnlyList<Channel>> GetGuildChannelsAsync(string token, string guildId);

        Task<IReadOnlyList<Channel>> GetDirectMessageChannelsAsync(string token);

        Task<IReadOnlyList<Message>> GetChannelMessagesAsync(string token, string channelId,
            DateTime? from, DateTime? to);

        Task<GuildMentionables> GetGuildMentionablesAsync(string token, string guildId);
    }
}