using DTO;
using HouseholdManagement.Models;
using HouseholdManagement.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement
{
    class QuanlyHokhauViewModel
    {

        public QuanlyHokhauViewModel()
        {
            HouseholdItems = new List<HoKhauDTO>();
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
            HouseholdItems.Add(new HoKhauDTO());
        }
        public List<HoKhauDTO> HouseholdItems { get; }

    }
}
