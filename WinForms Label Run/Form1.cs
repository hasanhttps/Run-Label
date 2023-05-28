namespace WinForms_Label_Run {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e) {
            Label? label = sender as Label;
            label.Location = new Point(Random.Shared.Next(0, 500), Random.Shared.Next(0, 500));
        }
        private void label1_MouseHover(object sender, EventArgs e) {
            Label? label = sender as Label;
            label.Location = new Point(Random.Shared.Next(0, 500), Random.Shared.Next(0, 500));
        }
        
    }
}