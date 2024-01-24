using LearningManagementSystem.Windows.Course;
using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace LearningManagementSystem.Pages.Courses;

/// <summary>
/// Interaction logic for CourseDescriptionPage.xaml
/// </summary>
public partial class CourseDescriptionPage : Page
{
    public CourseDescriptionPage()
    {
        InitializeComponent();
    }

    private void Back_Border_Button_MouseDown(object sender, MouseButtonEventArgs e)
    {
        CourseViewPage page = new CourseViewPage();

        CourseViewWindow window = GetCourseViewWindow();
        window.PageNavigator.Content = page;
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
