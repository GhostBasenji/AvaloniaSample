using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SimpleAvaloniaProject;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var button = this.FindControl<Button>("CloseWindowButton");
        button.Click += Button_Click;
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}