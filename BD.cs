using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;
using static System.Net.Mime.MediaTypeNames;

< Window x: Class = "WpfApp1.MainWindow"
        xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns: d = "http://schemas.microsoft.com/expression/blend/2008"
        xmlns: mc = "http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns: local = "clr-namespace:WpfApp1"
        mc: Ignorable = "d"
        Title = "Rede de Amigos" Height = "450" Width = "800" >
    < Grid >
        < Grid.ColumnDefinitions >
            < ColumnDefinition />
        </ Grid.ColumnDefinitions >
        < Label Content = "Rede de Amigos" HorizontalAlignment = "Left" Margin = "557,108,0,0" VerticalAlignment = "Top" Width = "169" Height = "43" FontSize = "20" FontWeight = "Bold" />
        < TextBox HorizontalAlignment = "Left" Margin = "538,156,0,0" TextWrapping = "Wrap" Text = "&#xD;&#xA;" VerticalAlignment = "Top" Width = "200" TextChanged = "TextBox_TextChanged" Height = "29" />
        < Label Content = "Apelido" HorizontalAlignment = "Left" Margin = "473,159,0,0" VerticalAlignment = "Top" Width = "60" RenderTransformOrigin = "0.575,-0.266" />
        < TextBox HorizontalAlignment = "Left" Margin = "538,156,0,0" TextWrapping = "Wrap" Text = "&#xA;" VerticalAlignment = "Top" Width = "200" TextChanged = "TextBox_TextChanged" Height = "29" BorderThickness = "3,3,3,3" />
        < Label Content = "" HorizontalAlignment = "Left" Margin = "473,159,0,0" VerticalAlignment = "Top" Width = "60" RenderTransformOrigin = "0.575,-0.266" />
        < TextBox HorizontalAlignment = "Left" Margin = "538,204,0,0" TextWrapping = "Wrap" Text = "&#xA;" VerticalAlignment = "Top" Width = "200" TextChanged = "TextBox_TextChanged" Height = "29" BorderThickness = "3,3,3,3" />
        < Label Content = "Telefone" HorizontalAlignment = "Left" Margin = "473,207,0,0" VerticalAlignment = "Top" Width = "60" RenderTransformOrigin = "0.575,-0.266" />
        < TextBox HorizontalAlignment = "Left" Margin = "538,252,0,0" TextWrapping = "Wrap" Text = "&#xA;" VerticalAlignment = "Top" Width = "200" TextChanged = "TextBox_TextChanged" Height = "29" BorderThickness = "3,3,3,3" />
        < Label Content = "e-mail" HorizontalAlignment = "Left" Margin = "473,255,0,0" VerticalAlignment = "Top" Width = "60" RenderTransformOrigin = "0.575,-0.266" />
        < ListBox d: ItemsSource = "{d:SampleData ItemCount=5}" SelectionChanged = "ListBox_SelectionChanged" Margin = "25,95,407,76" ScrollViewer.HorizontalScrollBarVisibility = "Disabled" BorderThickness = "3,3,3,3" >
            < ListBox.Effect >
                < DropShadowEffect />
            </ ListBox.Effect >
        </ ListBox >
        < Button Content = "Buscar" HorizontalAlignment = "Left" Margin = "588,315,0,0" VerticalAlignment = "Top" Click = "Button_Click" Width = "72" Height = "29" >
            < Button.Effect >
                < DropShadowEffect />
            </ Button.Effect >
        </ Button >
        < Button Content = "Remover" HorizontalAlignment = "Left" Margin = "690,315,0,0" VerticalAlignment = "Top" Click = "Button_Click" Width = "73" Height = "29" >
            < Button.Effect >
                < DropShadowEffect />
            </ Button.Effect >
        </ Button >
        < Button Content = "Listar Todos" HorizontalAlignment = "Left" Margin = "327,380,0,0" VerticalAlignment = "Top" Click = "Button_Click" Width = "73" Height = "29" >
            < Button.Effect >
                < DropShadowEffect />
            </ Button.Effect >
        </ Button >
        < Button Content = "Cadastrar" HorizontalAlignment = "Left" Margin = "482,315,0,0" VerticalAlignment = "Top" Click = "Button_Click" Width = "72" Height = "29" >
            < Button.Effect >
                < DropShadowEffect />
            </ Button.Effect >
        </ Button >

    </ Grid >
</ Window >
