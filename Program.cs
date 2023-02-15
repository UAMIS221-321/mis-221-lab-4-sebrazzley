// See https://aka.ms/new-console-template for more information


//main

string input;


DisplayMenu();

input = System.Console.ReadLine();

while(input != "3")
{
    if(input == "1")
    {
        GetFull();
    }
    else if (input =="2")
    {
        GetPartial();
    }
    else
        GetError();

    DisplayMenu();
    input = System.Console.ReadLine();
    
}


//end main




//********************************************************************
//    DISPLAYS YOUR OPTIONS
//********************************************************************
static void DisplayMenu()
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Enter 1 to display full triangle");
    System.Console.WriteLine("Enter 2 to display partial triangle");
    System.Console.WriteLine("Enter 3 to exit");
    System.Console.WriteLine("");
}


//********************************************************************
//     GETS A REGULAR-DEGULAR PYRAMID
//********************************************************************
static void GetFull()
{
        Random rand = new Random();
        int rand_num = rand.Next (3,10);
        
       
        for(int i = 0; i < rand_num; i++)
        {
            //makes it a pyramid
            for(int k = rand_num-i; k > 0; k--)
            {
                System.Console.Write(" ");    
            }
            for(int j = 0; j <= i; j++ )
            {
                
                    System.Console.Write("* ");

            }

             
            System.Console.WriteLine("");
        } 
}

    //********************************************************************
    //     GETS A HOLE-Y PYRAMID
    //********************************************************************
    
    static void GetPartial()
    {
        Random rand = new Random();
        int rand_num = rand.Next (3,10);
        
       
        for(int i = 0; i < rand_num; i++)
        {
            //makes it a pyramid
            for(int k = rand_num-i; k > 0; k--)
            {
                System.Console.Write(" ");    
            }
            for(int j = 0; j <= i; j++ )
            {
                int rand_num1 = rand.Next (0,2);
                
                if(rand_num1 == 0)
                {
                    System.Console.Write("* ");
                }
                else
                    System.Console.Write(" ");

            }

             
            System.Console.WriteLine("");
        } 
    }

//********************************************************************
//     WHEN THE USER INPUTS WRONG
//********************************************************************


static void GetError()
{
    System.Console.WriteLine("Invalid selection. Please try again");
}
