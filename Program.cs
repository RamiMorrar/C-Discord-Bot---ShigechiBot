using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.IO;
using CSCore.Opus;
using System.Web;
using GammaLibrary.Enhancements;
using GammaLibrary.Extensions;
using System.Linq;
using System.Net.Http;
using PixivSharp;

namespace ShigechiBot
{
    class Program
    {


        private DiscordSocketClient Client;
        private CommandService Commands;


        static void Main(string[] args)
        =>new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {

       

            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug,
            });

            Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug,
            });

            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);

            Client.Ready += Client_Ready;
            Client.Log += Client_Log;

           *String token Put here*
            using (var Stream = new FileStream((Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).Replace(@"bin\Debug\netcoreapp2.1", @"Data\Token.txt"), FileMode.Open, FileAccess.Read))
            using (var ReadToken = new StreamReader(Stream))
            {
                Token = ReadToken.ReadToEnd();
            }
                await Client.LoginAsync(TokenType.Bot, Token);
                await Client.StartAsync();

            await Task.Delay(-1);
        }

        private async Task Client_Ready()
        {
            await Client.SetGameAsync("Harvest Functions", "https://ramidev.blogspot.com/");
        }

        private async Task Client_Log(LogMessage Message)
        {
            Console.WriteLine($"{DateTime.Now} at {Message.Source}] {Message.Message}");
            //await Client.StartAsync();
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);

            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.User.IsBot) return;

            int ArgPos = 0;
            if (!(Message.HasStringPrefix( "!s ", ref ArgPos) || Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))) return;

            var Result = await Commands.ExecuteAsync(Context, ArgPos, null);
            if (!Result.IsSuccess)
                Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing command. Text: {Context.Message.Content} | Error: {Result.ErrorReason}");
        }

        
        }

    }
