using System;
using System.Configuration;
using System.Linq;
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
          await context.SayAsync("I love you");
            context.Wait(MessageReceived);
        }

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "MyIntent" with the name of your newly created intent in the following handler
        [LuisIntent("Book")]
        public async Task Book(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("OK! i will book"+ result.Entities.First() +" for you", "OK! i will book "+ result.Entities.First() + " for you");
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
            await context.SayAsync("Yes of Course!", "Yes of Course!");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Thanks")]
        public async Task Thanks(IDialogContext context, LuisResult result)
        {
            await context.SayAsync("You are welcome!", "You are welcome!");
            context.Wait(MessageReceived);
        }

    }
}