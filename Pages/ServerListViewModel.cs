﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;
using AIGS;
using System.Collections.ObjectModel;

namespace Votrix.Pages
{
    public class ServerListViewModel : Screen
    {
        public ObservableCollection<object> ServerList { get; set; } = new ObservableCollection<object>();
        public ServerListViewModel()
        {
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
            ServerList.Add(new object());
        }

        public void AddServer()
        {
            return;
        }

    }
}