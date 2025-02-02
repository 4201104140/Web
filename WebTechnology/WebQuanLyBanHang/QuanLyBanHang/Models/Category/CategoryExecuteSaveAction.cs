﻿using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class CategoryExecuteSaveAction
    {
        public Category Item { get; set; }
        public string EditFlag { get; set; }
        public bool Execute()
        {
            using(var cmd = new CategoryExecuteSaveBusiness())
            {
                cmd.EditFlag = this.EditFlag;
                cmd.Item = this.Item;
                return cmd.Execute();
            }
        }
    }
}