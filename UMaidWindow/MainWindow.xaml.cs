using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using DAL;

namespace UMaidWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Window Fields 
        List<Model.Person> persons = new List<Model.Person>();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            persons.Clear();

            using (UMAIDEntities entities = new UMAIDEntities())
            {
                var dataFromSQL = from o in entities.Persons
                                  select o;

                foreach (var o in dataFromSQL)
                {
                    Model.Person mPerson = new Model.Person();
                    mPerson.FName = o.FName;
                    mPerson.LName = o.LName;
                    mPerson.PersonID = o.personID;

                    persons.Add(mPerson);
                }
            }

            lbNames.ItemsSource = persons.OrderBy(c => c.LName).ThenBy(c => c.FName).ToList();
        }

    }
}
