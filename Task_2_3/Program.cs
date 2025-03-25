// See https://aka.ms/new-console-template for more information
int len_d = Convert.ToInt32(Console.ReadLine());
double len_mm = len_d * 25.4;
double cnt_mm = Math.Round(len_mm % 10,1);
double cnt_m = (int)len_mm / 1000;
double cnt_s = (int)(len_mm-cnt_m*1000-cnt_mm)/10;

Console.WriteLine("в {0} дюймах содержится {1} метров {2} сантиметров {3} миллиметров", len_d, cnt_m, cnt_s, cnt_mm);


