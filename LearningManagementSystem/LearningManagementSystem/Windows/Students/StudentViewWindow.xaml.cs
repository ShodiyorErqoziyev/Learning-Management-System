using LearningManagementSystem.Components;
using LearningManagementSystem.Pages.Students;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using static LearningManagementSystem.Windows.BlurWindow.BlurEffect;

namespace LearningManagementSystem.Windows.Students;

/// <summary>
/// Interaction logic for StudentViewWindow.xaml
/// </summary>
public partial class StudentViewWindow : Window
{
    public StudentComponent studentComponent { get; set; }
    public StudentViewWindow()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
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

        StudentViewPage studentViewPage = new StudentViewPage();
        studentViewPage.studentComponent = studentComponent;
        PageNavigator.Content = studentViewPage;
    }
}
