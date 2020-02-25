using System;
using System.Collections.Generic;
using data_soruce_mil.daos;
using data_soruce_mil.models;

namespace data_soruce_mil.services
{
    public class TestPurhaseIntentionService
    {
        private TestPurchaseIntentiomDao _intentiomDao;

        public TestPurhaseIntentionService(TestPurchaseIntentiomDao purchaseIntentiomDao)
        {
            _intentiomDao = purchaseIntentiomDao;
        }


        public bool CreateTestPurchaseIntention(TestPurchaseIntention purchaseIntention)
        {
            try
            {
                return  _intentiomDao .CreateTestPurchaseIntention(purchaseIntention);
            }
            catch (Exception ex)
            {
               throw  new Exception(ex.Message);
            }
        }

        public List<TestPurchaseIntention> GetTestPurchaseIntentions()
        {
            try
            {
                return _intentiomDao.GetAllPurchaseIntentions();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}