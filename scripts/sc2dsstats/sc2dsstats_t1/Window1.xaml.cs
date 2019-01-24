﻿using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace sc2dsstats
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            ContextMenu win_cm = new ContextMenu();
            MenuItem win_saveas = new MenuItem();
            win_saveas.Header = "Save as ...";
            win_saveas.Click += new RoutedEventHandler(win_SaveAs_Click);
            win_cm.Items.Add(win_saveas);
            win_dps_img1.ContextMenu = win_cm;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dps_png = @"D:/github/sc2dsstats_debug/dpv.png";


            if (File.Exists(dps_png))
            {
                // Create a BitmapSource  
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.UriSource = new Uri(@dps_png);
                bitmap.EndInit();

                // Set Image.Source  
                win_dps_img1.Source = bitmap;

            }
            else
            {
                MessageBox.Show("und es war sommer");
            }
        }


        private void win_SaveAs_Click(object sender, RoutedEventArgs e)
        {

            string dps_png = win_dps_img1.Source.ToString();
            dps_png = new Uri(dps_png).LocalPath;
            BitmapImage bitmap = new BitmapImage();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Save PNG Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                bitmap.BeginInit();
                bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.UriSource = new Uri(@dps_png);
                bitmap.EndInit();

                // Save the bitmap into a file.
                using (FileStream stream =
                    new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmap));
                    encoder.Save(stream);
                }


            }
        }

        private void win_img_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string dps_png = win_dps_img1.Source.ToString();
            dps_png = new Uri(dps_png).LocalPath;
            File.Delete(dps_png);
        }
    }
}