﻿//-----------------------------------------------------------------------

// <copyright file="GroupInfo.cs" company="Breanos GmbH">
// Copyright Notice:
// DAIPAN - This file, program or part of a program is considered part of the DAIPAN framework by Breanos GmbH for Industrie 4.0
// Published in 2018 by Gerhard Eder gerhard.eder@breanos.com and Achim Bernhard achim.bernhard@breanos.com
// To the extent possible under law, the publishers have dedicated all copyright and related and neighboring rights to this software to the public domain worldwide. This software is distributed without any warranty.
// You should have received a copy of the CC0 Public Domain Dedication along with this software. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.
// <date>Tuesday, October 30, 2018 1:26:47 PM</date>
// </copyright>

//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace AccessControlService.Data
{
    /// <summary>
    /// Represents a group of users.
    /// Via that group and/or its subgroups, a user can be assigned permissions
    /// </summary>
    public class GroupInfo
    {
        public string Name { get; set; }
        public GroupInfo ParentGroup { get; set; }
    }
}
