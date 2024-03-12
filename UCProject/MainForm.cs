namespace UCProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl newControl = new PersonRecordUserControl();
            usersPanel.Controls.Add(newControl);
            newControl.Click += newControl_Click;
            usersAmount.Text = usersPanel.Controls.Count.ToString();
            ageSum.Text = FindAgeSum();
        }

        private void newControl_Click(object sender, EventArgs e)
        {
            var thisUC = (PersonRecordUserControl)((Control)sender).Parent;
            if (((Button)sender).Name == "buttonEdit")
            {
                PersonRecordEditDialog window = new PersonRecordEditDialog(thisUC);
                window.ShowDialog();
                if (window.DialogResult == DialogResult.OK)
                {
                    thisUC.Id = window.Id;
                    thisUC.FirstName = window.FirstName;
                    thisUC.Surname = window.Surname;
                    thisUC.Patronymic = window.Patronymic;
                    thisUC.Age = window.Age;
                    usersAmount.Text = usersPanel.Controls.Count.ToString();
                    ageSum.Text = FindAgeSum();
                }
                else
                {
                    MessageBox.Show("Вы заполнили не все поля");
                }
            }
            else
            {
                usersPanel.Controls.Remove(thisUC);
                usersAmount.Text = usersPanel.Controls.Count.ToString();
                ageSum.Text = FindAgeSum();
            }
            
        }

        private string FindAgeSum()
        {
            int sum = 0;
            foreach (var control in usersPanel.Controls)
            {
                if (int.TryParse(((PersonRecordUserControl)control).Age, out int age))
                {
                    sum += age;
                }
            }
            return sum.ToString();
        }
    }
}