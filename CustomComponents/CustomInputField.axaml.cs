using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AIVA.CustomComponents;

public class CustomInputField : TemplatedControl
{
    public static readonly StyledProperty<EventHandler<TextChangedEventArgs>> OnTextUpdateProperty =
        AvaloniaProperty.Register<CustomInputField, EventHandler<TextChangedEventArgs>>(nameof(OnTextUpdate));
    
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
    
        // Obtener el TextBox por su nombre
        TextBox? textBox = e.NameScope.Find<TextBox>("TextInput");
    
        if (textBox != null)
        {
            // Suscribirse al evento TextChanged del TextBox
            textBox.TextChanged += (sender, args) =>
            {
                // Actualizar la propiedad InputText
                if (textBox.Text != null) Text = textBox.Text;

                // Invocar el evento OnTextUpdate si hay suscriptores
                OnTextUpdate?.Invoke(this, args);
            };
        }
    }


    public EventHandler<TextChangedEventArgs> OnTextUpdate  
    {
        get => GetValue(OnTextUpdateProperty);
        set => SetValue(OnTextUpdateProperty, value);
    }
    
    public static readonly StyledProperty<string> LabelTextProperty = AvaloniaProperty.Register<CustomInputField, string>(nameof(LabelText), "Campo:");
    

    public string LabelText
    {
        get => GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value + ":");
    }
    
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<CustomInputField, string>(nameof(Text), "");

    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }


    
    
}

