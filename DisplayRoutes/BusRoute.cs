﻿

using System;

namespace DisplayRoutes
{
    public class BusRoute
    {
        public int Number { get; set; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];
        public string[] PlacesServed { get; }
        public BusRoute(int number, string[] placesServed)
        {
            this.Number = number;
            this.PlacesServed = placesServed;
        }

        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, place => place == destination);
            //foreach (string place in PlacesServed)
            //{
            //    if (place == destination)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }


        public override string ToString() => $"{Number} : {Origin} -> {Destination}";


    }


}
