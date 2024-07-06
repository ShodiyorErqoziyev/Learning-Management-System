using LearningManagementSystem.Components;
using System.Windows;
using System.Windows.Controls;

namespace LearningManagementSystem.Pages;

/// <summary>
/// Interaction logic for StudentPage.xaml
/// </summary>
public partial class StudentPage : Page
{
    public StudentPage()
    {
        InitializeComponent();
    }
    private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
    {
        loader.Visibility = Visibility.Collapsed;
        scrolViver.Visibility = Visibility.Visible;

        for (int i = 1; i <= 30; i++)
        {
            StudentComponent student = new StudentComponent();
            student.Student_Number.Content = i.ToString();
            wrp_Students.Children.Add(student);
        }
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {

    }

    private void btnCreateStudent_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

}
