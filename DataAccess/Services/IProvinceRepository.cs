﻿using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IProvinceRepository
    {
        List<Province> GetAll();
    }
}
