using kakaotalk_analyzer.Core;
using System;
using System.Collections.Generic;
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
                Next.Enabled = true;
            }
            else
            {
                Next.Enabled = false;
            }
        }

        private void NextClick(object sender, EventArgs e)
        {
            Loading loading = new Loading(CriteriaDateTimePicker.Value.Date, Parser, (inactiveMemebers) =>
            {
                MainForm form = new MainForm(inactiveMemebers);
                form.FormClosed += (_, __) => Close();
                form.Show();

                Hide();
            });

            loading.ShowDialog();
        }
    }
}
