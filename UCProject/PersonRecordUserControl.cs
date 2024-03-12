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
    [DefaultEvent(nameof(Click))]
    public partial class PersonRecordUserControl : UserControl
    {
        public PersonRecordUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new event EventHandler? Click
        {
            add
            {
                buttonEdit.Click += value;
                buttonDelete.Click += value;
            }
            remove
            {
                buttonEdit.Click -= value;
                buttonDelete.Click -= value;
            }
        }

        [Browsable(true)]
        public string Id
        {
            get => userId.Text;
            set => userId.Text = value;
        }

        [Browsable(true)]
        public string Surname
        {
            get => userSurname.Text;
            set => userSurname.Text = value;
        }

        [Browsable(true)]
        public string FirstName
        {
            get => userName.Text;
            set => userName.Text = value;
        }

        [Browsable(true)]
        public string Patronymic
        {
            get => userPatronymic.Text;
            set => userPatronymic.Text = value;
        }

        [Browsable(true)]
        public string Age
        {
            get => userAge.Text;
            set => userAge.Text = value;
        }
    }
}
