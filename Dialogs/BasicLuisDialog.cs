using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(ConfigurationManager.AppSettings["LuisAppId"], ConfigurationManager.AppSettings["LuisAPIKey"])))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
          await context.SayAsync("Sunny day in rawicz: "+ context.Activity.ChannelId, "Sunny day in rawicz: " + context.Activity.ChannelId);
            context.Wait(MessageReceived);
        }

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "MyIntent" with the name of your newly created intent in the following handler
        [LuisIntent("Book")]
        public async Task Book(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("OK! i will book hotel for you", "OK! i will book hotel for you");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Calendar")]
        public async Task Calendar(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("You have free day today", "You have free day today");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Weather.GetCondition")]
        public async Task WeatherGetCondition(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("Weather. GetCondition", "Weather. GetCondition");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Weather.GetForecast")]
        public async Task WeatherGetForecast(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("Weather. GetForecast", "Weather. GetForecast");
            context.Wait(MessageReceived);
        }

        [LuisIntent("AIPO")]
        public async Task AIPO(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("Yes of Course!");
            context.Wait(MessageReceived);
        }


    }
}