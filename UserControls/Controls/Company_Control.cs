﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;

namespace UserControls
{
    public class Company_Control : BasicButton, ICompanyView
    {
        private Company company;
        public Company Company {
            get
            {
                company.ID = Text.Split(':')[0];
                return company;
            }
            set
            {
                Text = value.ID;
                Text += $": {value.Prices[value.Prices.Count-1].Value}";
                company = value;
            }
        }
    }
}