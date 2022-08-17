﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.Indexer_Yield
{
    class Parking : IEnumerable
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this[string nuber]
        {
            get
            {
                var car = _cars.FirstOrDefault(c => c.Number == nuber);
                return car;
            }
            
        }

        public Car this[int position]
        {
            get 
            {
                if (position < _cars.Count)
                    return _cars[position];
                else
                    return null;
            }

            set
            {
                if (position < _cars.Count)
                    _cars[position] = value; 

            }

        }
        public int Count => _cars.Count;
        public string Name { get; set; }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }

            return -1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or empty");
            }

            var car = _cars.FirstOrDefault(c => c.Number == number);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }

        public IEnumerator GetEnumerator()
        {
            //var current = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    current += i;
            //    yield return current;
            //}

            foreach (var car in _cars)
            {
                yield return car;
            }
        }

        public IEnumerable GetNames()
        {
            foreach (var car in _cars)
            {
                yield return car.Name;
            }
        }

        //public IEnumerator<Car> GetEnumerator()
        //{
        //    return _cars.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return _cars.GetEnumerator(); 
        //}
    }

    public class ParkingEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
