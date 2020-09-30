using System;

namespace prjAspNetMvc.Controllers
{
    internal class CLotto
    {
        public CLotto()
        {
        }

        internal string getNumbers()
        {
            Random r = new Random();
            int[] ar = new int[6];
            int count = 0;
            while (count <6)
            {
                int temp = r.Next(1, 50);
                if (!isSelected(temp,ar))
                {
                    ar[count] = temp;
                    count++;
                }
            }

            for(int i = 0; i < ar.Length; i++)
            {
                for(int j =0;j < ar.Length - 1; j++)
                {
                    if (ar[j + 1] < ar[j])
                    {
                        int big = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j+1] = big;

                    }
                }
            }
            string s = "";
            foreach (int i in ar)
            {
                s +=i.ToString() + " ";
            }
            return s;
        }

        private bool isSelected(int temp, int[] ar)
        {
            foreach (int i in ar)
            {
                if (i == temp)
                {
                    return true;
                }
            }
            return false;
        }
    }
}