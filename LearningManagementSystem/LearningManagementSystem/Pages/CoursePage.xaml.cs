using LearningManagementSystem.Components;
using System.Windows;
using System.Windows.Controls;

namespace LearningManagementSystem.Pages;

/// <summary>
/// Interaction logic for CoursePage.xaml
/// </summary>
public partial class CoursePage : Page
{
    public CoursePage()
    {
        InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        loader.Visibility = Visibility.Collapsed;
        scrolViver.Visibility = Visibility.Visible;
        for (int i = 0; i < 15; i++)
        {
            CourseComponent courseComponent = new CourseComponent();
            wrp_Course.Children.Add(courseComponent);
        }
    }

    private void btnCreateCourse_Click(object sender, RoutedEventArgs e)
    {

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {

    }
}
