﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemFormApp.RestApi.views
{
    public class ResponseContent<T> where T : class
    {
        public string Result { get; set; }
        public List<T> Data { get; set; }
    }
}
