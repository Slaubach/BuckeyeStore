using System;
using System.Collections.Generic;
using System.Text;

namespace BuckeyeStore
{
    class producttest
    {
        public void Test();
        {
        var product = new product
        {
            id = 1,
            name = "t-shirt",
            brand = "nike"
        };
        var review = new review
        {
            id = 1,
            body = "a durable buckeye t-shirt"
        };
        product.addreview(review);
            assert.notnull(product.review);
            Assert.equal(review.id, priduct.review.id);
            assert.exual(review.body, product.review.body);
        }
        }

    

