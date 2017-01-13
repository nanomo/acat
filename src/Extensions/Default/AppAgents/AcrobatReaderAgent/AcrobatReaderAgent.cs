﻿////////////////////////////////////////////////////////////////////////////
// <copyright file="AcrobatReaderAgent.cs" company="Intel Corporation">
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

using ACAT.Lib.Core.PreferencesManagement;
using ACAT.Lib.Core.UserManagement;
using ACAT.Lib.Core.Utility;
using ACAT.Lib.Extension.AppAgents.AcrobatReader;

namespace ACAT.Extensions.Default.AppAgents.AcrobatReaderAgent
{
    /// <summary>
    /// This is the application agent for Adobe Acrobat reader.
    /// Base class does all the heavy-lifting.  Override functions
    /// as required customize
    /// </summary>
    [DescriptorAttribute("9684490F-52DE-4BF4-9C9D-548CD2696F65",
                            "Acrobat Reader Agent",
                            "Manages interactions with Adboe Acrobat Reader to browse PDF files")]
    internal class AcrobatReaderAgent : AcrobatReaderAgentBase
    {
        /// <summary>
        /// Settings for this agent
        /// </summary>
        internal static AcrobatReaderAgentSettings Settings;

        /// <summary>
        /// Name of the settings file
        /// </summary>
        private const string SettingsFileName = "AcrobatReaderAgentSettings.xml";

        /// <summary>
        /// Initializes an instance of the class
        /// </summary>
        public AcrobatReaderAgent()
        {
            AcrobatReaderAgentSettings.PreferencesFilePath = UserManager.GetFullPath(SettingsFileName);
            Settings = AcrobatReaderAgentSettings.Load();

            autoSwitchScanners = Settings.AutoSwitchScannerEnable;
        }

        /// <summary>
        /// Returns the default settings
        /// </summary>
        /// <returns>Default settings object</returns>
        public override IPreferences GetDefaultPreferences()
        {
            return PreferencesBase.LoadDefaults<AcrobatReaderAgentSettings>();
        }

        /// <summary>
        /// Returns the settings for this agent
        /// </summary>
        /// <returns>The settings object</returns>
        public override IPreferences GetPreferences()
        {
            return Settings;
        }
    }
}