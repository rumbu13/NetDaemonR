﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure.DeviceTriggers
{
    public interface IDeviceTriggers : IObservable<DeviceTrigger>, IDisposable
    {

    }
}
