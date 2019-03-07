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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBClusterEndpoint operation.
    /// Deletes a custom endpoint and removes it from an Amazon Aurora DB cluster.
    /// 
    ///  <note> 
    /// <para>
    /// This action only applies to Aurora DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDBClusterEndpointRequest : AmazonRDSRequest
    {
        private string _dbClusterEndpointIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier associated with the custom endpoint. This parameter is stored as a
        /// lowercase string.
        /// </para>
        /// </summary>
        public string DBClusterEndpointIdentifier
        {
            get { return this._dbClusterEndpointIdentifier; }
            set { this._dbClusterEndpointIdentifier = value; }
        }

        // Check to see if DBClusterEndpointIdentifier property is set
        internal bool IsSetDBClusterEndpointIdentifier()
        {
            return this._dbClusterEndpointIdentifier != null;
        }

    }
}