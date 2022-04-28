using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewGroup
{
    public class ConsoleGroup : ObservableCollection<Console>
    {
        public string Name { get; private set; }
        public ConsoleGroup(string name):base()
        {
            Name = name;
        }
        public ConsoleGroup(string name, IEnumerable<Console> source):base(source)
        {
            Name = name;
        }
    }
}
