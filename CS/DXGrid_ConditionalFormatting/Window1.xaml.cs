using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.ComponentModel;
using System;
using DevExpress.Xpf.Grid;

namespace DXGrid_ConditionalFormatting {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = Products.GetData();
        }
    }
    public class ColumnRowIndexesCellValueConverter : MarkupExtension, IMultiValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        #region IMultiValueConverter Members

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (values[0] == null) return Brushes.Transparent;
            int columnIndex= (int)(values[0] as GridColumn).VisibleIndex;
            int rowIndex = (int)values[1];
            if (columnIndex == 1 && rowIndex == 1)            
                return Brushes.Red;
            else  
                return Brushes.Transparent; 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class Products {
        public static List<Product> GetData() {
            List<Product> data = new List<Product>();
            data.Add(new Product() { ProductName = "Chai", 
                UnitPrice = 18, UnitsOnOrder = 10 });
            data.Add(new Product() { ProductName = "Ipoh Coffee", 
                UnitPrice = 36.8, UnitsOnOrder = 12 });
            data.Add(new Product() { ProductName = "Outback Lager", 
                UnitPrice = 12, UnitsOnOrder = 25 });
            data.Add(new Product() { ProductName = "Boston Crab Meat", 
                UnitPrice = 18.4, UnitsOnOrder = 18 });
            data.Add(new Product() { ProductName = "Konbu", 
                UnitPrice = 6, UnitsOnOrder = 24 });
            return data;
        }
    }
    public class Product {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}
