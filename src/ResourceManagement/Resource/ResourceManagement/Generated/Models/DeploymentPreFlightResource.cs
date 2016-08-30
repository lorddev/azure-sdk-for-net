// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// The deployment preflight resource.
    /// </summary>
    public partial class DeploymentPreFlightResource : GenericResourceExtended
    {
        private string _apiVersion;
        
        /// <summary>
        /// Optional. Gets or sets the api version of the resource.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }
        
        private IList<string> _dependsOn;
        
        /// <summary>
        /// Optional. Gets the list of depends on.
        /// </summary>
        public IList<string> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentPreFlightResource class.
        /// </summary>
        public DeploymentPreFlightResource()
        {
            this.DependsOn = new LazyList<string>();
        }
    }
}
