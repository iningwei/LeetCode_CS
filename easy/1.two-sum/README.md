# 两个数字的和等于目标值
## 题干
从整数数组中找到两个数，使得它们的和等于目标值，最终返回这两个数的索引。
本题假设若有答案的话，只有一个答案。若无答案，则抛出异常。
## 示例
输入:nums=[2,7,11,15],target=9
输出:[0,1]
## 解答
### 笔者解答
笔者想到的是蛮力破解法，通过循环两两相加计算结果和target是否一致来判断
```
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {             
            for (int j = (i + 1); j < nums.Length; j++)
            {               
                if ((nums[i] + nums[j]) == target)
                {                    
                    return new int[]{i,j};
                }
            }
        }
        throw new System.Exception("can not find solution");
    }
```
测试结果统计:
```
√ Accepted
  √ 29/29 cases passed (408 ms)
  √ Your runtime beats 36.65 % of csharp submissions
  √ Your memory usage beats 87.47 % of csharp submissions (28.7 MB)
```
### 参考答案
本题主要考察的是``数组``和``哈希表``。

把已有的数值作为key，对应的索引作为value存到hash表中。在一次循环中，我们可以通过hash表的Contains(key)方法，快速判断是否有满足条件的数字。从而可以降低上述笔者算法中的循环比较所消耗时间。
```
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable h = new Hashtable();

        for (int i = 0; i < nums.Length; i++)
        {
            h[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (h.ContainsKey(complement) && (int)h[complement] != i)
            {
                return new int[] { i, (int)h[complement] };
            }
        }
        throw new System.Exception("can not find solution");
    }
```
笔者算法的时间复杂度为n*(n/2)=O(n^2)

引入hash表后事件复杂度变为n+n=O(n)

测试结果统计：
```
√ Accepted
  √ 29/29 cases passed (260 ms)
  √ Your runtime beats 72.72 % of csharp submissions
  √ Your memory usage beats 5.03 % of csharp submissions (30.6 MB)
```

上述代码还有进一步优化的空间，可以在一个for循环中完成：
```
    public int[] TwoSum(int[] nums, int target)
    {        
        Hashtable h = new Hashtable();         
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (h.ContainsKey(complement) && (int)h[complement] != i)
            {
                return new int[] { i, (int)h[complement] };
            }
            else
            {                
                h[nums[i]]=i;
            }
        }
        throw new System.Exception("can not find solution");
    }
```