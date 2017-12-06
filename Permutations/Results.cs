using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Permutations
{
    public partial class Results : Form
    {
        int Number;
        List<string> list = new List<string>();
        object locker = new object();

        public Results(int input)
        {
            InitializeComponent();
            Number = input;
            
            #region ShowThePermutation
            StringBuilder sb = new StringBuilder();
            Int64 result = 1;
            sb.Append($"{Number}! = ");
            for (int i = Number; i > 0; i--)
            {
                result *= i;
                sb.Append($"{i}x");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append($" = {result}");
            lblResult.Text = sb.ToString();
            #endregion
        }

        #region Heap's_Algorithm
        void Permute(int[] A, int n)
        {
            lock (locker)
            {
                if (n == 1)
                {
                    SaveArray(A);
                }
                else
                {
                    Permute(A, n - 1);
                    for (int i = 0; i < n - 1; i++)
                    {
                        Swap(A, n % 2 == 0 ? i : 0, n - 1);
                        SaveArray(A);
                        Permute(A, n - 1);
                    }
                }
            }
        }


        int[] Swap(int[] A, int x, int y)
        {
            int temp;
            temp = A[x];
            A[x] = A[y];
            A[y] = temp;

            return A;
        }

        void SaveArray(int[] A)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in A)
            {
                sb.Append(x);
            }
            if (list.Contains(sb.ToString())) return;
            list.Add(sb.ToString());
            list.Add(string.Empty);
        }
        #endregion

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            lblText.Text = "Generating...";
            btnProcess.Enabled = false;
            var P = new int[Number];
            for (int i = 0; i < Number; i++)
            {
                P[i] = i + 1;
            }
            await Task.Factory.StartNew(() => Permute(P,Number),TaskCreationOptions.LongRunning);
            lbResults.Items.AddRange(list.ToArray());
            SaveToFile(list);
            lblText.Text = "Done!";
            btnProcess.Enabled = true;
        }

        void SaveToFile(List<string> data)
        {
            using (var sw = new StreamWriter("../../../PermutationsData.txt",false))
            {
                foreach (var item in data)
                {
                    sw.WriteLine(item);
                }
            }
        }
    }
}
