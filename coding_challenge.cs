using System;
using System.Text;

public class OldPhonePad
{
    // Mapping of keypad numbers to letters
    private static readonly string[] KEYPAD = {
        "",     // 0
        "&'(",  // 1
        "ABC",  // 2
        "DEF",  // 3
        "GHI",  // 4
        "JKL",  // 5
        "MNO",  // 6
        "PQRS", // 7
        "TUV",  // 8
        "WXYZ"  // 9
    };

    public static string InputStringOldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        int i = 0;
        int n = input.Length;
        while (i < n)
        {
 if (input[i] == '#') break; // End of input
            if (input[i] == '*')
            {
                // Backspace: remove last character
                if (output.Length > 0)
                    output.Remove(output.Length - 1, 1);
                i++;
                continue;
            }
            if (input[i] == ' ')
            {
                i++;
                continue; // Pause between same button presses
            }
            // Count consecutive same digits
            int j = i;
            while (j < n && input[j] == input[i]) j++;
            int digit = input[i] - '0';
            int count = j - i;
            if (digit >= 0 && digit <= 9 && KEYPAD[digit].Length > 0)
            {
                int letterIndex = (count - 1) % KEYPAD[digit].Length;
                output.Append(KEYPAD[digit][letterIndex]);
            }
  		i = j;
        }
        return output.ToString();
    }
}