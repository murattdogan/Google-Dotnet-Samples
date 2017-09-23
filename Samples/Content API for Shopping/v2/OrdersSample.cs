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
// Unoffical sample for the Shoppingcontent v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages product items, inventory, and Merchant Center accounts for Google Shopping.
// API Documentation Link https://developers.google.com/shopping-content
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Shoppingcontent/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Shoppingcontent.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Shoppingcontent.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Shoppingcontent.v2;
using Google.Apis.Shoppingcontent.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Shoppingcontentv2.Methods
{
  
    public static class OrdersSample
    {


        /// <summary>
        /// Marks an order as acknowledged. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/acknowledge
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersAcknowledgeResponseResponse</returns>
        public static OrdersAcknowledgeResponse Acknowledge(ShoppingcontentService service, string merchantId, string orderId, OrdersAcknowledgeRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Acknowledge(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Acknowledge failed.", ex);
            }
        }

        /// <summary>
        /// Sandbox only. Moves a test order from state "inProgress" to state "pendingShipment". This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/advancetestorder
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the test order to modify.</param>
        /// <returns>OrdersAdvanceTestOrderResponseResponse</returns>
        public static OrdersAdvanceTestOrderResponse Advancetestorder(ShoppingcontentService service, string merchantId, string orderId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Advancetestorder(merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Advancetestorder failed.", ex);
            }
        }

        /// <summary>
        /// Cancels all line items in an order, making a full refund. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order to cancel.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersCancelResponseResponse</returns>
        public static OrdersCancelResponse Cancel(ShoppingcontentService service, string merchantId, string orderId, OrdersCancelRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Cancel(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Cancel failed.", ex);
            }
        }

        /// <summary>
        /// Cancels a line item, making a full refund. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/cancellineitem
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersCancelLineItemResponseResponse</returns>
        public static OrdersCancelLineItemResponse Cancellineitem(ShoppingcontentService service, string merchantId, string orderId, OrdersCancelLineItemRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Cancellineitem(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Cancellineitem failed.", ex);
            }
        }

        /// <summary>
        /// Sandbox only. Creates a test order. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/createtestorder
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersCreateTestOrderResponseResponse</returns>
        public static OrdersCreateTestOrderResponse Createtestorder(ShoppingcontentService service, string merchantId, OrdersCreateTestOrderRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Make the request.
                return service.Orders.Createtestorder(body, merchantId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Createtestorder failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves or modifies multiple orders in a single request. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/custombatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersCustomBatchResponseResponse</returns>
        public static OrdersCustomBatchResponse Custombatch(ShoppingcontentService service, OrdersCustomBatchRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Orders.Custombatch(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Custombatch failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves an order from your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <returns>OrderResponse</returns>
        public static Order Get(ShoppingcontentService service, string merchantId, string orderId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Get(merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Get failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves an order using merchant order id. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/getbymerchantorderid
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="merchantOrderId">The merchant order id to be looked for.</param>
        /// <returns>OrdersGetByMerchantOrderIdResponseResponse</returns>
        public static OrdersGetByMerchantOrderIdResponse Getbymerchantorderid(ShoppingcontentService service, string merchantId, string merchantOrderId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (merchantOrderId == null)
                    throw new ArgumentNullException(merchantOrderId);

                // Make the request.
                return service.Orders.Getbymerchantorderid(merchantId, merchantOrderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Getbymerchantorderid failed.", ex);
            }
        }

        /// <summary>
        /// Sandbox only. Retrieves an order template that can be used to quickly create a new order in sandbox. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/gettestordertemplate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="templateName">The name of the template to retrieve.</param>
        /// <returns>OrdersGetTestOrderTemplateResponseResponse</returns>
        public static OrdersGetTestOrderTemplateResponse Gettestordertemplate(ShoppingcontentService service, string merchantId, string templateName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (templateName == null)
                    throw new ArgumentNullException(templateName);

                // Make the request.
                return service.Orders.Gettestordertemplate(merchantId, templateName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Gettestordertemplate failed.", ex);
            }
        }
        public class OrdersListOptionalParms
        {
            /// Obtains orders that match the acknowledgement status. When set to true, obtains orders that have been acknowledged. When false, obtains orders that have not been acknowledged.We recommend using this filter set to false, in conjunction with the acknowledge call, such that only un-acknowledged orders are returned.
            public bool? Acknowledged { get; set; }  
            /// The maximum number of orders to return in the response, used for paging. The default value is 25 orders per page, and the maximum allowed value is 250 orders per page.Known issue: All List calls will return all Orders without limit regardless of the value of this field.
            public int? MaxResults { get; set; }  
            /// The ordering of the returned list. The only supported value are placedDate desc and placedDate asc for now, which returns orders sorted by placement date. "placedDate desc" stands for listing orders by placement date, from oldest to most recent. "placedDate asc" stands for listing orders by placement date, from most recent to oldest. In future releases we'll support other sorting criteria.
            public string OrderBy { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
            /// Obtains orders placed before this date (exclusively), in ISO 8601 format.
            public string PlacedDateEnd { get; set; }  
            /// Obtains orders placed after this date (inclusively), in ISO 8601 format.
            public string PlacedDateStart { get; set; }  
            /// Obtains orders that match any of the specified statuses. Multiple values can be specified with comma separation. Additionally, please note that active is a shortcut for pendingShipment and partiallyShipped, and completed is a shortcut for shipped , partiallyDelivered, delivered, partiallyReturned, returned, and canceled.
            public string Statuses { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the orders in your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OrdersListResponseResponse</returns>
        public static OrdersListResponse List(ShoppingcontentService service, string merchantId, OrdersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Orders.List(merchantId);

                // Applying optional parameters to the request.                
                request = (OrdersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.List failed.", ex);
            }
        }

        /// <summary>
        /// Refund a portion of the order, up to the full amount paid. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/refund
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order to refund.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersRefundResponseResponse</returns>
        public static OrdersRefundResponse Refund(ShoppingcontentService service, string merchantId, string orderId, OrdersRefundRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Refund(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Refund failed.", ex);
            }
        }

        /// <summary>
        /// Returns a line item. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/returnlineitem
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersReturnLineItemResponseResponse</returns>
        public static OrdersReturnLineItemResponse Returnlineitem(ShoppingcontentService service, string merchantId, string orderId, OrdersReturnLineItemRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Returnlineitem(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Returnlineitem failed.", ex);
            }
        }

        /// <summary>
        /// Marks line item(s) as shipped. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/shiplineitems
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersShipLineItemsResponseResponse</returns>
        public static OrdersShipLineItemsResponse Shiplineitems(ShoppingcontentService service, string merchantId, string orderId, OrdersShipLineItemsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Shiplineitems(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Shiplineitems failed.", ex);
            }
        }

        /// <summary>
        /// Updates the merchant order ID for a given order. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/updatemerchantorderid
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersUpdateMerchantOrderIdResponseResponse</returns>
        public static OrdersUpdateMerchantOrderIdResponse Updatemerchantorderid(ShoppingcontentService service, string merchantId, string orderId, OrdersUpdateMerchantOrderIdRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Updatemerchantorderid(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Updatemerchantorderid failed.", ex);
            }
        }

        /// <summary>
        /// Updates a shipment's status, carrier, and/or tracking ID. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/orders/updateshipment
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>OrdersUpdateShipmentResponseResponse</returns>
        public static OrdersUpdateShipmentResponse Updateshipment(ShoppingcontentService service, string merchantId, string orderId, OrdersUpdateShipmentRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Updateshipment(body, merchantId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Updateshipment failed.", ex);
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