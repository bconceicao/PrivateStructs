using System;

namespace structs
{
    class Program
    {

        class Person
        {
            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string email;
            private string phone;
            private string pause;


            public string FName
            {
                get
                {
                    return fName;
                }

                set
                {
                    fName = value;
                }
            }

            public string MName
            {
                get
                {
                    return mName;
                }

                set
                {
                    mName = value;
                }
            }

            public string LName
            {
                get
                {
                    return lName;
                }

                set
                {
                    lName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }

                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }

                set
                {
                    street2 = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }

            public string Zip
            {
                get
                {
                    return zip;
                }

                set
                {
                    zip = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    phone = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public string Pause
            {
                get
                {
                    return pause;
                }

                set
                {
                    pause = value;
                }
            }


        }
        static void Main(string[] args)
        {

            bool blnResult = false;
            Person temp = new Person();
            


            do
            {

                Console.Write("Enter first name: ");
                temp.FName = Console.ReadLine();
                blnResult = temp.FName.Length != 0;
                

                if (blnResult == false)
                {
                    
                    Console.WriteLine("Error. Must enter first name.");
                }

            } while (blnResult == false);

                

            Console.Write("Enter middle name: ");
            temp.MName = Console.ReadLine();

            do
            {
                Console.Write("Enter last name: ");
                temp.LName = Console.ReadLine();
                blnResult = temp.LName.Length != 0;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter last name.");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("Enter street address 1: ");
                temp.Street1 = Console.ReadLine();
                blnResult = temp.Street1.Length != 0;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter street address 1.");
                }
            } while (blnResult == false);

            Console.Write("Enter Street Address 2: ");
            temp.Street2 = Console.ReadLine();

            do
            {
                Console.Write("Enter city: ");
                temp.City = Console.ReadLine();
                blnResult = temp.City.Length != 0;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter city.");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("Enter State: ");
                temp.State = Console.ReadLine();
                blnResult = temp.State.Length == 2;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter State's 2 letter abbreviation.");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("Enter zip code: ");
                temp.Zip = Console.ReadLine();
                blnResult = temp.Zip.Length == 5;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter 5 digit zip code.");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("Enter email: ");
                temp.Email = Console.ReadLine();
                blnResult = (temp.Email.Contains("@")) &&  (temp.Email.Contains("."));

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter email.");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("Enter phone number: ");
                temp.Phone = Console.ReadLine();
                blnResult = temp.Phone.Length == 12;

                if (blnResult == false)
                {
                    Console.WriteLine("Error. Must enter phone number in correct format(xxx-xxx-xxx).");
                }
            } while (blnResult == false);

            


            Console.WriteLine($"\nName: {temp.FName} {temp.MName} {temp.LName}");
            Console.WriteLine($"\nAddress: {temp.Street1} {temp.Street2} \n \t {temp.City}, {temp.State} {temp.Zip}");
            Console.WriteLine($"\nEmail: {temp.Email}");
            Console.WriteLine($"\nPhone: {temp.Phone}");

            Console.Write("\n\nPress Enter to continue");
            temp.Pause = Console.ReadLine();
            
        }
    }
}
