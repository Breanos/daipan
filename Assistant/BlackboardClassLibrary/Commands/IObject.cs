﻿//-----------------------------------------------------------------------

// <copyright file="IObject.cs" company="Breanos GmbH">
// Copyright Notice:
// DAIPAN - This file, program or part of a program is considered part of the DAIPAN framework by Breanos GmbH for Industrie 4.0
// Published in 2018 by Gerhard Eder gerhard.eder@breanos.com and Achim Bernhard achim.bernhard@breanos.com
// To the extent possible under law, the publishers have dedicated all copyright and related and neighboring rights to this software to the public domain worldwide. This software is distributed without any warranty.
// You should have received a copy of the CC0 Public Domain Dedication along with this software. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.
// <date>Tuesday, October 30, 2018 1:26:47 PM</date>
// </copyright>

//-----------------------------------------------------------------------

///////////////////////////////////////////////////////////
//  IObject.cs
//  Implementation of the Interface IObject
//  Generated by Enterprise Architect
//  Created on:      02-Feb-2018 10:27:00
//  Original author: bezdedeanu
///////////////////////////////////////////////////////////

namespace BlackboardClassLibrary.Commands
{
    /// <summary>
    /// Base class interface for ObjectBase
    /// </summary>
    public interface IObject
    {
        /// <summary>
        /// Must be cloneable
        /// </summary>
        /// <returns></returns>
        object Clone();
    }//end IObject
}
