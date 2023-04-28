using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian1
{
    using System;

    public class Student : Uzytkownik
    {
        public int rocznikStudiow { get; set; }

        public Student(string imie, string nazwisko, string login, string haslo, int rocznikStudiow) : base(imie, nazwisko)
        {
            this.rocznikStudiow = rocznikStudiow;
            this.login = Szyfrowanie.ZaszyfrujCezar(imie + "_" + nazwisko, 5);
            this.haslo = Szyfrowanie.ZaszyfrujCezar(nazwisko.Substring(0, 3) + GenerujLosoweHaslo(), 5);
        }

        public override string ToString()
        {
            string tekst = $"Imię: {this.imie}, Nazwisko: {this.nazwisko}, Login: {this.login}, Hasło: {this.haslo}";
            return tekst;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Student s = (Student)obj;
            return (this.login == s.login && this.haslo == s.haslo);
        }

        public override void ZmienLogin(string nowyLogin, string StaryLoginOdUzytkownika)
        {
            if (StaryLoginOdUzytkownika == this.login)
            {
                this.login = Szyfrowanie.ZaszyfrujCezar(nowyLogin, 5);
            }
        }

        public override void ZmienHaslo(string noweHaslo, string StareHasloOdUzytkownika)
        {
            if (StareHasloOdUzytkownika == this.haslo)
            {
                this.haslo = Szyfrowanie.ZaszyfrujCezar(noweHaslo, 5);
            }
        }

        private string GenerujLosoweHaslo()
        {
            Random rand = new Random();
            int losowaLiczba = rand.Next(100000, 999999);
            return losowaLiczba.ToString();
        }
    }

}
