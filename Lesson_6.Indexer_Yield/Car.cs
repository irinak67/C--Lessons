﻿using System;


namespace Lesson_6.Indexer_Yield
{
    class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
