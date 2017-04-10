using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProductivityPack.Factories
{
    public static class DialogBoxFactory
    {
        public static DialogResult ShowErrorDialog(string caption, string message)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestionDialog(string caption, string message)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public static DialogResult ShowWarningDialog(string caption, string message)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
    }
}
