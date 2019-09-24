using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    public class Suffix
    {
        // A Suffix Tree (A Tree of all suffixes) Node 
        public class SuffixTreeNode
        {
            static readonly int MAX_CHAR = 26;
            public SuffixTreeNode[] children = new SuffixTreeNode[MAX_CHAR];

            public SuffixTreeNode() // Constructor 
            {
                // Initialize all child pointers as NULL 
                for (int i = 0; i < MAX_CHAR; i++)
                    children[i] = null;
            }

            // A recursive function to insert a suffix of the s in 
            // subtree rooted with this node 
            public void insertSuffix(String s)
            {
                // If string has more characters 
                if (s.Length > 0)
                {
                    // Find the first character and convert it 
                    // into 0-25 range. 
                    char cIndex = (char)(s[0] - 'a');

                    // If there is no edge for this character, 
                    // add a new edge 
                    if (children[cIndex] == null)
                        children[cIndex] = new SuffixTreeNode();

                    // Recur for next suffix 
                    children[cIndex].insertSuffix(s.Substring(1));
                }
            }
        }

        // A Tree of all suffixes 
        public class Suffix_Tree
        {
            static readonly int MAX_CHAR = 26;
            public SuffixTreeNode root;

            // Constructor (Builds a Tree of suffies of the given text) 
            public Suffix_Tree(String s)
            {
                root = new SuffixTreeNode();

                // Consider all suffixes of given string and insert 
                // them into the Suffix Tree using recursive function 
                // insertSuffix() in SuffixTreeNode class 
                for (int i = 0; i < s.Length; i++)
                    root.insertSuffix(s.Substring(i));
            }

            // A recursive function to count nodes in Tree 
            public int _countNodesInTree(SuffixTreeNode node)
            {
                // If all characters of pattern have been processed, 
                if (node == null)
                    return 0;

                int count = 0;
                for (int i = 0; i < MAX_CHAR; i++)
                {

                    // if children is not NULL then find count 
                    // of all nodes in this subTree 
                    if (node.children[i] != null)
                        count += _countNodesInTree(node.children[i]);
                }

                // return count of nodes of subTree and plus 
                // 1 because of node's own count 
                return (1 + count);
            }

            // method to count total nodes in suffix Tree 
            public int countNodesInTree()
            {
                return _countNodesInTree(root);
            }

        }

        // Returns count of distinct substrings of str 
        public static int countDistinctSubstring(String str)
        {
            // Construct a Tree of all suffixes 
            Suffix_Tree sTree = new Suffix_Tree(str);

            // Return count of nodes in Tree of Suffixes 
            return sTree.countNodesInTree();
        }
    }



static int[] countSubstrings(string s, int[][] queries)
    {
        /*
         * Write your code here.
         */
        List<int> result = new List<int>();
        int len = s.Length;

        foreach (int[] subarray in queries)
        {
            int left = subarray[0];
            int right = subarray[1];

            //for (int i = left; i <= right; i++)
            //    subs += s[i];

            int slen = right - left + 1;            
            string subs = s.Substring(left, slen);            

            int res = Suffix.countDistinctSubstring(subs) - 1;

            // todo optimize by implement Suffix tree according to Yokkonen algo
            /*HashSet<string> stringList = new HashSet<string>();
            for (int i = 0; i < subs.Length; i++)
            {
                for (int j = i; j < subs.Length; j++)
                {                    
                    stringList.Add(subs.Substring(i, j-i+1));
                }
            }*/

            result.Add(res);
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\hr_output.txt", true);
        TextReader textReader = new StreamReader(@"C:\Users\Roman\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\bin\Debug\input04.txt");

        string[] nq = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nq[0]);

        int q = Convert.ToInt32(nq[1]);

        string s = textReader.ReadLine();

        int[][] queries = new int[q][];

        for (int queriesRowItr = 0; queriesRowItr < q; queriesRowItr++)
        {
            queries[queriesRowItr] = Array.ConvertAll(textReader.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        int[] result = countSubstrings(s, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
