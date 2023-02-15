// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//main

int num;


DisplayMenu();
num = int.Parse (Console.ReadLine());

while(num != 3)
{
    if(num ==1)
    {
        GetFull();
    }
    else if (num ==2)
    {
        GetPartial();
    }
    else
        GetError();

    DisplayMenu();
    num = int.Parse(System.Console.ReadLine());
}


//end main





static void DisplayMenu()
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Enter 1 to display full triangle");
    System.Console.WriteLine("Enter 2 to display partial triangle");
    System.Console.WriteLine("Enter 3 to exit");
    System.Console.WriteLine("");
}


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

    static void GetError()
    {
        System.Console.WriteLine("Invalid selection. Please try again");
    }
