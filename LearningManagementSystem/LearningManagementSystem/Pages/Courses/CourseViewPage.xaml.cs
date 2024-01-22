using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LearningManagementSystem.Pages.Courses;

/// <summary>
/// Interaction logic for CourseViewPage.xaml
/// </summary>
public partial class CourseViewPage : Page
{
    public CourseViewPage()
    {
        InitializeComponent();
    }

    private void Lesson_Count_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Lesson_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#329DFF"));
    }

    private void Lesson_Count_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        SolidColorBrush myColorBrush = (SolidColorBrush)Application.Current.Resources["labelColor"];
        Lesson_Count.Foreground = myColorBrush;
    }

    private void Student_Count_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Student_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#329DFF"));
    }

    private void Student_Count_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        SolidColorBrush myColorBrush = (SolidColorBrush)Application.Current.Resources["labelColor"];
        Student_Count.Foreground = myColorBrush;
    }

    private void Lesson_Count_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

    }

    private void Student_Count_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

    }

    private void Description_Button_Click(object sender, RoutedEventArgs e)
    {

    }
}
