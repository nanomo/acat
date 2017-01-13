﻿////////////////////////////////////////////////////////////////////////////
// <copyright file="BoolDescriptorAttribute.cs" company="Intel Corporation">
//
// Copyright (c) 2013-2017 Intel Corporation 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
////////////////////////////////////////////////////////////////////////////

using System;

namespace ACAT.Lib.Core.PreferencesManagement
{
    /// <summary>
    /// Custom attribute for boolean fields/properties
    /// </summary>
    public class BoolDescriptorAttribute : Attribute
    {
        /// <summary>
        /// Initializes an instance of the class
        /// </summary>
        /// <param name="desc">Description of the field/property</param>
        /// <param name="defaultvalue">Default value</param>
        public BoolDescriptorAttribute(String desc, bool defaultvalue = false)
        {
            Description = desc;
            DefaultValue = defaultvalue;
        }

        /// <summary>
        /// Gets or sets the default value
        /// </summary>
        public bool DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public String Description { get; private set; }
    }
}