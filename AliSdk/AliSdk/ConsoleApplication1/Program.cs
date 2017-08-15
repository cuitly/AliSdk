using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api;
using AliSdk.Top.Api.Request;
using AliSdk.Top.Api.parser;
using AliSdk.Top.Api.Domain;
using AliSdk.Top.Api.Utils;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://gw.open.china.alibaba.com/openapi";
            string appkey = "1005806";
            string secret = "=Kl7n9riRho";
            TopJsonRestClient client = new TopJsonRestClient(url, appkey, secret);
            ////获取卖家自定义类目
            //SelfCatGetRequest request = new SelfCatGetRequest();
            //request.MemberId = "joeelife168";
            //List<SellerCat> result = client.SelfCatListGet(request);

            ////获取订单列表
            //OrderListGetRequest request = new OrderListGetRequest();
            //request.CreateStartTime = "2013-05-26 00:00:00";
            //request.SellerMemberId = "joeelife168";
            //client.OrderListGet(request, "5436111f-1729-4e38-b45b-f638a416adbe");

            ////获取订单详情
            //OrderFullInfoGetRequest request = new OrderFullInfoGetRequest();
            //request.OrderId = "356838164824240";
            //client.OrderListGet(request, "5436111f-1729-4e38-b45b-f638a416adbe");

            ////获取物流公司
            //LogisticsListGetRequest request = new LogisticsListGetRequest();
            //request.MemberId = "joeelife168";
            //client.LogisticsListGet(request, "dfaf2d6d-abc9-40bc-8d6f-cc811baa0956");

            //获取商品列表
            //OffersGetRequest request = new OffersGetRequest();
            //request.Type = "SALE";
            //request.ReturnFields = @"offerId,isPrivate,privateProperties,detailsUrl,postCategryId,type,tradeType,offerStatus,memberId,subject,details,qualityLevel,imageList,productFeatureList,isOfferSupportOnlineTrade,isSupportMix,tradingType,unit,priceUnit,amount,amountOnSale,saledCount,retailPrice,unitPrice,priceRanges,termOfferProcess,freightTemplateId,sendGoodsId,productUnitWeight,freightType,isSkuOffer,isSkuTradeSupported,skuArray,isSkuTradeSupported,gmtCreate,gmtModified,gmtApproved,gmtModified,gmtExpire";
            //client.OfferListGet(request, "5436111f-1729-4e38-b45b-f638a416adbe");

//              //获取商品详情
            OfferGetRequest request = new OfferGetRequest();
            request.OfferId = "1262147902";
            request.ReturnFields = @"offerId,userCategorys,isPrivate,privateProperties,detailsUrl,postCategryId,type,tradeType,offerStatus,memberId,subject,details,qualityLevel,imageList,productFeatureList,isOfferSupportOnlineTrade,isSupportMix,tradingType,unit,priceUnit,amount,amountOnSale,saledCount,retailPrice,unitPrice,priceRanges,termOfferProcess,freightTemplateId,sendGoodsId,productUnitWeight,freightType,isSkuOffer,isSkuTradeSupported,skuArray,isSkuTradeSupported,gmtCreate,gmtModified,gmtApproved,gmtModified,gmtExpire";
            Offer result = client.OfferGet(request);

            ////获取省份编码
            //AreaGetRequest request = new AreaGetRequest();
            //List<Area> result = client.AreaCodeGet(request);
        }
    }
}
