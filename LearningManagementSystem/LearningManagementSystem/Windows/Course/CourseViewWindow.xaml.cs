using System.Runtime.InteropServices;
using System;
using System.Windows;
using System.Windows.Interop;
using static LearningManagementSystem.Windows.BlurWindow.BlurEffect;
using System.Windows.Media;

namespace LearningManagementSystem.Windows.Course;

/// <summary>
/// Interaction logic for CourseViewWindow.xaml
/// </summary>
public partial class CourseViewWindow : Window
{
    public CourseViewWindow()
    {
        InitializeComponent();
    }



    [DllImport("user32.dll")]
    internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);
    internal void EnableBlur()
    {
        var windowHelper = new WindowInteropHelper(this);

        var accent = new AccentPolicy();
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

        var accentStructSize = Marshal.SizeOf(accent);

        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);

        var data = new WindowCompositionAttributeData();
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
        data.SizeOfData = accentStructSize;
        data.Data = accentPtr;

        SetWindowCompositionAttribute(windowHelper.Handle, ref data);

        Marshal.FreeHGlobal(accentPtr);
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        EnableBlur();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Lesson_Count_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Lesson_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#329DFF"));
    }

    private void Lesson_Count_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Lesson_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Black"));
    }

    private void Student_Count_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Student_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#329DFF"));
    }

    private void Student_Count_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Student_Count.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Black"));
    }

    private void Lesson_Count_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

    }

    private void Student_Count_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

    }
    
    private void Description_Button_Click(object sender, RoutedEventArgs e)
    {

    }
}