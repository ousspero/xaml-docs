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

#region radmap-features-extended-data_1
// Create extended property set.
// It can be shared between the number
// of the map shapes.
ExtendedPropertySet propertySet = new ExtendedPropertySet();
propertySet.RegisterProperty( "Name", "City Name", typeof( string ), String.Empty );
propertySet.RegisterProperty( "Population", "Population", typeof( int ), 0 );
MapEllipse sofiaEllipse = new MapEllipse()
{
    ShapeFill = new MapShapeFill()
    {
        Stroke = new SolidColorBrush( Colors.Red ),
        StrokeThickness = 2,
        Fill = new SolidColorBrush( Colors.Transparent )
    },
    Width = 20,
    Height = 20,
    Location = new Location( 42.6957539183824, 23.3327663758679 ),
};
// Create extended data for the ellipse
// using existing property set.
ExtendedData sofiaData = new ExtendedData( propertySet );
// Set the extended properties.
sofiaData.SetValue( "Name", "Sofia" );
sofiaData.SetValue( "Population", 1300000 );
// Assign extended data to the map shape.
sofiaEllipse.ExtendedData = sofiaData;
this.informationLayer.Items.Add( sofiaEllipse );
#endregion

#region radmap-features-extended-data_4
ExtendedPropertySet propertySet = new ExtendedPropertySet();
propertySet.RegisterProperty( "Name", "City Name", typeof( string ), String.Empty );
propertySet.RegisterProperty( "Population", "Population", typeof( int ), 0 );
MapEllipse sofiaEllipse = new MapEllipse()
{
    ShapeFill = new MapShapeFill()
    {
        Stroke = new SolidColorBrush( Colors.Red ),
        StrokeThickness = 2,
        Fill = new SolidColorBrush( Colors.Transparent )
    },
    Width = 20,
    Height = 20,
    Location = new Location( 42.6957539183824, 23.3327663758679 ),
};
ExtendedData sofiaData = new ExtendedData( propertySet );
sofiaData.SetValue( "Name", "Sofia" );
sofiaData.SetValue( "Population", 1300000 );
sofiaEllipse.ExtendedData = sofiaData;
// Assign tooltip which uses the extended properties.
ToolTip tooltip = new ToolTip();
Binding tooltipBinding = new Binding()
{
    Converter = new ExtendedDataConverter(),
    ConverterParameter = "{Name}: {Population} people",
    Source = sofiaEllipse.ExtendedData
};
tooltip.SetBinding( ToolTip.ContentProperty, tooltipBinding );
ToolTipService.SetToolTip( sofiaEllipse, tooltip );
this.informationLayer.Items.Add( sofiaEllipse );
#endregion
}
