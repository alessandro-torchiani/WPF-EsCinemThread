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
using System.Threading;

namespace WpfApp5
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static object x = new object();
        Thread t1;
        Thread t2;
        Thread tCas;
        Thread tCas2;
        int posto = 0;
        int posto2 = 0;

        public MainWindow()
        {
            InitializeComponent();
            rec1.Fill = System.Windows.Media.Brushes.Green;
            rec2.Fill = System.Windows.Media.Brushes.Green;
            rec3.Fill = System.Windows.Media.Brushes.Green;
            rec4.Fill = System.Windows.Media.Brushes.Green;
            rec5.Fill = System.Windows.Media.Brushes.Green;
        }


        public void Cassa1()
        {

            lock (x)
            {
                if (posto == 1 || posto == 2 || posto == 3 || posto == 4 || posto == 5)
                {
                    if (posto == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec1.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec1.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox1.Clear();


                            }

                            else if (rec1.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox1.Clear();
                            }
                        }));
                    }

                    if (posto == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec2.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec2.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox1.Clear();


                            }

                            else if (rec2.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox1.Clear();
                            }
                        }));
                    }

                    if (posto == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec3.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec3.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox1.Clear();


                            }

                            else if (rec3.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox1.Clear();
                            }
                        }));
                    }

                    if (posto == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec4.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec4.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox1.Clear();


                            }

                            else if (rec4.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox1.Clear();
                            }
                        }));
                    }

                    if (posto == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec5.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec5.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox1.Clear();


                            }

                            else if (rec5.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox1.Clear();
                            }
                        }));
                    }
                }
                else
                {
                    MessageBox.Show("Inserire un numero da 1 a 8 compresi");
                    txtBox1.Clear();
                }
            }

        }

        public void Cassa2()
        {

            lock (x)
            {
                if (posto == 1 || posto == 2 || posto == 3 || posto == 4 || posto == 5)
                {
                    if (posto == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec1.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec1.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox2.Clear();


                            }

                            else if (rec1.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox2.Clear();
                            }
                        }));
                    }

                    if (posto == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec2.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec2.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox2.Clear();


                            }

                            else if (rec2.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox2.Clear();
                            }
                        }));
                    }

                    if (posto == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec3.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec3.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox2.Clear();


                            }

                            else if (rec3.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox2.Clear();
                            }
                        }));
                    }

                    if (posto == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec4.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec4.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox2.Clear();


                            }

                            else if (rec4.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox2.Clear();
                            }
                        }));
                    }

                    if (posto == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            if (rec5.Fill == System.Windows.Media.Brushes.Green)
                            {

                                rec5.Fill = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Ora il posto è tuo");
                                txtBox2.Clear();


                            }

                            else if (rec5.Fill == System.Windows.Media.Brushes.Red)
                            {
                                MessageBox.Show("Il posto è già occupato");
                                txtBox2.Clear();
                            }
                        }));
                    }
                }
                else
                {
                    MessageBox.Show("Inserire un numero da 1 a 5");
                    txtBox2.Clear();
                }
            }

        }

        public void Casual()
        {
            bool found = true;
            lock (x)
            {
                if (posto == 1 || posto == 2 || posto == 3 || posto == 4 || posto == 5)
                {
                    while (found)
                    {
                        if (posto == 1)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                if (rec1.Fill == System.Windows.Media.Brushes.Green)
                                {
                                    found = false;
                                    rec1.Fill = System.Windows.Media.Brushes.Red;
                                    MessageBox.Show("Ora il posto è tuo");

                                }
                            }));
                        }

                        if (posto == 2)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                if (rec2.Fill == System.Windows.Media.Brushes.Green)
                                {
                                    found = false;
                                    rec2.Fill = System.Windows.Media.Brushes.Red;
                                    MessageBox.Show("Ora il posto è tuo");


                                }

                            }));
                        }

                        if (posto == 3)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                if (rec3.Fill == System.Windows.Media.Brushes.Green)
                                {
                                    found = false;
                                    rec3.Fill = System.Windows.Media.Brushes.Red;
                                    MessageBox.Show("Ora il posto è tuo");



                                }
                            }));
                        }

                        if (posto == 4)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                if (rec4.Fill == System.Windows.Media.Brushes.Green)
                                {
                                    found = false;
                                    rec4.Fill = System.Windows.Media.Brushes.Red;
                                    MessageBox.Show("Ora il posto è tuo");


                                }
                            }));
                        }

                        if (posto == 5)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                if (rec5.Fill == System.Windows.Media.Brushes.Green)
                                {
                                    found = false;
                                    rec5.Fill = System.Windows.Media.Brushes.Red;
                                    MessageBox.Show("Ora il posto è tuo");

                                }

                            }));
                        }

                        if (found)
                        {
                            found = false;
                        }
                    }
                }
            }
        }


        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            posto = int.Parse(txtBox1.Text);
            t1 = new Thread(new ThreadStart(Cassa1));
            t1.Start();
        }

        private void btn2_Click_1(object sender, RoutedEventArgs e)
        {
            posto = int.Parse(txtBox2.Text);
            t2 = new Thread(new ThreadStart(Cassa2));
            t2.Start();
        }

        private void btnSvuota_Click_1(object sender, RoutedEventArgs e)
        {
            rec1.Fill = System.Windows.Media.Brushes.Green;
            rec2.Fill = System.Windows.Media.Brushes.Green;
            rec3.Fill = System.Windows.Media.Brushes.Green;
            rec4.Fill = System.Windows.Media.Brushes.Green;
            rec5.Fill = System.Windows.Media.Brushes.Green;
        }

        private void btnCasuale1_Click(object sender, RoutedEventArgs e)
        {
            Random cas = new Random();
            posto = cas.Next(1, 6);
            tCas = new Thread(new ThreadStart(Casual));
            tCas.Start();
        }

        private void btnCasuale2_Click(object sender, RoutedEventArgs e)
        {
            Random cas = new Random();
            posto = cas.Next(1, 6);
            tCas2 = new Thread(new ThreadStart(Casual));
            tCas2.Start();
        }
    }


}
