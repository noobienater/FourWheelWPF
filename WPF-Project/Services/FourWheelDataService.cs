﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPF_Project.DAL;
using WPF_Project.Model;

namespace WPF_Project.Services
{
    public class FourWheelDataService : IFourWheelDataService
    {
        IFourWheelRepository repo = new FourWheelRepository();

        public List<Customer> GetAllCustomers()
        {
            return repo.GetCustomers();
        }

        public List<Task> GetAllTasks()
        {
            return repo.GetTasks();
        }
    }
}