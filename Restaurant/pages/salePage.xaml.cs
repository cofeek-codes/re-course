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

namespace Restaurant.pages
{
    /// <summary>
    /// Логика взаимодействия для salePage.xaml
    /// </summary>
    public partial class salePage : Page
    {
        private kormyshevEntities _context = kormyshevEntities.GetContext();
        private List<SaleProduct> saleProducts = ListSaleProducts.products;
        List<Category1> category;
        public salePage()
        {
            InitializeComponent();
            dtgItems.ItemsSource = _context.Product1.ToList();
            dgSale.ItemsSource = saleProducts;
            lwData.ItemsSource = _context.Product1.ToList();
            category = new List<Category1>() {
                new Category1()
                {
                    id=0, Name = "Все",
                }
            };
            category = category.Concat(_context.Category1.ToList()).ToList();
            lwCategory.ItemsSource = category;
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuspend_Click(object sender, RoutedEventArgs e)
        {
            ListSaleProducts.products = new List<SaleProduct>();
            saleProducts = ListSaleProducts.products;

            dgSale.ItemsSource = saleProducts;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ListSaleProducts.products = saleProducts;
            Global.frm.GoBack();
        }
        #region datagrid && listview
        private void dtgItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var p = (Product1)dtgItems.SelectedItem;
            var sp = saleProducts.Find(x => x.id == p.id);
            if (sp == null)
            {
                sp = new SaleProduct()
                {
                    id = p.id,
                    Name = p.Name,
                    Count = 1,
                    Price = p.Price,
                    TotalPrice = p.Price,
                    Weight = p.Weight
                };
                saleProducts.Add(sp);
            }
            else
            {
                sp.Count++;
                sp.TotalPrice = sp.Price * sp.Count;
                sp.Weight += p.Weight;
            }


            dgSale.ItemsSource = saleProducts.ToList();
            Total();
        }

        private void lwData_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var p = (Product1)lwData.SelectedItem;
            var sp = saleProducts.Find(x => x.id == p.id);
            if (sp == null)
            {
                sp = new SaleProduct()
                {
                    id = p.id,
                    Name = p.Name,
                    Count = 1,
                    Price = p.Price,
                    TotalPrice = p.Price,
                    Weight = p.Weight
                };
                saleProducts.Add(sp);
            }
            else
            {
                sp.Count++;
                sp.TotalPrice = sp.Price * sp.Count;
                sp.Weight += p.Weight;
            }

            dgSale.ItemsSource = saleProducts.ToList();
            Total();
        }

        #endregion

        private void tboxSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var t = tboxSerch.Text;
            SaleProduct sp;
            try
            {
                sp = saleProducts.Find(x => x.Name == t);
                var p = _context.Product1.ToList().Find(x => x.Name == t);
                if (sp == null)
                {
                    sp = new SaleProduct()
                    {
                        id = p.id,
                        Name = p.Name,
                        Count = 1,
                        Price = p.Price,
                        TotalPrice = p.Price,
                        Weight = p.Weight
                    };
                    saleProducts.Add(sp);
                }
                else
                {
                    sp.Count++;
                    sp.TotalPrice = sp.Price * sp.Count;
                    sp.Weight += p.Weight;
                }

                dgSale.ItemsSource = saleProducts.ToList();
            }
            catch { }
        }

        private void lwCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel = (Category1)lwCategory.SelectedItem;
            if (sel.id == 0)
            {
                dtgItems.ItemsSource = _context.Product1.ToList();
                lwData.ItemsSource = _context.Product1.ToList();
                return;
            }
            dtgItems.ItemsSource = _context.Product1.ToList().FindAll(x => x.CategoryId == sel.id).ToList();
            lwData.ItemsSource = _context.Product1.ToList().FindAll(x => x.CategoryId == sel.id).ToList();
        }

        private void Total()
        {
            var total = 0.0;
            var subTotal = 0.0;

            saleProducts.ForEach(x =>
            {
                total += x.TotalPrice;
                subTotal += x.TotalPrice;
            });

            lblTotal.Content = total;
            lblSubTotal.Content = subTotal;
            lblDiscount.Content = 0;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb.Text == null)
            {
                lwCategory.ItemsSource = category;
                return;
            }
            lwCategory.ItemsSource = category.FindAll(x => x.Name.ToLower().Contains(tb.Text.ToLower())).ToList();
        }
    }

    public class SaleProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
    }

    public static class ListSaleProducts
    {
        public static List<SaleProduct> products { get; set; } = new List<SaleProduct>();
    }
}
