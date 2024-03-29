﻿
using CarEvents.Interface;
using CarEvents.Models;
using CarEvents.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;



namespace CarEvents.Services
{
    public class CarDetailService : ICarDetailService
    {
        public List<CarDetail> GetJsonData()
        {
            string jsonFileName = "Cardetails.json";
            CarList carlist = new CarList();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();



                //Converting JSON Array Objects into generic list    
                carlist = JsonConvert.DeserializeObject<CarList>(jsonString);
            }



            //Binding listview with json string     
            //BloodBankList2.ItemsSource = objBloodBankList.bank_detail;
            return carlist.Cardetail;
        }
    }
}