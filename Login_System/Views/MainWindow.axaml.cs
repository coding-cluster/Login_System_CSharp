using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Login_System.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SignIn_OnClick(object? sender, RoutedEventArgs e)
    {
        var password = PassBox.Text;
        if (password == "abc123")
        {
            var dialog = new MessageDialog("¡Contraseña Correcta!");
            dialog.ShowDialog(this);
        }
        else
        {
            var dialog = new MessageDialog("Contraseña incorrecta.");
            dialog.ShowDialog(this);
        }
    }
}