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
using System.Windows;

namespace HouseholdManagement.ViewModels
{
    class ChuyenKhauPage1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelectCongDanViewModel> listCongDan;
        private readonly List<VaiTroSoHoKhauDTO> listQuanhe;
        private readonly List<int> listIdHoKhau;
        private bool? isAllItemSelected;

        public bool? IsAllItemSelected
        {
            get
            {
                if (listCongDan != null && listCongDan.Count == 0)
                    return false;



                return isAllItemSelected;
            }

            set
            {
                if (isAllItemSelected == value) return;
               
                isAllItemSelected = value;
                
                if (isAllItemSelected.HasValue)
                    SelectAll(isAllItemSelected.Value, listCongDan);

                OnPropertyChanged();
            }
        }

        private void SelectAll(bool select, IEnumerable<SelectCongDanViewModel> models)
        {
            
            foreach (var model in models)
            {
                model.IsSelected = select;
            }
        }


        public ObservableCollection<SelectCongDanViewModel> ListCongDan
        {
            get
            {
                return listCongDan;
            }

            set
            {
                listCongDan = value;
                OnPropertyChanged();
            }
        }

        public List<VaiTroSoHoKhauDTO> ListQuanhe
        {
            get
            {
                return listQuanhe;
            }
        }

        public List<int> ListIdHoKhau
        {
            get
            {
                return listIdHoKhau;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ChuyenKhauPage1ViewModel()
        {
            listCongDan = new ObservableCollection<SelectCongDanViewModel>();
            listIdHoKhau = new List<int>();
            listQuanhe = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
            

            List<HoKhauDTO> hokhau = Constant.DataTableToList<HoKhauDTO>(new HoKhauDAO().SelectAllHoKhau());
            foreach(HoKhauDTO hk in hokhau)
            {
                listIdHoKhau.Add(hk.Id);
            }

        }


    }

    

    public class SelectCongDanViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SelectCongDanViewModel()
        {
    
        }

        private string id;
        private string cmnd;
        private string name;
        private string gioitinh;
        private string ngaysinh;
        private string quanhe;
        private string ghiChu;
        private bool isSelected;

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

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }

            set
            {
                isSelected = value;
                OnPropertyChanged();
            }
        }
    }
}
