using System.Security.Cryptography.X509Certificates;

namespace Structures
{

    struct Book
    {
        public string title;
        public string author;
        public int year;
    }


    public partial class frmStrac : Form
    {

        Book mybook;

        public frmStrac()
        {
            InitializeComponent();
        }

        private void btnsaveandshow_Click(object sender, EventArgs e)
        {
            mybook.title= txttitle.Text.ToString();
            mybook.author= txtauthor.Text.ToString();
            mybook.year = int.Parse(txtyear.Text.ToString());

            MessageBox.Show(mybook.title + " is written by " + mybook.author + " in " +mybook.year.ToString());
        }
    }
}
