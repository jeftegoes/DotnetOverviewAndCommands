namespace Library
{
    public static class StringLibrary
    {
        public static bool StartWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            var ch = str[0];
            return char.IsUpper(ch);
        }
    }
}