using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Models
{
    class ManagementItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }

        public ManagementItem()
        {

        }

        public ManagementItem(String name, Object content, String pathData)
        {
            mName = name;
            mContent = content;
            mPathData = pathData;
        }
        

        private String mName;
        private Object mContent;
        private String mPathData;

        public String Name {
            get { return mName;}
            set { mName = value;}
        }

        public Object Content
        {
            get { return mContent; }
            set { mContent = value; }
        }

        public String Path
        {
            get { return mPathData; }
            set { mPathData = value; }
        }
    }
}
