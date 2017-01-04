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
    class ThemTamTruPage2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelectTamTruViewlModel> listTamTru;
        public ObservableCollection<SelectTamTruViewlModel> ListTamTru
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ThemTamTruPage2ViewModel(int id)
        {
            listTamTru = new ObservableCollection<SelectTamTruViewlModel>();

            List<TomTatBanThanDTO> tomtat = Constant.DataTableToList<TomTatBanThanDTO>(new TomTatBanThanDAO().SelectTomTatBanThanByCongDanId(id));
            if (tomtat.Count > 0)
                foreach (TomTatBanThanDTO tt in tomtat)
                {
                    SelectTamTruViewlModel model = new SelectTamTruViewlModel();
                    model.IdCongDan = tt.IdCongdan+"";
                    model.NgayBatDau = tt.NgayBatdau.ToString("dd/MM/yyyy");
                    model.NgayKetThuc = tt.NgayKetthuc.ToString("dd/MM/yyyy");
                    model.ChoO = tt.ChoO;
                    model.GhiChu = tt.Ghichu;
                    model.NgheNghiep = tt.Nghenghiep;
                    listTamTru.Add(model);
                }


        }
    }



    public class SelectTamTruViewlModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SelectTamTruViewlModel()
        {

        }
        private string idCongDan;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string choO;
        private string ngheNghiep;
        private string ghiChu;



        public string IdCongDan
        {
            get
            {
                return idCongDan;
            }

            set
            {
                idCongDan = value;
            }
        }

        public string NgayBatDau
        {
            get
            {
                return ngayBatDau.Substring(0,10);
            }

            set
            {
                ngayBatDau = value;
                OnPropertyChanged();
            }
        }

        public string NgayKetThuc
        {
            get
            {
                return ngayKetThuc.Substring(0, 10);
            }

            set
            {
                ngayKetThuc = value;
                OnPropertyChanged();
            }
        }

        public string ChoO
        {
            get
            {
                return choO;
            }

            set
            {
                choO = value;
                OnPropertyChanged();
            }
        }

        public string NgheNghiep
        {
            get
            {
                return ngheNghiep;
            }

            set
            {
                ngheNghiep = value;
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
