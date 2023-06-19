using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPrefixSet
{
	internal class PrefixSet
	{
		private static readonly string GoodSet = "GOOD SET";
		private static readonly string BadSet = "BAD SET";
		private class TrieNode
		{
			public bool isWord;
			public readonly Dictionary<char, TrieNode> children;

			public TrieNode()
			{
				children = new Dictionary<char, TrieNode>();
			}
		}

		private class Trie
		{
			private TrieNode root;

			public Trie()
			{
				root = new();
			}

			public bool Add(string word)
			{
				TrieNode node = root;
				foreach(char ch in word)
				{
					if (!node.children.ContainsKey(ch))
					{
						node.children.Add(ch, new TrieNode());
					}
					if (node.children[ch].isWord)
					{
						return false;
					}
					node = node.children[ch];
				}
				node.isWord = true;
				return node.children.Count == 0;
			}
		}

		public static void NoPrefixSet(List<string> words)
		{
			Trie trie = new();
			foreach(string word in words)
			{
				if (!trie.Add(word))
				{
                    Console.WriteLine(BadSet);
                    Console.WriteLine(word);
                    return;
                }
			}
            Console.WriteLine(GoodSet);
        }
	}
}
