namespace Calculate_Reward_Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cont = " " ;
            do
            {
                Console.WriteLine("Enter the transaction detail");
                string[] tranc = Console.ReadLine().Split(",").ToArray();
                if (tranc[2] == "VISA card")
                {
                    VISACard vc = new VISACard();
                    Console.WriteLine("Total reward points earned in this transaction is {0}", string.Format("{0:0.00}",vc.ComputeRewardPoints(tranc[0], int.Parse(tranc[1]))));
                }   
                else if(tranc[2] == "HPVISA card")
                {
                    HPVISACard hpvc = new HPVISACard();
                    Console.WriteLine("Total reward points earned in this transaction is {0}", string.Format("{0:0.00}", hpvc.ComputeRewardPoints(tranc[0], int.Parse(tranc[1]))));


                }
                else
                {
                    Console.WriteLine("Invalid data");
                }
                Console.WriteLine("Do you want to continue?(Yes/No)");
                cont = Console.ReadLine();
                    
                    }while (cont.Equals("Yes"));
        }
    }
}