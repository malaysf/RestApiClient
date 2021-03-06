﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.


using System;
using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Generated.OpenApi.PodApi;
    using System.Net.Http;
    using System.Collections.Generic;

    /// <summary>
    /// Provides methods for managing the company certificates, by encapsulating
    /// <see cref="SecurityApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class SecurityApi
    {
        private readonly Generated.OpenApi.PodApi.CompanycertClient _securityApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public SecurityApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _securityApi = new Generated.OpenApi.PodApi.CompanycertClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
            _log = ApiLogging.LoggerFactory?.CreateLogger<SecurityApi>();
        }

        /// <summary>
        /// Create a company trusted or untrusted certificate. 
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Create(CompanyCert cert)
        {
            try
            {
                return _apiExecutor.Execute(_securityApi.V1CreateAsync, _authTokens.SessionToken, cert);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to create a company trusted or untrusted certificate.");
                throw;
            }
        }

        /// <summary>
        /// Delete a company certificate. 
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Delete(string fingerPrint)
        {
            try
            {
                return _apiExecutor.Execute(_securityApi.V1DeleteAsync, _authTokens.SessionToken, new StringId() { Id = fingerPrint});
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to delete a company certificate.");
                throw;
            }
        }

        /// <summary>
        /// Get the details of a company certificate.
        /// </summary>
        /// <returns>Company certificate details.</returns>
        public CompanyCertDetail Get(string fingerPrint)
        {
            try
            {
                return _apiExecutor.Execute(_securityApi.V1GetAsync, fingerPrint, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to get details of a company certificate.");
                throw;
            }
        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public IEnumerable<Anonymous> GetIssued(string fingerPrint)
        {
            try
            {
                return _apiExecutor.Execute(_securityApi.V1IssuedbyAsync, fingerPrint, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to get a list of all certificates which were verified to the certificate passed.");
                throw;
            }
        }

        /// <summary>
        /// Update a company certificate.
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Update(string fingerPrint, CompanyCertAttributes certAttributes)
        {
            try
            {
                return _apiExecutor.Execute(_securityApi.V1UpdateAsync, fingerPrint, _authTokens.SessionToken, certAttributes);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying update a company certificate.");
                throw;
            }
        }

        /// <summary>
        /// List all trusted certs.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public IEnumerable<Anonymous> GetAllTrusted(int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1ListAsync, _authTokens.SessionToken, skip, limit);
        }

        /// <summary>
        /// List all trusted certs.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public IEnumerable<Anonymous> GetPodManaged(int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1PodmanagedListAsync, _authTokens.SessionToken, skip, limit);
        }

        /// <summary>
        /// List all certs of the given types.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public IEnumerable<Anonymous> GetByTypes(IEnumerable<CompanyCertType> typeIdList, int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1TypeListAsync, typeIdList, _authTokens.SessionToken, skip, limit);
        }
    }
}
