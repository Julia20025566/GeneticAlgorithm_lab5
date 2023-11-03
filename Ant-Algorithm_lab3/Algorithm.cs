using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant_Algorithm_lab3
{
    class Algorithm
    {
        private Random rnd = new Random();
        private Logger log;

        //популяция (набор хромосом)
        public int[][] population { get; set; }

        //количество генов в хромосоме
        public int maxGenes { get; set; }

        //количество особей в популяции
        public int maxIndividual { get; set; }

        //максимальное количество поколений
        public int maxGeneration { get; set; }

        //номер текущего поколения
        public int countGeneration { get; set; } = 0;

        //здоровье особей
        public double[] health { get; set; }

        //расстановка городов
        public Graph map { get; }

        //вероятность скрещивания
        public double chanceCrossing { get; set; }

        //вероятность мутации
        public double chanceMutation { get; set; }

        //родительский пул
        public List<int> parentPool { get; set; } = new List<int>();

        //рулетка
        public double[] roulette { get; set; }

        //-----------------------------------------------------//
        public Algorithm(int maxGenes, int maxIndividual, int maxGeneration, Graph map, double chanceCrossing, double chanceMutation, Logger log)
        {
            this.maxGenes = maxGenes;
            this.maxIndividual = maxIndividual;
            this.maxGeneration = maxGeneration;
            this.map = map;

            population = new int[maxIndividual][];
            for (int i = 0; i < maxIndividual; i++)
            {
                population[i] = new int[maxGenes];
            }

            health = new double[maxIndividual];
            roulette = new double[maxIndividual];

            this.chanceCrossing = chanceCrossing;
            this.chanceMutation = chanceMutation;
            this.log = log;
        }

        //начальная инициализация популяции
        public void InitPopulation()
        {
            for (int i = 0; i < maxIndividual; i++)
            {
                for (int j = 0; j < maxGenes; j++)
                {
                    population[i][j] = j;

                }
            }

            for (int i = 1; i < maxIndividual; i++)
            {
                for (int j = 0; j < maxGenes; j++)
                {
                    population[i] = Mutation(population[i]);
                }
            }
        }

        //оценка приспособленности
        public void CalcFitness()
        {
            for (int i = 0; i < maxIndividual; i++)
            {
                health[i] = 1 / map.calcPath(population[i]);
            }
        }


        //селекция
        public void Breeding()
        {
            double chance;
            double sum = 0;
            for (int i = 0; i < maxIndividual; i++)
            {
                sum += health[i];
            }
            for (int i = 0; i < maxIndividual; i++)
            {
                roulette[i] = health[i] / sum * 100.0;
            }
            for (int i = 1; i < maxIndividual; i++)
            {
                roulette[i] += roulette[i - 1];
            }
            for (int i = 0; i < 2; i++)
            {
                chance = rnd.NextDouble() * 100;
                int j;
                for (j = 0; j < maxIndividual && roulette[j] < chance; j++) ;
                parentPool.Add(j);
            }
        }

        //скрещивание
        public int[] Crossnig(int x, int y)
        {
            int k = Int32.Parse((maxGenes * chanceCrossing).ToString());
            List<int> l1 = new List<int>();
            for (int i = 0; i < k; i++)
            {
                int value = rnd.Next(maxGenes);
                while (l1.Contains(value))   // Определяет входил ли элемент
                {
                    value = rnd.Next(maxGenes);
                }
                l1.Add(value);
            }
            l1.Sort();
            
            List<int> l2 = new List<int>();
            for (int i = 0; i < k; i++)
            {
                int j;
                for (j = 0; j < maxGenes && population[y][j] != population[x][l1[i]]; j++) ;
                l2.Add(j);
            }
            l2.Sort();
            int[] s = new int[maxGenes];
            for (int i = 0; i < maxGenes; i++)
            {
                s[i] = population[y][i];
            }
            List<int> u1 = new List<int>();
            List<int> u2 = new List<int>();
            for (int i = 0; i < maxGenes; i++)
            {
                u1.Add(i);
                u2.Add(i);
            }
            for (int i = 0; i < k; i++)
            {
                u1.Remove(l1[i]);
                u2.Remove(l2[i]);
            }
            for (int i = 0; i < u1.Count(); i++)
            {
                s[u2[i]] = population[x][u1[i]];
            }
            return s;
        }


        //мутация
        public int[] Mutation(int[] a)
        {
            int x = rnd.Next(maxGenes);
            int y = rnd.Next(maxGenes);
            while (x == y)
            {
                y = rnd.Next(maxGenes);
            }
            int t = a[y];
            a[y] = a[x];
            a[x] = t;
            return a;
        }

        //применение генетических операторов
        public int[] GeneticOperation(int x, int y)
        {
            int[] s = Crossnig(x, y);
            double chance = rnd.NextDouble();
            if (chance < chanceMutation)
            {
                s = Mutation(s);
            }
            return s;
        }

        //процесс эволюции
        public int Evolution()

        {
            /* log.showLog("Дистанция");

            for (int i = 1; i < map.maxCities; i++)
            {
            log.showLog(map.distance[0][i].ToString());
            }*/

            //инициализация исходной популяции
            InitPopulation();

            //оценка приспособленности хромосом
            CalcFitness();
            string t = "";



            //пока не выполнено условие завершения
            while (countGeneration < maxGeneration)
            {
                //вывод "состояния" текущего поколения
                log.addPoint(double.Parse(countGeneration.ToString()), AvgHealth());
                log.showLog("Состояние популяции");
                for (int i = 0; i < maxIndividual; i++)
                {
                    t = "";
                    for (int j = 0; j < maxGenes; j++)
                    {
                        t += population[i][j].ToString() + " ";
                    }
                    t += " : " + (1 / health[i]).ToString();
                    log.showLog(t);
                }
                log.showLog("Среднее здоровье : " + AvgHealth().ToString());
                log.showLog("----------------------------------------------------");

                //селекция
                Breeding();

                //применение генетических операторов
                int x = parentPool[0];
                int y = parentPool[1];
                int[] s = GeneticOperation(x, y);
                
                //создание новой популяции
                double worst = health[0];
                int i_worst = 0;
                for (int i = 0; i < maxIndividual; i++)
                {
                    if (health[i] < worst)
                    {
                        i_worst = i;
                        worst = health[i];
                    }
                }
                for (int j = 0; j < maxGenes; j++)
                {
                    population[i_worst][j] = s[j];
                }

                log.showLog("Исключили хромосомы : " + i_worst.ToString());
                log.showLog("Скрестили : " + x.ToString() + " и " + y.ToString());
                //оценка приспособленности хромосом
                CalcFitness();

                //подсчёт поколений
                countGeneration++;

            }

            //выбор наилучшей хромосомы
            return chooseWinner();
        }

        //выбор наилучшей хромосомы
        public int chooseWinner()
        {
            double path = health[0];
            int index = 0; ;
            for (int i = 1; i < maxIndividual; i++)
            {
                if (health[i] > path)
                {
                    path = health[i];
                    index = i;
                }
            }
            return index;
        }
        //определение среднего здоровья
        public double AvgHealth()
        {
            double sum = 0;
            for (int i = 0; i < health.Length; i++)
            {
                sum += 1 / health[i];
            }
            return sum / health.Length;
        }
    }
}
