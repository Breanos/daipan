﻿//-----------------------------------------------------------------------

// <copyright file="BrokerCommands.cs" company="Breanos GmbH">
// Copyright Notice:
// DAIPAN - This file, program or part of a program is considered part of the DAIPAN framework by Breanos GmbH for Industrie 4.0
// Published in 2018 by Gerhard Eder gerhard.eder@breanos.com and Achim Bernhard achim.bernhard@breanos.com
// To the extent possible under law, the publishers have dedicated all copyright and related and neighboring rights to this software to the public domain worldwide. This software is distributed without any warranty.
// You should have received a copy of the CC0 Public Domain Dedication along with this software. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.
// <date>Monday, December 3, 2018 3:34:35 PM</date>
// </copyright>

//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace BreanosConnectors.Kpu.Communication.Common
{
    public static class BrokerCommands
    {
        public const string KPU_REGISTRATION = "KpuRegistration";
        public const string PACKAGE = "Package";
        public const string PACKAGE_REQUEST = "PackageRequest";
        public const string EXECUTE_REQUEST = "ExecuteRequest";
        public const string MODEL_UPDATE = "ModelUpdate";
        public const string CONFIGURE_ROUTES = "ConfigureRoutes";
        public const string KPU_DEPLOYMENT = "KPUDeployment";
        public const string REQUESTKPUID = "RequestKPUId";
        public const string TELLKPUID = "KPUId";
    }
}
