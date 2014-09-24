using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region raddocking-theming-overview_0
public StylingPaneHeader()
{
    InitializeComponent();
    StyleManager.SetTheme( this.radDocking, new Theme( new Uri( "/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative ) ) );
}
#endregion

#region raddocking-theming-overview_3
public StylingPaneHeader()
{
    InitializeComponent();
    StyleManager.SetTheme( this.radDocking, new RadDockingTheme() );
}
#endregion
}
