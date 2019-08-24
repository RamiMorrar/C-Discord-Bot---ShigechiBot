using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace ShigechiBot.Core.Commands
{
    public class Hello : ModuleBase<SocketCommandContext>
    {
        [Command("hello"), Alias("hello", "hi", "Hello", "Hi"), Summary("Hello Command")]
        public async Task ShigechiHi()
        {
            await Context.Channel.SendMessageAsync("Hi, I'm Shigechi!");
        }

        [Command("Coding"), Alias("coding", "code")]
        public async Task Coding()

        {
            
            var Code = new EmbedBuilder();
            Code.WithImageUrl("");
            Code.WithDescription("Here is a list of resources you can use to kick start your career in coding! \n \n " +
                "[The C++ guide by Trevor Payne is a fantastic resource on how to code in one of the most powerful languages in the world](https://www.youtube.com/playlist?list=PL82YdDfxhWsCyZLsg_kXhH8sy5ixQNras) \n \n" +
                "[C++ Documentation](http://www.cplusplus.com/) & [Video Tutorials by Jason Turner](https://www.youtube.com/user/lefticus1/videos) \n \n \n " +
                "[Lastly, Microsoft's Documentation on C# is a go-to source for learning an easier, yet very intuitive and nuanced language](https://docs.microsoft.com/en-us/dotnet/csharp/). \n \n \n" +
                "If you want something more visual and someone who can teach well, I also recommend mmtuts' [video tutorials here](https://www.youtube.com/playlist?list=PL0eyrZgxdwhxD9HhtpuZV22KxEJAZ55X-) \n  \n " +
                "If you aren't interested in the ways of making Software, here are some web development guides for [HTML/CSS](https://www.youtube.com/playlist?list=PL0eyrZgxdwhwNC5ppZo_dYGVjerQY3xYU) and [Javascript](https://www.youtube.com/playlist?list=PL0eyrZgxdwhxNGMWROnaY35NLyEjTqcgB) also made by MMtuts! \n \n" +
                "Lastly, it's also important to know how to network/build on your programming expertise. Here is a list of guides to get your foot through the door: \n" +
                "[An article on building a portfolio and networking](https://www.codementor.io/codementorteam/how-to-get-your-first-developer-job-even-if-you-don-t-have-a-cs-degree-8b60y8ch2) \n" +
                "[Local Programming Meet-ups for your location(though you may have to sign-up for an account or sign-in with Social Media to make to be able to attend one)](https://www.meetup.com/topics/computer-programming/)\n \n \n" +
                "[TutorialsPoint](https://www.tutorialspoint.com/index.htm) - A webiste containing excellent information on any and all programming languauges, as well as programming/computer science theory");

            
            await Context.Channel.SendMessageAsync("", false, Code.Build());
        }

        [Command("Cooking"), Alias("cook", "cookie")]
        public async Task Cooking()

        {
            var cooking = new EmbedBuilder();
            cooking.WithDescription("[SeriousEats](https://www.seriouseats.com/) is a great website that provides that can make anybody who has never cooked in their life able to cook :star::star::star::star::star: meals \n \n" +
                "[Binging With Babish](https://www.youtube.com/user/bgfilms) \n \n " +
                "And lastly for now, [Peaceful Cuisine](https://www.youtube.com/user/ryoya1983), a channel dedicated to vegan and special treats!");

            await Context.Channel.SendMessageAsync("", false, cooking.Build());
        }


        [Command("commands"), Alias("Coms", "Cmd", "cmd"), Summary("Command List")]
        public async Task Embed()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Command List", Context.User.GetAvatarUrl());
            Embed.WithColor(40, 200, 150);
            Embed.WithFooter("https://ramidev.blogspot.com/", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("This is where all commands are! Type !s -commandname- to choose from list! \n" +
                "Commands: \n" +
                "unga\n" +
                "nodrip \n" +
                "drip \n" +
                "meow\n" +
                 
                "kof = Resources for KOF \n " +
               "ss = Resources for Samurai Shodown\n" +
               "dbfz = Resources for DBFZ \n" +
               "gg = Resources for Guilty Gear \n \n" +
               "cook = Resources for Cooking \n \n" +
               "Coding = Resources For Coding");

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }


        [Command("Commands"), Alias("Harvest", "h", "harv", "harvest")]
        public async Task Harvest()
        {
            EmbedBuilder Harvest = new EmbedBuilder();

            Harvest.WithImageUrl("https://66.media.tumblr.com/e8827f5e36c9d65409dd0123bf38b95f/tumblr_ob38u2qYGq1sxfvy5o4_500.gif");

            await Context.Channel.SendMessageAsync("", false, Harvest.Build());


        }

        [Command("DBFZ"), Alias("DBFZ", "dbfz"), Summary("Resources for DBFZ")]

        public async Task DBFZ() {
            var DBFZ = new EmbedBuilder();
            DBFZ.WithColor(255, 153, 0);
            DBFZ.WithDescription("A list of DBFZ Resources for people to learn the game! \n \n" +
                "[Loli Ho's Youtube Channel for all recorded DBFZ Match Footage from top players Recorded on PS4](https://www.youtube.com/playlist?list=PLb2AhgILxZP-z7xF-xKA1oJB6K2ORtD0v) \n \n " +
                "[A quick guide on DBFZ's mechanics and general gameflow](https://www.youtube.com/playlist?list=PLj34EySs1IeaV0Ccj4yJGwBcG4gyATNpM)\n \n" +
                "[A playlist of made by top anime player, LordKnight, on tips & nuances of DBFZ](https://www.youtube.com/playlist?list=PLkfxjGxqaaPfeGPw6sSTliyiZCIuWpqf_) \n \n");

            DBFZ.WithThumbnailUrl("http://i0.wp.com/shoryuken.com/wp-content/uploads/2017/06/DBFZ-logo.jpg");

            await Context.Channel.SendMessageAsync("", false, DBFZ.Build());

        }



        [Command("KOF"), Alias("KOF", "kof"), Summary("Resources for KOF")]

        public async Task KOF()
        {
            var KOF = new EmbedBuilder();
            KOF.WithColor(100, 100, 0);
            KOF.WithDescription("A list of KOF Resources for people to learn the game! \n \n" +
              "[Dandy J's KOF Tutorial](https://www.youtube.com/watch?v=Ye3KVgI1LvU) \n \n" +
              "[Gatoray's Channel for all the latest KOF tournament footage](https://www.youtube.com/user/gatoraykof/playlists)\n \n " +
              "[Dreamcancel, a website all about KOF and other SNK games, including online matchmaking and where to find local meet-ups](https://dreamcancel.com/) \n"
    
             );
            KOF.WithThumbnailUrl("http://vignette4.wikia.nocookie.net/snk/images/1/16/KOF-Logo.png/revision/latest?cb=20150103030115");

            await Context.Channel.SendMessageAsync("", false, KOF.Build());

        }

        [Command("Guilty Gear"), Alias("GG", "gg", "gear"), Summary ("Resources for Guilty Gear")]

        public async Task GG()
        {
            var GG = new EmbedBuilder();

            
            GG.WithDescription("A list of Guilty Gear Resources for people to learn the game! \n \n " +
                "[Dustloop.Com - A #1 resource for all anime games, especially Guilty Gear!](http://www.dustloop.com/forums/index.php?/forums/forum/3-guilty-room/) \n \n" +
                "[Guilty Gear Crash Course](https://www.youtube.com/playlist?list=PLj34EySs1IeZ8GpjKW8R2T6dzI6B3GSuH)\n \n " +
             ""    );
            GG.WithThumbnailUrl("https://1lal3e4eckus2d9p8g17wl8c-wpengine.netdna-ssl.com/wp-content/uploads/2019/08/Guilty-Gear-2020-960x539.jpg");

            await Context.Channel.SendMessageAsync("", false, GG.Build());

        }


        [Command("SamSho"), Alias("SS", "SS", "SamSho"), Summary("Resources for Samurai Shodown")]

        public async Task SamSho()
        {
            var SamSho = new EmbedBuilder();
            SamSho.WithColor(100, 100, 0);
            SamSho.WithDescription("A list of SamSho Resources for people to learn the game! \n \n " +
                "[SamShostrats - An online encyclopedia with resources gathered from all over the internet!](http://samshostrats.ga/) \n \n " +
                "[Mizuumi Wiki](http://wiki.mizuumi.net/w/Samurai_Shodown)");

        SamSho.WithThumbnailUrl("https://i2.wp.com/www.theouterhaven.net/wp-content/uploads/2019/03/Samurai-Shodown-Logo-e1553523191975.png?resize=750%2C400&ssl=1");
            await Context.Channel.SendMessageAsync("", false, SamSho.Build());

        }

        [Command("cake"), Alias("cake")]

        public async Task Cake()
        {
            await Context.Channel.SendMessageAsync("https://twitter.com/EXWildWolf/status/1161852060456722432?s=2");
        }


        [Command("HYPE"), Alias("hype", "HYPE")]

     public async Task HYPE()
        {
            EmbedBuilder HYPE = new EmbedBuilder();
            HYPE.WithImageUrl("https://i.imgur.com/JS72a0e.gif");
            await Context.Channel.SendMessageAsync("", false, HYPE.Build());

        }

    

        [Command("MEOW MEOW NIGGA!"), Alias("B", "Meow", "meow")]
        public async Task MEOW()
        {
            var Embed = new EmbedBuilder();
            Embed.WithColor(50, 200, 175);
            Embed.WithDescription("https://www.youtube.com/watch?v=K0t7U8m3Bxo");
            await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=K0t7U8m3Bxo");
        }

        [Command("UNGA!"), Alias("unga", "Unga")]
        public async Task Unga()
        {
            var Embed = new EmbedBuilder();
            Embed.WithColor(50, 200, 175);
            Embed.WithImageUrl("https://cdn.discordapp.com/attachments/600996989513105418/609162206298505236/image0.gif");
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }

        [Command("No Drip"), Alias("nodrip", "no")]
        public async Task NoDrip()
        {
            var Embed = new EmbedBuilder();
            Embed.WithColor(50, 200, 175);
            Embed.WithImageUrl("https://img.fireden.net/a/image/1456/02/1456028788876.gif");
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }

        [Command("ALLDRIP"), Alias("alldrip", "muchdrip", "drip")]
        public async Task ALLDRIP()
        {
            var Embed = new EmbedBuilder();
            Embed.WithColor(50, 200, 175);
            Embed.WithImageUrl("https://pbs.twimg.com/media/EBLfA6KUcAAWrJu?format=jpg&name=360x360");
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }




        [Command("join", RunMode = RunMode.Async), Alias("vc", "voice", "voicechat")]
        public async Task JoinChannel(IVoiceChannel channel = null)
        {
            // Gets the audio channel
            channel = channel ??  (Context.User as IGuildUser)?.VoiceChannel;
            if (channel == null) { await Context.Channel.SendMessageAsync("User must be in a voice channel, or a voice channel must be passed as an argument."); return; }

            

            // Client Service
            var audioClient = await channel.ConnectAsync( );

            
        }
        
    }

   


}
