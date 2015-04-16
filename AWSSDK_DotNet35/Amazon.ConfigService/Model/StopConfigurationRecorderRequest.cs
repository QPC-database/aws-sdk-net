/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StopConfigurationRecorder operation.
    /// Stops recording configurations of all the resources associated with the account.
    /// </summary>
    public partial class StopConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private string _configurationRecorderName;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderName. 
        /// <para>
        /// The name of the recorder object that records each configuration change made to the
        /// resources.
        /// </para>
        /// </summary>
        public string ConfigurationRecorderName
        {
            get { return this._configurationRecorderName; }
            set { this._configurationRecorderName = value; }
        }

        // Check to see if ConfigurationRecorderName property is set
        internal bool IsSetConfigurationRecorderName()
        {
            return this._configurationRecorderName != null;
        }

    }
}