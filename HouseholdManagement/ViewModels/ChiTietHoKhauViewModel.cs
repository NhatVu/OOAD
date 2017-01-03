using DataAcessLayer;
using DTO;
using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HouseholdManagement.Utilities;

namespace HouseholdManagement.ViewModels
{
    class ChiTietHoKhauViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<SelectHoKhauViewlModel> lisChiTiettHoKhau;
        private readonly List<string> listQuanhe;
        


        public List<SelectHoKhauViewlModel> ListChiTietHoKhau
        {
            get
            {
                return lisChiTiettHoKhau;
            }

            set
            {
                lisChiTiettHoKhau = value;
            }
        }


        public List<string> ListQuanhe
        {
            get
            {
                return listQuanhe;
            }
            
        }

        public Dictionary<int, int> MapCongDanIdToChiTietHoKhauId { get; set; }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ChiTietHoKhauViewModel(int hoKhauId)
        {
            MapCongDanIdToChiTietHoKhauId = new Dictionary<int, int>();
            DataTable chiTietHoKhauSource = new ChiTietHoKhauDAO().GetByHoKhauId(hoKhauId);
            foreach (DataRow row in chiTietHoKhauSource.Rows)
            {
                int congDanId = Int32.Parse(row["id"].ToString());
                int ChiTietHoKhauId = Int32.Parse(row["chiTietHoKhauId"].ToString());
                MapCongDanIdToChiTietHoKhauId.Add(congDanId, ChiTietHoKhauId);

            }
            lisChiTiettHoKhau = Constant.DataTableToList<SelectHoKhauViewlModel>(chiTietHoKhauSource);
            foreach (SelectHoKhauViewlModel current in lisChiTiettHoKhau)
            {
                if (Int32.Parse(current.Gioitinh) == 0)
                    current.Gioitinh = "Nữ";
                else current.Gioitinh = "Nam";

                DateTime dt = DateTime.Parse(current.Ngaysinh);
                current.Ngaysinh = dt.ToString("dd/MM/yyyy");
            }
            listQuanhe = new List<string>();
            List<VaiTroSoHoKhauDTO> quanhe = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());

            foreach (VaiTroSoHoKhauDTO vt in quanhe)
            {
                listQuanhe.Add(vt.TenVaitro);
            }
        }
    }

}
