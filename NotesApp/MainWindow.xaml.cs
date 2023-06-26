using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NotesApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : WinUIEx.WindowEx
    {
        //from https://github.com/microsoft/microsoft-ui-xaml/issues/7009
        void SetCapitionButtonColorForWin10()
        {
            var res = Microsoft.UI.Xaml.Application.Current.Resources;
            Action<Windows.UI.Color> SetTitleBarButtonForegroundColor = (Windows.UI.Color color) => { res["WindowCaptionForeground"] = color; };
            var currentTheme = ((FrameworkElement)Content).ActualTheme;
            if (currentTheme == ElementTheme.Dark)
            {
                SetTitleBarButtonForegroundColor(Colors.White);
            }
            else if (currentTheme == ElementTheme.Light)
            {
                SetTitleBarButtonForegroundColor(Colors.Black);
            }
            else
            {
                if (App.Current.RequestedTheme == ApplicationTheme.Dark)
                {
                    SetTitleBarButtonForegroundColor(Colors.White);
                }
                else
                {
                    SetTitleBarButtonForegroundColor(Colors.Black);
                }
            }
        }

        void InitDesign()
        {
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);

            SetCapitionButtonColorForWin10();

            MicaBackdrop abackdrop = new MicaBackdrop();
            abackdrop.Kind = Microsoft.UI.Composition.SystemBackdrops.MicaKind.Base;
            this.SystemBackdrop = abackdrop;

            this.SetWindowSize(550, 550);
            this.CenterOnScreen();
            this.SetIsResizable(false);
        }

        public MainWindow()
        {
            this.InitializeComponent();
            InitDesign();
        }

        private void RootGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AppTitleBackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainNavigation_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

        }
    }
}
