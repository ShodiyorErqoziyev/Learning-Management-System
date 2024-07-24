using LearningManagementSystem.Windows;
using LearningManagementSystem.Windows.Students;
using System;
using System.Windows;
using System.Windows.Controls;
using static LearningManagementSystem.Windows.MessageBoxWindow;

namespace LearningManagementSystem.Pages.Students;

/// <summary>
/// Interaction logic for StudentViewPage.xaml
/// </summary>
public partial class StudentViewPage : Page
{

    string message = string.Empty;

    public StudentViewPage()
    {
        InitializeComponent();
    }

    private void Update_Button_Click(object sender, RoutedEventArgs e)
    {
        StudentUpdatePage studentUpdatePage = new StudentUpdatePage();
        StudentViewWindow studentViewWindow = GetStudentWindow();
        studentViewWindow.PageNavigator.Content = studentUpdatePage;
        
    }

    public static StudentViewWindow GetStudentWindow()
    {
        StudentViewWindow studentViewWindow = null!;

        foreach (Window window in Application.Current.Windows)
        {
            Type type = typeof(StudentViewWindow);
            if (window != null && window.DependencyObjectType.Name == type.Name)
            {
                studentViewWindow = (StudentViewWindow)window;
                if (studentViewWindow != null)
                {
                    break;
                }
            }
        }
        return studentViewWindow!;
    }

    private void Delete_Student_Button_Click(object sender, RoutedEventArgs e)
    {
        message = Student_Firstname.Content.ToString() + " " + Student_Lastname.Content.ToString() + "ni o'chirmoqchimisiz?";
        
        var messageBox = new MessageBoxWindow(message, MessageType.Confirmation, MessageButtons.OkCancel);
        var result = messageBox.ShowDialog();
        if (result == true)
        {
            StudentViewWindow studentViewWindow = GetStudentWindow();
            studentViewWindow.Close();
        }


    }
}
