global using H.Services.Logger;
using System.Windows;
using System.Windows.Markup;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]

[assembly: XmlnsDefinition("QQ:908293466", "H.Extensions.Log4net")]
[assembly: XmlnsPrefix("QQ:908293466", "h")]

[assembly: XmlnsDefinition("https://github.com/HeBianGu", "H.Extensions.Log4net")]
[assembly: XmlnsPrefix("https://github.com/HeBianGu", "h")]


[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "H.Extensions.Log4net")]
[assembly: XmlnsPrefix("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "h")]
