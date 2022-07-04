using System.Collections.Generic;

namespace CheckParantesisAssessment
{
    public static class Common
    {
        public static bool IsMatchingPair(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }

        public static bool AreBracketsBalanced(char[] exp)
        {
            var st = new Stack<char>();

            for (var i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    st.Push(exp[i]);

                if (exp[i] == '}' || exp[i] == ')'
                    || exp[i] == ']')
                {

                    if (st.Count == 0)
                    {
                        return false;
                    }

                    else if (!IsMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            if (st.Count == 0)
                return true;
            else
            {
                return false;
            }
        }
    }
}
