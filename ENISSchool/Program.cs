using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ENISSchool
{
    class Program
    {

        static void Main(string[] args)
        {
            String name, surname, classEtd;
            Console.WriteLine("The student name");
            name = Console.ReadLine();
            Console.WriteLine("The Student surname");
            surname = Console.ReadLine();
            Console.WriteLine("The student class");
            classEtd = Console.ReadLine();

            string speciality;
            int classNumber;
            Console.WriteLine("The speciality");
            speciality = Console.ReadLine();
            Console.WriteLine("The classNumber");
            classNumber = Convert.ToInt32(Console.ReadLine());
            var grd = new Grade()
            {
                Speciallity = speciality,
                classNumber = classNumber,
            };

            var grade1 = new Grade()
            {
                Id = 30
            };

            var gradeList = new List<Grade>
            {
            new Grade()
            {
                classNumber =8 ,
                Speciallity = "info"
            },

            new Grade()
            {
                classNumber = 7,
                Speciallity = "Technique"
            }

        };
            var grd1 = new Grade()
            {
                Speciallity = "telecom",
                classNumber = 45,
            };
            var studentList = new List<Student>()
               {
                new Student()
                {
                    Name ="MohamedDali" , SurName="ben salah" ,Grade=grd1
                },
                  new Student()
                {
                    Name ="MohamedAli" , SurName="salah"
                },

               };

            using (var context = new ENISContext())
            {



               var std = new Student()
                {
                    Name = name,
                    SurName = surname,
                    Class = classEtd,
                    Grade = grd
                };
                context.Students.Add(std);
                context.Remove<Grade>(grade1);
                context.SaveChanges();

                /*context.Add<CourseStudent>

                var SearchedStudent = context CourseStudent(){
                    StudentsId = StudentID;
                    CourseId = CourseID;
                }*/ 
                //houni bch n'affictiw kol etudiant il cours mte3ou chnou w houwa ya3ref il studentCourses ama a7na bch nzidouha fil context zeda 

               /* var studentsWidthSameName = context.Students.Where(s => s.Name == GetName()).ToList();
                if (studentsWidthSameName.Count != 0)
                {
                    foreach (var elt in studentsWidthSameName)
                        Console.WriteLine($"{elt.Name},{elt.SurName},{elt.Class}");
                }
                else Console.WriteLine("Not Found");*/


                /*Console.WriteLine("The name of the student that you want to modify ");
                string modif = Console.ReadLine();
                var studentsModif = context.Students.Where(s => s.Name == modif).ToList();
                if (studentsModif.Count != 0)
                {
                    var stdMod = studentsModif.First();
                    Console.WriteLine("The new Surname");
                    string newSurname = Console.ReadLine();
                    stdMod.SurName = newSurname;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("NOT FOUND");
                }*/
                /* Console.WriteLine("The name of the student that you want to delete ");
                 string rmv = Console.ReadLine();
                 var studentsRemv = context.Students.Where(s => s.Name == rmv).ToList();
                 if (studentsRemv.Count != 0)
                 {
                     var stdRemv = studentsRemv.First();
                     context.Students.Remove(stdRemv);
                     context.SaveChanges();
                 }
                 else
                 {
                     Console.WriteLine("NOT FOUND");
                 }
                 context.Add<Grade>(grd);
                 context.SaveChanges();*/
            }





        }

        public static string GetName()
        {
            string searchedName;
            Console.WriteLine("The Name of the searched student ");
            searchedName = Console.ReadLine();
            return searchedName;
        }

    }
}

