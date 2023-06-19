namespace NoPrefixSet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<string> words = new();
			for (int i = 0; i < n; ++i)
			{
				words.Add(Console.ReadLine());
			}
			PrefixSet.NoPrefixSet(words);
        }
	}
}