using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using ConsoleApp10;

namespace UnitTestProjectFr
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name()
        {
            Person a = new Person("Anna", "", 0);
            Assert.AreEqual(a.Name, "Anna");
        }
        [TestMethod]
        public void SurName()
        {
            Person a = new Person("", "Smirnova", 0);
            Assert.AreEqual(a.Surname, "Smirnova");
        }
        [TestMethod]
        public void Age()
        {
            Person a = new Person("", "Smirnova", (uint)10);
            Assert.AreEqual(a.Age, (uint)10);
        }
        [TestMethod]
        public void RandomPersonName()
        {
            Person a = new Person();
            a.Init();
            string[] mas = { "Nikolay", "Alexei", "Andrei", "Nikita", "Alexandr", "Daniil", "Denis", "Daria", "Maria", "Kristina", "Anna", "Yulia", "Eva", "Viktoria" };
            int pos = Array.IndexOf(mas, a.Name);
            pos++;
            Assert.IsNotNull(pos);
        }
        [TestMethod]
        public void RandomPersonSurname()
        {
            Person a = new Person();
            a.Init();
            string[] mas = { "Petrov", "Smirnov", "Ivanov", "Chernov", "Belov", "Krasnov", "Orlov", "Petrova", "Smirnova", "Ivanova", "Chernova", "Belova", "Krasnova", "Orlova" };
            int pos = Array.IndexOf(mas, a.Surname);
            pos++;
            Assert.IsNotNull(pos);
        }
        [TestMethod]
        public void RandomPersonAge()
        {
            Person a = new Person();
            a.Init();
            bool ok;
            ok = (a.Age < (uint)101);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void Equals()
        {
            Person a = new Person();
            Person b = new Person();
            bool ok = a.Equals(b);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void ComparePersonPol()
        {
            Person a = new Person(age: 30);
            Person b = new Person(age: 35);
            int ok = a.CompareTo(b);
            Assert.AreEqual(ok, -1);
        }
        [TestMethod]
        public void ComparePersonOtr()
        {
            Person a = new Person(age: 35);
            Person b = new Person(age: 30);
            int ok = a.CompareTo(b);
            Assert.AreEqual(ok, 1);
        }
        [TestMethod]
        public void ComparePersonNull()
        {
            Person a = new Person(age: 35);
            Person b = new Person(age: 35);
            int ok = a.CompareTo(b);
            Assert.AreEqual(ok, 0);
        }
        [TestMethod]
        public void TeacherKol()
        {
            Teacher a = new Teacher(kolStud: 100);
            Assert.AreEqual(a.KolStud, (uint)100);
        }
        [TestMethod]
        public void TeacherDisNul()
        {
            Teacher a = new Teacher(discipline: "      ");
            Assert.AreEqual(a.Discipline, "Не указано");
        }
        [TestMethod]
        public void TeacherDis()
        {
            Teacher a = new Teacher(discipline: "maths", kolStud: 100);
            Assert.AreEqual(a.Discipline, "maths");
        }
        [TestMethod]
        public void TeacherRand()
        {
            string[] mas = { "maths", "programming", "history", "biology", "geography", "physics", "chemistry" };
            Teacher a = new Teacher();
            a.Init();
            int pos = Array.IndexOf(mas, a.Discipline);
            pos++;
            Assert.IsNotNull(pos);
        }
        [TestMethod]
        public void TeacherEquals()
        {
            Teacher a = new Teacher();
            Teacher b = new Teacher();
            bool ok = a.Equals(b);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void StudentCourse()
        {
            Student a = new Student(course: 3);
            Assert.AreEqual(a.Course, (uint)3);
        }
        [TestMethod]
        public void StudentCourseMany()
        {
            Student a = new Student(course: 100);
            Assert.AreEqual(a.Course, (uint)4);
        }
        [TestMethod]
        public void StudentMark()
        {
            Student a = new Student(course: 3, avmark: 7);
            Assert.AreEqual(a.AvMark, (double)7);
        }
        [TestMethod]
        public void StudentRand()
        {
            Student a = new Student();
            a.Init();
            bool ok = (a.Course < 7);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void StudentEquals()
        {
            Student a = new Student();
            Student b = new Student();
            bool ok = a.Equals(b);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void EmployeeCourse()
        {
            Employee a = new Employee(salary: 30000);
            Assert.AreEqual(a.Salary, (uint)30000);
        }
        [TestMethod]
        public void EmployeeCourseMany()
        {
            Employee a = new Employee(years: 5);
            Assert.AreEqual(a.Years, (uint)5);
        }
        [TestMethod]
        public void EmployeeRand()
        {
            Employee a = new Employee();
            a.Init();
            bool ok = (a.Salary < 100001);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void EmployeeEquals()
        {
            Employee a = new Employee();
            Employee b = new Employee();
            bool ok = a.Equals(b);
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void AnimalNameNoConstr()
        {
            Animal a = new Animal();
            Assert.AreEqual(a.Name, "lion");
        }
        [TestMethod]
        public void AnimalRand()
        {
            Animal a = new Animal();
            a.Init();
            string[] mas = { "lion", "fish", "rabbit", "unicorn", "dog", "squirrel", "bear", "whale" };
            int pos = Array.IndexOf(mas, a.Name);
            pos++;
            Assert.IsNotNull(pos);
        }
        [TestMethod]
        public void AnimalClone()
        {
            Animal a = new Animal();
            Animal b = (Animal)a.Clone();
            b.number.number++;
            Assert.AreNotEqual(a.number.number, b.number.number);
        }
        [TestMethod]
        public void AnimalCopy()
        {
            Animal a = new Animal();
            Animal b = (Animal)a.Copy();
            b.number.number++;
            Assert.AreEqual(a.number.number, b.number.number);
        }
        [TestMethod]
        public void PrSortSurname()
        {
            Person a = new Person("abs", "abcde", 10);
            Person b = new Person("abs", "zyx", 21);
            Person.count = 2;
            Person[] mas = { b, a };
            Program.SortSurname(ref mas);
            Assert.AreEqual(mas[0], a);
        }
        [TestMethod]
        public void PrSortAge()
        {
            Person a = new Person("abs", "abcde", 10);
            Person b = new Person("abs", "zyx", 21);
            Person.count = 2;
            Person[] mas = { b, a };
            Program.SortAge(ref mas);
            Assert.AreEqual(mas[0], a);
        }
    }
}
