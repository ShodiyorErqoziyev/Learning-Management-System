using LearningManagementSystem.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningManagementSystem
{
    public partial class MainWindow : Window
    {
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
            Application.Current.Shutdown();
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

        }
    }
}
