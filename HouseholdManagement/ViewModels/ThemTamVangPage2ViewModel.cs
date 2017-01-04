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
    class ThemTamVangPage2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelectTamVangViewlModel> listTamTru;
        private readonly List<int> listIdCongDan;
        private readonly List<int> listCmndCongDan;
        private readonly List<string> listHoTenCongDan;


        public ObservableCollection<SelectTamVangViewlModel> ListTamTru
        {
            get
            {
                return listTamTru;
            }

            set
            {
                listTamTru = value;
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





        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ThemTamVangPage2ViewModel()
        {
            listTamTru = new ObservableCollection<SelectTamVangViewlModel>();
            listTamTru.Add(new SelectTamVangViewlModel());
            listIdCongDan = new List<int>();
            listCmndCongDan = new List<int>();
            listHoTenCongDan = new List<string>();

            List<CongDanDTO> congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectAllCongDan());
            foreach (CongDanDTO cd in congdan)
            {
                listIdCongDan.Add(cd.Id);
                if (cd.Cmnd != 0) listCmndCongDan.Add(cd.Cmnd);
                ListHoTenCongDan.Add(cd.HoTen);
            }
        }
    }



    public class SelectTamVangViewlModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SelectTamVangViewlModel()
        {

        }

        private string id;
        private string cmnd;
        private string name;
        private string gioitinh;
        private string ngaysinh;
        private string quequan;
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

        public string QueQuan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
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