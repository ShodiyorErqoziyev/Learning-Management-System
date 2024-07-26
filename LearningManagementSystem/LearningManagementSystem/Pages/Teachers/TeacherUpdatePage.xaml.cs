using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LearningManagementSystem.Pages.Teachers;

/// <summary>
/// Interaction logic for TeacherUpdatePage.xaml
/// </summary>
public partial class TeacherUpdatePage : Page
{

    string path = string.Empty;
    public TeacherUpdatePage()
    {
        InitializeComponent();
    }

    private OpenFileDialog GetImageDialog()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        return openFileDialog;
    }

    private void teacher_Image_Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        var openFileDialog = GetImageDialog();
        if (openFileDialog.ShowDialog() == true)
        {
            path = openFileDialog.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                teacher_Picture.ImageSource = null;
                teacher_Picture.ImageSource = new BitmapImage(new Uri(path, UriKind.Relative));
            }
        }
    }

    private void teacher_Image_Border_MouseEnter(object sender, MouseEventArgs e)
    {
        teacher_Image_Border.BorderBrush = (SolidColorBrush)Application.Current.Resources["borderMouseEnter"];
    }

    private void teacher_Image_Border_MouseLeave(object sender, MouseEventArgs e)
    {
        teacher_Image_Border.BorderBrush = (SolidColorBrush)Application.Current.Resources["BorderColor"];
    }

    private void rbErkak_Click(object sender, RoutedEventArgs e)
    {

    }
}
