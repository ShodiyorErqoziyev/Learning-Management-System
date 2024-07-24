using LearningManagementSystem.Windows.Course;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LearningManagementSystem.Components;

/// <summary>
/// Interaction logic for CourseComponent.xaml
/// </summary>
public partial class CourseComponent : UserControl
{
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
        courseViewWindow.ShowDialog();
    }

    private void btnManege_Click(object sender, RoutedEventArgs e)
    {

    }

    private void deletebtn_Click(object sender, RoutedEventArgs e)
    {

    }
}
