using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    public class SymbolGraph
    {
        private Dictionary<string, int> st;
        private String[] keys;
        public Graph G { get; set; }

        public SymbolGraph(string[] input, string delimeter)
        {
            st = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] a = input[i].Split(new string[] { delimeter }, StringSplitOptions.None);
                foreach (var item in a)
                {
                    if (!st.ContainsKey(item))
                    {
                        st.Add(item, st.Count);
                    }
                }
            }

            keys = new String[st.Count];
            foreach (var name in st.Keys)
            {
                keys[st[name]] = name;
            }

            this.G = new Graph(st.Count);
            for (int i = 0; i < input.Length; i++)
            {
                string[] a = input[i].Split(new string[] { delimeter }, StringSplitOptions.None);
                throw new NotImplementedException();
            }
        }

        public bool Contains(string key)
        {
            return st.ContainsKey(key);
        }

        public int this[string key]
        {
            get
            {
                return this.st[key];
            }

            private set
            {
                throw new NotImplementedException();
            }
        }

        public string Name(int v)
        {
            return this.keys[v];
        }

    }
}
