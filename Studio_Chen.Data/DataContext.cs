using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Gymnast> Gymnast { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Studio_Chen_DB");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        #region ctor
        //public DataContext()
        //{
        //    LstCourses = new List<Lesson>() {
        //    new Lesson() { EndDate = new DateTime(), StartDate = new DateTime(),
        //        MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.ballet } ,
        //    new Lesson() { EndDate = new DateTime(), StartDate = new DateTime(),
        //        MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.pilates } };
        //    LstGymnast = new List<Lesson>() {
        //    new Lesson() { Address = "BB", Email = "@gmail", FirstName = "Shosh", LastName = "Telem", Phone = "03", Identity = "2" },
        //    new Lesson() { Address = "Emanuhel", Email = "@gmail", FirstName = "Ester", LastName = "Zarniv", Phone = "09", Identity = "3"}};
        //    LstLesson = new List<Lesson>() {
        //                    new Lesson() { StartHour = new TimeOnly(), CourseIdentity = "1", Date = new DateTime(),
        //                    EndHour = new TimeOnly(),  MeetNumber = 1, GymnastList = LstGymnast ,
        //                    EquipmentList=new List<string>(){ "water", "gym shorts"},Teacher= new Teacher()
        //                    { courses = LstCourses, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName =
        //                    "Nechama", Identity = "3", Phone = "03" } } };
        //    LstTeacher = new List<Teacher>() { new Teacher() { courses = LstCourses, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName = "Nechama", Identity = "3", Phone = "03" },
        //                                            new Teacher() { courses = LstCourses, LastName = "Lederman", Address = "Emanuhel", Email = "14@gmail", FirstName = "Galit", Identity = "4", Phone = "09" } };
        //}
        #endregion
    }
}