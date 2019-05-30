# 字符串里找子串
## 题干
从字符串（haystack``干草堆``）中找到第一次出现子串(needle``针``)的位置，没有的话返回-1
## 示例
输入：haystack="hello",needle="ll"
输出：2
## 解答
### 笔者解答
笔者直接使用C#的IndexOf来获得索引，竟然过了~
```
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
```
测试结果统计:
```
√ Accepted
  √ 74/74 cases passed (84 ms)
  √ Your runtime beats 46.37 % of csharp submissions
  √ Your memory usage beats 5.1 % of csharp submissions (21.6 MB)
```
### 参考答案
考察的知识点分析等
```
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Equals(needle)) {
            return 0;
        }        
        if (haystack.Length == 0) {
            return -1;
        }
        int back = 0;
        int haystackLen=haystack.Length;
        int needleLen = needle.Length;
        while (back <=haystackLen -needleLen) {
            String cur = haystack.Substring(back, needleLen);
            if (cur.Equals(needle)) {
                return back;
            }       
            back++;
        }
        return -1;
    }
```
测试结果统计：
```
√ Accepted
  √ 74/74 cases passed (76 ms)
  √ Your runtime beats 66.18 % of csharp submissions
  √ Your memory usage beats 23.57 % of csharp submissions (20.7 MB)
```