using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SetParams2
{
    public class BasicResources : INotifyPropertyChanged
    {
        private List<string> _copyThisList;
        public List<string> CopyThisList
        {
            get { return _copyThisList; }
            set
            {
                if (this._copyThisList == value) return;
                this._copyThisList = value;
                NotifyPropertyChanged("CopyThisList");
            }
        }
        private string _destDir;

        public string DestDir
        {
            get { return _destDir; }
            set
            {
                if (this._destDir == value) return;
                this._destDir = value;
                NotifyPropertyChanged("DestDir");
            }
        }
        private bool _listChanged;

        public bool IsListChanged
        {
            get { return _listChanged; }
            set
            {
                if (_listChanged == value) return;
                _listChanged = value;
                NotifyPropertyChanged("IsListChanged");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
