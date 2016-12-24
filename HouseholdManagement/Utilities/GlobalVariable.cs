using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Utilities
{
    static class GlobalVariable
    {
        private static int mCurrentCongAnId;

        public static int CurrentCongAnId
        {
            get
            {
                return mCurrentCongAnId;
            }
            set
            {
                mCurrentCongAnId = value;
            }
        }
    }
}
