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
    class ChuyenKhauPage2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelectCongDanViewModel> listCongDan;
        private readonly List<string> listQuanhe;
        private readonly List<int> listIdHoKhau;
        private readonly List<VaiTroSoHoKhauDTO> listVaitro;
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

        public List<string> ListQuanhe
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

        public List<VaiTroSoHoKhauDTO> ListVaitro
        {
            get
            {
                return listVaitro;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ChuyenKhauPage2ViewModel()
        {
            listCongDan = new ObservableCollection<SelectCongDanViewModel>();
            listIdHoKhau = new List<int>();
            listQuanhe = new List<string>();
            listVaitro = new List<VaiTroSoHoKhauDTO>();

            listVaitro = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
            foreach(VaiTroSoHoKhauDTO vt in listVaitro)
            {
                ListQuanhe.Add(vt.TenVaitro);
            }
            
            List<HoKhauDTO> hokhau = Constant.DataTableToList<HoKhauDTO>(new HoKhauDAO().SelectAllHoKhau());
            foreach(HoKhauDTO hk in hokhau)
            {
                listIdHoKhau.Add(hk.Id);
            }

        }


    }

    

   
}
