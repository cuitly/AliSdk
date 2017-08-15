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
//test
        static void Main(string[] args)
        {
            string url = "http://gw.open.1688.com/openapi";
            string appkey = "1007562";
            string secret = "HwHpTL3PGFr~";
            string access_token = "c46e9b19-73e7-428c-bf7e-7615f75367de";
            TopJsonRestClient client = new TopJsonRestClient(url, appkey, secret);
            ////获取卖家自定义类目
            //SelfCatGetRequest request = new SelfCatGetRequest();
            //request.MemberId = "joeelife168";
            //List<SellerCat> result = client.SelfCatListGet(request);

            //获取订单列表
            OrderListGetRequest request = new OrderListGetRequest();
            request.CreateStartTime = "2016-01-09 00:00:00";
            request.CreateEndTime = "2016-03-10 23:00:00";
            //request.ModifyStartTime = "2016-02-18 00:00:00";//20160118000000000-0800
            //request.ModifyEndTime = "2016-02-19 16:00:00";
            request.SellerMemberId = "b2b-1820152771";
            request.OrderStatus = "WAIT_SELLER_SEND";
            //request.PageNo = 1;
            //request.PageSize = 1;
            var t = client.OrderListGet(request, access_token);
            Console.WriteLine();
            //LoginIdsGetRequest request = new LoginIdsGetRequest();
            //List<string> list = new List<string>();
            //list.Add("b2b-1820152771");
            //request.MemberIds = list;
            //client.MerberIdToLoginId(request);


            //获取订单详情
            //OrderFullInfoGetRequest request = new OrderFullInfoGetRequest();
            //request.OrderId = "1473062980651493";
            //request.NeedOrderEntries = true;
            //request.NeedInvoiceInfo = true;
            //request.NeedOrderMemoList = true;
            //request.NeedLogisticsOrderList = true;
            //var response = client.OrderListGet(request, access_token);
            ////获取物流公司
            //LogisticsListGetRequest request = new LogisticsListGetRequest();
            //request.MemberId = "joeelife168";
            //client.LogisticsListGet(request, access_token);

            //获取商品列表
            //OffersGetRequest request = new OffersGetRequest();
            //request.Type = "SALE";
            //request.PageNo = 3;
            //request.PageSize = 35;
            //request.ReturnFields = @"offerId,isPrivate,privateProperties,detailsUrl,postCategryId,type,tradeType,offerStatus,memberId,subject,details,qualityLevel,imageList,productFeatureList,isOfferSupportOnlineTrade,isSupportMix,tradingType,unit,priceUnit,amount,amountOnSale,saledCount,retailPrice,unitPrice,priceRanges,termOfferProcess,freightTemplateId,sendGoodsId,productUnitWeight,freightType,isSkuOffer,isSkuTradeSupported,skuArray,isSkuTradeSupported,gmtCreate,gmtModified,gmtApproved,gmtModified,gmtExpire";
            //client.OfferListGet(request, access_token);

//              //获取商品详情
            //OfferGetRequest request = new OfferGetRequest();
            //request.OfferId = "1262147902";
            //request.ReturnFields = @"offerId,retailPrice,userCategorys,isPrivate,privateProperties,detailsUrl,postCategryId,type,tradeType,offerStatus,memberId,subject,details,qualityLevel,imageList,productFeatureList,isOfferSupportOnlineTrade,isSupportMix,tradingType,unit,priceUnit,amount,amountOnSale,saledCount,retailPrice,unitPrice,priceRanges,termOfferProcess,freightTemplateId,sendGoodsId,productUnitWeight,freightType,isSkuOffer,isSkuTradeSupported,skuArray,isSkuTradeSupported,gmtCreate,gmtModified,gmtApproved,gmtModified,gmtExpire";
            //Offer result = client.OfferGet(request);

            ////获取省份编码
            //AreaGetRequest request = new AreaGetRequest();
            //List<Area> result = client.AreaCodeGet(request);

            //获取商品卖家自定义类目
            //OffersUserCategoryGetRequest request = new OffersUserCategoryGetRequest();
            //request.OfferIds = "1262147902;1262281135";
            //List<OfferUserCategory> result = client.OfferUserCategorysGet(request, access_token);

            //OfferModifyRequest request = new OfferModifyRequest();
            //request.Offer = "{\"offerId\":\"1262147902\",\"skuList\":\"[{\\\"specAttributes\\\":{\\\"3216\\\":\\\"白色\\\",\\\"450\\\":\\\"XS\\\"},\\\"amountOnSale\\\":80,\\\"cargoNumber\\\":\\\"0010108\\\"}]\"}";
            //    client.OfferModify(request, access_token);

            //修改商品货号、数量
            //OfferModifyRequest request = new OfferModifyRequest();
            //request.OfferId = "1262147902";
            //request.AmountOnSale = 100;
            //List<SkuInfo> skus = new List<SkuInfo>();
            //SkuInfo sku = new SkuInfo();
            //sku.AmountOnSale = 1;
            //sku.CargoNumber = "1111";
            //sku.SpecAttributes = "\"3216\":\"白色\",\"450\":\"XS\"";
            //skus.Add(sku);
            ////SkuInfo sku1 = new SkuInfo();
            ////sku1.AmountOnSale = 100000;
            ////sku1.CargoNumber = "222";
            ////sku1.SpecAttributes = "\"3216\":\"白色\",\"450\":\"S\"";
            ////skus.Add(sku1);
            //request.skus = skus;
            //client.OfferModify(request, access_token);

            //获取订单物流信息
            //LogisticsOrdersGetRequest request = new LogisticsOrdersGetRequest();
            //request.MemberId = "joeelife168";
            //request.OrderId = "353932845967412";
            //request.TradeSourceType = "cbu-trade";
            //client.LogisticsOrderGet(request, access_token);

            //线下发货
            //LogisticsOfflineSendRequest request = new LogisticsOfflineSendRequest();
            //request.MemberId = "joeelife168";
            //request.OrderId = "360313162783272";
            //request.TradeSourceType = "cbu-trade";
            //request.OrderEntryIds = "360313162793272,360313162803272";
            //request.GmtLogisticsCompanySend = "2012-04-13 09:38:00";
            //request.GmtSystemSend = "2012-04-13 09:38:00";
            //request.LogisticsBillNo = "3173681495";
            //request.LogisticsCompanyId = "2";
            //request.Remarks = "";
            
            //client.LogisticesOfflineSend(request, access_token);

            //虚拟发货
            //LogisticsDummySendRequest request = new LogisticsDummySendRequest();
            //request.MemberId = "joeelife168";
            //request.OrderId = "35393284596741211";
            //request.TradeSourceType = "cbu-trade";
            //request.OrderEntryIds = "353932845977412";
            //request.GmtSystemSend = "2012-04-13 09:38:00";
            //request.Remarks = "";
            //client.LogisticesDummySend(request, access_token);

            //商品下架
            //OfferExpireRequest request = new OfferExpireRequest();
            //request.OfferIds = "1262147902;1262281135";
            //client.OfferExpire(request, access_token);

            //OfferStockModifyRequest req = new OfferStockModifyRequest();
            //req.OfferId = 520573964344;
            //req.OfferAmountChange = 20;
            //var result = client.OfferStockModify(req, access_token);
        }
    }
}
