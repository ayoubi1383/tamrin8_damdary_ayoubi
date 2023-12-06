namespace tamrin8_damdary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class animal
    {
        public DateTime birth_date { get; }
        static int max_life { get; }
        public List<environment> environment { get; set; }
        public float weight { get; set; }
        public bool gender { get; set; }
        public string name { get; set; }
        public float stress_factor()
        {
            return 0;
        }
        public int life()
        {
            return 0;
        }
        public int time_to_die()
        {
            return 0;
        }
        public float kill_priority()
        {
            return 0;
        }
        public int cost_per_day()
        {
            return 0;
        }
        public int value_per_day()
        {
            return 0;
        }
    }
    class cow : animal
    {
        public DateTime birth_date { get; }
        static int max_life { get; }
        public List<environment> environment { get; set; }
        public static int number { get; set; }
        public List<cow_parameter> cow_Parameter { get; set; }
        public string tostring()
        {
            return "0";
        }
    }
    class sheep
    {
        public DateTime birth_date { get; }
        static int max_life { get; }
        public List<environment> environment { get; set; }
        public static int number { get; set; }
        public List<sheep_parameter> sheep_Parameter { get; set; }
        public string tostring()
        {
            return "0";
        }
    }
    class environment
    {
        health_parameter<double> hp = new health_parameter<double>();
        public double  health_paramete_TDS
        {
            get
            { 
                double a = 0;
                double varedi = ((hp.current / hp.standard) * a) * 100;
                return Convert.ToDouble(hp.name) + varedi ;
            }
            set
            {
                hp.name = "amir";
                hp.current = 3;
                hp.standard = 2;
            }
        }
        public double health_paramete_Temp 
        {
            get
            {
                double a = 0;
                double varedi = ((hp.current / hp.standard) * a) * 100;
                return Convert.ToDouble(hp.name) + varedi;
            }
            set
            {
                hp.name = "amir";
                hp.current = 3;
                hp.standard = 2;
            }
        }
        public double health_paramete_Density { get; set; }
        public double health_paramete_db { get; set; }
        public double health_paramete_AQL { get; set; }
        public double health_paramete_OX { get; set; }
        public DateOnly date { get; set; }
        public double  tostring()
        {
            return 0;
        }
    }
    class health_parameter<T>
    {
        public string name { get; set; }
        public T current { get; set; }
        public T standard { get; set; }
        public string tostring()
        {
            return "0";
        }
        public float stress_factor()
        {
            return 0;
        }
    }
    class cow_parameter
    {
        public int health_parameter_time_to_stand { get; set; }
        public int health_parameter_time_to_deal { get; set; }
        public int health_parameter_time_to_relax { get; set; }
        public int health_parameter_number_of_meal { get; set; }
        public int health_parameter_number_of_milk_production { get; set; }
        public DateOnly date { get; set; }
        public string to_string()
        {
            return "0";
        }
    }
    class sheep_parameter
    {
        public int health_parameter_time_to_stand { get; set; }
        public int health_parameter_time_to_deal { get; set; }
        public int health_parameter_time_to_relax { get; set; }
        public int health_parameter_number_of_meal { get; set; }
        public int health_parameter_number_of_milk_production { get; set; }
        public DateOnly date { get; set; }
        public string to_string()
        {
            return "0";
        }
    }
}