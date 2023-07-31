namespace Auto_Mover
{
    partial class MoveForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Auto Move";


            this.StartButton = new System.Windows.Forms.Button();
            this.StartButton.Location = new System.Drawing.Point(150, 149);
            this.StartButton.Text = "Start";
            this.StartButton.Size = new System.Drawing.Size(268, 145);
            this.StartButton.TabIndex = 0;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += StartButton_Click;

            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);

            this.Controls.Add(this.StartButton);
        }

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer MoveTimer;

        #endregion
    }
}