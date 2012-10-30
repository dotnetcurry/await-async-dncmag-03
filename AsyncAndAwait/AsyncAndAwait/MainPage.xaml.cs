using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AsyncAndAwait
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            pageTitle.Text = "Order System - No orders have been loaded yet.";
        }
        private async void LoadOrders_Click(object sender, RoutedEventArgs e)
        {
            OrderLoadingProgress.Visibility = Visibility.Visible;

            var orderHandler = new OrderHandler();

            var orderTask = Task<IEnumerable<Order>>.Factory.StartNew(() =>
            {
                return orderHandler.GetAllOrders();
            });
            pageTitle.Text = "Order System - Loading...";
            var orders = await orderTask;

            Orders.Items.Clear();
            foreach (var order in orders)
                Orders.Items.Add(order);
            pageTitle.Text = "Order System - Loaded!";
            OrderLoadingProgress.Visibility = Visibility.Collapsed;
        }
    }
}
