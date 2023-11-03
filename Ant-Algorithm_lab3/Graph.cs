using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant_Algorithm_lab3
{

    class Graph
    {

        private Random rnd = new Random();

        public int maxCities { get; set; } = 0;
        public int maxDistance { get; set; }

        public City[] cities { get; set; }
        public double[][] distance { get; set; }

        public Graph(int maxCities, int maxDistance)
        {
            this.maxCities = maxCities;
            cities = new City[this.maxCities];
            for (int i = 0; i < maxCities; i++)
                cities[i] = new City();

            distance = new double[this.maxCities][];
            for (int i = 0; i < this.maxCities; i++)
            {
                distance[i] = new double[this.maxCities];
            }
            this.maxDistance = maxDistance;

        }

        public void initGraph()
        {
            int from;


            for (from = 0; from < maxCities; from++)
            {
                cities[from].x = rnd.Next(maxDistance);
                cities[from].y = rnd.Next(maxDistance);
            }


        }

        public void calcDistance()
        {
            int from, to;
            double d;
            for (from = 0; from < maxCities; from++)
            {
                for (to = 0; to < maxCities; to++)
                {
                    distance[from][to] = 0.0;
                    if (from != to && distance[from][to] == 0.0)
                    {
                        d = cities[from].distance(cities[to]);

                        distance[from][to] = d;
                        distance[to][from] = d;
                    }
                }
            }
        }

        public double calcPath(int[] path)
        {
            double way = 0.0;
            int i;
            for (i = 0; i < maxCities - 1; i++)
            {
                way += distance[path[i]][path[i + 1]];
            }
            way += distance[path[i]][path[0]];
            return way;
        }

    }
}
