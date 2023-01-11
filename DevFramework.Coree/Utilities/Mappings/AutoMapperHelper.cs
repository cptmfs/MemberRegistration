﻿using AutoMapper;
using NHibernate.Mapping.ByCode.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Coree.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MaptoSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(c =>
            { c.CreateMap<T, T>(); });

            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }
        public static T MaptoSameType<T>(T obj)
        {
            Mapper.Initialize(c =>
            { c.CreateMap<T, T>(); });

            T result = Mapper.Map<T,T>(obj);
            return result;
        }
    }
}
