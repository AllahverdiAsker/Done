using System;
using System.Collections.Generic;
using System.Text;

namespace Done
{
    class Exam
    {

        private string _student;
        private double _point;
        private DateTime _startDate;
        private DateTime _endTime;
        public string Subject;

        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }
        public string Student
        {
            get => _student;
            set
            {
                bool check = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        check = false;

                    }
                }
                if (check && value.Length > 2)
                {
                    _student = value;
                }
            }


        }



        public Exam(DateTime startdate, DateTime enddate)
        {
            if (startdate < enddate)
            {
                _startDate = startdate;
                _endTime = enddate;
            }
        }


    }
}
