using LearningManagementSystem.Pages.Courses;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using static LearningManagementSystem.Windows.BlurWindow.BlurEffect;

namespace LearningManagementSystem.Windows.Course;

/// <summary>
/// Interaction logic for CourseViewWindow.xaml
/// </summary>
public partial class CourseViewWindow : Window
{

    public int index = 0;

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

        if(index == 2)
        {
            CourseViewPage courseViewPage = new CourseViewPage();
            PageNavigator.Content = courseViewPage;
        }else if(index == 1) 
        {
            CouseUpdatePage couseUpdatePage = new CouseUpdatePage();
            PageNavigator.Content = couseUpdatePage;
        }
        
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

}