using LearningManagementSystem.Windows.Course;
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

namespace LearningManagementSystem.Components
{
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
            Course_Component.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#329DFF"));
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
}
