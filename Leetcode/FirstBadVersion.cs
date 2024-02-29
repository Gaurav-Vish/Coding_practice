/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        // Console.WriteLine(IsBadVersion(n));
        int l=1,h=n,bad=0;
        while(l<=h){
            int mid=l+((h-l)/2);
            if(IsBadVersion(mid)){
                h=mid-1;
                bad=mid;
            }
            else{
                l=mid+1;
            }
        }
        return bad;
    }
}