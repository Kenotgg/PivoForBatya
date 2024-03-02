using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
      int batyaCounter = 0;

            List<Batya> batyaList = new List<Batya>() ;
        void ListFiller()
        {
            var batya = new Batya("Вася", true, 100);
            batyaList.Add(batya);
            var baty1 = new Batya("Александр", false, 100);
            batyaList.Add(baty1);
            var baty2 = new Batya("Богдан", true, 100);
            batyaList.Add(baty2);
            var baty3 = new Batya("Максим", true, 100);
            batyaList.Add(baty3);
            var baty4 = new Batya("Степа", true, 100);
            batyaList.Add(baty4);
            var baty5 = new Batya("Андрей", true, 100);
            batyaList.Add(baty5);
            var baty6 = new Batya("Иван", true, 100);
            batyaList.Add(baty6);
        }

            
        
       
        public MainWindow()
        {
            InitializeComponent();
            ListFiller();

            // TextBox1.TextChanged += TextBox1_TextChanged;
        }
        public void OnCreate(object sender, RoutedEventArgs e)
        {

            string batyaName = TextBox1.Text;
            for (i = 0; i < batyaList.Count; i++)
            {
                if (batyaName == batyaList[i].Name)
                {
                    batyaCounter++;
                    if (batyaList[i].olovoIsMined)
                    {
                        MessageBox.Show("Pivo otpravleno " + batyaList[i].Name);
                    }
                    if(!batyaList[i].olovoIsMined)
                    {
                        MessageBox.Show("Pivo ne otpravleno " + batyaList[i].Name);
                    }
                }
            }
            if(batyaCounter == 0)
            {
                MessageBox.Show("Batya ne nayden " + batyaName);
               
            }
            batyaCounter = 0;

        }
        public void OnGiveToAll(object sender, RoutedEventArgs e)
        {
            string batyaName = TextBox1.Text;
            for (i = 0; i < batyaList.Count; i++)
            {    
              MessageBox.Show("Pivo otpravleno " + batyaList[i].Name);
                    
                   
              }
            }
           
        }

    }
    

