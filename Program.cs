namespace day4
{

    struct time
    {
        //1.members 

        public int hour;
        public int minute;
        public int second;

        //2.validation by property ... property used to encapsulate setter and getter

             //prop for hour
        public int Hour
        {
          set { 
                if (value >= 0) 
                    hour = value; 
                else
                    hour = 0; 
            }
           
          get
            {   return hour; }
        }

        //prop for min
        public int Minute
        {
            set
            {
                if (value >= 0)
                    minute = value;
                else
                   minute = 0;
            }

            get
            { 
                return minute;
            }
        }

        //prop for second
        public int Second
        {
            set
            {
                if (value >= 0)
                    second = value;
                else
                    second = 0;
            }

            get
            {
                return second;
            }
        }
                    //auto prop
                        //public int Hour { get; set; }
                        //public int Minute { get; set; }
                       //public int Second { get; set; }



        //3.operation(print)
        public void print()
        {
            Console.WriteLine($"{hour}H:{minute}M: {second}S");
        }

        //constructors
        public time(int _hour, int _minute)
        {
            hour = _hour;
            minute = _minute;
            
        }

        //parameterless 
        public time()
        {
            hour = 0;
            minute = 5;
            second = 9;
    }
        public time(int h)
        {
            hour = h;
        }

        public time(int _hour, int _min,int _sec)
        {
            hour = _hour;
            minute = _min;
            second = _sec;
        }


    }

    internal class Program
    {

        


        static void Main(string[] args)
        {

            //time time = new time();
            //time.Hour= 1;
            //time.Minute= 12;
            //time.Second= 30;
            //time.print();

            time c1=new time();
            c1.print();

           time c2=new time(3);
            c2.print();
            time c3=new time(4,2);
            c3.print();
            time c4=new time(5,3,44);
            c4.print();
          



            time[] arr = new time[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter hour");
                arr[i].Hour = int.Parse(Console.ReadLine());
                Console.WriteLine("enter min");
                arr[i].Minute = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second");
                arr[i].Second = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].print();
            }
        }
    }
}