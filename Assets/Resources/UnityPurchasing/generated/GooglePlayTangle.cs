#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("D4yCjb0PjIePD4yMjTal8oFGT6nrRhWr2kLscHTb25uBMbiD2pUkaBpA8FboJNLSZb83JcfwD8muTB7DlNatwOU8nWjTcL17RCnXTuarp5KntOJBj8wZbJK4nRyhNcQXz0KUpfGAXD2pKRsNTin9KUaiIm9gqyi2vQ+Mr72Ai4SnC8ULeoCMjIyIjY638VW01YecGMZT6ngDxQQbFdzqnAio15WgsX8U8I3GTb/O5rMZ5oe9AJnAOfRscINbkcqk37cDaul9wkbTiqL2vXJmGSAiLwOz11SeUXqdlW+VAharxJwR8vdVmOzbNgP2EiceCLnVSeU7iw8pLVxiF+NMalUzm3qYiVb88zhgJgMLbQedqjELBRMaBR59ABHmomgUyI+OjI2M");
        private static int[] order = new int[] { 1,6,4,4,7,10,6,8,10,13,11,11,12,13,14 };
        private static int key = 141;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
