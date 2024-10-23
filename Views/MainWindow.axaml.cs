using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AIVA.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void NavigationEvent(object? sender, SelectionChangedEventArgs e)
    {
        if (NavigationButtons.SelectedItem is not ListBoxItem selectedItem)
            return;

        var tag = selectedItem.Tag?.ToString();
        switch (tag)
        {
            case "Captura":
                ContentControlView.Content = new NuevaCaptura2Control();
                break;
            case "Transactions":
                ContentControlView.Content = new NuevaCapturaControl();
                break;
            case "Budget":
                ContentControlView.Content = new NuevaCapturaControl();
                break;
            case "Reports":
                ContentControlView.Content = new NuevaCapturaControl();
                break;
            case "Goals":
                ContentControlView.Content = new NuevaCapturaControl();
                break;
        }
    }

    private void OnHamburgerButtonClick(object? sender, RoutedEventArgs e)
    {
        MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
    }
}