using LearningManagementSystem.Windows.Course;
using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using LearningManagementSystem.Constans;

namespace LearningManagementSystem.Pages.Courses;

/// <summary>
/// Interaction logic for CourseAllStudentsPage.xaml
/// </summary>
public partial class CourseAllStudentsPage : Page
{
    public CourseAllStudentsPage()
    {
        InitializeComponent();
    }

    private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Back_Border_Button_MouseDown(object sender, MouseButtonEventArgs e)
    {
        CourseViewPage page = new CourseViewPage();

        CourseViewWindow window = GetWindow.GetCourseViewWindow();
        window.PageNavigator.Content = page;
    }

}
