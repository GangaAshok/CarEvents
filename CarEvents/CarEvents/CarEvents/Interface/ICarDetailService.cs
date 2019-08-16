using CarEvents.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents.Interface
{
    public interface ICarDetailService
    {
        List<CarDetail> GetJsonData();
    }
}
