﻿using CiRent.DAL.Abstract;
using CiRent.DAL.Abstract.IRepositories;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.DAL.Concrete.EF.Repositories
{
    public class ParamDictionaryRepository : GenericRepository<Category>, IParamDictionaryRepository
    {
        public ParamDictionaryRepository(ICiRentContext context) : base(context)
        {

        }
    }
}
