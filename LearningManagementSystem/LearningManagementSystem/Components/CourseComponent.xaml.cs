using LearningManagementSystem.Constans;
using LearningManagementSystem.Pages;
using LearningManagementSystem.Windows;
using LearningManagementSystem.Windows.Course;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using static LearningManagementSystem.Windows.MessageBoxWindow;

namespace LearningManagementSystem.Components;

/// <summary>
/// Interaction logic for CourseComponent.xaml
/// </summary>
public partial class CourseComponent : UserControl
{

    string message = string.Empty;

    public CourseComponent()
    {
        InitializeComponent();
    }

    private void Course_Component_MouseEnter(object sender, MouseEventArgs e)
    {
        Course_Component.BorderBrush = (SolidColorBrush)Application.Current.Resources["borderMouseEnter"]; 
    }

    private void Course_Component_MouseLeave(object sender, MouseEventArgs e)
    {
        Course_Component.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));
    }

    private void Course_Component_MouseDown(object sender, MouseButtonEventArgs e)
    {
        CourseViewWindow courseViewWindow = new CourseViewWindow();
        courseViewWindow.index = 2;
        courseViewWindow.ShowDialog();
    }

    private void btnManege_Click(object sender, RoutedEventArgs e)
    {
        CourseViewWindow courseViewWindow = new CourseViewWindow();
        courseViewWindow.index = 1;
        courseViewWindow.ShowDialog();
    }

    private void deletebtn_Click(object sender, RoutedEventArgs e)
    {
        message = Course_Name.Content.ToString() + "  kursini o'chirmoqchimisiz?";

        var messageBox = new MessageBoxWindow(message, MessageType.Confirmation, MessageButtons.OkCancel);
        var result = messageBox.ShowDialog();
        if (result == true)
        {
            MainWindow mainWindow = GetWindow.GetMainWindow();
            CoursePage coursePage = GetWindow.GetCoursePage(mainWindow.PageNavigator);
            coursePage.wrp_Course.Children.Remove(this);
        }
    }
}
