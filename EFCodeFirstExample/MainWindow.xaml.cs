using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EFCodeFirstExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolDBEntities db;
        public MainWindow()
        {
            InitializeComponent();

            db = new SchoolDBEntities();
            
        }

        void LoadStandards()
        {
            cmbStandard.ItemsSource = db.Standards.ToList();

            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            grdStudents.ItemsSource = db.Students.ToList();
        }
    }
}