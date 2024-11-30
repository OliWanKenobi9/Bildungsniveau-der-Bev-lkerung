using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bildungsniveau_statistikaustria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] data = new double[5];

            List<double[]> list = new List<double[]>();

            data[0] = 1981;
            data[1] = 46;
            data[2] = 31;
            data[3] = 18.4;
            data[4] = 4.4;

            list.Add(data);

            data = new double[5];
            data[0] = 1991;
            data[1] = 34.2;
            data[2] = 37;
            data[3] = 21.9;
            data[4] = 6.9;

            list.Add(data);

            data = new double[5];
            data[0] = 2001;
            data[1] = 26.2;
            data[2] = 39.4;
            data[3] = 24.6;
            data[4] = 9.9;

            list.Add(data);

            data = new double[5];
            data[0] = 2008;
            data[1] = 19.5;
            data[2] = 36.9;
            data[3] = 30.2;
            data[4] = 13.4;

            list.Add(data);

            data = new double[5];
            data[0] = 2009;
            data[1] = 19.5;
            data[2] = 36.6;
            data[3] = 30.1;
            data[4] = 13.8;

            list.Add(data);

            data = new double[5];
            data[0] = 2010;
            data[1] = 19.4;
            data[2] = 36.3;
            data[3] = 30.2;
            data[4] = 14.1;

            list.Add(data);

            data = new double[5];
            data[0] = 2011;
            data[1] = 19.2;
            data[2] = 36;
            data[3] = 30.2;
            data[4] = 14.6;

            list.Add(data);

            data = new double[5];
            data[0] = 2012;
            data[1] = 19.1;
            data[2] = 35.6;
            data[3] = 30.2;
            data[4] = 15.2;

            list.Add(data);

            data = new double[5];
            data[0] = 2013;
            data[1] = 19.2;
            data[2] = 35.1;
            data[3] = 30;
            data[4] = 15.7;

            list.Add(data);

            data = new double[5];
            data[0] = 2014;
            data[1] = 19.1;
            data[2] = 34.6;
            data[3] = 30.1;
            data[4] = 16.2;

            list.Add(data);

            data = new double[5];
            data[0] = 2015;
            data[1] = 18.5;
            data[2] = 34.7;
            data[3] = 30.1;
            data[4] = 16.7;

            list.Add(data);

            data = new double[5];
            data[0] = 2016;
            data[1] = 18.3;
            data[2] = 34.4;
            data[3] = 30.2;
            data[4] = 17.1;

            list.Add(data);

            data = new double[5];
            data[0] = 2017;
            data[1] = 18;
            data[2] = 34.2;
            data[3] = 30.3;
            data[4] = 17.5;

            list.Add(data);

            data = new double[5];
            data[0] = 2018;
            data[1] = 17.9;
            data[2] = 33.7;
            data[3] = 30.3;
            data[4] = 18.1;

            list.Add(data);

            data = new double[5];
            data[0] = 2019;
            data[1] = 17.6;
            data[2] = 33.4;
            data[3] = 30.4;
            data[4] = 18.6;

            list.Add(data);

            data = new double[5];
            data[0] = 2020;
            data[1] = 17.5;
            data[2] = 33;
            data[3] = 30.4;
            data[4] = 19.2;

            list.Add(data);

            data = new double[5];
            data[0] = 2021;
            data[1] = 17.3;
            data[2] = 32.6;
            data[3] = 30.4;
            data[4] = 19.7;

            list.Add(data);

            data = new double[5];
            data[0] = 2022;
            data[1] = 17.1;
            data[2] = 32;
            data[3] = 30.4;
            data[4] = 20.4;

            list.Add(data);

            string fileName = "data.csv";
            string filePath = "C:\\Users\\olive\\OneDrive\\Dokumente\\POS\\Bildungsniveau der Bevölkerung";

            string fullPath = Path.Combine(filePath, fileName);

            System.IO.File.Delete(fullPath);

            for (int i = 0; i < list.Count; i++)
            {
                System.IO.File.AppendAllText(fullPath, list[i].Select(d => d.ToString()).Aggregate((a, b) => a + ";" + b) + Environment.NewLine);
            }

        }
    }
}
