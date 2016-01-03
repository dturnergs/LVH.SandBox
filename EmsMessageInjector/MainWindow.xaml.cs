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

namespace EmsMessageInjector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbEnvironments_Loaded(object sender, RoutedEventArgs e)
        {
            IEnvironments environment = CreateEnvironments();
            GatherEnvironments(environment);
            PopulateEnvironmentComboBox(sender, environment);
        }

        private static void PopulateEnvironmentComboBox(object sender, IEnvironments environment)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = environment;
            comboBox.SelectedIndex = 0;
        }

        private static IEnvironments CreateEnvironments()
        {
            return new Environments();
        }

        private void GatherEnvironments(IEnvironments environments)
        {
            //TODO: Turn this into a foreach read from a property file
            environments.GatherEnvironments("DEV");
            environments.GatherEnvironments("QA");
            environments.GatherEnvironments("CERT");
            environments.GatherEnvironments("PROD");
        }

        private void cbEnvironments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;

            GetAvailableQueues(value);
            PopulateQueuesComboBox(value);
        }

        private void PopulateQueuesComboBox(string value)
        {
            //cbQueues.ItemsSource = queues;
            //Title = "Selected: " + value;
        }

        private void GetAvailableQueues(string value)
        {
            IEnvironments environment = CreateEnvironments();
            environment.GetAvailableQueues(value);
            Console.WriteLine("test");
        }
    }
}
