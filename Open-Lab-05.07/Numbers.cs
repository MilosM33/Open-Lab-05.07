using System;
using System.Linq;
namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            var temp = nums.ToList();
            temp.Remove(nums.Min());
            return temp.ToArray();
        }
        
        
    }
}
