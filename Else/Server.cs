﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIGS.Common;
using AIGS.Helper;
using Stylet;
using System.IO;
using Votrix.Protocol;

using System.Collections.ObjectModel;

namespace Votrix.Else
{

    public class Server : Screen
    {
        public eProtocolType PType { get; set; } = eProtocolType.SS;

        public string Name { get; set; } = "New Server" + RandHelper.GetIntRandom(3,9,0);
        public string Address { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "1080";

        public string UserName { get; set; }
        public string Password { get; set; }

        //加密方式
        public int SecuritySS { get; set; } = (int)eSecuritySS.aes_256_cfb;
        public int SecurityVmess { get; set; } = (int)eSecurityVmess.auto;
        public int SecuritySocks { get; set; } = (int)eSecuritySocks.aes_256_cfb;

        public string UUID { get; set; }
        public string AlterID { get; set; }

        //传输协议
        public int Network { get; set; } = (int)eNetwork.ws;

        //伪装类型
        public string Type { get; set; }
        public string Host { get; set; }
        public string Path { get; set; } = "/";

        public bool TLSEnable { get; set; } = true;
        public bool AllowInsecure { get; set; } = false;

        public void Copy(Server obj)
        {
            PType = obj.PType;
            Name = obj.Name;
            Address = obj.Address;
            Port = obj.Port;

            UserName = obj.UserName;
            Password = obj.Password;

            SecuritySS = obj.SecuritySS;
            SecurityVmess = obj.SecurityVmess;
            SecuritySocks = obj.SecuritySocks;

            UUID = obj.UUID;
            AlterID = obj.AlterID;

            Network = obj.Network;
            Type = obj.Type;
            Host = obj.Host;
            Path = obj.Path;

            TLSEnable = obj.TLSEnable;
            AllowInsecure = obj.AllowInsecure;
        }
    }
}
