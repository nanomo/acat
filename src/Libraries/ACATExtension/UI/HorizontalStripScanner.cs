﻿////////////////////////////////////////////////////////////////////////////
// <copyright file="HorizontalStripScanner.cs" company="Intel Corporation">
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
using System.Diagnostics.CodeAnalysis;
using ACAT.Lib.Core.PanelManagement;
using ACAT.Lib.Core.PanelManagement.CommandDispatcher;
using ACAT.Lib.Core.Utility;
using ACAT.Lib.Core.WidgetManagement;
using ACAT.Lib.Extension.CommandHandlers;

#region SupressStyleCopWarnings

[module: SuppressMessage(
        "StyleCop.CSharp.ReadabilityRules",
        "SA1126:PrefixCallsCorrectly",
        Scope = "namespace",
        Justification = "Not needed. ACAT naming conventions takes care of this")]
[module: SuppressMessage(
        "StyleCop.CSharp.ReadabilityRules",
        "SA1101:PrefixLocalCallsWithThis",
        Scope = "namespace",
        Justification = "Not needed. ACAT naming conventions takes care of this")]
[module: SuppressMessage(
        "StyleCop.CSharp.ReadabilityRules",
        "SA1121:UseBuiltInTypeAlias",
        Scope = "namespace",
        Justification = "Since they are just aliases, it doesn't really matter")]
[module: SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1200:UsingDirectivesMustBePlacedWithinNamespace",
        Scope = "namespace",
        Justification = "ACAT guidelines")]
[module: SuppressMessage(
        "StyleCop.CSharp.NamingRules",
        "SA1309:FieldNamesMustNotBeginWithUnderscore",
        Scope = "namespace",
        Justification = "ACAT guidelines. Private fields begin with an underscore")]
[module: SuppressMessage(
        "StyleCop.CSharp.NamingRules",
        "SA1300:ElementMustBeginWithUpperCaseLetter",
        Scope = "namespace",
        Justification = "ACAT guidelines. Private/Protected methods begin with lowercase")]

#endregion SupressStyleCopWarnings

namespace ACAT.Lib.Extension
{
    /// <summary>
    /// This is a scanner with a single row of buttons.
    /// </summary>
    [Descriptor("4287E55B-3364-46B5-A5B2-6C8BE3C57F1E", 
                    "HorizontalStripScanner", 
                    "Horizontal strip of buttons")]
    public partial class HorizontalStripScanner: HorizontalStripScannerBase
    {
        /// <summary>
        /// The command dispatcher.  If the derived class as additional
        /// commands, just call Commands.Add on this object
        /// </summary>
        protected Dispatcher commandDispatcher;

        /// <summary>
        /// Initalizes a new instance of the class
        /// </summary>
        public HorizontalStripScanner()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="panelClass">The panel class of the conextual menu</param>
        /// <param name="panelTitle">title of the contextual</param>
        public HorizontalStripScanner(String panelClass, String panelTitle)
            : base(panelClass, panelTitle)
        {
            commandDispatcher = new Dispatcher(this);
        }

        /// <summary>
        /// Gets the command dispatcher object
        /// </summary>
        public override RunCommandDispatcher CommandDispatcher
        {
            get { return commandDispatcher; }
        }

        /// <summary>
        /// The dispatcher object.  The DefaultCommandDispatcher
        /// will take care of executing the commands
        /// </summary>
        public class Dispatcher : DefaultCommandDispatcher
        {
            public Dispatcher(IScannerPanel panel)
                : base(panel)
            {
            }
        }

        /// <summary>
        /// Invoked when the user actuates a button in
        /// the scanner form
        /// </summary>
        /// <param name="widget">widget actuated</param>
        /// <param name="handled">was this handled here?</param>
        public override void OnWidgetActuated(Widget widget, ref bool handled)
        {
            handled = false;
        }
    }
}
