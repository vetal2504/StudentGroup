﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Student
    {
        private int id;
        private string name;
        private DateTime date;
        public Student() { }

        public Student(int _id, string _name, DateTime _date)
        {

        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}