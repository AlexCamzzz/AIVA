using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AIVA.Views;

public partial class NuevaCapturaControl : UserControl
{
    public NuevaCapturaControl()
    {
        InitializeComponent();
        InputFieldVendedorNombre.OnTextUpdate += (sender, args) =>
        {
            
        };
    }
    
    private void lo()
    {
        
    }
}