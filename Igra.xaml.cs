using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Memroy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Igra : Page
    {
        public Igra()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://htmlcolorcodes.com/assets/images/colors/cyan-color-solid-background-1920x1080.png"));
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://htmlcolorcodes.com/assets/images/colors/cyan-color-solid-background-1920x1080.png"));
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://htmlcolorcodes.com/assets/images/colors/red-color-solid-background-1920x1080.png"));
    }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://htmlcolorcodes.com/assets/images/colors/red-color-solid-background-1920x1080.png"));
    }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/d/d0/Color-yellow.JPG"));
        }

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/d/d0/Color-yellow.JPG"));
        }

        private void Image_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Flag_of_Libya_%281977%E2%80%932011%29.svg/300px-Flag_of_Libya_%281977%E2%80%932011%29.svg.png"));
        }

        private void Image_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Flag_of_Libya_%281977%E2%80%932011%29.svg/300px-Flag_of_Libya_%281977%E2%80%932011%29.svg.png"));
        }

        private void Image_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFFPxrM6LnygxNoD4iJsPlJoHb0BSHIHcDbdSBJ18ulYZzp12y9zF4Sayu6kniO6eHhmI&usqp=CAU"));
        }

        private void Image_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFFPxrM6LnygxNoD4iJsPlJoHb0BSHIHcDbdSBJ18ulYZzp12y9zF4Sayu6kniO6eHhmI&usqp=CAU"));
        }

        private void Image_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://images.unsplash.com/flagged/photo-1593005510329-8a4035a7238f?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8eWVsbG93JTIwY29sb3J8ZW58MHx8MHx8fDA%3D"));
        }

        private void Image_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://images.unsplash.com/flagged/photo-1593005510329-8a4035a7238f?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8eWVsbG93JTIwY29sb3J8ZW58MHx8MHx8fDA%3D"));

        }

        private void Image_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/185284489/photo/orange.jpg?s=612x612&w=0&k=20&c=m4EXknC74i2aYWCbjxbzZ6EtRaJkdSJNtekh4m1PspE="));
        }

        private void Image_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/185284489/photo/orange.jpg?s=612x612&w=0&k=20&c=m4EXknC74i2aYWCbjxbzZ6EtRaJkdSJNtekh4m1PspE="));
        }

        private void Image_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/187102598/photo/gold-background.jpg?s=612x612&w=0&k=20&c=qJWuiK4eW9UXo7aHiA0iLVHoDbkCfz8Z5bY9YGxZM6o="));
        }

        private void Image_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/187102598/photo/gold-background.jpg?s=612x612&w=0&k=20&c=qJWuiK4eW9UXo7aHiA0iLVHoDbkCfz8Z5bY9YGxZM6o="));
        }
    }
    }
