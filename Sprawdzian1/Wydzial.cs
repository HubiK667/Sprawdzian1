using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian1
{
    using System;
    using System.Collections.Generic;

    class Wydzial
    {
        private List<Student> studenci = new List<Student>();

        public void DodajStudenta(Student student)
        {
            foreach (Student s in studenci)
            {
                if (s.Equals(student))
                {
                    Console.WriteLine($"Nie można dodać studenta {student.imie} {student.nazwisko}, ponieważ istnieje już student o takim samym loginie i haśle.");
                    return;
                }
            }

            studenci.Add(student);
            Console.WriteLine($"Dodano studenta {student.imie} {student.nazwisko}.");
        }

        public void ZmienHaslo(Student student, string stareHaslo, string noweHaslo)
        {
            if (!student.Equals(stareHaslo))
            {
                Console.WriteLine($"Nie udało się zmienić hasła dla studenta {student.imie} {student.nazwisko}, ponieważ podano nieprawidłowe stare hasło.");
                return;
            }
            else if (noweHaslo.Length < 6)
            {
                Console.WriteLine($"Nie udało się zmienić hasła dla studenta {student.imie} {student.nazwisko}, ponieważ nowe hasło jest za krótkie (minimum 6 znaków).");
                return;
            }
            else
            {
                student.ZmienHaslo(noweHaslo, stareHaslo);
                Console.WriteLine($"Zmieniono hasło dla studenta {student.imie}   {student.nazwisko}.");
            }
        }

        public void ZmienLogin(Student student, string staryLogin, string nowyLogin)
        {
            if (!student.Equals(staryLogin))
            {
                Console.WriteLine($"Nie udało się zmienić loginu dla studenta {student.imie}   {student.nazwisko}, ponieważ podano nieprawidłowy stary login.");
                return;
            }

            foreach (Student s in studenci)
            {
                if (s.Equals(student))
                {
                    Console.WriteLine($"Nie można zmienić loginu dla studenta {student.imie}{student.nazwisko}, ponieważ istnieje już student o takim samym loginie i haśle.");
                    return;
                }
            }

            student.ZmienLogin(nowyLogin, staryLogin);
            Console.WriteLine($"Zmieniono login dla studenta {student.imie}   {student.nazwisko}.");
        }

        public void WypiszStudentow()
        {
            Console.WriteLine("Studenci:");
            foreach (Student s in studenci)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }

}
