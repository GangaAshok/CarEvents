using CarEvents.Models;
using CarEvents.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarEvents.ViewModels
{
   public class ItempageViewModel: INotifyPropertyChanged
    {
        private readonly CarDetailService _cardetailService;
        public IList<CarDetail> CarList { get; private set; }
        public ItempageViewModel()
        {
            _cardetailService = new CarDetailService();
            //_banklistService = new BloodBankService();
            CarList = _cardetailService.GetJsonData();


        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    }
