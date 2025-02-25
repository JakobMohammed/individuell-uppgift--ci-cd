using System.Text;

public class CipherService
{
    public string Encrypt(string input, int shift)
    {
        var result = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result.Append((char)(((c + shift - offset) % 26) + offset));
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }

    public string Decrypt(string input, int shift)
    {
        return Encrypt(input, 26 - shift);
    }
}