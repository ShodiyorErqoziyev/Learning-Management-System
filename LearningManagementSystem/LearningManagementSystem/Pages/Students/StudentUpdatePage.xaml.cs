using LearningManagementSystem.Windows.Students;
using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LearningManagementSystem.Pages.Students;

/// <summary>
/// Interaction logic for StudentUpdatePage.xaml
/// </summary>
public partial class StudentUpdatePage : Page
{
    public StudentUpdatePage()
    {
        InitializeComponent();
    }

    string path = string.Empty;

    private OpenFileDialog GetImageDialog()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        return openFileDialog;
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

    private void rbErkak_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Student_Picture_Border_MouseEnter(object sender, MouseEventArgs e) 
    {
        Student_Picture_Border.BorderBrush = (SolidColorBrush)Application.Current.Resources["borderMouseEnter"];
    }

    private void Student_Picture_Border_MouseLeave(object sender, MouseEventArgs e)
    {
        Student_Picture_Border.BorderBrush = (SolidColorBrush)Application.Current.Resources["BorderColor"];
    }

    private void Student_Picture_Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        var openFileDialog = GetImageDialog();
        if(openFileDialog.ShowDialog() == true)
        {
            path = openFileDialog.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                Student_Picture.ImageSource = null;
                Student_Picture.ImageSource = new BitmapImage(new Uri(path, UriKind.Relative));
            }

        }
    }

    private void txt_phone_number_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        string text = textBox.Text;
        string filteredText = Regex.Replace(text, "[^0-9]+", "");

        if (text != filteredText)
        {
            int caretIndex = textBox.CaretIndex;
            textBox.Text = filteredText;
            textBox.CaretIndex = caretIndex > 0 ? caretIndex - 1 : 0;
        }
    }

    private void Exit_Button_Click(object sender, RoutedEventArgs e)
    {
        StudentViewPage studentViewPage = new StudentViewPage();
        StudentViewWindow studentViewWindow = GetStudentWindow();
        studentViewWindow.PageNavigator.Content = studentViewPage;
    }
}
