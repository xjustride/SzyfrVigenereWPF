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

namespace SzyfrVigenereWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class SzyfrVigenere
        {
            private string alfabet = "abcdefghijklmnopqrstuvwxyz";

            public string Szyfruj(string input, string klucz)
            {
                return PrzetworzTekst(input, klucz, true);
            }

            public string Deszyfruj(string input, string klucz)
            {
                return PrzetworzTekst(input, klucz, false);
            }

            private string PrzetworzTekst(string tekst, string klucz, bool szyfruj)
            {
                StringBuilder wynik = new StringBuilder();
                klucz = klucz.ToLower();
                int kluczIndex = 0;

                foreach (char c in tekst.ToLower())
                {
                    if (alfabet.Contains(c))
                    {
                        int cIndex = alfabet.IndexOf(c);
                        int kIndex = alfabet.IndexOf(klucz[kluczIndex % klucz.Length]);
                        int index = szyfruj ? (cIndex + kIndex) % alfabet.Length : (cIndex - kIndex + alfabet.Length) % alfabet.Length;

                        wynik.Append(alfabet[index]);
                        kluczIndex++;
                    }
                    else
                    {
                        wynik.Append(c);
                    }
                }

                return wynik.ToString();
            }
        }

        private SzyfrVigenere szyfrVigenere = new SzyfrVigenere();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string klucz = "tajnyklucz"; // Tutaj zdefiniuj klucz lub pobierz go z interfejsu użytkownika
            string encrypted = szyfrVigenere.Szyfruj(input, klucz);
            outputTextBox.Text = encrypted;
        }

        private void decryptButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string klucz = "tajnyklucz"; // Użyj tego samego klucza, co do szyfrowania
            string decrypted = szyfrVigenere.Deszyfruj(input, klucz);
            outputTextBox.Text = decrypted;
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
