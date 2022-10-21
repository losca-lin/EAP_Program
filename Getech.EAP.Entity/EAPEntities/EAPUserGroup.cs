using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity
{
    public class EAPUserGroup : INotifyPropertyChanged
    {
        public EAPUserGroup() { }
        public string GroupID { get; set; }
        public string MainMenu { get; set; }
        public string SubMenu { get; set; }
        public string SubMenuENG { get; set; }

        private bool ismenuenable;
        public bool IsMenuEnable
        {
            get
            {
                return ismenuenable;
            }
            set
            {
                ismenuenable = value;
                OnPropertyChanged("IsMenuEnable");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
