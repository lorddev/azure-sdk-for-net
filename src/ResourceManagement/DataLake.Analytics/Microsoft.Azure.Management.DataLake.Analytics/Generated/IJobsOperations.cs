// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// JobsOperations operations.
    /// </summary>
    public partial interface IJobsOperations
    {
        /// <summary>
        /// Gets the job statistics object specified by the job ID.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobStatistics>> GetStatisticsWithHttpMessagesAsync(string accountname, string jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the U-SQL job debug data information specified by the job ID.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobDataPath>> GetDebugDataPathWithHttpMessagesAsync(string accountname, string jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Builds (compiles) the specified job in the specified Data Lake
        /// Analytics account for job correctness and validation.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to build the job for
        /// </param>
        /// <param name='parameters'>
        /// The parameters to build a job, which simulates submission.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> BuildWithHttpMessagesAsync(string accountname, JobInformation parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits the specified job to the specified Data Lake Analytics
        /// account for computation.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to create the job for
        /// </param>
        /// <param name='jobId'>
        /// The parameters to submit a job.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to submit a job.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> CreateWithHttpMessagesAsync(string accountname, string jobId, JobInformation parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the running job specified by the job ID.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to cancel the job for
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID to cancel.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string accountname, string jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the JobInfo object specified by the job ID.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> GetWithHttpMessagesAsync(string accountname, string jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics JobInformation
        /// objects within the specified resource group with a link to the
        /// next page, if any.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// Gets or sets OData Select statement. Limits the properties on each
        /// entry to just those requested, e.g.
        /// Categories?$select=CategoryName,Description. Optional.
        /// </param>
        /// <param name='count'>
        /// Gets or sets a Boolean value of true or false to request a count
        /// of the matching resources included with the resources in the
        /// response, e.g. Categories?$count=true. Optional.
        /// </param>
        /// <param name='search'>
        /// Gets or sets a free form search. A free-text search expression to
        /// match for whether a particular entry should be included in the
        /// feed, e.g. Categories?$search=blue OR green. Optional.
        /// </param>
        /// <param name='format'>
        /// Gets or sets the return format. Return the response in particular
        /// formatxii without access to request headers for standard
        /// content-type negotiation (e.g Orders?$format=json). Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobInformation>>> ListWithHttpMessagesAsync(string accountname, ODataQuery<JobInformation> odataQuery = default(ODataQuery<JobInformation>), string select = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics JobInformation
        /// objects within the specified resource group with a link to the
        /// next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobInformation>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
