namespace WinForms2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenNeedPanel(MenuP);
        }

        private void OpenNeedPanel(Panel panel)
        {
            QuestionsP.Visible = false;
            MenuP.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void QuestionsB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsP);
        }

        private void GoToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP);
        }
    }
}
