using System.Windows;

namespace SEH;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    static bool FirstStart = true;
    public MainWindow()
    {
        if (FirstStart)
        {
            FirstStart = false;
            this.Visibility = Visibility.Hidden;
            FirstStartWindow result = new FirstStartWindow();
            if (result.ShowDialog() == true)
            {
                int selectedOption = result.SelectedOption;
                switch (selectedOption)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        MessageBoxResult close = MessageBox.Show("Vuoi chiudere il programma?", "Chiusura",
                            MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (close == MessageBoxResult.Yes)
                        {
                            Application.Current.Shutdown();
                        }

                        break;
                }

            }
        }

        InitializeComponent();
    }
}