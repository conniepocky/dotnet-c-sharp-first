using System;

namespace hello_waffles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Waffles!");
	    Console.WriteLine("Whats your favourite food");
	    var best_food_ever = Console.ReadLine();
	    Console.WriteLine($"{best_food_ever} are good but waffles are the best :)");
	    Console.WriteLine("Whats your favourite operating system?");
	    var os = Console.ReadLine();

	    long my_waffles = 4739857539867;
	    
	    if (os == "linux") {
		Console.WriteLine("Yaay!");
            } 
	    else if (os == "windows") {
		    Console.WriteLine("nooo :(");
    	    }
	    else {
		    Console.WriteLine("at least its not windows :)");
	    }
    }
  }
}
