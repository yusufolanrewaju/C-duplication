Console.WriteLine("Welcome to the Duplication App!");
string time;
time = DateTime.Now.ToString("hh:mm:ss tt ||  dd/MM/yyyy");
Console.WriteLine("YOUR TIME AND DATE: " + time);
Console.WriteLine("");
Console.WriteLine("Do you want to create an Account?");
string a1;
a1 = Console.ReadLine();
    if (a1 == "Yes" || a1 == "yes") {
        Console.WriteLine("Choose a Username: ");
        string us1;
        us1 = Console.ReadLine();
        Console.WriteLine("Choose a Password: ");
        string pass1;
        pass1 = Console.ReadLine();
        Console.WriteLine("Do you want to Login?");
        string a2;
        a2 = Console.ReadLine();
        if (a2 == "Yes" || a2 == "yes")
        {
            Console.WriteLine("Enter your Username: ");
            string us2;
            us2 = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string pass2;
            pass2 = Console.ReadLine();
            while (us2 != us1 || pass2 != pass1)
            {
                Console.WriteLine();
                Console.WriteLine("Username or Password Incorrect.");
                Console.WriteLine("Please Try Again!");
                Console.WriteLine("Enter your Username: ");
                us2 = Console.ReadLine();
                Console.WriteLine("Enter your Password: ");
                pass2 = Console.ReadLine();
            }
            Console.WriteLine("Welcome to the Duplication App!");
            Console.WriteLine();
            Console.WriteLine("Enter Text to Duplicate.");
            string dup;
            dup = Console.ReadLine();
            Console.WriteLine("How many times do you want to print?");
            double tm, te;
            tm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do you want to number your lines?");
            string a4;
            a4 = Console.ReadLine();
            if (a4 == "Yes" || a4 == "yes")
            {
                for (te = 1; te <= tm; te++)
                {
                    Console.WriteLine(te + ". " + dup + " ");
                    Console.WriteLine();
                }
            }
            else
            {
                for (te = 1; te <= tm; te++)
                {
                    Console.WriteLine(dup + " ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thanks for using our App..... ");
            Console.WriteLine();
            Console.WriteLine("Do you want to use our App again?");
            string a3;
            a3 = Console.ReadLine();
            while (a3 == "Yes" || a3 == "yes")
            {
                Console.WriteLine("Enter Text to Duplicate.");
                dup = Console.ReadLine();
                Console.WriteLine("How many times do you want to print?");
                tm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to number your lines?");
                a4 = Console.ReadLine();
                if (a4 == "Yes" || a4 == "yes")
                {
                    for (te = 1; te <= tm; te++)
                    {
                        Console.WriteLine(te + ". " + dup + " ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (te = 1; te <= tm; te++)
                    {
                        Console.WriteLine(dup + " ");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Thanks for using our App..... ");
                Console.WriteLine();
                Console.WriteLine("Do you want to use our App again?");
                a3 = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for Using our App.");
            time = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine("The time is " + time);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("See you Soon ☺️");
            time = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine("The time is " + time);
        }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Looking forward to seeing you use our app ☺️😊");
    time = DateTime.Now.ToString("hh:mm:ss tt");
    Console.WriteLine("The time is " + time);
}
