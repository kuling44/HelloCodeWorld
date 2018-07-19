# MyReflectionDemoT
反射调用测试
//Assembly myAssembly = Assembly.Load("Ruanmou.DB.SqlServer");// 获取反射文件路径
//Type myType = myAssembly.GetType("Ruanmou.DB.SqlServer.GenericMethod");//获取反射对象的对象类型
//object obMy = Activator.CreateInstance(myType);获取对象
//MethodInfo methodMy = myType.GetMethod("Show1", new Type[] { typeof(string), typeof(int), typeof(DateTime) });//获取对象的方法体，以及参数
//methodMy.Invoke(obMy, new object[] { "123", 1, DateTime.Now });//反射调用程序方法体
冲突测试，线上。
