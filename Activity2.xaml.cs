using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity2()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", position = "President", Image="image1.jpg"});
            employees.Add(new Employee { DisplayName = "John Dee", position = "Vice President", Image = "image2.jpg" });
            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", position = "President", Image = "image1.jpg" });
            employees.Add(new Employee { DisplayName = "John Dee", position = "Vice President", Image = "image2.jpg" });
            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", position = "President", Image = "image1.jpg" });
        }
    }
}