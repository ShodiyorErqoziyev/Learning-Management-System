using LearningManagementSystem.Windows.Course;
using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using LearningManagementSystem.Constans;

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

        CourseViewWindow window = GetWindow.GetCourseViewWindow();
        window.PageNavigator.Content = page;
    }

}
