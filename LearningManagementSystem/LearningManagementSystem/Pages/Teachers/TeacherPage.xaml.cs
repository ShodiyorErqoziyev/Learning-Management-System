using LearningManagementSystem.Components;
using System.Windows;
using System.Windows.Controls;

namespace LearningManagementSystem.Pages;

/// <summary>
/// Interaction logic for TeacherPage.xaml
/// </summary>
public partial class TeacherPage : Page
{
    public TeacherPage()
    {
        InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        loader.Visibility = Visibility.Collapsed;
        scrolViver.Visibility = Visibility.Visible;
        for (int i = 0; i < 15; i++)
        {
            TeacherComponent teacherComponent = new TeacherComponent();
            wrp_Teacher.Children.Add(teacherComponent);
        }
    }

    private void btnCreateTeacher_Click(object sender, RoutedEventArgs e)
    {

    }

    private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}
