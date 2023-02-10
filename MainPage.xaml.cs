using CommunityToolkit;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Markup;


namespace MauiApp10;

public partial class MainPage : ContentPage {
   public MainPage()
	{
		InitializeComponent();
   }

   public async void Create_SnackBar(Color backgroundColor, Color textColor, Color actionButtonTextColor,
      string text, string actionButtonText, int cornderRadius, int timeSpan) {
      var snackbarOptions = new SnackbarOptions {
         BackgroundColor = backgroundColor,
         TextColor = textColor,
         ActionButtonTextColor = actionButtonTextColor,
         CornerRadius = new CornerRadius(cornderRadius),
      };
      Action action = async () => await DisplayAlert("Snackbar", "The user click on Snackbar", "Ok");
      TimeSpan duration = TimeSpan.FromSeconds(timeSpan);
      Snackbar snackbar = (Snackbar)Snackbar.Make(text, action, actionButtonText, duration, snackbarOptions);
      await snackbar.Show();
   }

   public async void Create_ToastBar() {
      string toastText = "This is toast";
      ToastDuration duration = ToastDuration.Short;
      double fontSize = 14;
      var toast = Toast.Make(toastText, duration, fontSize);
      await toast.Show();
   }

   private void buttonToast(object sender, EventArgs e) 
   {
      Create_ToastBar();
   }

   private void buttonSnackbar(object sender, EventArgs e) 
   {
      Create_SnackBar(Colors.BurlyWood, Colors.AliceBlue, Colors.DarkGrey, "This is snackBar", "Click to me", 5, 3);
   }

   private void buttonPopup(object sender, EventArgs e) 
   {
      this.ShowPopup(new PopupWindow());
   }
}



   //private void Button_Clicked(object sender, EventArgs e) {

   //   var snackbar = Snackbar.Make("This is snackbar", () => DisplayAlert("Did you  subscribed", "to me?", "Ok"), "Yes!",
   //      TimeSpan.FromSeconds(4), new CommunityToolkit.Maui.Core.SnackbarOptions {
   //         BackgroundColor = Colors.BlueViolet,
   //         TextColor = Colors.White,
   //         ActionButtonTextColor = Colors.White,
   //      });
   //   snackbar.Show();
   //}

   //private async void Button_Clicked2(object sender, EventArgs e) 
   //{
   //   CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

   //   var snackbarOptions = new SnackbarOptions {
   //      TextColor = Colors.Blue,
   //      ActionButtonTextColor = Colors.Yellow,
   //      CornerRadius = new CornerRadius(10),
   //   };

   //   string Text = "This is second snackbar";
   //   string actionButtonText = "Click Here to Hide snackbar";
   //   Action action = async () => await DisplayAlert("Snackbar", "The user click on SnackBar", "Ok", "No");
   //   TimeSpan duration = TimeSpan.FromSeconds(3);

   //   var snackbar = Snackbar.Make(Text, action, actionButtonText, duration, snackbarOptions);
   //   await snackbar.Show(cancellationTokenSource.Token);
   //}


