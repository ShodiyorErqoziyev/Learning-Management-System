using LearningManagementSystem.Components;
using LearningManagementSystem.Constans;
using LearningManagementSystem.Windows;
using LearningManagementSystem.Windows.Students;
using System.Windows;
using System.Windows.Controls;
using static LearningManagementSystem.Windows.MessageBoxWindow;

namespace LearningManagementSystem.Pages.Students;

/// <summary>
/// Interaction logic for StudentViewPage.xaml
/// </summary>
public partial class StudentViewPage : Page
{
    public StudentComponent studentComponent { get; set; }
    string message = string.Empty;

    public StudentViewPage()
    {
        InitializeComponent();
    }

    private void Update_Button_Click(object sender, RoutedEventArgs e)
    {
        StudentUpdatePage studentUpdatePage = new StudentUpdatePage();
        StudentViewWindow studentViewWindow = GetWindow.GetStudentWindow();
        studentViewWindow.PageNavigator.Content = studentUpdatePage;
        
    }

    private void Delete_Student_Button_Click(object sender, RoutedEventArgs e)
    {
        message = Student_Firstname.Content.ToString() + " " + Student_Lastname.Content.ToString() + "ni o'chirmoqchimisiz?";
        
        var messageBox = new MessageBoxWindow(message, MessageType.Confirmation, MessageButtons.OkCancel);
        var result = messageBox.ShowDialog();
        if (result == true)
        {
            MainWindow mainWindow = GetWindow.GetMainWindow();
            StudentPage studentPage = GetWindow.GetStudentPage(mainWindow.PageNavigator);
            studentPage.wrp_Students.Children.Remove(studentComponent);
            StudentViewWindow studentViewWindow = GetWindow.GetStudentWindow();
            studentViewWindow.Close();
        }


    }
}
