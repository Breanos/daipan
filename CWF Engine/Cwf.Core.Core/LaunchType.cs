﻿//-----------------------------------------------------------------------

// <copyright file="LaunchType.cs" company="Breanos GmbH">
// Copyright Notice:
// DAIPAN - This file, program or part of a program is considered part of the DAIPAN framework by Breanos GmbH for Industrie 4.0
// Published in 2018 by Gerhard Eder gerhard.eder@breanos.com and Achim Bernhard achim.bernhard@breanos.com
// To the extent possible under law, the publishers have dedicated all copyright and related and neighboring rights to this software to the public domain worldwide. This software is distributed without any warranty.
// You should have received a copy of the CC0 Public Domain Dedication along with this software. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.
// <date>Monday, November 5, 2018 12:22:54 AM</date>
// </copyright>

//-----------------------------------------------------------------------


namespace CWF.Core
{
    /// <summary>
    /// Launch type.
    /// </summary>
    public enum LaunchType
    {
        /// <summary>
        /// The workflow starts when Cwf engine starts.
        /// </summary>
        Startup,
        /// <summary>
        /// The workflow must be triggered manually to start.
        /// </summary>
        Trigger,
        /// <summary>
        /// The workflow starts periodically.
        /// </summary>
        Periodic
    }
}