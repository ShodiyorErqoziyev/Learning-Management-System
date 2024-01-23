using LearningManagementSystem.Windows.Course;
using System;
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
        CourseAllLessonsPage courseAllLessonsPage = new CourseAllLessonsPage();

        CourseViewWindow courseViewWindow = GetCourseViewWindow();
        courseViewWindow.PageNavigator.Content = courseAllLessonsPage;
    }

    private void Student_Count_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        CourseAllStudentsPage courseAllStudentsPage = new CourseAllStudentsPage();

        CourseViewWindow courseViewWindow = GetCourseViewWindow();
        courseViewWindow.PageNavigator.Content = courseAllStudentsPage;
    }

    private void Description_Button_Click(object sender, RoutedEventArgs e)
    {

    }

    public static CourseViewWindow GetCourseViewWindow()
    {
        CourseViewWindow courseViewWindow = null!;

        foreach (Window window in Application.Current.Windows)
        {
            Type type = typeof(CourseViewWindow);
            if (window != null && window.DependencyObjectType.Name == type.Name)
            {
                courseViewWindow = (CourseViewWindow)window;
                if (courseViewWindow != null)
                {
                    break;
                }
            }
        }
        return courseViewWindow!;
    }
}
