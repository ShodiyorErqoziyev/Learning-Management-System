using LearningManagementSystem.Pages;
using LearningManagementSystem.Windows.Course;
using LearningManagementSystem.Windows.Students;
using LearningManagementSystem.Windows.Teachers;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LearningManagementSystem.Constans;

public class GetWindow
{
    public static MainWindow GetMainWindow()
    {
        MainWindow mainWindow = null!;

        foreach (Window window in Application.Current.Windows)
        {
            Type type = typeof(MainWindow);
            if (window != null && window.DependencyObjectType.Name == type.Name)
            {
                mainWindow = (MainWindow)window;
                if (mainWindow != null)
                {
                    break;
                }
            }
        }
        return mainWindow!;
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

    public static CourseViewWindow GetCourseViewWindow()
    {
        CourseViewWindow courseViewWindow = null!;

        foreach (Window window in Application.Current.Windows)
        {
            Type type = typeof(CourseViewWindow);
            if (window != null && window.DependencyObjectType.Name == type.Name)
            {
                courseViewWindow = (CourseViewWindow)window;
                if (courseViewWindow != null)
                {
                    break;
                }
            }
        }
        return courseViewWindow!;
    }

    public static TeacherViewWindow GetTeacherViewWindow()
    {
        TeacherViewWindow teacherViewWindow = null!;

        foreach (Window window in Application.Current.Windows)
        {
            Type type = typeof(TeacherViewWindow);
            if (window != null && window.DependencyObjectType.Name == type.Name)
            {
                teacherViewWindow = (TeacherViewWindow)window;
                if (teacherViewWindow != null)
                {
                    break;
                }
            }
        }
        return teacherViewWindow!;
    }


    ///////////////////////////////////////////////////////////////////////////////////////

    public static TeacherPage GetTeacherPage(Frame frame)
    {
        if (frame.Content is TeacherPage teacherPage)
        {
            return teacherPage;
        }
        return null!;
    }

    public static StudentPage GetStudentPage(Frame frame)
    {
        if (frame.Content is StudentPage studentPage)
        {
            return studentPage;
        }
        return null!;
    }

    public static CoursePage GetCoursePage(Frame frame)
    {
        if (frame.Content is CoursePage coursePage)
        {
            return coursePage;
        }
        return null!;
    }
}
