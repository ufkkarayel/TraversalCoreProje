﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;
        public void TAdd(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public Newsletter TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetList()
        {
            return _newsletterDal.GetList();
        }

        public void TUpdate(Newsletter t)
        {
            _newsletterDal.Update(t);
        }
    }
}
