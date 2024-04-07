using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Login_System.Views;

public partial class MessageDialog : Window
{
    public MessageDialog()
    {
        InitializeComponent();
    }

    public MessageDialog(string message) : this()
    {
        this.FindControl<TextBlock>("MessageTextBlock").Text = message;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void AcceptClick(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}