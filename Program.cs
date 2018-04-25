using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.WebSocket;

namespace disctesstt
{
    class Program
    {
        public static DiscordSocketClient _client = new DiscordSocketClient();

        static void Main(string[] args)
        {
            _client.LoginAsync(TokenType.User, "MTU3NjIxMzU1NDA2MTYzOTY4.DaQ8ig.GNLVhZsqIszDPODDds_SGt0x - AE");
            _client.StartAsync();
            _client.Log += Log;
            DOIT();
        }

        private static Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        private static async Task DOIT()
        {
            Console.WriteLine("doing");
            Console.ReadLine();

            SocketGuild guild = _client.GetGuild(402524457647734805);
            IMessageChannel channel = guild.GetChannel(402524457647734808) as IMessageChannel;
            Console.ReadLine();

            EmbedBuilder eb = new EmbedBuilder();
            eb.WithTitle("This is a test");
            eb.AddInlineField("Can I use embed when nobody else can?", ":white_check_mark:");

            channel.SendMessageAsync("", false, eb);
            Console.WriteLine("did work");
            Console.ReadLine();
        }
    }
}