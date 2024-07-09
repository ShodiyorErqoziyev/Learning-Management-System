using LearningManagementSystem.Windows.Students;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LearningManagementSystem.Components;

/// <summary>
/// Interaction logic for StudentComponent.xaml
/// </summary>
public partial class StudentComponent : UserControl
{
    public StudentComponent()
    {
        InitializeComponent();
    }

    private void Student_Border_MouseEnter(object sender, MouseEventArgs e)
    {
        Student_Border.BorderBrush = (SolidColorBrush)Application.Current.Resources["borderMouseEnter"];
    }

    private void Student_Border_MouseLeave(object sender, MouseEventArgs e)
    {
        Student_Border.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));
    }

    private void Other_Button_Click(object sender, RoutedEventArgs e)
    {
        StudentViewWindow studentViewWindow = new StudentViewWindow();
        studentViewWindow.ShowDialog();
    }
}
