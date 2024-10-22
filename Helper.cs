namespace Static
{
    internal static class Helper
    {
        public static bool IsOdd(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
        public static bool HasDigit(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(string str)
        {
            bool smallChar = false;
            bool bigChar = false;

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    smallChar = true;
                }
                else if (char.IsLower(c))
                {
                    bigChar = true;
                }
            }
            return smallChar && bigChar && HasDigit(str) && str.Length >= 8;
        }
        public static string Capitalaze(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();

        }

    }


}
