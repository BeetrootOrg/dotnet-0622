namespace CodeConvention
{
    public class Class
    {
        private static int _private;
        public static int Public;
        protected static int Protected;
        internal static int Internal;

        private const int PrivateConst = 0;
        public const int PublicConst = 0;
        protected const int ProtectedConst = 0;
        internal const int InternalConst = 0;

        private int _privateInt;
        public int PublicInt;
        protected int ProtectedInt;
        internal int InternalInt;

        public enum Enum
        {
            One,
            Two,
            Three
        }

        private int PrivateFunction(int int1, int int2)
        {
            var Variable = int1 + int2;
            return 1;
        }

        public int PublicFunction(int int1, int int2)
        {
            var Variable = int1 + int2;
            return 1;
        }

        protected int ProtectedFunction(int int1, int int2)
        {
            var Variable = int1 + int2;
            return 1;
        }

        internal int InternalFunction(int int1, int int2)
        {
            var Variable = int1 + int2;
            return 1;
        }

        private void PrivateVoidFunction(int int1, int int2){}
        public void PublicVoidFunction(int int1, int int2){}
        protected void ProtectedVoidFunction(int int1, int int2){}
        internal void InternalVoidFunction(int int1, int int2){}        

    }
    private class PrivateClass{}
    protected class ProtectedClass{}
    internal class InternalClass{}
    
}