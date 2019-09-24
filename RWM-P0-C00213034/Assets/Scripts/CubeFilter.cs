using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter
{
    public static int collatz(int n)
    {
        if(n % 2 == 0)
        {
            n = n / 2;
        }
        else
        {
            n = n * 3 - 1;
        }
        return n;
    }

    public static int [] cubes(int [] nums)
    {
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = collatz(nums[i]);
        }

        return res;
    }
}
