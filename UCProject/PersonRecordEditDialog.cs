using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCProject
{
    public partial class PersonRecordEditDialog : Form
    {
        public PersonRecordEditDialog(PersonRecordUserControl user)
        {
            InitializeComponent();
            Id = user.Id;
            FirstName = user.FirstName;
            Surname = user.Surname;
            Patronymic = user.Patronymic;
            Age = user.Age;
        }

        public string Id
        {
            get => txbId.Text;
            set => txbId.Text = value;
        }

        public string Surname
        {
            get => txbSurname.Text;
            set => txbSurname.Text = value;
        }

        public string FirstName
        {
            get => txbName.Text;
            set => txbName.Text = value;
        }

        public string Patronymic
        {
            get => txbPatronymic.Text;
            set => txbPatronymic.Text = value;
        }

        public string Age
        {
            get => txbAge.Text;
            set => txbAge.Text = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(Id != "" && FirstName != "" && Surname != "" && Patronymic != "" && Age != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
