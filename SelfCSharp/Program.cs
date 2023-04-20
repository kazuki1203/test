using System;

namespace Con_pro0701
{
    class Program
    {
        static void Main(string[] args)
        {
            var mh= new[] { 40.0, 33.0, 50.0, 55.0, 60.0, 54.0 } ;
            var jp = new[] { 80.0, 90.0, 95.0, 93.0, 80.0, 90.0 };
            var sc = new [] { 50.0, 60.0, 65.0, 64.0, 63.0, 60.0 };
            var ph = new [] { 70.0, 77.0, 65.0, 60.0, 70.0, 76.0 };
            var name = new[] { "数学", "国語", "理科", "社会" };

            var hairetu = new[,] { { 40.0, 33.0, 50.0, 55.0, 60.0, 54.0 }, { 80.0, 90.0, 95.0, 93.0, 80.0, 90.0 }, { 50.0, 60.0, 65.0, 64.0, 63.0, 60.0 }, { 70.0, 77.0, 65.0, 60.0, 70.0, 76.0 } };
            var hairetu2 = new[] { mh, jp, sc, ph };
            Console.WriteLine(hairetu[0, 1]);

            double avlmh = 0.0;
            double avljp = 0.0;
            double avlsc = 0.0;
            double avlph = 0.0;

            for (var i = 0 ; i  < 6 ;  i++)
            {
                avlmh = avlmh + mh[i];
                avljp = avljp + jp[i];
                avlsc = avlsc + sc[i];
                avlph = avlph + ph[i];
            }
            var val = new[] { avlmh / 6, avljp / 6, avlsc / 6, avlph / 6 };
            for ( var i = 0; i < val.Length; i++)
            {
                Console.WriteLine(name[i] + "の平均点:" + val[i] + "点");
            }

            var avls = new[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (var i = 0; i < 4; i++)
            {
                for (var ii = 0; ii < 6; ii++)
                {
                    avls[i] = avls[i] + hairetu[i, ii];
                }
                avls[i] = avls[i] / 6;
                Console.WriteLine(name[i] + "の平均点 :" + avls[i] + "点");
            }
        }
    }
}
