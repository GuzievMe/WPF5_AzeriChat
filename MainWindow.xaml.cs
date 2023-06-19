//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Wpf5_AzeriChat
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//        }
//    }
//}



using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SimpleChatApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void ChangesForProperty(string prpName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prpName));
        }


        private void txtBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Text = "";
                tb.Foreground = Brushes.Black;
            }
        }

        private void txtBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = "Search";
                    tb.Foreground = Brushes.Gray;
                }
            }
        }


        List<string> cahamat = new()
        {
            "Loris", "Jonathan", "Anjel", "Lamia", "Grelish", "Akuba", "Sezar"
        };

        ///>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  MESAJLARRR <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<///
        ///
        List<string> LorisinMesajlari = new()
        {
            "Hi", "Helo", "Wtdf", "sfafadf", "fdf", "dfafsfdafd" ,"Hi", "Helo", "Wtdf", "sfafadf", "fdf", "dfafsfdafd"

        };
        List<string> JohnMesajlari = new()
        {
            "Hey, how are you?","I'm good, thanks! How about you?","Just working on some projects. How about you?",
            "Did you watch the latest episode of that show?","Happy birthday! ", "Thank you so much!" ," I'm excited for the day" , 
            "I hope you have a fantastic celebration.\r\n", " Thanks, I'm planning to have a small gathering with friends.",
        "Have you ever been to France?\r\n", " Yes, I visited Paris last year.", " It was amazing!",
      " I've always wanted to see the Eiffel Tower.", "You should definitely plan a trip. It's worth it.\r\n"   };

        List<string> AngelMesajlari = new() {  "dsdsdsd",   "dassdadada0",    "123212121", "sdsadad" , "sdadsad" };
        List<string> LamiaMesajlari = new() { "Yes", "visited", "ast yea", "trip", "definitely" };
        List<string> GrelishMesajlari = new() { "Eiffel", "Tower", "definitely", "plan", "see" };
        List<string> SezarinMesajlari = new() { "celebration", "should", "last", "was", "small" };
        List<string> QabilinMesajlari = new() { ".....",  "Plaease be nice", "........", "Dont swear", "....." };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Content.ToString() == "Loris")
                {
                    Contact.Text = "Loris";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in LorisinMesajlari)
                    {
                        Add(item, ref count ); 
                    }
                }
                else if (btn.Content.ToString() == "Jonathan")
                {
                    Contact.Text = "Jonathan";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in JohnMesajlari)
                    {
                        Add(item, ref count);
                    }
                }
                else if (btn.Content.ToString() == "Angel")
                {
                    Contact.Text = "Angel";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in AngelMesajlari)
                    {
                        Add(item, ref count);
                    }
                }
                else if (btn.Content.ToString() == "Lamia")
                {
                    Contact.Text = "Lamia";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in LamiaMesajlari)
                    {
                        Add(item, ref count);
                    }
                }
                else if (btn.Content.ToString() == "Grelish")
                {
                    Contact.Text = "Grelish";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in GrelishMesajlari)
                    {
                        Add(item, ref count);
                    }
                }
                else if (btn.Content.ToString() == "Akuba")
                {
                    Contact.Text = "Akuba";
                    ChatStackPanel.Children.Clear();
                    
                }
                else if (btn.Content.ToString() == "Sezar")
                {
                    Contact.Text = "Sezar";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in SezarinMesajlari)
                    {
                        Add(item, ref count);
                    }
                }
                else if (btn.Content.ToString() == "Qabil Turkoglu )")
                {
                    Contact.Text = "Qabil Turkoglu )";
                    ChatStackPanel.Children.Clear();
                    int count = 0;
                    foreach (var item in QabilinMesajlari )
                    {
                        Add(item, ref count);
                    }
                }

            }
        }
        private void Add(string item, ref int  count)
        {
            TextBlock withL = new();
            withL.Text = item;
            withL.FontSize = 15;
            withL.Margin = new Thickness(5);
            withL.Foreground = Brushes.White;
            withL.MaxWidth = 180;
            withL.TextWrapping = TextWrapping.Wrap;
            //MessageBox.Show("sada");

            if (count % 2 == 0)
            {
                withL.HorizontalAlignment = HorizontalAlignment.Left;
                withL.Background = Brushes.Gray;
            }
            else
            {
                withL.HorizontalAlignment = HorizontalAlignment.Right;
                withL.Background = Brushes.DeepPink;
            }

            ChatStackPanel.Children.Add(withL);
            count++;
        }
        ///////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageTextBox.Text;
            AddMessageToChat("You", message);
            MessageTextBox.Clear();
            Date.Content = "Today";
        }

        private void AddMessageToChat(string sender, string message)
        {
            
            string formattedMessage = $"{sender}: {message}";
            TextBlock messageTextBlock = new TextBlock
            { MaxWidth = 200,
                TextWrapping = TextWrapping.Wrap,
                HorizontalAlignment = HorizontalAlignment.Right,
                Text = formattedMessage,
                Margin = new Thickness(0, 0, 0, 10),
                Background = Brushes.DeepPink,
                Foreground = Brushes.White
            };
            
            ChatStackPanel.Children.Add(messageTextBlock);
        }




        ////////////////////////////////////////////
        ///////////////////////////////////////////
    }
}
