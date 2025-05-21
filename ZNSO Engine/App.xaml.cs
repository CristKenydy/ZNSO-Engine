using System.Configuration;
using System.Data;
using System.Windows;
using ZNSO_Engine.Editors;

namespace ZNSO_Engine;

public partial class App : Application
{
    MainWindow mainWindow;
    MainEditor editor;
    public App()
    {
        mainWindow = new MainWindow();
        if (mainWindow.ShowDialog() == false)
        {
            Current.Shutdown();
        }
        else if (mainWindow.ShowDialog() == true)
        {
            editor = new MainEditor();
            editor.Show();
        }
    }
}

