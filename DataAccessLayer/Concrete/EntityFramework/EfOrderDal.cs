﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, Context>, IOrderDal
    {
    }
}
