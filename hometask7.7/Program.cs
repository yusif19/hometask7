namespace hometask7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int increment = 1;
            int [] employees=new int[increment];
            Console.WriteLine("Enter new employees");

            employees[0] = Convert.ToInt32(Console.ReadLine());
            
           while (flag) { 

                Console.WriteLine("Do you want do contuniue");
                string answer  = Console.ReadLine();
                if(answer.ToLower() == "yes") {

                    Array.Resize(ref employees, increment + 1);
                    employees[increment]=Convert.ToInt32(Console.ReadLine());
                    increment++;

                }
                else
                {
                    if(answer.ToLower() == "no")
                    {
                        flag = false;
                        for(int i = 0; i < employees.Length; i++)
                        {
                            Console.WriteLine(employees[i]);

                        }
                    }


                }
            

            }


        }
    }
}