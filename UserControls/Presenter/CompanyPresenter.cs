﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;

namespace UserControls.Presenter
{
    public class CompanyPresenter
    {
        public ICompanyView View { get; set; }
        public CompanyPresenter(ICompanyView view)
        {
            View = view;
        }

        public Company GetCompany()
        {
            return View.Company;
        }

        public void SetCompany(Company company)
        {
            View.Company = company;
        }
    }
}