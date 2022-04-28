using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewGroup
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ConsoleGroup> ConsoleList { get; set; } = new ObservableCollection<ConsoleGroup>();
        public MainPage()
        {
            InitializeComponent();
            ConsoleList.Add(new ConsoleGroup("Sony", new[]
            {
                new Console
                {
                    Title = "PlayStation 5",
                    Price = 3000
                },
                new Console
                {
                    Title = "PlayStation 4",
                    Price = 2500
                }
            }));
            ConsoleList.Add(new ConsoleGroup("Microsoft", new[]
            {
                new Console
                {
                    Title = "Xbox 360",
                    Price = 3000
                },
                new Console
                {
                    Title = "Xbox one",
                    Price = 2500
                }
            }));
            ConsoleList.Add(new ConsoleGroup("Nintendo", new[]
            {
                new Console
                {
                    Title = "Nindendo Wii",
                    Price = 3000
                },
                new Console
                {
                    Title = "Nintendo Switch",
                    Price = 2500
                }
            }));
            BindingContext = this;
        }
    }
}
