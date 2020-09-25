using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KIMS.GUI
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, Tuple<DateTime, int>> Talks;

        public MainForm(Dictionary<string, Tuple<DateTime, int>> Talks)
        {
            this.Talks = Talks;
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Tuple<DateTime, int>> pair in Talks)
            {
                Result.Rows.Add(pair.Key, pair.Value.Item1, pair.Value.Item2);
            }

            Result.Sort(Result.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
