﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class_5
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public void SetDriver(Driver driver)
        {
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;
        }
    }
}
