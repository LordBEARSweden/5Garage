using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                    yield return vehicle;
            }
        }

        internal bool Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal bool Remove(T vehicle)
        {
            //Add logic
            for (int i = 0; i < vehicles.Length; i--)
            {

            }
            return false;
        }
    }
}
