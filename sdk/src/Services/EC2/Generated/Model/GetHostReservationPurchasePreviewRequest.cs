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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetHostReservationPurchasePreview operation.
    /// 
    /// </summary>
    public partial class GetHostReservationPurchasePreviewRequest : AmazonEC2Request
    {
        private List<string> _hostIdSet = new List<string>();
        private string _offeringId;

        /// <summary>
        /// Gets and sets the property HostIdSet.
        /// </summary>
        public List<string> HostIdSet
        {
            get { return this._hostIdSet; }
            set { this._hostIdSet = value; }
        }

        // Check to see if HostIdSet property is set
        internal bool IsSetHostIdSet()
        {
            return this._hostIdSet != null && this._hostIdSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OfferingId.
        /// </summary>
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

    }
}