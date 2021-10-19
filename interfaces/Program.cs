using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp10
{
    public class Program
    {
        public static void SortSurname(ref Person[] mas)
        {
            if (Person.count == 0)
            {
                Console.WriteLine("\nНи один элемент еще не создан!\n");
                return;
            }
            Person[] sort = new Person[Person.count];
            for (int i = 0; i < Person.count; i++)
            {
                sort[i] = mas[i];
            }
            Array.Sort(sort, new SortBySurname());
            for (int i = 0; i < Person.count; i++)
            {
                mas[i] = sort[i];
            }
            for (int i = 0; i < Person.count; i++)
            {
                mas[i].Write();
            }
            return;
        }
        public static void SortAge(ref Person[] mas)
        {
            if (Person.count == 0)
            {
                Console.WriteLine("\nНи один элемент еще не создан!\n");
                return;
            }
            Person[] sort = new Person[Person.count];
            for (int i = 0; i < Person.count; i++)
            {
                sort[i] = mas[i];
            }
            Array.Sort(sort);
            for (int i = 0; i < Person.count; i++)
            {
                mas[i] = sort[i];
            }
            for (int i = 0; i < Person.count; i++)
            {
                mas[i].Write();
            }
            return;
        }
        public static void RandomSozdanie(ref Person[] mas)
        {
            int men = 0;
            Console.WriteLine("\n1. Создать преподавателя");
            Console.WriteLine("2. Создать студента");
            Console.WriteLine("3. Создать сотрудника");
            Console.WriteLine("4. Создать просто человека");
            ProvMenu(ref men, 0, 5);
            switch (men)
            {
                case 1:
                    Teacher t = new Teacher();
                    Person.count--;
                    Teacher ter = (Teacher)t.Init();
                    mas[Person.count - 1] = ter;
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    break;
                case 2:
                    Student s = new Student();
                    Person.count--;
                    Student ser = (Student)s.Init();
                    mas[Person.count - 1] = ser;
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    break;
                case 3:
                    Employee e = new Employee();
                    Person.count--;
                    Employee eer = (Employee)e.Init();
                    mas[Person.count - 1] = eer;
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    break;
                case 4:
                    Person p = new Person();
                    Person.count--;
                    Person per = (Person)p.Init();
                    mas[Person.count - 1] = per;
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    break;
            }
        }
        static public void AvSalary(params Person[] mas)
        {
            uint summ = 0;
            int count = 0;
            foreach (Person x in mas)
            {
                if (x is Employee)
                {
                    Employee e = x as Employee;
                    summ += e.Salary;
                    count++;
                }
            }
            Console.WriteLine($"\nСредняя зарплата равна {summ / count}\n");
        }
        static public void PoiskStud(params Person[] mas)
        {
            int count = 0;
            foreach (Person x in mas)
            {
                if (x is Student)
                {
                    Student a = x as Student;
                    if (a != null && a.AvMark > 7)
                    {
                        count++;
                        x.Write();
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"\nНайдено {count} таких человека\n");
            }
            else Console.WriteLine("\nТаких студентов нет!\n");
        }
        static public void Poisk(int poisk, int pol, params Person[] mas)
        {
            string[] imena = new string[20];
            int count = 0;
            if (pol == 1)
            {
                if (poisk == 1)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Teacher && (x.Name == "Alexei" || x.Name == "Nikolai" || x.Name == "Alexander" || x.Name == "Andrei" || x.Name == "Daniil" || x.Name == "Denis" || x.Name == "Nikita"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 2)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Student && (x.Name == "Alexei" || x.Name == "Nikolai" || x.Name == "Alexander" || x.Name == "Andrei" || x.Name == "Daniil" || x.Name == "Denis" || x.Name == "Nikita"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 3)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Employee && (x.Name == "Alexei" || x.Name == "Nikolai" || x.Name == "Alexander" || x.Name == "Andrei" || x.Name == "Daniil" || x.Name == "Denis" || x.Name == "Nikita"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 4)
                {
                    for (int i = 0; i < Person.count; i++)
                    {
                        if (mas[i].Name == "Alexei" || mas[i].Name == "Nikolai" || mas[i].Name == "Alexander" || mas[i].Name == "Andrei" || mas[i].Name == "Daniil" || mas[i].Name == "Denis" || mas[i].Name == "Nikita")
                        {
                            mas[i].Write();
                            imena[count] = mas[i].Name;
                            count++;
                        }
                    }
                }
            }
            else
            {
                if (poisk == 1)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Teacher && (x.Name == "Kristina" || x.Name == "Maria" || x.Name == "Daria" || x.Name == "Anna" || x.Name == "Yulia" || x.Name == "Eva" || x.Name == "Viktoria"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 2)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Student && (x.Name == "Kristina" || x.Name == "Maria" || x.Name == "Daria" || x.Name == "Anna" || x.Name == "Yulia" || x.Name == "Eva" || x.Name == "Viktoria"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 3)
                {
                    foreach (Person x in mas)
                    {
                        if (x is Employee && (x.Name == "Kristina" || x.Name == "Maria" || x.Name == "Daria" || x.Name == "Anna" || x.Name == "Yulia" || x.Name == "Eva" || x.Name == "Viktoria"))
                        {
                            x.Write();
                            imena[count] = x.Name;
                            count++;
                        }
                    }
                }
                if (poisk == 4)
                {
                    for (int i = 0; i < Person.count; i++)
                    {
                        if (mas[i].Name == "Kristina" || mas[i].Name == "Maria" || mas[i].Name == "Daria" || mas[i].Name == "Anna" || mas[i].Name == "Yulia" || mas[i].Name == "Eva" || mas[i].Name == "Viktoria")
                        {
                            mas[i].Write();
                            imena[count] = mas[i].Name;
                            count++;
                        }
                    }
                }
            }
            if (count == 0) Console.WriteLine("\nТаких людей не найдено!");
            else
            {
                Console.WriteLine($"\nВсего найдено {count} таких человека\n");
                Console.Write("Найденные имена: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write(imena[i] + ", ");
                }
            }
            Console.WriteLine();
        }
        static public void ProvDouble(out double a)
        {
            double n;
            bool ok;
            a = 0;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out n);
                if (ok && n != 0) a = n;
                else Console.WriteLine("Введите, пожалуйста, положительное число!");
            } while (!ok || n == 0);
        }
        static public void ProvUint(out uint a)
        {
            uint n;
            bool ok;
            a = 0;
            do
            {
                string buf = Console.ReadLine();
                ok = uint.TryParse(buf, out n);
                if (ok && n != 0) a = n;
                else Console.WriteLine("Введите, пожалуйста, натуральное число!");
            } while (!ok || n == 0);
        }
        public static void Sozdanie(ref Person[] mas)
        {
            int men = 0;
            Console.WriteLine("\n1. Создать преподавателя");
            Console.WriteLine("2. Создать студента");
            Console.WriteLine("3. Создать сотрудника");
            Console.WriteLine("4. Создать просто человека");
            ProvMenu(ref men, 0, 5);
            switch (men)
            {
                case 1:
                    Console.WriteLine("\nЕго имя: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Его фамилия: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Его возраст: ");
                    ProvUint(out uint age);
                    Console.WriteLine("Его преподаваемый предмет: ");
                    string discipline = Console.ReadLine();
                    Console.WriteLine("Количество его студентов: ");
                    ProvUint(out uint stud);
                    Teacher t = new Teacher(name: name, surname: surname, age: age, discipline: discipline, kolStud: stud);
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    mas[Person.count - 1] = t;
                    break;
                case 2:
                    Console.WriteLine("\nЕго имя: ");
                    string namest = Console.ReadLine();
                    Console.WriteLine("Его фамилия: ");
                    string surnamest = Console.ReadLine();
                    Console.WriteLine("Его возраст: ");
                    ProvUint(out uint agest);
                    Console.WriteLine("Его курс: ");
                    ProvUint(out uint course);
                    Console.WriteLine("Его средняя оценка: ");
                    ProvDouble(out double mark);
                    Student s = new Student(name: namest, surname: surnamest, age: agest, course: course, avmark: mark);
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    mas[Person.count - 1] = s;
                    break;
                case 3:
                    Console.WriteLine("\nЕго имя: ");
                    string namesot = Console.ReadLine();
                    Console.WriteLine("Его фамилия: ");
                    string surnamesot = Console.ReadLine();
                    Console.WriteLine("Его возраст: ");
                    ProvUint(out uint agesot);
                    Console.WriteLine("Его зарплата: ");
                    ProvUint(out uint salary);
                    Console.WriteLine("Сколько лет он работает?");
                    ProvUint(out uint years);
                    Employee e = new Employee(name: namesot, surname: surnamesot, age: agesot, salary: salary, years: years);
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    mas[Person.count - 1] = e;
                    break;
                case 4:
                    Console.WriteLine("\nЕго имя: ");
                    string nameper = Console.ReadLine();
                    Console.WriteLine("Его фамилия: ");
                    string surnameper = Console.ReadLine();
                    Console.WriteLine("Его возраст: ");
                    ProvUint(out uint ageper);
                    Person p = new Person(name: nameper, surname: surnameper, age: ageper);
                    Console.WriteLine($"\nЧеловек №{Person.count} создан\n");
                    mas[Person.count - 1] = p;
                    break;
            }
        }
        public static void ProvMenu(ref int switchcase, int niz, int verh)
        {
            int n;
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok && n > niz && n < verh) switchcase = n;
                else Console.WriteLine("Выберите, пожалуйста, один из пунктов меню!");
            } while (!ok || n < (niz + 1) || n > (verh - 1));
        }
        public static void Menu1(ref Person[] mas)
        {
            int switchcase = 0;
            do
            {
                Console.WriteLine("1. Создать элемент");
                Console.WriteLine("2. Вывести все объекты");
                Console.WriteLine("3. Поиск персон мужского или женского пола");
                Console.WriteLine("4. Поиск студентов с оценкой выше 7");
                Console.WriteLine("5. Средняя зарплата сотрудников");
                Console.WriteLine("6. Создать и напечатать массив элементов INit");
                Console.WriteLine("7. Отсортировать созданные элементы по возрасту и найти человека с указанными параметрами");
                Console.WriteLine("8. Отсортировать созданные элементы по фамилии и найти человека с указанными параметрами");
                Console.WriteLine("9. Создать элемент типа Animal и его клон");
                Console.WriteLine("10. Создать элемент типа Animal и его копию");
                Console.WriteLine("11. Завершение работы");
                ProvMenu(ref switchcase, 0, 12);
                switch (switchcase)
                {
                    case 1:
                        int Case1 = 0;
                        Console.WriteLine("1. Создать вручную");
                        Console.WriteLine("2. Создать автоматически");
                        ProvMenu(ref Case1, 0, 3);
                        if (Case1 == 1) Sozdanie(ref mas);
                        else RandomSozdanie(ref mas);
                        break;
                    case 2:
                        if (Person.count == 0)
                        {
                            Console.WriteLine("Ни один элемент еще не создан!\n");
                            break;
                        }
                        int count = 0;
                        Console.WriteLine("\nС использованием виртуальных методов:");
                        foreach (Person x in mas)
                        {
                            if (count < Person.count)
                            {
                                Console.Write($"\nЧеловек №{count + 1}");
                                x.Write();
                            }
                            count++;
                        }
                        count = 0;
                        Console.WriteLine("\nБез использования виртуальных методов:");
                        foreach (Person x in mas)
                        {
                            if (count < Person.count)
                            {
                                Console.Write($"\nЧеловек №{count + 1}");
                                x.Show();
                            }
                            count++;
                        }
                        break;
                    case 3:
                        if (Person.count == 0)
                        {
                            Console.WriteLine("Ни один элемент еще не создан!\n");
                            break;
                        }
                        int switchCase3 = 0;
                        int Pol = 0;
                        Console.WriteLine("\n1. Искать среди преподавателей");
                        Console.WriteLine("2. Искать среди студентов");
                        Console.WriteLine("3. Искать среди сотруников");
                        Console.WriteLine("4. Искать среди всех людей");
                        ProvMenu(ref switchCase3, 0, 5);
                        Console.WriteLine("\n1. Искать имена мужчин");
                        Console.WriteLine("2. Искать имена женщин");
                        ProvMenu(ref Pol, 0, 3);
                        Poisk(switchCase3, Pol, mas);
                        Console.WriteLine();
                        break;
                    case 4:
                        if (Student.kolichestvo == 0)
                        {
                            Console.WriteLine("Ни один студент еще не создан!\n");
                            break;
                        }
                        PoiskStud(mas);
                        break;
                    case 5:
                        if (Employee.kolichestvo == 0)
                        {
                            Console.WriteLine("Ни один сотрудник еще не создан!\n");
                            break;
                        }
                        AvSalary(mas);
                        break;
                    case 6:
                        int Case6 = 0;
                        Console.WriteLine("Введите, пожалуйста, количество элементов в массиве: ");
                        ProvUint(out uint n);
                        INit[] massiv = new INit[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("\n1. Создать преподавателя");
                            Console.WriteLine("2. Создать студента");
                            Console.WriteLine("3. Создать сотрудника");
                            Console.WriteLine("4. Создать просто человека");
                            Console.WriteLine("5. Создать животное (не входит в иерархию классов)");
                            ProvMenu(ref Case6, 0, 6);
                            switch (Case6)
                            {
                                case 1:
                                    Teacher t = new Teacher();
                                    t = (Teacher)t.Init();
                                    Person.count -= 2;
                                    massiv[i] = t;
                                    break;
                                case 2:
                                    Student s = new Student();
                                    s = (Student)s.Init();
                                    Person.count -= 2;
                                    massiv[i] = s;
                                    break;
                                case 3:
                                    Employee e = new Employee();
                                    e = (Employee)e.Init();
                                    Person.count -= 2;
                                    massiv[i] = e;
                                    break;
                                case 4:
                                    Person p = new Person();
                                    p = (Person)p.Init();
                                    Person.count -= 2;
                                    massiv[i] = p;
                                    break;
                                case 5:
                                    Animal an = new Animal();
                                    Number.count--;
                                    an = (Animal)an.Init();
                                    massiv[i] = an;
                                    break;
                            }
                            Console.WriteLine("Элемент создан.");
                        }
                        for (int i = 0; i < n; i++)
                        {
                            massiv[i].Write();
                        }
                        break;
                    case 7:
                        SortAge(ref mas);
                        if (Person.count == 0)
                        {
                            break;
                        }
                        Console.WriteLine("Введите возраст человека, которого надо найти: ");
                        ProvUint(out uint age7);
                        Person[] sortmas = new Person[Person.count];
                        for (int i = 0; i < Person.count; i++)
                        {
                            sortmas[i] = mas[i];
                        }
                        int pos7 = Array.BinarySearch(sortmas, new Person(age: age7));
                        Person.count--;
                        if (pos7 < 0) Console.WriteLine("\nВ массиве нет такого элемента!\n");
                        else Console.WriteLine($"\nВ отсортированном массиве элемент находится на позиции {pos7 + 1}\n");
                        break;
                    case 8:
                        SortSurname(ref mas);
                        if (Person.count == 0)
                        {
                            break;
                        }
                        Console.WriteLine("Введите фамилию человека, которого надо найти: ");
                        string surname8 = Console.ReadLine();
                        Person[] sort = new Person[Person.count];
                        for (int i = 0; i < Person.count; i++)
                        {
                            sort[i] = mas[i];
                        }
                        int pos = Array.BinarySearch(sort, new Person(surname: surname8), new SortBySurname());
                        Person.count--;
                        if (pos < 0) Console.WriteLine("\nВ массиве нет такого элемента!\n");
                        else Console.WriteLine($"\nВ отсортированном массиве элемент находится на позиции {pos + 1}\n");
                        break;
                    case 9:
                        Console.WriteLine("\nПоле 'номер' являтеся элементом другого класса! ");
                        Animal anim = new Animal();
                        Number.count--;
                        anim = (Animal)anim.Init();
                        int Case9 = 0;
                        Console.WriteLine("\n1. Создать вручную");
                        Console.WriteLine("2. Создать автоматически");
                        ProvMenu(ref Case9, 0, 3);
                        switch (Case9)
                        {
                            case 1:
                                Console.WriteLine("\nВведите вид животного: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Введите цвет животного: ");
                                string colour = Console.ReadLine();
                                Console.WriteLine("Введите возраст животного: ");
                                ProvUint(out uint age);
                                anim.Name = name;
                                anim.Colour = colour;
                                anim.Age = age;
                                break;
                            case 2:
                                break;
                        }
                        Animal clone = (Animal)anim.Clone();
                        Console.WriteLine("\nСам элемент: ");
                        anim.Write();
                        Console.WriteLine("Его клон: ");
                        clone.Write();
                        Console.WriteLine("\nА теперь изменим номер клонированного животного и посмотрим что получится");
                        clone.number.number++;
                        Console.WriteLine("\nСам элемент: ");
                        anim.Write();
                        Console.WriteLine("Его клон: ");
                        clone.Write();
                        break;
                    case 10:
                        Console.WriteLine("\nПоле 'номер' являтеся элементом другого класса! ");
                        Animal animal = new Animal();
                        Number.count--;
                        animal = (Animal)animal.Init();
                        int Case10 = 0;
                        Console.WriteLine("\n1. Создать вручную");
                        Console.WriteLine("2. Создать автоматически");
                        ProvMenu(ref Case10, 0, 3);
                        switch (Case10)
                        {
                            case 1:
                                Console.WriteLine("\nВведите вид животного: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Введите цвет животного: ");
                                string colour = Console.ReadLine();
                                Console.WriteLine("Введите возраст животного: ");
                                ProvUint(out uint age);
                                animal.Name = name;
                                animal.Colour = colour;
                                animal.Age = age;
                                break;
                            case 2:
                                break;
                        }
                        Animal copy = animal.Copy();
                        Console.WriteLine("\nСам элемент: ");
                        animal.Write();
                        Console.WriteLine("Его клон: ");
                        copy.Write();
                        Console.WriteLine("\nА теперь изменим номер копированного животного и посмотрим что получится");
                        copy.number.number++;
                        Console.WriteLine("\nСам элемент: ");
                        animal.Write();
                        Console.WriteLine("Его копия: ");
                        copy.Write();
                        break;
                    case 11:
                        Console.WriteLine("\nСпасибо за использование!");
                        break;
                }
            } while (switchcase != 11);
        }
        static void Main(string[] args)
        {
            Person[] mas = new Person[20];
            Menu1(ref mas);
        }
    }
}
