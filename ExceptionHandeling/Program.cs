using System;

namespace ExceptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Servis servis;
            try
            {
                servis = new Servis();
                servis.Radi(0);
            }
            catch(NasException e)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("nalazimo se u exception bloku");
                Console.WriteLine(e.Message); ;
            }
 
            
        }
    }
}
