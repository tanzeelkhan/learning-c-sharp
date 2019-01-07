using System; 

namespace FirstConsoleApp
{

    //DEFINING A CLASS

    public class Stakeholder
    {
        static Stakeholder()
        {
            Console.WriteLine("I'm in the static Constructor");
        }
        protected int sid;
        
        public virtual void disp()
        {
            Console.WriteLine("I'm in Parent Class Stakeholder");
        }
    }

    public class CorporateCustomer: Stakeholder
    {

        public CorporateCustomer()
        {
            Console.WriteLine("Default constructor");
        }

        public override void disp()
        {
            Console.WriteLine("I'm in Child Class, Corporate Customer");
        }

        public void PrintSid()
        {
            CorporateCustomer CC1 = new CorporateCustomer();
         
                CC1.sid = 21;
                Console.WriteLine("Stakeholder ID: "+ CC1.sid);
        }
    }
    
    public class Customer //Class
    {
        string firstName;
        string lastName;
        private int id;
        protected int mno;


        public Customer(string name)
        {
            firstName = name;
            lastName = null;
        }
        public Customer(string fname, string lname) //Parameterized Consructor
        {
            firstName = fname;
            lastName = lname;
        }

            public void set(int cid)
                {
                id=cid; 
                }

            public int get()
                {
                return id;
                }

    public void PrintFullName() //User defined function
        {
            Console.WriteLine("Full Name: {0}", firstName + " " + lastName);
        }

        ~Customer()  //Destructor
        {
            Console.WriteLine("\n\nObject Destroyed");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string fname=Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lname = Console.ReadLine();

            Customer C1 = new Customer(fname);
            Customer C2 = new Customer(fname, lname);
            C1.PrintFullName();
            C2.PrintFullName();
            C1.set(10);
            Console.WriteLine("Customer ID: " + C1.get());
            CorporateCustomer cu = new CorporateCustomer();
            cu.PrintSid();

            Stakeholder st = new CorporateCustomer();
            st.disp();
            Console.ReadLine();

            //DATA TYPES
        /*    int a = 10;
            uint b = 20;
            string str = "Hello World";
            char c = 'M';
            var un = 10;
            var st = "This is a String declared using var";
            short s = 10;
            float f = 10.2f;
            double d = 11.5;
            var pi = 3.13;
            bool Truth = true;
            Console.WriteLine("The int type variable a has value "+ a + ". The Max Value of type int is " + int.MaxValue);

            Console.ReadLine();*/

        }
    }
}
