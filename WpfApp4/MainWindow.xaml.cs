using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MyRichTextBox.Document=new FlowDocument(){};
            var uiElement = new TextBlock(){HorizontalAlignment = HorizontalAlignment.Left,Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"};
            MyRichTextBox.Document.Blocks.Add(new BlockUIContainer(uiElement));
            uiElement = new TextBlock(){HorizontalAlignment = HorizontalAlignment.Left,Text = "AAAAAAAAAAAAAAAAAAAAAA",VerticalAlignment =VerticalAlignment.Center};
            var button = new Button(){Content = "测试",Width=80,Height = 26,VerticalAlignment =VerticalAlignment.Center};
            var stackPanel = new StackPanel(){Orientation = Orientation.Horizontal,HorizontalAlignment = HorizontalAlignment.Left};
            stackPanel.Children.Add(uiElement);
            stackPanel.Children.Add(button);
            MyRichTextBox.Document.Blocks.Add(new BlockUIContainer(stackPanel){});

            Paragraph paragraph = new Paragraph();
            Run run = new Run() { Text = "我是红色的RunAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)) };
            paragraph.Inlines.Add(run);
            var button1 = new Button(){Content = "测试"};
            paragraph.Inlines.Add(button1);
            MyRichTextBox.Document.Blocks.Add(paragraph);
        }
    }
}
