using CommunityToolkit.Maui.Views;

namespace MauiApp10;

public partial class PopupWindow : Popup 
{
	public PopupWindow() 
   {
      InitializeComponent();
	}

   public void ButtonYes(object sender, EventArgs e) 
   {
      Close(true);
   }

   public void ButtonNo(object sender, EventArgs e) 
   {
      Application.Current.Quit();
   }
}
