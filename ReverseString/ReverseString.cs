namespace ReverseString
{
    public class ReverseString
    {
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();

            int rightIndex = charArray.Length - 1, leftIndex = 0;

            while (leftIndex < rightIndex)
            {
                if (!char.IsLetter(charArray[leftIndex]))
                {
                    leftIndex++;
                }  
                else if (!char.IsLetter(charArray[rightIndex]))
                {
                    rightIndex--;
                }
                else
                {
                    char tmp = charArray[leftIndex];
                    charArray[leftIndex] = charArray[rightIndex];
                    charArray[rightIndex] = tmp;
                    leftIndex++;
                    rightIndex--;
                }
            }

            var reversedInput = new string(charArray);

            return reversedInput;
        }
    }
}
