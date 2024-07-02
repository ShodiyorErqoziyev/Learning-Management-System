using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LearningManagementSystem.Components
{
    /// <summary>
    /// Interaction logic for TeacherComponent.xaml
    /// </summary>
    public partial class TeacherComponent : UserControl
    {
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
    }
}
