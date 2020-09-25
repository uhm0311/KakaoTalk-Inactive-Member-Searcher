using kakaotalk_analyzer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KIMS.GUI
{
    public partial class Loading : Form
    {
        private readonly ThreadStart threadStart;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams temp = base.CreateParams;
                temp.ClassStyle |= 0x200;

                return temp;
            }
        }

        public Loading(ThreadStart threadStart)
        {
            this.threadStart = threadStart;

            InitializeComponent();
        }

        private void FormLoad(object sender, System.EventArgs e)
        {
            new Thread(() =>
            {
                threadStart.Invoke();
                Invoke(new MethodInvoker(() => Close()));
            })
            { IsBackground = true }.Start();
        }

        public delegate void OnLoadedListener(Dictionary<string, DateTime> inactiveMebers);
    }
}
