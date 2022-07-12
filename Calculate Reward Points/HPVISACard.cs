using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Reward_Points
{
    internal class HPVISACard:VISACard
    {
         public override double  ComputeRewardPoints(string _type, double _amount)
        {
            //Fill your code here
            if(_type == "Fuel")
            {
                return (base.ComputeRewardPoints(_type,_amount) + 10);
            }
            else
            {
                // return base.ComputeRewardPoints(_type,_amount);
                return 0;
            }
            
        }
    }
}
