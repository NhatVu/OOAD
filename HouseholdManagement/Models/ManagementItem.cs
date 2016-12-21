using HouseholdManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Models
{
    class ManagementItem :INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged.Invoke(this, args);
        }


        public ManagementItem()
        {

        }

        public ManagementItem(String name, IInstance content, String pathData, String detail)
        {
            mName = name;
            mContent = content;
            mPathData = pathData;
            mDetail = detail;
        }
        

        private String mName;
        private IInstance mContent;
        private String mPathData;
        private String mDetail;

        public String Name {
            get { return mName;}
            set { mName = value;}
        }

        public String Detail
        {
            get { return mDetail; }
            set { mDetail = value; }
        }

        public Object Content
        {
            get
            {
                return mContent.getInstance();
            }

            set { mContent = (IInstance)value; }
        }

        public String Path
        {
            get { return mPathData; }
            set { mPathData = value; }
        }
    }
}
