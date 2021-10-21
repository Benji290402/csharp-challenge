using System;
namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            char[] a = str.ToCharArray();
            Array.Reverse(a);

            return new string(a);
        }
    }
}