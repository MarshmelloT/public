using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test20230527.Models;

namespace Test20230527.Controllers
{
    public class BiddingsController : Controller
    {
        private TestEntities db = new TestEntities();

        /// <summary>
        /// 封装一个设置工程分类的方法每次调用把分类记录到ViewBag里视图可以直接取
        /// </summary>
        public void SetProTypeList()
        {
            ViewBag.ProTypeList = db.ProjectType.ToList();
        }

        // GET: Biddings
        public ActionResult Index(string ProName = "", int ProTypeID = 0)
        {
            //设置分类到ViewBag值
            SetProTypeList();
            //记录查询的分类id视图要用
            ViewBag.CheckTypeID = ProTypeID;
            //查询数据
            var ProList = db.Bidding.Where(b => b.ProName.Contains(ProName));
            //判断是否选了分类
            if (ProTypeID > 0)
            {
                ProList = ProList.Where(b => b.ProTypeID == ProTypeID);
            }
            //返回查询的视图及数据
            return View(ProList.ToList());
        }

        // GET: Biddings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bidding bidding = db.Bidding.Find(id);
            if (bidding == null)
            {
                return HttpNotFound();
            }
            return View(bidding);
        }

        // GET: Biddings/Create
        public ActionResult Create()
        {
            //设置分类到ViewBag值
            SetProTypeList();
            return View();
        }

        // POST: Biddings/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性。有关
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProName,ProTypeID,ProAddress,Input,Date,Charge,Unit,Amount,Contacts,Tel")] Bidding bidding)
        {
            if (ModelState.IsValid)
            {
                db.Bidding.Add(bidding);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //设置分类到ViewBag值
            SetProTypeList();
            return View(bidding);
        }

        // GET: Biddings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bidding bidding = db.Bidding.Find(id);
            if (bidding == null)
            {
                return HttpNotFound();
            }
            //设置分类到ViewBag值
            SetProTypeList();
            return View(bidding);
        }

        // POST: Biddings/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性。有关
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProName,ProTypeID,ProAddress,Input,Date,Charge,Unit,Amount,Contacts,Tel")] Bidding bidding)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bidding).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //设置分类到ViewBag值
            SetProTypeList();
            return View(bidding);
        }

        // GET: Biddings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bidding bidding = db.Bidding.Find(id);
            if (bidding == null)
            {
                return HttpNotFound();
            }
            return View(bidding);
        }

        // POST: Biddings/Delete/5
        //因为删除重定向为GET方式请求，故注释以下两个特性
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bidding bidding = db.Bidding.Find(id);
            db.Bidding.Remove(bidding);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
