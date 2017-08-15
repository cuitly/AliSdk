using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using AliSdk.Top.Api.Request;
using AliSdk.Top.Api.parser;

namespace AliSdk.Top.Api
{
    public class TopJsonRestClient
    {
        private ITopClient client;

        public TopJsonRestClient(string url,string appKey, string appSecret)
        {
            client = new TopRestClient(url,appKey, appSecret);
        }

        /// <summary>
        /// TOP API: category.getSelfCatlist 
        /// </summary>
        public List<SellerCat> SelfCatListGet(SelfCatGetRequest request)
        {
            return client.Execute(request, new SelfCatGetParser());
        }

        /// <summary>
        /// TOP API: trade.order.orderList.get  
        /// </summary>
        public OrderListGetResponse OrderListGet(OrderListGetRequest request,string access_token)
        {
            return client.Execute(request, new OrderListGetParser(),true,access_token);
        }

        /// <summary>
        /// TOP API: trade.order.orderDetail.get 
        /// </summary>
        public Order OrderListGet(OrderFullInfoGetRequest request, string access_token)
        {
            return client.Execute(request, new OrderGetParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: trade.logisticsCompany.logisticsCompanyList.get 
        /// </summary>
        public List<LogisticsCompany> LogisticsListGet(LogisticsListGetRequest request, string access_token)
        {
            return client.Execute(request, new LogisticsListGetParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: trade.logisticsCompany.logisticsCompanyList.get 
        /// </summary>
        public OffersGetResponse OfferListGet(OffersGetRequest request, string access_token)
        {
            return client.Execute(request, new OffersGetParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: offer.get
        /// </summary>
        public Offer OfferGet(OfferGetRequest request)
        {
            return client.Execute(request, new OfferGetParser(), true);
        }

        /// <summary>
        /// TOP API: areaCode.get 
        /// </summary>
        public List<Area> AreaCodeGet(AreaGetRequest request)
        {
            return client.Execute(request, new AreaGetParser(), true);
        }
    }
}
