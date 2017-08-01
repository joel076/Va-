using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyBot
{
	public class Program
	{
		
		

		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
			
			var client = new DiscordSocketClient(new DiscordSocketConfig {
				WebSocketProvider = Discord.Net.Providers.WS4Net.WS4NetProvider.Instance,
				LogLevel = LogSeverity.Info
			});

			client.Log += Log;
			client.MessageReceived += MessageReceived;

			string token = "MzA3NTQyMjQxMDQyNDk3NTM2.C-T0kw.26UU8gZRrfcMRUkjSsIhlGKbI6w"; 
			await client.LoginAsync(TokenType.Bot, token);
			await client.StartAsync();
			var cmdthread = new Thread(() => adco(client));
			cmdthread.Start();
			
			// Block this task until the program is closed.
			await Task.Delay(-1);
		}

		private async Task MessageReceived(SocketMessage message)
		{
			Thread msgthread = new Thread(() => MessageHandler(message));
			msgthread.Start();
		}

		private void MessageHandler(SocketMessage message)
		{
			Console.WriteLine("Recived message: '" + message.Content + "' by: " + message.Author);
			if (message.Author.Id != 307542241042497536)
			{

				if (message.Content.Equals("!time"))
				{ 
					var time = new DateTime();
					time = DateTime.Now;
					time.ToLocalTime();
					message.Channel.SendMessageAsync(time.Year + "-" + time.Month + "-" + time.Day + " | " + time.Hour + ":" + time.Minute);
				}
			}
		}

		private void adco(DiscordSocketClient client)
		{
			try
			{
				ulong ch;
				string c = "";
				for (;;)
				{
					ch = (ulong)Convert.ToInt64(Console.ReadLine()); //I dont know.
					c = Console.ReadLine();
					(client.GetChannel(ch) as IMessageChannel).SendMessageAsync(c);
				}
			}catch(System.FormatException e)
			{
				Console.WriteLine("write a channel id");
			}
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}


	}
}