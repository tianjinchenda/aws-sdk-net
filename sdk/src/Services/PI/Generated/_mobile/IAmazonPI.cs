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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PI.Model;

namespace Amazon.PI
{
    /// <summary>
    /// Interface for accessing PI
    ///
    /// AWS Performance Insights enables you to monitor and explore different dimensions of
    /// database load based on data captured from a running RDS instance. The guide provides
    /// detailed information about Performance Insights data types, parameters and errors.
    /// For more information about Performance Insights capabilities see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
    /// Amazon RDS Performance Insights </a> in the <i>Amazon RDS User Guide</i>.
    /// 
    ///  
    /// <para>
    ///  The AWS Performance Insights API provides visibility into the performance of your
    /// RDS instance, when Performance Insights is enabled for supported engine types. While
    /// Amazon CloudWatch provides the authoritative source for AWS service vended monitoring
    /// metrics, AWS Performance Insights offers a domain-specific view of database load measured
    /// as Average Active Sessions and provided to API consumers as a 2-dimensional time-series
    /// dataset. The time dimension of the data provides DB load data for each time point
    /// in the queried time range, and each time point decomposes overall load in relation
    /// to the requested dimensions, such as SQL, Wait-event, User or Host, measured at that
    /// time point.
    /// </para>
    /// </summary>
    public partial interface IAmazonPI : IAmazonService, IDisposable
    {
                
        #region  DescribeDimensionKeys



        /// <summary>
        /// For a specific time period, retrieve the top <code>N</code> dimension keys for a metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimensionKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDimensionKeys service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        Task<DescribeDimensionKeysResponse> DescribeDimensionKeysAsync(DescribeDimensionKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceMetrics



        /// <summary>
        /// Retrieve Performance Insights metrics for a set of data sources, over a time period.
        /// You can provide specific dimension groups and dimensions, and provide aggregation
        /// and filtering criteria for each group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceMetrics service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        Task<GetResourceMetricsResponse> GetResourceMetricsAsync(GetResourceMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}