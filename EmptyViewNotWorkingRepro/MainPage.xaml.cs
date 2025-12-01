namespace EmptyViewNotWorkingRepro
{
  public partial class MainPage : ContentPage
  {

    public MainPage()
    {
      InitializeComponent();

      EmptyCollection.ItemsSource = new List<string>();
      NullCollection.ItemsSource = null;
      ValuesCollection.ItemsSource = new List<string>() { "string1", "string2", "string3" };
    }
  }
}
