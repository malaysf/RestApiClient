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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>UserDetail</returns>
        UserDetail V1AdminUserCreatePost (string sessionToken, UserCreate payload);

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserDetail</returns>
        ApiResponse<UserDetail> V1AdminUserCreatePostWithHttpInfo (string sessionToken, UserCreate payload);
        /// <summary>
        /// PROVISIONAL Find a user based on attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>UserList</returns>
        UserList V1AdminUserFindPost (string sessionToken, UserFilter payload);

        /// <summary>
        /// PROVISIONAL Find a user based on attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserList</returns>
        ApiResponse<UserList> V1AdminUserFindPostWithHttpInfo (string sessionToken, UserFilter payload);
        /// <summary>
        /// Retreive a list of all users in the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>UserIdList</returns>
        UserIdList V1AdminUserListGet (string sessionToken);

        /// <summary>
        /// Retreive a list of all users in the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of UserIdList</returns>
        ApiResponse<UserIdList> V1AdminUserListGetWithHttpInfo (string sessionToken);
        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidActionPasswordResetPost (string sessionToken, long? uid, PasswordReset payload);

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidActionPasswordResetPostWithHttpInfo (string sessionToken, long? uid, PasswordReset payload);
        /// <summary>
        /// Get the URL of the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>AvatarList</returns>
        AvatarList V1AdminUserUidAvatarGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the URL of the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of AvatarList</returns>
        ApiResponse<AvatarList> V1AdminUserUidAvatarGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidAvatarUpdatePost (string sessionToken, long? uid, AvatarUpdate payload);

        /// <summary>
        /// Update the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidAvatarUpdatePostWithHttpInfo (string sessionToken, long? uid, AvatarUpdate payload);
        /// <summary>
        /// Get the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>IntegerList</returns>
        IntegerList V1AdminUserUidDelegatesGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of IntegerList</returns>
        ApiResponse<IntegerList> V1AdminUserUidDelegatesGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidDelegatesUpdatePost (string sessionToken, long? uid, DelegateAction payload);

        /// <summary>
        /// Update the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidDelegatesUpdatePostWithHttpInfo (string sessionToken, long? uid, DelegateAction payload);
        /// <summary>
        /// Get the disclaimer assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Disclaimer</returns>
        Disclaimer V1AdminUserUidDisclaimerGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the disclaimer assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of Disclaimer</returns>
        ApiResponse<Disclaimer> V1AdminUserUidDisclaimerGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Assign a disclaimer to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidDisclaimerUpdatePost (string sessionToken, long? uid, StringId payload);

        /// <summary>
        /// Assign a disclaimer to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidDisclaimerUpdatePostWithHttpInfo (string sessionToken, long? uid, StringId payload);
        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>FeatureList</returns>
        FeatureList V1AdminUserUidFeaturesGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of FeatureList</returns>
        ApiResponse<FeatureList> V1AdminUserUidFeaturesGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidFeaturesUpdatePost (string sessionToken, long? uid, FeatureList payload);

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidFeaturesUpdatePostWithHttpInfo (string sessionToken, long? uid, FeatureList payload);
        /// <summary>
        /// Retreive user details for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>UserDetail</returns>
        UserDetail V1AdminUserUidGet (string sessionToken, long? uid);

        /// <summary>
        /// Retreive user details for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of UserDetail</returns>
        ApiResponse<UserDetail> V1AdminUserUidGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>RoleList</returns>
        RoleList V1AdminUserUidRolesGet (string sessionToken, long? uid);

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of RoleList</returns>
        ApiResponse<RoleList> V1AdminUserUidRolesGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidRolesUpdatePost (string sessionToken, long? uid, StringList payload);

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidRolesUpdatePostWithHttpInfo (string sessionToken, long? uid, StringList payload);
        /// <summary>
        /// Get the status, active or inactive, for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>UserStatus</returns>
        UserStatus V1AdminUserUidStatusGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the status, active or inactive, for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of UserStatus</returns>
        ApiResponse<UserStatus> V1AdminUserUidStatusGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the status of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1AdminUserUidStatusUpdatePost (string sessionToken, long? uid, UserStatus payload);

        /// <summary>
        /// Update the status of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1AdminUserUidStatusUpdatePostWithHttpInfo (string sessionToken, long? uid, UserStatus payload);
        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>UserDetail</returns>
        UserDetail V1AdminUserUidUpdatePost (string sessionToken, long? uid, UserAttributes payload);

        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserDetail</returns>
        ApiResponse<UserDetail> V1AdminUserUidUpdatePostWithHttpInfo (string sessionToken, long? uid, UserAttributes payload);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserDetail</returns>
        System.Threading.Tasks.Task<UserDetail> V1AdminUserCreatePostAsync (string sessionToken, UserCreate payload);

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserCreatePostAsyncWithHttpInfo (string sessionToken, UserCreate payload);
        /// <summary>
        /// PROVISIONAL Find a user based on attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserList</returns>
        System.Threading.Tasks.Task<UserList> V1AdminUserFindPostAsync (string sessionToken, UserFilter payload);

        /// <summary>
        /// PROVISIONAL Find a user based on attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserList>> V1AdminUserFindPostAsyncWithHttpInfo (string sessionToken, UserFilter payload);
        /// <summary>
        /// Retreive a list of all users in the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of UserIdList</returns>
        System.Threading.Tasks.Task<UserIdList> V1AdminUserListGetAsync (string sessionToken);

        /// <summary>
        /// Retreive a list of all users in the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (UserIdList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserIdList>> V1AdminUserListGetAsyncWithHttpInfo (string sessionToken);
        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidActionPasswordResetPostAsync (string sessionToken, long? uid, PasswordReset payload);

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidActionPasswordResetPostAsyncWithHttpInfo (string sessionToken, long? uid, PasswordReset payload);
        /// <summary>
        /// Get the URL of the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of AvatarList</returns>
        System.Threading.Tasks.Task<AvatarList> V1AdminUserUidAvatarGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the URL of the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (AvatarList)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvatarList>> V1AdminUserUidAvatarGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidAvatarUpdatePostAsync (string sessionToken, long? uid, AvatarUpdate payload);

        /// <summary>
        /// Update the avatar of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidAvatarUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, AvatarUpdate payload);
        /// <summary>
        /// Get the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of IntegerList</returns>
        System.Threading.Tasks.Task<IntegerList> V1AdminUserUidDelegatesGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (IntegerList)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerList>> V1AdminUserUidDelegatesGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidDelegatesUpdatePostAsync (string sessionToken, long? uid, DelegateAction payload);

        /// <summary>
        /// Update the delegates assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidDelegatesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, DelegateAction payload);
        /// <summary>
        /// Get the disclaimer assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of Disclaimer</returns>
        System.Threading.Tasks.Task<Disclaimer> V1AdminUserUidDisclaimerGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the disclaimer assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminUserUidDisclaimerGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Assign a disclaimer to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidDisclaimerUpdatePostAsync (string sessionToken, long? uid, StringId payload);

        /// <summary>
        /// Assign a disclaimer to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidDisclaimerUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, StringId payload);
        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of FeatureList</returns>
        System.Threading.Tasks.Task<FeatureList> V1AdminUserUidFeaturesGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (FeatureList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeatureList>> V1AdminUserUidFeaturesGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidFeaturesUpdatePostAsync (string sessionToken, long? uid, FeatureList payload);

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidFeaturesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, FeatureList payload);
        /// <summary>
        /// Retreive user details for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of UserDetail</returns>
        System.Threading.Tasks.Task<UserDetail> V1AdminUserUidGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Retreive user details for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserUidGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of RoleList</returns>
        System.Threading.Tasks.Task<RoleList> V1AdminUserUidRolesGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (RoleList)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoleList>> V1AdminUserUidRolesGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidRolesUpdatePostAsync (string sessionToken, long? uid, StringList payload);

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidRolesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, StringList payload);
        /// <summary>
        /// Get the status, active or inactive, for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of UserStatus</returns>
        System.Threading.Tasks.Task<UserStatus> V1AdminUserUidStatusGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the status, active or inactive, for a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (UserStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserStatus>> V1AdminUserUidStatusGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the status of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidStatusUpdatePostAsync (string sessionToken, long? uid, UserStatus payload);

        /// <summary>
        /// Update the status of a particular user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidStatusUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, UserStatus payload);
        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserDetail</returns>
        System.Threading.Tasks.Task<UserDetail> V1AdminUserUidUpdatePostAsync (string sessionToken, long? uid, UserAttributes payload);

        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserUidUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, UserAttributes payload);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create a new user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>UserDetail</returns>
        public UserDetail V1AdminUserCreatePost (string sessionToken, UserCreate payload)
        {
             ApiResponse<UserDetail> localVarResponse = V1AdminUserCreatePostWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserDetail</returns>
        public ApiResponse< UserDetail > V1AdminUserCreatePostWithHttpInfo (string sessionToken, UserCreate payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserCreatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserCreatePost");

            var localVarPath = "/v1/admin/user/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

        /// <summary>
        /// Create a new user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserDetail</returns>
        public async System.Threading.Tasks.Task<UserDetail> V1AdminUserCreatePostAsync (string sessionToken, UserCreate payload)
        {
             ApiResponse<UserDetail> localVarResponse = await V1AdminUserCreatePostAsyncWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserCreatePostAsyncWithHttpInfo (string sessionToken, UserCreate payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserCreatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserCreatePost");

            var localVarPath = "/v1/admin/user/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

        /// <summary>
        /// PROVISIONAL Find a user based on attributes 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>UserList</returns>
        public UserList V1AdminUserFindPost (string sessionToken, UserFilter payload)
        {
             ApiResponse<UserList> localVarResponse = V1AdminUserFindPostWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Find a user based on attributes 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserList</returns>
        public ApiResponse< UserList > V1AdminUserFindPostWithHttpInfo (string sessionToken, UserFilter payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserFindPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserFindPost");

            var localVarPath = "/v1/admin/user/find";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserFindPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserFindPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserList)));
            
        }

        /// <summary>
        /// PROVISIONAL Find a user based on attributes 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserList</returns>
        public async System.Threading.Tasks.Task<UserList> V1AdminUserFindPostAsync (string sessionToken, UserFilter payload)
        {
             ApiResponse<UserList> localVarResponse = await V1AdminUserFindPostAsyncWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Find a user based on attributes 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserList>> V1AdminUserFindPostAsyncWithHttpInfo (string sessionToken, UserFilter payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserFindPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserFindPost");

            var localVarPath = "/v1/admin/user/find";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserFindPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserFindPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserList)));
            
        }

        /// <summary>
        /// Retreive a list of all users in the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>UserIdList</returns>
        public UserIdList V1AdminUserListGet (string sessionToken)
        {
             ApiResponse<UserIdList> localVarResponse = V1AdminUserListGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retreive a list of all users in the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of UserIdList</returns>
        public ApiResponse< UserIdList > V1AdminUserListGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserListGet");

            var localVarPath = "/v1/admin/user/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserIdList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserIdList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserIdList)));
            
        }

        /// <summary>
        /// Retreive a list of all users in the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of UserIdList</returns>
        public async System.Threading.Tasks.Task<UserIdList> V1AdminUserListGetAsync (string sessionToken)
        {
             ApiResponse<UserIdList> localVarResponse = await V1AdminUserListGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retreive a list of all users in the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (UserIdList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserIdList>> V1AdminUserListGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserListGet");

            var localVarPath = "/v1/admin/user/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserIdList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserIdList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserIdList)));
            
        }

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidActionPasswordResetPost (string sessionToken, long? uid, PasswordReset payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidActionPasswordResetPostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidActionPasswordResetPostWithHttpInfo (string sessionToken, long? uid, PasswordReset payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidActionPasswordResetPost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidActionPasswordResetPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidActionPasswordResetPost");

            var localVarPath = "/v1/admin/user/{uid}/action/password_reset";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidActionPasswordResetPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidActionPasswordResetPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidActionPasswordResetPostAsync (string sessionToken, long? uid, PasswordReset payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidActionPasswordResetPostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Send a password reset email to the email address of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidActionPasswordResetPostAsyncWithHttpInfo (string sessionToken, long? uid, PasswordReset payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidActionPasswordResetPost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidActionPasswordResetPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidActionPasswordResetPost");

            var localVarPath = "/v1/admin/user/{uid}/action/password_reset";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidActionPasswordResetPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidActionPasswordResetPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the URL of the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>AvatarList</returns>
        public AvatarList V1AdminUserUidAvatarGet (string sessionToken, long? uid)
        {
             ApiResponse<AvatarList> localVarResponse = V1AdminUserUidAvatarGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URL of the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of AvatarList</returns>
        public ApiResponse< AvatarList > V1AdminUserUidAvatarGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidAvatarGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidAvatarGet");

            var localVarPath = "/v1/admin/user/{uid}/avatar";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvatarList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvatarList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvatarList)));
            
        }

        /// <summary>
        /// Get the URL of the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of AvatarList</returns>
        public async System.Threading.Tasks.Task<AvatarList> V1AdminUserUidAvatarGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<AvatarList> localVarResponse = await V1AdminUserUidAvatarGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URL of the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (AvatarList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvatarList>> V1AdminUserUidAvatarGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidAvatarGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidAvatarGet");

            var localVarPath = "/v1/admin/user/{uid}/avatar";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvatarList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvatarList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvatarList)));
            
        }

        /// <summary>
        /// Update the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidAvatarUpdatePost (string sessionToken, long? uid, AvatarUpdate payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidAvatarUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidAvatarUpdatePostWithHttpInfo (string sessionToken, long? uid, AvatarUpdate payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidAvatarUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidAvatarUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidAvatarUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/avatar/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidAvatarUpdatePostAsync (string sessionToken, long? uid, AvatarUpdate payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidAvatarUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the avatar of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidAvatarUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, AvatarUpdate payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidAvatarUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidAvatarUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidAvatarUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/avatar/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAvatarUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>IntegerList</returns>
        public IntegerList V1AdminUserUidDelegatesGet (string sessionToken, long? uid)
        {
             ApiResponse<IntegerList> localVarResponse = V1AdminUserUidDelegatesGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of IntegerList</returns>
        public ApiResponse< IntegerList > V1AdminUserUidDelegatesGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDelegatesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDelegatesGet");

            var localVarPath = "/v1/admin/user/{uid}/delegates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerList)));
            
        }

        /// <summary>
        /// Get the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of IntegerList</returns>
        public async System.Threading.Tasks.Task<IntegerList> V1AdminUserUidDelegatesGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<IntegerList> localVarResponse = await V1AdminUserUidDelegatesGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (IntegerList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerList>> V1AdminUserUidDelegatesGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDelegatesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDelegatesGet");

            var localVarPath = "/v1/admin/user/{uid}/delegates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerList)));
            
        }

        /// <summary>
        /// Update the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidDelegatesUpdatePost (string sessionToken, long? uid, DelegateAction payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidDelegatesUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidDelegatesUpdatePostWithHttpInfo (string sessionToken, long? uid, DelegateAction payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/delegates/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidDelegatesUpdatePostAsync (string sessionToken, long? uid, DelegateAction payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidDelegatesUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the delegates assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidDelegatesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, DelegateAction payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidDelegatesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/delegates/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDelegatesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the disclaimer assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Disclaimer</returns>
        public Disclaimer V1AdminUserUidDisclaimerGet (string sessionToken, long? uid)
        {
             ApiResponse<Disclaimer> localVarResponse = V1AdminUserUidDisclaimerGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the disclaimer assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of Disclaimer</returns>
        public ApiResponse< Disclaimer > V1AdminUserUidDisclaimerGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDisclaimerGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDisclaimerGet");

            var localVarPath = "/v1/admin/user/{uid}/disclaimer";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// Get the disclaimer assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of Disclaimer</returns>
        public async System.Threading.Tasks.Task<Disclaimer> V1AdminUserUidDisclaimerGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<Disclaimer> localVarResponse = await V1AdminUserUidDisclaimerGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the disclaimer assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminUserUidDisclaimerGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDisclaimerGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDisclaimerGet");

            var localVarPath = "/v1/admin/user/{uid}/disclaimer";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// Assign a disclaimer to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidDisclaimerUpdatePost (string sessionToken, long? uid, StringId payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidDisclaimerUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Assign a disclaimer to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidDisclaimerUpdatePostWithHttpInfo (string sessionToken, long? uid, StringId payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/disclaimer/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Assign a disclaimer to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidDisclaimerUpdatePostAsync (string sessionToken, long? uid, StringId payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidDisclaimerUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Assign a disclaimer to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidDisclaimerUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, StringId payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidDisclaimerUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/disclaimer/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidDisclaimerUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>FeatureList</returns>
        public FeatureList V1AdminUserUidFeaturesGet (string sessionToken, long? uid)
        {
             ApiResponse<FeatureList> localVarResponse = V1AdminUserUidFeaturesGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of FeatureList</returns>
        public ApiResponse< FeatureList > V1AdminUserUidFeaturesGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidFeaturesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidFeaturesGet");

            var localVarPath = "/v1/admin/user/{uid}/features";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FeatureList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FeatureList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeatureList)));
            
        }

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of FeatureList</returns>
        public async System.Threading.Tasks.Task<FeatureList> V1AdminUserUidFeaturesGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<FeatureList> localVarResponse = await V1AdminUserUidFeaturesGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Symphony feature entitlements enabled for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (FeatureList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FeatureList>> V1AdminUserUidFeaturesGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidFeaturesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidFeaturesGet");

            var localVarPath = "/v1/admin/user/{uid}/features";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FeatureList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FeatureList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeatureList)));
            
        }

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidFeaturesUpdatePost (string sessionToken, long? uid, FeatureList payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidFeaturesUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidFeaturesUpdatePostWithHttpInfo (string sessionToken, long? uid, FeatureList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/features/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidFeaturesUpdatePostAsync (string sessionToken, long? uid, FeatureList payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidFeaturesUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the list of Symphony feature entitlements for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidFeaturesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, FeatureList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidFeaturesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/features/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidFeaturesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Retreive user details for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>UserDetail</returns>
        public UserDetail V1AdminUserUidGet (string sessionToken, long? uid)
        {
             ApiResponse<UserDetail> localVarResponse = V1AdminUserUidGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retreive user details for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of UserDetail</returns>
        public ApiResponse< UserDetail > V1AdminUserUidGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidGet");

            var localVarPath = "/v1/admin/user/{uid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

        /// <summary>
        /// Retreive user details for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of UserDetail</returns>
        public async System.Threading.Tasks.Task<UserDetail> V1AdminUserUidGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<UserDetail> localVarResponse = await V1AdminUserUidGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retreive user details for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserUidGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidGet");

            var localVarPath = "/v1/admin/user/{uid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>RoleList</returns>
        public RoleList V1AdminUserUidRolesGet (string sessionToken, long? uid)
        {
             ApiResponse<RoleList> localVarResponse = V1AdminUserUidRolesGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of RoleList</returns>
        public ApiResponse< RoleList > V1AdminUserUidRolesGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidRolesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidRolesGet");

            var localVarPath = "/v1/admin/user/{uid}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoleList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleList)));
            
        }

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of RoleList</returns>
        public async System.Threading.Tasks.Task<RoleList> V1AdminUserUidRolesGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<RoleList> localVarResponse = await V1AdminUserUidRolesGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Get the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (RoleList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoleList>> V1AdminUserUidRolesGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidRolesGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidRolesGet");

            var localVarPath = "/v1/admin/user/{uid}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoleList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleList)));
            
        }

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidRolesUpdatePost (string sessionToken, long? uid, StringList payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidRolesUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidRolesUpdatePostWithHttpInfo (string sessionToken, long? uid, StringList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidRolesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidRolesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidRolesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/roles/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidRolesUpdatePostAsync (string sessionToken, long? uid, StringList payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidRolesUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Update the list of roles assigned to a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidRolesUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, StringList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidRolesUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidRolesUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidRolesUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/roles/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidRolesUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the status, active or inactive, for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>UserStatus</returns>
        public UserStatus V1AdminUserUidStatusGet (string sessionToken, long? uid)
        {
             ApiResponse<UserStatus> localVarResponse = V1AdminUserUidStatusGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status, active or inactive, for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>ApiResponse of UserStatus</returns>
        public ApiResponse< UserStatus > V1AdminUserUidStatusGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidStatusGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidStatusGet");

            var localVarPath = "/v1/admin/user/{uid}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserStatus)));
            
        }

        /// <summary>
        /// Get the status, active or inactive, for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of UserStatus</returns>
        public async System.Threading.Tasks.Task<UserStatus> V1AdminUserUidStatusGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<UserStatus> localVarResponse = await V1AdminUserUidStatusGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status, active or inactive, for a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <returns>Task of ApiResponse (UserStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserStatus>> V1AdminUserUidStatusGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidStatusGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidStatusGet");

            var localVarPath = "/v1/admin/user/{uid}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserStatus)));
            
        }

        /// <summary>
        /// Update the status of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1AdminUserUidStatusUpdatePost (string sessionToken, long? uid, UserStatus payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1AdminUserUidStatusUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1AdminUserUidStatusUpdatePostWithHttpInfo (string sessionToken, long? uid, UserStatus payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidStatusUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidStatusUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidStatusUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/status/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update the status of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1AdminUserUidStatusUpdatePostAsync (string sessionToken, long? uid, UserStatus payload)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1AdminUserUidStatusUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of a particular user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1AdminUserUidStatusUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, UserStatus payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidStatusUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidStatusUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidStatusUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/status/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidStatusUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update an existing user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>UserDetail</returns>
        public UserDetail V1AdminUserUidUpdatePost (string sessionToken, long? uid, UserAttributes payload)
        {
             ApiResponse<UserDetail> localVarResponse = V1AdminUserUidUpdatePostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserDetail</returns>
        public ApiResponse< UserDetail > V1AdminUserUidUpdatePostWithHttpInfo (string sessionToken, long? uid, UserAttributes payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

        /// <summary>
        /// Update an existing user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserDetail</returns>
        public async System.Threading.Tasks.Task<UserDetail> V1AdminUserUidUpdatePostAsync (string sessionToken, long? uid, UserAttributes payload)
        {
             ApiResponse<UserDetail> localVarResponse = await V1AdminUserUidUpdatePostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserDetail>> V1AdminUserUidUpdatePostAsyncWithHttpInfo (string sessionToken, long? uid, UserAttributes payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UserApi->V1AdminUserUidUpdatePost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling UserApi->V1AdminUserUidUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling UserApi->V1AdminUserUidUpdatePost");

            var localVarPath = "/v1/admin/user/{uid}/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDetail)));
            
        }

    }
}
