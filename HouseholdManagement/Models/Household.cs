using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Models
{
    class Household 
    {


        private String mId;
        private String mName;
        private String mAddress;
        private String mDateTime;
        private String mDetailId;

        public Household()
        {

        }

        public Household(String id, String name, String address, String datetime, String detailId)
        {
            mId = id;
            mName = name;
            mAddress = address;
            mDateTime = datetime;
            mDetailId = detailId;
        }

        public String Id { get { return mId;} set { mId = value;} }

        public String Name { get { return mName; } set { mName = value; } }
        public String Address { get { return mAddress; } set { mAddress = value; } }
        public String DateTime { get { return mDateTime; } set { mDateTime = value; } }
        public String DetailId { get { return mDetailId; } set { mDetailId = value; } }





    }
}
