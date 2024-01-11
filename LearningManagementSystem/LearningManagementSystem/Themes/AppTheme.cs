using System;
using System.Windows;

namespace LearningManagementSystem.Themes;

public class AppTheme
{
    public static void ChangeTheme(Uri themeuri)
    {
        ResourceDictionary Theme = new ResourceDictionary() { Source = themeuri };

        App.Current.Resources.Clear();
        App.Current.Resources.MergedDictionaries.Add(Theme);
    }
}
