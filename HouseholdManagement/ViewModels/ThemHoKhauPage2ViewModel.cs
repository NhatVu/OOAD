using DataAcessLayer;
using DTO;
using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.ViewModels
{
    class ThemHoKhauPage2ViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelectHoKhauViewlModel> listHoKhau;
        private readonly List<int> listIdCongDan;
        private readonly List<int> listCmndCongDan;
        private readonly List<string> listHoTenCongDan;
        private readonly List<string> listQuanhe;


        public ObservableCollection<SelectHoKhauViewlModel> ListHoKhau
        {
            get
            {
                return listHoKhau;
            }

            set
            {
                listHoKhau = value;
                OnPropertyChanged();
            }
        }

        public List<int> ListIdCongDan
        {
            get
            {
                return listIdCongDan;
            }
        }

        public List<int> ListCmndCongDan
        {
            get
            {
                return listCmndCongDan;
            }
        }

        public List<string> ListHoTenCongDan
        {
            get
            {
                return listHoTenCongDan;
            }
        }

        public List<string> ListQuanhe
        {
            get
            {
                return listQuanhe;
            }
        }

        

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ThemHoKhauPage2ViewModel()
        {
            listHoKhau = new ObservableCollection<SelectHoKhauViewlModel>();
            listHoKhau.Add(new SelectHoKhauViewlModel());
            listIdCongDan = new List<int>();
            listCmndCongDan = new List<int>();
            listHoTenCongDan = new List<string>();
            listQuanhe = new List<string>();
            List<CongDanDTO> congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanIdNotInHoKhau());
            List<VaiTroSoHoKhauDTO> quanhe = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
            foreach (CongDanDTO cd in congdan)
            {
                listIdCongDan.Add(cd.Id);
                if (cd.Cmnd != 0) listCmndCongDan.Add(cd.Cmnd);
                ListHoTenCongDan.Add(cd.HoTen);  
            }

            foreach (VaiTroSoHoKhauDTO vt in quanhe)
            {
                listQuanhe.Add(vt.TenVaitro);
            }
        }
    }

    

    public class SelectHoKhauViewlModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SelectHoKhauViewlModel()
        {
    
        }

        private string  id;
        private string cmnd;
        private string name;
        private string gioitinh;
        private string ngaysinh;
        private string quanhe;
        private string ghiChu;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
                OnPropertyChanged();
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
                OnPropertyChanged();
            }
        }

        public string Quanhe
        {
            get
            {
                return quanhe;
            }

            set
            {
                quanhe = value;
                OnPropertyChanged();
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
                OnPropertyChanged();
            }
        }
    }
}
