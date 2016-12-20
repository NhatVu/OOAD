using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Models
{
    class ManagementItem
    {

        public ManagementItem()
        {

        }

        public ManagementItem(String name, Object content, String pathData, String detail)
        {
            mName = name;
            mContent = content;
            mPathData = pathData;
            mDetail = detail;
        }
        

        private String mName;
        private Object mContent;
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
