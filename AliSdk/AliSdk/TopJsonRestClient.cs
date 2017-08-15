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
        public List<SellerCat> SelfCatListGet(SelfCatGetRequest request,string access_token)
        {
            return client.Execute(request, new SelfCatGetParser(), true, access_token);
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
        /// TOP API: offer.getPublishOfferList 
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

        /// <summary>
        /// TOP API: userCategory.get.offerIds
        /// </summary>
        public List<OfferUserCategory> OfferUserCategorysGet(OffersUserCategoryGetRequest request, string access_token)
        {
            return client.Execute(request, new OfferUserCategoryGetParser(), true,access_token);
        }

        /// <summary>
        /// TOP API: offer.modify.increment 
        /// </summary>
        public bool OfferModify(OfferModifyRequest request, string access_token)
        {
            return client.Execute(request, new OfferModifyParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: offer.modify.increment 
        /// </summary>
        public bool OfferStockModify(OfferStockModifyRequest request, string access_token)
        {
            return client.Execute(request, new OfferStockModifyParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: e56.logistics.orders.get 
        /// </summary>
        public List<LogisticsOrder> LogisticsOrderGet(LogisticsOrdersGetRequest request, string access_token)
        {
            return client.Execute(request, new LogisticesOrderGetParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: e56.logistics.offline.send 
        /// </summary>
        public bool LogisticesOfflineSend(LogisticsOfflineSendRequest request, string access_token)
        {
            return client.Execute(request, new LogisticsSendParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: e56.logistics.dummy.send  
        /// </summary>
        public bool LogisticesDummySend(LogisticsDummySendRequest request, string access_token)
        {
            return client.Execute(request, new LogisticsSendParser(), true, access_token);
        }

        /// <summary>
        /// TOP API: offer.expire   
        /// </summary>
        public ReturnObject OfferExpire(OfferExpireRequest request, string access_token)
        {
            return client.Execute(request, new OfferExpireParser(), true, access_token);
        }

        /// <summary>
        /// TOP API:trade.order.batch.rate  
        /// </summary>
        public string OrderBatchRate(TradeOrderBathRate request, string access_token)
        {
            return client.Execute(request, new TradeOrderBathRateParser(), true, access_token);
        }


        /// <summary>
        /// TOP API:trade.order.batch.rate  
        /// </summary>
        public List<ProductAttributes> ProductAttribute(ProductAttributesGetRequest request, string access_token)
        {
            return client.Execute(request, new ProductAttributesGetParser(), true, access_token);
        }

        /// <summary>
        /// TOP API:convertLoginIdsByMemberIds
        /// </summary>
        public List<MemberLoginId> MerberIdToLoginId(LoginIdsGetRequest request)
        {
            return client.Execute(request, new LoginIdsGetParser(), true);
        }
    }
}
