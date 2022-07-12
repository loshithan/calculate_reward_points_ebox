using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Reward_Points
{
    internal class VISACard
    {

        public virtual double ComputeRewardPoints(string _type, double _amount)
        {

            double rewardPoint ;

            rewardPoint = _amount * 0.01;

            return rewardPoint;
        }
    }
}
