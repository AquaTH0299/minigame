// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("fM5NbnxBSkVmygTKu0FNTU1JTE/1twWP8MeD/bsNfhWaiFT6yYjZeaCgcGGwry3Ux21JNWLawg8A6WxIvR6gaL2pJWMpyM1e2suMWPdcA9aTtyIgHF9mf4peHpgTdApVVh1IB1XY6dTueje2wHzKZqsg0DZvmvQmtbfXJl8AQGR8RRVd1X8aFbV6x6VvGGEt7ChQaEG2Yb+NIqYXPBO+DVkE2nrBglx92Dby9bwoeCzGj7KkjL3qpJKWgPL5spSZSDnrE6bSQwsHq8BIoDABB/89WzTVse9ZW3lnmY1UMs6Zhjuy/9QANrJYO7qEMVYV3foXdBgxuS4OvI7wLObXsuaNsQvOTUNMfM5NRk7OTU1M3UNKBXBXQWukjDtwow+bTU5PTUxN");
        private static int[] order = new int[] { 0,6,9,4,5,11,13,12,8,12,10,11,12,13,14 };
        private static int key = 76;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
