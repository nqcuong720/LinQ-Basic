﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Join
{
    public class Program
    {
        public static void Join()
        {
            // List 1: .
            IList<string> listOne = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
            };
            IList<string> listTwo = new List<string>()
            {
                "One",
                "Two",
                "Three",
            };

            var innerJoin = listOne.Join(
                listTwo,
                str1 => str1,
                str2 => str2,
                (str1, str2) => str1);
            foreach (var s in innerJoin)
            {
                Console.WriteLine(s);
            }
        }

        public static void Join2()
        {
            IList<Student> listStudent = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "Nguyễn Quốc Cường", Age = 21, StandardId = 1 },
                new Student() { StudentId = 2, StudentName = "Nguyễn Quốc Khánh", Age = 16, StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Nguyễn Văn Hùng", Age = 49, StandardId = 2 },
                new Student { StudentId = 4, StudentName = "Nguyễn Thị Thúy Nga", Age = 24, StandardId = 3 },
                new Student { StudentId = 5, StudentName = "Nguyễn Thị Ánh Tuyết", Age = 48, StandardId = 2 },
                new Student { StudentId = 6, StudentName = "Trần Hoài Đức", Age = 21, StandardId = 1 },
                new Student { StudentId = 7, StudentName = "Dương Thái Nhật", Age = 21, StandardId = 3 },
                new Student { StudentId = 8, StudentName = "Nguyễn Thị Kim Anh", Age = 21, StandardId = 2 },
                new Student { StudentId = 9, StudentName = "Võ Lê Ngọc Diệp", Age = 21, StandardId = 3 },
            };

            IList<Standard> listStandard = new List<Standard>()
            {
                new Standard() { StandardId = 1, StandardName = "Standard 1" },
                new Standard() { StandardId = 2, StandardName = "Standard 2" },
                new Standard() { StandardId = 3, StandardName = "Standard 3" },
            };

            var innerJoin = listStudent.Join(
                listStandard,
                student => student.StandardId,
                standard => standard.StandardId,
                (student, standard) => new
                {
                    StudentName = student.StudentName,
                    StandardName = standard.StandardName,
                });
            foreach (var obj in innerJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
        }

        public static void Main(string[] args)
        {
            Join();
            Join2();
        }
    }
}
