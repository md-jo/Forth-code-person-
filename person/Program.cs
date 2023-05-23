// See https://aka.ms/new-console-template for more information
          Person p = new Person();
          
            Console.WriteLine("enter first name");
         string first  = Console.ReadLine();
            Console.WriteLine("enter last name");
            string last = Console.ReadLine();
            Console.WriteLine("enter email ");
            string email = Console.ReadLine();
            if (email.EndsWith(".com")&&email.Contains("@"))
                 p.Email = email;
            else
                Console.WriteLine("error ");
           
            p.lastName = last;
            p.firstName = first;
            Console.WriteLine();
            Console.WriteLine();
            p.GetFullName();
 class Person
    {
        
        public string firstName
        {
            get;
            set;
        }
        

        public string lastName
        {
            get;
            set;
        }
      
        public string Email
        {
            get;
            set;
            
        }


        public void GetFullName()
        {
            Console.WriteLine("your email");
            Console.WriteLine(Email);
 Console.WriteLine(  " your name is  "+firstName + " " + lastName);
        }
        
    }