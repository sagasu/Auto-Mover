namespace Auto_Mover
{
    public partial class MoveForm : Form
    {
        private MouseMoverService mouseMoverService;
        public MoveForm()
        {
            InitializeComponent();
            mouseMoverService = new MouseMoverService();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.MoveTimer.Start();
        }

        private void MoveTimer_Tick(object? sender, EventArgs e)
        {
            mouseMoverService.MoveMouse();
        }
    }
}