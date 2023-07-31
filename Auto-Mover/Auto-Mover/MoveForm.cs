namespace Auto_Mover
{
    public partial class MoveForm : Form
    {
        private readonly MouseMoverService _mouseMoverService;
        public MoveForm()
        {
            InitializeComponent();
            _mouseMoverService = new MouseMoverService();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.MoveTimer.Start();
        }

        private void MoveTimer_Tick(object? sender, EventArgs e)
        {
            _mouseMoverService.MoveMouse();
        }
    }
}