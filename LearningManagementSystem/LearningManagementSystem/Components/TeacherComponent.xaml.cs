using LearningManagementSystem.Constans;
using LearningManagementSystem.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LearningManagementSystem.Components;

/// <summary>
/// Interaction logic for TeacherComponent.xaml
/// </summary>
public partial class TeacherComponent : UserControl
{

    private bool action_button = false;

    public TeacherComponent()
    {
        InitializeComponent();
    }

    private void Teacher_Component_MouseEnter(object sender, MouseEventArgs e)
    {
        Teacher_Component.BorderBrush = (SolidColorBrush)Application.Current.Resources["borderMouseEnter"];
    }

    private void Teacher_Component_MouseLeave(object sender, MouseEventArgs e)
    {
        Teacher_Component.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));
    }

    private void Teacher_Component_MouseDown(object sender, MouseButtonEventArgs e)
    {

    }

    private void Action_Button_Click(object sender, RoutedEventArgs e)
    {
        if (!action_button)
        {
            Delete_Button.Visibility = Visibility.Visible;
            Update_Button.Visibility = Visibility.Visible;
            Action_Border_Bakcground.Background = (SolidColorBrush)Application.Current.Resources["ActionBorderBackground"];
            action_button = true;
        }
        else
        {
            Delete_Button.Visibility = Visibility.Collapsed;
            Update_Button.Visibility = Visibility.Collapsed;
            Action_Border_Bakcground.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));
            action_button = false;
        }
    }

    private void Action_Button_LostFocus(object sender, RoutedEventArgs e)
    {
        var focus = Keyboard.FocusedElement;
        if(focus == Delete_Button)
        {
            Delete_Button.Visibility = Visibility.Visible;
        }
        else if(focus == Update_Button)
        {
            Update_Button.Visibility = Visibility.Visible;
        }
        else
        {
            Delete_Button.Visibility = Visibility.Collapsed;
            Update_Button.Visibility = Visibility.Collapsed;
        }

        Action_Border_Bakcground.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));
        action_button = false;
    }

    private void Delete_Button_Click(object sender, RoutedEventArgs e)
    {
        Delete_Button.Visibility = Visibility.Collapsed;
        MainWindow mainWindow = GetWindow.GetMainWindow();
        TeacherPage teacherPage = GetWindow.GetTeacherPage(mainWindow.PageNavigator);
        teacherPage.wrp_Teacher.Children.Remove(this);
    }

    private void Update_Button_Click(object sender, RoutedEventArgs e)
    {
        Update_Button.Visibility = Visibility.Collapsed;
    }
}
