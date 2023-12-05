using System.Net.Cache;

namespace Form_5
{
    public partial class Form1 : Form
    {
        List<PersonData> peopel;
        public Form1()
        {
            InitializeComponent();
            peopel = new List<PersonData>
            {
                new PersonData {FirsName = "  parham" , LastName="darvishi" , Age = "30"},

            };
            peopelGridViwe.DataSource = peopel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
