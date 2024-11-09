using System;
using ReactiveUI;
using System.Windows.Input;
using Avalonia.Controls;

namespace VowelCountApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    public object ProcessString { get; }
#pragma warning restore CA1822 // Mark members as static
    
        ProcessString = ReactiveCommand.Create(() =>
        {
            String str1 = TextBoxString.Text;
            int vcount=0, i, str1len = str1.Length;

            for (i = 0; i < str1len; i++)
            {
                str2 = Mid(str1, i);
                if (str2)
                {
                    vcount++;
                }
            }
        });

}