Linq

```c#


//Student

namespace MvcApp.Controllers{
	public class MyindexController : Controller{
        //
        mydbDataContext mycontext = new mydbDataContext();    
        public ActionResult create(){
            Goods delins = new Goods();
            
 		   //添加  实例化一个对象
            delins.name = name;
            mycontext.Goods.InsertOnSubmit(delins);
            
            Goods delins = mycontext.Goods.Where(o => o.id == id).First();
            //删除  找到一个id及此对象
            mycontext.Goods.DeleteOnSubmit(delins);
            mycontext.SubmitChanges();       
            //编辑  找到一个id对象 并修改
            mycontext.Goods.EditOnSubmit(delins);
            mycontext.SubmitChanges();
            
            //提交修改
		   mycontext.SubmitChanges();
		    //查询全部
            List<Goods> result = mycontext.Goods.ToList();
            //将查询结果显示
            List<String> resulter = new List<String>();
            String s;
            foreach(Goods item in result){
			  s = item.id.toString();
               resulter.add(s +"."+item.name);
            }
            Session["result"]=resulter;
          	return View();
        }
    }
}




```

