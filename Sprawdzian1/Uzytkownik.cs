using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian1
{
    public abstract class Uzytkownik
    {
        public string imie;
        public string nazwisko;
        public string login;
        public string haslo;

        //kostruktor
        public Uzytkownik(string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko= nazwisko;
            this.login = GenerujLogin();
            this.haslo = GenerujHaslo();
        }

        public string GenerujLogin()
        {
            string login = imie.ToLower()+nazwisko.ToLower();
            login = Szyfrowanie.ZaszyfrujCezar(login, 3); 
            return login;
        }

        public string GenerujHaslo()
        {
            string haslo = nazwisko.Substring(0, 3).ToLower()+new Random().Next(100000, 999999);
            haslo = Szyfrowanie.ZaszyfrujCezar(haslo, 3); 
            return haslo;
        }
        public string UkryjLogin()
        {
            return "Ukryty login: " + Szyfrowanie.ZaszyfrujCezar(login, 3); 
        }

        public string UkryjHaslo()
        {
            return "Ukryte hasło: " + Szyfrowanie.ZaszyfrujCezar(haslo, 3); 
        }

        public string PokazLogin()
        {
            return "Login: " + login;
        }

        public string PokazHaslo()
        {
            return "Hasło: " + haslo;
        }

        public abstract void ZmienLogin(string nowyLogin, string StaryLoginOdUzytkownika);
        public abstract void ZmienHaslo(string noweHaslo, string StareHasloOdUzytkownika);
   
    }
}

