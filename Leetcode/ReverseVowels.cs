public class Solution {
    public string ReverseVowels(string s) {
        char[] st = s.ToCharArray();
        int a=0,b=s.Length-1;
        List<char> vowels = new List<char>(){'a','e','i','o','u','A','E','I','O','U'};
        
        while(a<=b){
            if(vowels.Contains(st[a]) && vowels.Contains(st[b])){
                char t=st[a];
                st[a]=st[b];
                st[b]=t;
                a++;b--;
            }
            else if(!vowels.Contains(st[a])){
                a++;
            }
            else if(!vowels.Contains(st[b])){
                b--;
            }
        }
        
        Console.WriteLine(st);
        s = new string(st);
        return s;
    }
}