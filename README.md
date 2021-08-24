# XamlCombine
Combines multiple XAML resource dictionaries into one and sorts them in order of usage

## 特性
1. 使用`.net6.0`编译
2. 支持空行和注释行,注释行以`#`开头
3. 支持指定`x:`属性,如`x:Class=XuanYuan.Styles.Themes.Theme`.(这个特性可以支持Maui/Xamarin引用主题)

## 使用
XamlCombine.exe list-of-xamls.txt result-xaml.xaml  

Where:
- list-of-xamls.txt - text file which contains list of XAML filenames, 
- result-xaml.xaml - filename of result XAML file.

## 参考 
代码修改自[XamlCombine](https://github.com/fluentribbon/XamlCombine)