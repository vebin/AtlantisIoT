﻿using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Devices
{
    class Beeper : Device
    {
        public Beeper()
        {
            id = null;
            name = "Beeper";
            type = Types.beeperDevice.ToString();
            metric = "0";
            generateMac();
            macAddress = "00:00:00:00:00:00";
        }
    }
}
