using System;
using System.Linq;
using System.Windows;
using System.ComponentModel;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class CustomEventProvider {
        static readonly Random Rnd = new Random();
        static string[] Users = new string[] {"Peter Dolan", "Ryan Fischer", "Andrew Miller",
                                            "Tom Hamlett", "Jerry Campbell", "Carl Lucas",
                                            "Mark Hamilton", "Steve Lee"};

        public static BindingList<CustomEvent> GetCustomEvents() {
            BindingList<CustomEvent> result = new BindingList<CustomEvent>();
            int count = Users.Count();
            for (int i = 0; i < count; i++) {
                string subjPrefix = Users[i] + "'s ";
                result.Add(CreateEvent(subjPrefix + "meeting",  2, 5));
                result.Add(CreateEvent(subjPrefix + "travel", 3, 6));
                result.Add(CreateEvent(subjPrefix + "phone call", 0, 10));
            }
            return result;
        }

        static CustomEvent CreateEvent(string subject, int status, int label) {
            CustomEvent apt = new CustomEvent();
            apt.Subject = subject;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(Rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(Rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
    }
}
