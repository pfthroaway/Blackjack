using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace Blackjack
{
    internal static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        /// <summary>
        /// Creates a random number generator based on this thread.
        /// </summary>
        internal static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    internal static class MyExtensions
    {
        /// <summary>
        /// Shuffles a List.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="list">List name</param>
        internal static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    internal static class Int32Helper
    {
        /// <summary>
        /// Utilizes int.TryParse to easily Parse an Integer.
        /// </summary>
        /// <param name="text">Text to be parsed</param>
        /// <returns></returns>
        internal static int Parse(string text)
        {
            int temp = 0;
            int.TryParse(text, out temp);
            return temp;
        }

        /// <summary>
        /// Utilizes int.TryParse to easily Parse an Integer.
        /// </summary>
        /// <param name="dbl">Double to be parsed</param>
        /// <returns>Parsed integer</returns>
        internal static int Parse(double dbl)
        {
            int temp = 0;
            try
            {
                temp = (int)dbl;
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Sulimn", MessageBoxButton.OK); }

            return temp;
        }
    }
}