﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-23
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Sqladmin v1beta4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and configures Cloud SQL instances, which provide fully-managed MySQL databases.
// API Documentation Link https://cloud.google.com/sql/docs/reference/latest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Sqladmin/v1beta4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Sqladmin.v1beta4/ 
// Install Command: PM>  Install-Package Google.Apis.Sqladmin.v1beta4
//
//------------------------------------------------------------------------------  
using Google.Apis.Sqladmin.v1beta4;
using Google.Apis.Sqladmin.v1beta4.Data;
using System;

namespace GoogleSamplecSharpSample.Sqladminv1beta4.Methods
{
  
    public static class UsersSample
    {


        /// <summary>
        /// Deletes a user from a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/users/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="host">Host of the user in the instance.</param>
        /// <param name="name">Name of the user in the instance.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(SqladminService service, string project, string instance, string host, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (host == null)
                    throw new ArgumentNullException(host);
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Users.Delete(project, instance, host, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new user in a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/users/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(SqladminService service, string project, string instance, User body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Users.Insert(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Lists users in the specified Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/users/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <returns>UsersListResponseResponse</returns>
        public static UsersListResponse List(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Users.List(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing user in a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/users/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="host">Host of the user in the instance.</param>
        /// <param name="name">Name of the user in the instance.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Update(SqladminService service, string project, string instance, string host, string name, User body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (host == null)
                    throw new ArgumentNullException(host);
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Users.Update(body, project, instance, host, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Update failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}