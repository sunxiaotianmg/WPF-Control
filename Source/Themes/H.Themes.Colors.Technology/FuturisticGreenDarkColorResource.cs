﻿using H.Themes.Colors;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace H.Themes.Colors.Technology;
[Display(Name = "未来主义绿", GroupName = "深色科技风", Description = "纯色", Order = 100, Prompt = "试验")]
public class FuturisticGreenDarkColorResource : ColorResourceBase
{
    public FuturisticGreenDarkColorResource()
    {
        this.IsDark = true;
    }
    public override ResourceDictionary Resource => new ResourceDictionary()
    {
        Source = new Uri("pack://application:,,,/H.Themes.Colors.Technology;component/FuturisticGreenDark.xaml")
    };
}
