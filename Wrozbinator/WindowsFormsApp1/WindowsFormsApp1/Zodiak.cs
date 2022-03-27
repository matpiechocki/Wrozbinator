using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Zodiak
    {
        private int liczba = 0;
        public int Podajliczbe(int dzien1, int miesiac1)
        {
            liczba = (dzien1 % 10) + (miesiac1 % 10);
            if (liczba >= 1 && liczba <= 9)
            {
                return liczba;
            }
            else
            {
                return liczba % 10 + 1;
            }
        }
        public string Twojzodiak(int dzien1, int miesiac1)
        {
            
            if (miesiac1 == 1)
            {
                if(dzien1 >=1 && dzien1 <=19)
                {
                    return "KOZIOROŻEC"; 
                }
                else if (dzien1 >=20 && dzien1 <=31)
                {
                    return "WODNIK";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 2)
            {
                if (dzien1 >= 1 && dzien1 <= 18)
                {

                    return "WODNIK";
                }
                else if (dzien1 >= 19 && dzien1 <= 29)
                {
                    return "RYBY";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 3)
            {
                if (dzien1 >= 1 && dzien1 <= 20)
                {

                    return "RYBY";
                }
                else if (dzien1 >= 21 && dzien1 <= 30)
                {
                    return "BARAN";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 4)
            {
                if (dzien1 >= 1 && dzien1 <= 19)
                {

                    return "BARAN";
                }
                else if (dzien1 >= 20 && dzien1 <= 30)
                {
                    return "BYK";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 5)
            {
                if (dzien1 >= 1 && dzien1 <= 20)
                {

                    return "BYK";
                }
                else if (dzien1 >= 21 && dzien1 <= 31)
                {
                    return "BLIŹNIĘTA";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 6)
            {
                if (dzien1 >= 1 && dzien1 <= 20)
                {

                    return "BLIŹNIĘTA";
                }
                else if (dzien1 >= 21 && dzien1 <= 30)
                {
                    return "RAK";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 7)
            {
                if (dzien1 >= 1 && dzien1 <= 22)
                {

                    return "RAK";
                }
                else if (dzien1 >= 23 && dzien1 <= 31)
                {
                    return "LEW";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 8)
            {
                if (dzien1 >= 1 && dzien1 <= 22)
                {

                    return "LEW";
                }
                else if (dzien1 >= 23 && dzien1 <= 31)
                {
                    return "PANNA";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 9)
            {
                if (dzien1 >= 1 && dzien1 <= 22)
                {

                    return "PANNA";
                }
                else if (dzien1 >= 23 && dzien1 <= 30)
                {
                    return "WAGA";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 10)
            {
                if (dzien1 >= 1 && dzien1 <= 22)
                {

                    return "WAGA";
                }
                else if (dzien1 >= 23 && dzien1 <= 31)
                {
                    return "SKORPION";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 11)
            {
                if (dzien1 >= 1 && dzien1 <= 21)
                {
                    return "SKORPION";
                }
                else if (dzien1 >= 22 && dzien1 <= 30)
                {
                    return "STRZELEC";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            if (miesiac1 == 12)
            {
                if (dzien1 >= 1 && dzien1 <= 21)
                {
                    return "STRZELEC";
                }
                else if (dzien1 >= 22 && dzien1 <= 31)
                {
                    return "KOZIOROŻEC";
                }
                else
                {
                    return "Nieprawidłowe dane";
                }
            }
            else
            {
                return "Nieprawidłowe dane";
            }
        }
        public int Twojwiek(int dzien1, int miesiac1)
        {

            int wiek = 0;
            int wiek2 = 100;
            wiek = miesiac1*dzien1*miesiac1 / 2;
            if (wiek >= 60 && wiek < 100)
            {
                return wiek;
            }
            else
            {
                return wiek2;
            }
        }
        internal string Podajliczbe(float v)
        {
            throw new NotImplementedException();
        }
    }
}
