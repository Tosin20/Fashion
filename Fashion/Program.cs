namespace Fashion
{
    public class Program
    {
        public static string isNigeria { get;  set; }

        static void Main(string[] args)
        {
            Boutique tops = new Boutique();

            Console.WriteLine("What is your bust size?");
            string bust = Console.ReadLine();
            double bustSize;
            double.TryParse(bust, out bustSize);         //try parse to convert string to double

            Console.WriteLine("What is your waist size?");
            string waist = Console.ReadLine();
            double waistSize;
            double.TryParse(waist, out waistSize);    

            Console.WriteLine("Your top size is: {0} ",tops.CalcSize(bustSize, waistSize));
            

            try
            {
                 Console.WriteLine("Are you in Nigeria? - yes or no");         //try and catch incase user enters something else
                  isNigeria =( Console.ReadLine()).ToLower();

            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Input");
            }
            finally
            {
                if( isNigeria == "yes")
                {
                    Console.WriteLine("Input your distance:");
                    string distance = Console.ReadLine();
                   float dis;
                    float.TryParse(distance, out dis);

                    Console.WriteLine(tops.Price(dis)); 
                }

                else
                {
                   

                    Console.WriteLine(tops.Price());
                }
            }
        }
        
    }
}