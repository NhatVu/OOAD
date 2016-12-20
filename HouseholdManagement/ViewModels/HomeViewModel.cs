using HouseholdManagement.Models;
using HouseholdManagement.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement
{
    class HomeViewModel
    {
        private readonly static String QUANLY_HOKHAU_PATH_DATA = "M10,20V14H14V20H19V12H22L12,3L2,12H5V20H10Z";
        private readonly static String QUANLY_TAMTRU_PATH_DATA = "M13,12H20V13.5H13M13,9.5H20V11H13M13,14.5H20V16H13M21,4H3A2,2 0 0,0 1,6V19A2,2 0 0,0 3,21H21A2,2 0 0,0 23,19V6A2,2 0 0,0 21,4M21,19H12V6H21";
        private readonly static String QUANLY_TAMVANG_PATH_DATA = "M17.12,10L16.04,8.18L15.31,11.05L17.8,15.59V22H16V17L13.67,13.89L12.07,18.4L7.25,20.5L6.2,19L10.39,16.53L12.91,6.67L10.8,7.33V11H9V5.8L14.42,4.11L14.92,4.03C15.54,4.03 16.08,4.37 16.38,4.87L18.38,8.2H22V10H17.12M17,3.8C16,3.8 15.2,3 15.2,2C15.2,1 16,0.2 17,0.2C18,0.2 18.8,1 18.8,2C18.8,3 18,3.8 17,3.8M7,9V11H4A1,1 0 0,1 3,10A1,1 0 0,1 4,9H7M9.25,13L8.75,15H5A1,1 0 0,1 4,14A1,1 0 0,1 5,13H9.25M7,5V7H3A1,1 0 0,1 2,6A1,1 0 0,1 3,5H7Z";
        private readonly static String THONGKE_PATH_DATA = "M5,4H19A2,2 0 0,1 21,6V18A2,2 0 0,1 19,20H5A2,2 0 0,1 3,18V6A2,2 0 0,1 5,4M5,8V12H11V8H5M13,8V12H19V8H13M5,14V18H11V14H5M13,14V18H19V14H13Z";
        private readonly static String THONGTIN_PATH_DATA = "M12,13C9.33,13 4,14.33 4,17V20H20V17C20,14.33 14.67,13 12,13M12,4A4,4 0 0,0 8,8A4,4 0 0,0 12,12A4,4 0 0,0 16,8A4,4 0 0,0 12,4M12,14.9C14.97,14.9 18.1,16.36 18.1,17V18.1H5.9V17C5.9,16.36 9,14.9 12,14.9M12,5.9A2.1,2.1 0 0,1 14.1,8A2.1,2.1 0 0,1 12,10.1A2.1,2.1 0 0,1 9.9,8A2.1,2.1 0 0,1 12,5.9Z";
        private readonly static String THAY_MATKHAU_PATH_DATA = "M11,10V12H10V14H8V12H5.83C5.42,13.17 4.31,14 3,14A3,3 0 0,1 0,11A3,3 0 0,1 3,8C4.31,8 5.42,8.83 5.83,10H11M3,10A1,1 0 0,0 2,11A1,1 0 0,0 3,12A1,1 0 0,0 4,11A1,1 0 0,0 3,10M16,14C18.67,14 24,15.34 24,18V20H8V18C8,15.34 13.33,14 16,14M16,12A4,4 0 0,1 12,8A4,4 0 0,1 16,4A4,4 0 0,1 20,8A4,4 0 0,1 16,12Z";
        private readonly static String DANGXUAT_PATH_DATA = "M7,12L12,7V10H16V14H12V17L7,12M22,12A10,10 0 0,1 12,22A10,10 0 0,1 2,12A10,10 0 0,1 12,2A10,10 0 0,1 22,12M20,12A8,8 0 0,0 12,4A8,8 0 0,0 4,12A8,8 0 0,0 12,20A8,8 0 0,0 20,12Z";

        private readonly static String QLHK_STRING = "Quản lý hộ khẩu";
        private readonly static String QLTT_STRING = "Quản lý tạm trú";
        private readonly static String QLTV_STRING = "Quản lý tạm vắng";
        private readonly static String TK_STRING = "Thống kê";

        private readonly static String QLHK_STRING_DETAIL = "Danh sách sổ hộ khẩu";
        private readonly static String QLTT_STRING_DETAIL = "Danh sách giấy tạm trú";
        private readonly static String QLTV_STRING_DETAIL = "Danh sách giấy tạm vắng";
        private readonly static String THONGKE_DETAIL = "Danh sách thống kê";

        private readonly static String THONGTIN_STRING = "Thông tin tài khoản";
        private readonly static String DOIMATKHAU_STRING = "Thay đổi mật khẩu";
        private readonly static String DANGXUAT_STRING = "Đăng xuất";

        private readonly static String THONGTIN_STRING_DETAIL = "Thông tin tài khoản";
        private readonly static String DOIMATKHAU_STRING_DETAIL = "Thay đổi mật khẩu";
        public HomeViewModel()
        {
            ManagementItems = new[]
            {
                new ManagementItem(QLHK_STRING,QuanlyHokhau.createInstance(),QUANLY_HOKHAU_PATH_DATA,QLHK_STRING_DETAIL),
                new ManagementItem(QLTT_STRING,QuanlyTamTru.createInstance(),QUANLY_TAMTRU_PATH_DATA, QLTT_STRING_DETAIL),
                new ManagementItem(QLTV_STRING,QuanlyTamVang.createInstance(),QUANLY_TAMVANG_PATH_DATA, QLTV_STRING_DETAIL),
                new ManagementItem(TK_STRING,Thongke.createInstance(),THONGKE_PATH_DATA, THONGKE_DETAIL)
            };

            ProfileItems = new[]
            {
                new ManagementItem(THONGTIN_STRING, ProfileOverview.createInstance(), THONGTIN_PATH_DATA, THONGTIN_STRING_DETAIL),
                new ManagementItem(DOIMATKHAU_STRING, ChangePassword.createInstance(), THAY_MATKHAU_PATH_DATA, DOIMATKHAU_STRING_DETAIL),
                new ManagementItem(DANGXUAT_STRING, null, DANGXUAT_PATH_DATA,null)
            };
        }

        public ManagementItem[] ManagementItems { get; }
        public ManagementItem[] ProfileItems { get; }
    }
}
