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

namespace XEploaiSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double Tich = 0, Diemtb = 0;
        int xeploai;
        string renluyen;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtDiemVan.Text);
            double b = double.Parse(txtDiemToan.Text);
            Tich = (a + b);
            Diemtb = Tich / 2;    
            
            
            if (Diemtb >= 8&& btnTot.IsChecked==true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai gioi"+" Duoc khen thuong");
            }
            if (Diemtb >= 8 && btnKha.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai kha");
            }
            if (Diemtb >= 8 && btnYeu.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai yeu"); 
            }
            if (Diemtb < 8 && Diemtb>=7 &&btnTot.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai kha");
            }
            if (Diemtb < 8 && Diemtb >= 7 && btnKha.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai kha");
            }
            if (Diemtb < 8 && Diemtb >= 7 && btnYeu.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb+"\nXep loai yeu");
            }
            if (Diemtb < 7 && btnTot.IsChecked == true)
            {
                MessageBox.Show("Ten sinh vien: " + txtTenSinhVien.Text + "\nMa sinh vien: " + txtMaSinhVien.Text + "\nRen luyen: " + renluyen + "\nDiem trung binh: " + Diemtb + "\nXep loai yeu");
            }
        }

        private void BtnTot_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)btnTot.IsChecked)
            {
                renluyen = btnTot.Content.ToString();
                btnKha.IsEnabled = false;
                btnYeu.IsEnabled = false;
            }
        }

        private void BtnKha_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)btnKha.IsChecked)
            {
                renluyen = btnKha.Content.ToString();
                btnTot.IsEnabled = false;
                btnYeu.IsEnabled = false;
            }
        }

        private void BtnYeu_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)btnYeu.IsChecked)
            {
                renluyen = btnYeu.Content.ToString();
                btnKha.IsEnabled = false;
                btnTot.IsEnabled = false;
            }
        }         
    }
}
