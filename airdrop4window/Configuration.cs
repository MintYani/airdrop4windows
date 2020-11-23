using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;

namespace airdrop4window
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Wi-Fi Direct";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Advertiser", ClassType=typeof(Advertiser)},
            new Scenario() { Title="Connector", ClassType=typeof(Connector)}
        };

        public async void NotifyUserFromBackground(string strMessage, NotifyType type)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                NotifyUser(strMessage, type);
            });
        }
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
