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

namespace BaiTapKiemTra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnHoaDon_Click(object sender, RoutedEventArgs e)
        {
            string ten = "Ten: " + txtname.Text + "\n";
            string sdt = "So Dien Thoai: " + txtnumber.Text + "\n";
            string soluong = "SoLuong: " + txtSL.Text + "\n";
            string SanPham;
            int gia, tong;

            if (rbnTV.IsChecked == true)
            {
                SanPham = "SanPham: TiVi" + "\n";
                gia = 200000;
            }
            else
            if (rbnTL.IsChecked == true)
            {
                SanPham = "SanPham: TuLanh" + "\n";
                gia = 150000;
            }
            else
            {
                SanPham = "SanPham: MayTinh" + "\n";
                gia = 50000;
            }

                tong = gia * int.Parse(txtSL.Text);

                string hienThi = ten + sdt + soluong + SanPham +  "Tong Tien : " + tong.ToString() + "\n";
                txbHienThi.Text = hienThi;
               
            }
          
        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        }

    
       
}

