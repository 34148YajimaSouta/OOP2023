using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace colerChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void cbColor_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectColor = (MyColor)((ComboBox)sender).SelectedItem;
            colorArea.Background = new SolidColorBrush(selectColor.Color);
        }

        private void stock_Click(object sender, RoutedEventArgs e) {
            string colorList = string.Format("R={0} G={1} B={2}",rSlider.Value,gSlider.Value,bSlider.Value);
            colorListBox.Items.Add(colorList);
        }
    }
}
