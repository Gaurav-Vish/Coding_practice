public class Solution {
    public bool IsPerfectSquare(int num) {
        long l=1,h=num;
        while(l<=h){
            long m=l+(h-l)/2; //if it's int then it will exceed int's max value
            Console.WriteLine(m);
            if(m*m==num){
                return true;
            }
            else if(m*m>num){
                h=m-1;
            }
            else if(m*m<num){
                l=m+1;
            }
        }
        return false;
    }
}