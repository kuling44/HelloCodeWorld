using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace MyReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

           // System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
           // xml.Load("标准打印格式.xml");

           // System.Xml.XmlNodeList nodeList = xml.SelectNodes(@"//datas/standard_template_result");
           // string err=string.Empty;
           //List<string> _list=new List<string>();
           // foreach (System.Xml.XmlNode item in nodeList)
           // {
                
           //     string cp_code=item["cp_code"].InnerText.ToString();
           //     string standard_template_id = item["standard_templates"]["standard_template_do"]["standard_template_id"].InnerText.ToString();
           //     string standard_template_name = item["standard_templates"]["standard_template_do"]["standard_template_name"].InnerText.ToString();
           //     string standard_template_url = item["standard_templates"]["standard_template_do"]["standard_template_url"].InnerText.ToString();

           //     StringBuilder sb=new StringBuilder("insert into zq_cn_print_template   (cp_code, bz_template_id, bz_template_name, bz_template_url, sl_template_id, sl_template_name, sl_sl_template_url) values (");

           //     sb.Append("'"+cp_code+"','"+standard_template_id+"','"+standard_template_name+"','"+standard_template_url+"',");
               
           //     int _int = 0;
           //     foreach (System.Xml.XmlNode item1 in item["standard_templates"])
           //     {
                    
           //         if (_int==0)
           //         {
           //             _int++;
           //             continue;
           //         }
           //         _int++;
           //         string standard_template_id_SL = item1["standard_template_id"].InnerText.ToString();
           //         string standard_template_name_SL = item1["standard_template_name"].InnerText.ToString();
           //         string standard_template_url_SL = item1["standard_template_url"].InnerText.ToString();
           //         sb.Append("'"+standard_template_id_SL+"','"+standard_template_name_SL+"','"+standard_template_url_SL+"' )");

           //     }
           //     if (_int==1)
           //     {
           //         sb.Append("'','','' )");

           //     }
           //     _list.Add(sb.ToString());
           // }

           // K12DbWork.DBWork dbXML = new K12DbWork.DBWork("user id=zs_test;password=zs_test;data source=253");
           // dbXML.InserteDB(_list.ToArray(), ref err);

           // Console.ReadKey();

            #endregion

            //Assembly myAssembly = Assembly.Load("Ruanmou.DB.SqlServer");// 获取反射文件路径
            //Type myType = myAssembly.GetType("Ruanmou.DB.SqlServer.GenericMethod");//获取反射对象的对象类型
            //object obMy = Activator.CreateInstance(myType);获取对象
            //MethodInfo methodMy = myType.GetMethod("Show1", new Type[] { typeof(string), typeof(int), typeof(DateTime) });//获取对象的方法体，以及参数
            //methodMy.Invoke(obMy, new object[] { "123", 1, DateTime.Now });//反射调用程序方法体

            #region 助手发货测试

            Assembly myFH = Assembly.Load("ZQQiOrderSend");
            Type myFhType = myFH.GetType("ZQQiOrderSend.ZQQiYouZanSend");
            object obFh = Activator.CreateInstance(myFhType);
            MethodInfo methodMy = myFhType.GetMethod("YZMXFH");//, new Type[] { typeof(DataSet), typeof(String[]), typeof(String) });
            //methodMy.Invoke(myFhType, new object[] { "123", 1, DateTime.Now });

            DataSet ds = new DataSet();
            String strMessage = string.Empty;

            string[] sqlList = new string[] { "select t.tid as KHDDH,'2222' as CYSID,'YSDH123456' as YSDH,tid as KHDDHMX from zq_youzan_order t where t.tid='11'", "select T.OID AS KHDDHMX from zq_youzan_orderMX t where t.tid='11' ", "select * from zqqikeyinfo t where t.shopid='YOUZANSHOP2'" };
            K12DbWork.DBWork db = new K12DbWork.DBWork("user id=zs_test;password=zs_test;data source=96");
            ds = db.SelectDB(sqlList, new string[] { "a", "b","c" }, ref strMessage);

            String[] sql = null;

            object[] arg = new object[] { ds, sql, strMessage };
            methodMy.Invoke(obFh, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);
            Console.ReadKey();


            #endregion

            #region 菜鸟打印
            //Assembly cnAssembly = Assembly.Load("ZQQI_CaiNiaoPrint");
            //Type cnType = cnAssembly.GetType("ZQQI_CaiNiaoPrint.ClassPrint");
            //object obMy = Activator.CreateInstance(cnType);
            //MethodInfo method = cnType.GetMethod("PrintWork");
            ////(DataSet ds, ref String[] sqls, ref String strMessage)

            //DataSet ds = new DataSet();
            //string strMessage = string.Empty;

            //string[] sqlList = new string[] { "SELECT * FROM CN_PRINT_DEMO ", "SELECT * FROM CN_PRINT_DEMO_ZDY" };
            //K12DbWork.DBWork db = new K12DbWork.DBWork("user id=zs_test;password=zs_test;data source=253");
            //ds = db.SelectDB(sqlList, new string[] { "a", "b" }, ref strMessage);

            //string[] sql = null;

            //object[] arg = new object[] { ds, sql, strMessage };
            //method.Invoke(obMy, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);
            //Console.ReadKey();
            #endregion

            // Assembly
            //
            #region
            //Assembly myAssembly = Assembly.Load("ZQZYApiForTm");
            //Type type = myAssembly.GetType("ZQZYApiForTm.ZQZYApiForCaiNiao");
            ////object oTest = Activator.CreateInstance(type, "HYnwzeFGYumXBpGg7XyT+VEUQOQFVweZiADX1bvXbTYdLo6bytjPqw==");//实例化
            //object oTest = Activator.CreateInstance(type, "zEoqeJSuSy/LrrJnuH30wExyVKL1cPvxlnx2vnZtBUhpziiaQ5nvS0qvSQC5w3PfQ2ChDpvz28vFGv7+vrxf3hdnKzP79gyd2Az6HMkgel2MleWorIaiIg==");//实例化
            ////GetCaiNiaoWaybillcode(string ShopName, string cp_code, string cp_type, string code, DataTable dt, ref string waybillcode, ref string strErr)
            //string ShopName = "钟华图书专营店";
            //string cp_code="ZTO";
            //string cp_type = "加盟";
            //string code = "01187";
            ////01187
            ////01413

            //DataTable dt=new DataTable();
            //string waybillcode=string.Empty;
            //string strErr = string.Empty;
            //MethodInfo method = type.GetMethod("GetCaiNiaoWaybillcode");
            //object[] arg = new object[] { ShopName, cp_code, cp_type, code, dt, waybillcode, strErr };
            ////method.Invoke(oTest, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);

            ////method = type.GetMethod("UpdateCaiNiaoWaybillcode");
            ////method.Invoke(oTest, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);

            ////method = type.GetMethod("CancelCaiNiaoWaybillcode");
            ////method.Invoke(oTest, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);

            //type = myAssembly.GetType("ZQZYApiForTm.ZQZYApiForSendGoods");
            //oTest = Activator.CreateInstance(type, "zEoqeJSuSy/LrrJnuH30wExyVKL1cPvxlnx2vnZtBUhpziiaQ5nvS0qvSQC5w3PfQ2ChDpvz28vFGv7+vrxf3hdnKzP79gyd2Az6HMkgel2MleWorIaiIg==");//实例化
            //method = type.GetMethod("GetTradeFullinfo");
            ////public Boolean GetTradeFullinfo(String ShopName, String Tid, String TidFields, String OidFields, String DetailsFields, ref DataSet dsInfo, ref String ErrorMsg)
            //DataSet dsInfo = new DataSet();
            //arg = new object[] { ShopName, "75450031829009606", "tid,num,num_iid,status,title,type,price,discount_fee,has_post_fee,total_fee,created,pay_time,modified,end_time,buyer_message,buyer_memo,buyer_flag,seller_memo,seller_flag,invoice_name,buyer_nick,credit_card_fee,step_trade_status,step_paid_fee,mark_desc,shipping_type,buyer_cod_fee,adjust_fee,trade_from,buyer_rate,seller_nick,pic_path,payment,seller_rate,post_fee,receiver_name,receiver_state,receiver_city,receiver_district,receiver_address,receiver_zip,receiver_mobile,receiver_phone,consign_time,received_payment", "oid,status,title,price,num_iid,item_meal_id,sku_id,num,outer_sku_id,order_from,total_fee,payment,discount_fee,adjust_fee,modified,sku_properties_name,refund_id,is_oversold,is_service_order,end_time,item_meal_name,pic_path,seller_nick,buyer_nick,refund_status,outer_iid,snapshot_url,snapshot,timeout_action_time,buyer_rate,seller_rate,seller_type,cid", "", dsInfo, strErr };
            //method.Invoke(oTest, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);

            //try
            //{
            //    if (System.IO.File.Exists("AA.TXT"))
            //    {
            //        System.IO.File.Delete("AA.TXT");
            //    }
            //    dsInfo = (DataSet)arg[5];
            //    dsInfo.WriteXml("AA.TXT");
            //}
            //catch (Exception ex)
            //{

            //}
            #endregion

            //public bool SendGoods(string shopname, string DDhao, string strYDhao, string wlGSCode, string A, ref string strMessage, ref string errStr)
            //string DDhao = "123"; string strYDhao = "321"; string wlGSCode = "3333"; string A = ""; string strMessage = ""; string errStr = "";
            //type = myAssembly.GetType("ZQZYApiForTm.ZQZYApiForSendGoods");
            //oTest = Activator.CreateInstance(type, "zEoqeJSuSy/LrrJnuH30wExyVKL1cPvxlnx2vnZtBUhpziiaQ5nvS0qvSQC5w3PfQ2ChDpvz28vFGv7+vrxf3hdnKzP79gyd2Az6HMkgel2MleWorIaiIg==");
            //method = type.GetMethod("SendGoods");
            //arg = new object[] {ShopName,DDhao,strYDhao,wlGSCode,A,strMessage,errStr};
            //method.Invoke(oTest, BindingFlags.InvokeMethod, null, arg, System.Globalization.CultureInfo.CurrentCulture);

        }
    }
}
