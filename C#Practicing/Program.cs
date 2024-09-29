using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practicing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "azzxzy";
            Console.WriteLine(ShortenString(s));
            Console.ReadLine();
        }


        static String ShortenString(String s) { 
        
        Stack <char> st = new Stack<char>();

         int i = 0;
            while (i < s.Length) {
                if (st.Count == 0 || (st.Count != 0 && s[i] != st.Peek()))
                {
                    st.Push(s[i]);
                    i++;
                }
              
                else
                {
                    if (st.Count != 0)
                        st.Pop();
                        i++;
                }
                    
                    
            }

            if (st.Count == 0)
            {
                return ("Empty String");
            }
            else
            {
                String short_string = "";
                while(st.Count !=0)
                {
                    short_string += st.Peek();
                    st.Pop() ;
                }
                return (short_string);
            }

        }

      

    }
}
