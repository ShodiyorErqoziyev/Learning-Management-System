using LearningManagementSystem.Pages;
using LearningManagementSystem.Themes;
using LearningManagementSystem.Windows;
using System;
using System.Windows;
using System.Windows.Input;
using static LearningManagementSystem.Windows.MessageBoxWindow;

namespace LearningManagementSystem
{
    public partial class MainWindow : Window
    {

        string message = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            message = "Ilovadan chiqmoqchimisiz?";

            //var messageBox = new MessageBoxWindow(message, MessageType.Confirmation, MessageButtons.YesNo);
            //var result = messageBox.ShowDialog();
            //if (result == true)
            //{
                Application.Current.Shutdown();
            //}
        }

        private void MouseDragable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rbDashboard_Click(object sender, RoutedEventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage();
            PageNavigator.Content = dashboardPage;
        }

        private void rbTeacher_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage teacherPage = new TeacherPage();
            PageNavigator.Content = teacherPage;    
        }

        private void rbCourse_Click(object sender, RoutedEventArgs e)
        {
            CoursePage coursePage = new CoursePage();
            PageNavigator.Content = coursePage;
        }

        private void rbStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentPage studentPage = new StudentPage();
            PageNavigator.Content = studentPage;
        }

        private void rbPayment_Click(object sender, RoutedEventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();
            PageNavigator.Content = paymentPage;
        }

        private void rbGroups_Click(object sender, RoutedEventArgs e)
        {
            // Hozircha commentga olib qo'ydim. Kerak bo'lsa ishlataman
        }

        private void IsChecked(object sender, RoutedEventArgs e)
        {
            if (chkbox.IsChecked == true)
            {
                AppTheme.ChangeTheme(new Uri("Themes/DarkTheme.xaml", UriKind.Relative));

            }
            else
            {
                AppTheme.ChangeTheme(new Uri("Themes/LightTheme.xaml", UriKind.Relative));
            }
        }

        private void tg_btn_menu_Click(object sender, RoutedEventArgs e)
        {
            if(tg_btn_menu.IsChecked == true)
            {
                Menu_Stp.Visibility = Visibility.Visible;
                Path_Stp.Visibility= Visibility.Collapsed;
            }
            else
            {
                Menu_Stp.Visibility = Visibility.Collapsed;
                Path_Stp.Visibility = Visibility.Visible;
            }
        }
    }
}
