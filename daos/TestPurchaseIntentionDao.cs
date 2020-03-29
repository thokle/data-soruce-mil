using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using  data_soruce_mil.models;
using System.Linq;
namespace data_soruce_mil.daos
{
    public class TestPurchaseIntentionDao
    {
        private groccitEntities groccitEntities;

        public TestPurchaseIntentionDao()
        {
            groccitEntities = new groccitEntities();
        }
        public bool CreateTestPurchaseIntention(TestPurchaseIntention purchaseIntention)
        {
            groccitEntities.tblTestPurchases.AddOrUpdate(Mapper.MapTo(purchaseIntention));
           var e =  groccitEntities.SaveChangesAsync();
            return e.Result == 1;
        }

        public List<TestPurchaseIntention> GetAllPurchaseIntentions()
        {

            return (from p in groccitEntities.tblTestPurchases
                    select new TestPurchaseIntention()
                    {

                        Brand = p.brand,
                        City = p.city,
                        Color = p.color,
                        Comment = p.comment,
                        Email = p.email,
                        Name = p.name,
                        Price = p.price.Value,
                        Size = p.size,
                        Types = p.type,
                        Url = p.url,
                        Zipcode = p.postnr.Value,
                        Phone = p.phone,
                        Model = p.model
                        
                    }).ToList();

        }

        private static TestPurchaseIntention NewMethod(tblTestPurchase p)
        {
            return new TestPurchaseIntention()
            {
               
            };
        }
    }

    public  class Mapper
    {
        public static tblTestPurchase MapTo(TestPurchaseIntention purchaseIntention)
        {
            var t = new tblTestPurchase();
            t.brand = purchaseIntention.Brand;
            t.city = purchaseIntention.City;
            t.color = purchaseIntention.Color;
            t.comment = purchaseIntention.Comment;
            t.email = purchaseIntention.Email;
            t.name = purchaseIntention.Name;
            t.phone = ""+purchaseIntention.Phone;
            t.postnr = purchaseIntention.Zipcode;
            t.price = purchaseIntention.Price;
            t.size = purchaseIntention.Size;
            t.type = purchaseIntention.Types;
            t.url = purchaseIntention.Url;
            t.model = purchaseIntention.Model;
            return t;

        }
    }
   

}