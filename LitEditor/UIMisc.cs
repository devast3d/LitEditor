using System;
using System.Windows.Forms;

namespace LitEditor
{
    public static class UIMisc
    {
        public static bool ShowFileDialog(string filter, out string filePath)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                return true;
            }

            filePath = string.Empty;
            return false;
        }

        public static bool ShowLitFileDialog(out string filePath)
        {
            return ShowFileDialog("Dark Omen Lights (*.LIT)|*.LIT|All files (*.*)|*.*", out filePath);
        }
    }
}
