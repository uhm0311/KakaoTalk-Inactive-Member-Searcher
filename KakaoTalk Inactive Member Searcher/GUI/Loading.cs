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
        private readonly DateTime CriteriaDateTime;

        private readonly KakaoTalkParser Parser;
        private readonly OnLoadedListener Listener;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams temp = base.CreateParams;
                temp.ClassStyle |= 0x200;

                return temp;
            }
        }

        public Loading(DateTime CriteriaDateTime, KakaoTalkParser Parser, OnLoadedListener Listener)
        {
            this.CriteriaDateTime = CriteriaDateTime;

            this.Parser = Parser;
            this.Listener = Listener;

            InitializeComponent();
        }

        private void FormLoad(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                Dictionary<string, DateTime> lastTalk = new Dictionary<string, DateTime>();
                Parser.ParseStart();

                foreach (Talk talk in Parser.Talks)
                {
                    if (!lastTalk.ContainsKey(talk.Name) && talk.State != TalkState.Leave)
                    {
                        lastTalk.Add(talk.Name, talk.Time);
                    }
                    else
                    {
                        if (talk.State == TalkState.Leave)
                        {
                            lastTalk.Remove(talk.Name);
                        } 
                        else if (lastTalk[talk.Name] < talk.Time)
                        {
                            lastTalk[talk.Name] = talk.Time;
                        }
                    }
                }

                Invoke(new MethodInvoker(() =>
                {
                    Listener((from item in lastTalk where item.Value < CriteriaDateTime select item).ToDictionary(x => x.Key, x => x.Value));
                    Close();
                }));
            }))
            { IsBackground = true }.Start();
        }

        public delegate void OnLoadedListener(Dictionary<string, DateTime> inactiveMebers);
    }
}
