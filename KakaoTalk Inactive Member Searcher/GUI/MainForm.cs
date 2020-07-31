using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KIMS.GUI
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, DateTime> InactiveMembers;

        public MainForm(Dictionary<string, DateTime> InactiveMembers)
        {
            this.InactiveMembers = InactiveMembers;
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, DateTime> pair in InactiveMembers)
            {
                Result.Rows.Add(pair.Key, pair.Value.ToString());
            }

            Result.Sort(Result.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
