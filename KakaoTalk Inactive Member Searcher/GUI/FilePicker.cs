using kakaotalk_analyzer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KIMS.GUI
{
    public partial class FilePicker : Form
    {
        private KakaoTalkParser Parser;

        public FilePicker()
        {
            InitializeComponent();
        }

        private void PathFinderClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Parser = new KakaoTalkParser(Path.Text = dialog.FileName);
                CriteriaDateTimePicker.Enabled = true;
            }
        }

        private void CriteriaDateTimePickerValueChanged(object sender, EventArgs e)
        {
            DateTime criteriaDateTime = CriteriaDateTimePicker.Value;
            
            if (criteriaDateTime < DateTime.Today)
            {
                Inactive.Enabled = true;
            }
            else
            {
                Inactive.Enabled = false;
            }

            if (criteriaDateTime > DateTime.Today)
            {
                Active.Enabled = false;
            }
            else
            {
                Active.Enabled = true;
            }
        }

        private void IactiveClick(object sender, EventArgs e)
        {
            ShowLoadingDialog((_) => true, (time) => time < CriteriaDateTimePicker.Value.Date);
        }

        private void ActiveClick(object sender, EventArgs e)
        {
            bool Comparator(DateTime time) => time >= CriteriaDateTimePicker.Value.Date;

            ShowLoadingDialog(Comparator, Comparator);
        }

        private void ShowLoadingDialog(Func<DateTime, bool> Comparator1, Func<DateTime, bool> Comparator2)
        {
            Loading loading = new Loading(() =>
            {
                Dictionary<string, Tuple<DateTime, int>> talks = new Dictionary<string, Tuple<DateTime, int>>();
                Parser.ParseStart();

                foreach (Talk talk in Parser.Talks)
                {
                    if (!talks.ContainsKey(talk.Name) && talk.State != TalkState.Leave)
                    {
                        talks.Add(talk.Name, new Tuple<DateTime, int>(talk.Time, 0));
                    }
                    else if (Comparator1(talk.Time))
                    {
                        if (talk.State == TalkState.Leave)
                        {
                            talks.Remove(talk.Name);
                        }
                        else if (talks[talk.Name].Item1 < talk.Time)
                        {
                            talks[talk.Name] = new Tuple<DateTime, int>(talk.Time, talks[talk.Name].Item2 + 1);
                        }
                    }
                }

                Invoke(new MethodInvoker(() =>
                {
                    MainForm form = new MainForm((from item in talks where Comparator2(item.Value.Item1) select item).ToDictionary(x => x.Key, x => x.Value));
                    form.FormClosed += (_, __) => Close();
                    form.Show();

                    Hide();
                }));
            });

            loading.ShowDialog();
        }
    }
}
