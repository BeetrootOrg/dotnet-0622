namespace CodeConvention
{
    public class PublicClass
    {
        private static int _privateStaticIntValue;
        public static int PublicStaticIntValue;
        protected static int ProtectedStaticIntValue;
        internal static int InternalStaticIntValue;

        private const int PrivateConstant = 0;
        public const int PublicConstant = 0;
        protected const int ProtectedConstant = 0;
        internal const int InternalConstant = 0;

        private int _privateIntValue;
        public int PublicIntValue;
        protected int ProtectedIntValue;
        internal int InternalIntValue;

        public enum PublicEnum
        {
            FirstValue,
            SecondValue,
            ThirdValue
        }

        private int PrivateIntFunction(int firstParameter, int secondParameter)
        {
            var localVariable = firstParameter + secondParameter;
            return 1;
        }

        public int PublicIntFunction(int firstParameter, int secondParameter)
        {
            var localVariable = firstParameter + secondParameter;
            return 1;
        }

        protected int ProtectedIntFunction(int firstParameter, int secondParameter)
        {
            var localVariable = firstParameter + secondParameter;
            return 1;
        }

        internal int InternalIntFunction(int firstParameter, int secondParameter)
        {
            var localVariable = firstParameter + secondParameter;
            return 1;
        }

        private void PrivateVoidFunction(int firstParameter, int secondParameter){}
        public void PublicVoidFunction(int firstParameter, int secondParameter){}
        protected void ProtectedVoidFunction(int firstParameter, int secondParameter){}
        internal void InternalVoidFunction(int firstParameter, int secondParameter){}        

    }
    private class PrivateClass{}
    protected class ProtectedClass{}
    internal class InternalClass{}
    
}