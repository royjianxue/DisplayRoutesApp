namespace DisplayRoutes
{
    public class BusRouteRepository 
    { 
        public static BusRoute[] InitializeRoutes ()
        {
            return new BusRoute[]
            {
                new BusRoute(40, new string[]
                {
                    "Morecambe", "Lancaster", "Garstang", "Preston"
                }),
                new BusRoute(42, new string[]
                {
                    "Lancaster", "Garstang", "Blackpool"
                }),
                new BusRoute(100, new string []
                {
                    "University", "Lancaster", "Morecambe"
                }),
                new BusRoute(555, new string []
                {
                    "Lancaster", "Carnforth", "Windermere", "Keswick"
                })
        };
    }

    }
}
