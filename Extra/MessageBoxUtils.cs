namespace FilterGenerator.Extra
{
    public static class MessageBoxUtils
    {
        public static void CreateErrorMessageBox(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void CreateInfoMessageBox(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void CreateWarningMessageBox(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
    }
}