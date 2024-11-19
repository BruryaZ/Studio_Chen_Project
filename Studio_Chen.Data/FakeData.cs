using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data
{
    public class FakeData
    {
        public List<Course> LstCourses { get; set; }
        public List<Gymnast> LstGymnast { get; set; }
        public List<Lesson> LstLesson { get; set; }
        public List<Teacher> LstTeacher { get; set; }
        public List<int> List { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public FakeData()
        {
            LstCourses = new List<Course>() {
            new Course() { EndDate = new DateTime(), StartDate = new DateTime(),
                MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.ballet } ,
            new Course() { EndDate = new DateTime(), StartDate = new DateTime(),
                MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.pilates } };
            LstGymnast = new List<Gymnast>() {
            new Gymnast() { Address = "BB", Email = "@gmail", FirstName = "Shosh", LastName = "Telem", Phone = "03", Identity = "2" },
            new Gymnast() { Address = "Emanuhel", Email = "@gmail", FirstName = "Ester", LastName = "Zarniv", Phone = "09", Identity = "3"}};
            LstLesson = new List<Lesson>() {
                            new Lesson() { StartHour = new TimeOnly(), CourseIdentity = "1", Date = new DateTime(),
                            EndHour = new TimeOnly(),  MeetNumber = 1, GymnastList = LstGymnast ,
                            EquipmentList=new List<string>(){ "water", "gym shorts"},Teacher= new Teacher()
                            { courses = LstCourses, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName =
                            "Nechama", Identity = "3", Phone = "03" } } };
            LstTeacher = new List<Teacher>() { new Teacher() { courses = LstCourses, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName = "Nechama", Identity = "3", Phone = "03" },
                                                    new Teacher() { courses = LstCourses, LastName = "Lederman", Address = "Emanuhel", Email = "14@gmail", FirstName = "Galit", Identity = "4", Phone = "09" } };

        }
    }
}
