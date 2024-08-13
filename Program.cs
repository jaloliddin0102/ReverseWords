string s = "Let's take LeetCode contest";
Console.WriteLine(ReverseWords(s));
    static string ReverseWords(string s) {
        string[]array = s.Split(new char[]{' '});
        string answer = "";
        for (int i = 0; i < array.Length; i++) 
            {
                for (int j = s.Length - 1; j >= 0; j--)
                {
                        answer += array[i][j];
                }
                if (i!=array.Length-1)
                answer += " ";
            }
        return answer;
    }
