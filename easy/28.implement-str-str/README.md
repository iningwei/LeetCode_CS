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
本体主要考察字符串中寻找子串的问题，笔者的答案自然不是期望的。
正确的解法即大名鼎鼎的KMP算法。

测试结果统计：
```

```