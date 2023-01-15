using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        public String _name;
        public String _studentid;
        public int _birthyear;
        public String _height;
        public double _grade;
        public String _major;

        public Student(String name, String studentid, int birthyear, String height, double grade, String major)
        {
            this._name = name;
            this._studentid = studentid;
            this._birthyear = birthyear;
            this._height = height;
            this._grade = grade;
            this._major = major;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Studentid
        {
            get { return _studentid; }
        }

        public int Birthyear
        {
            get { return _birthyear; }
        }

        public string Height
        {
            get { return _height; }
        }

        public double Grade
        {
            get { return _grade; }
        }

        public string Major
        {
            get { return _major; }
        }
    }
}
