using System;
using System.Collections.Generic;
using data_soruce_mil.daos;
using data_soruce_mil.models;

namespace data_soruce_mil.services
{

    public interface ITestPurhaseIntentionService
    {

        bool CreateTestPurchaseIntention(TestPurchaseIntention purchaseIntention);
        List<TestPurchaseIntention> GetTestPurchaseIntentions();


    }
    public class TestPurhaseIntentionService : ITestPurhaseIntentionService
    {
        private TestPurchaseIntentionDao _intentiomDao;


        public TestPurhaseIntentionService() => _intentiomDao = new TestPurchaseIntentionDao();


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