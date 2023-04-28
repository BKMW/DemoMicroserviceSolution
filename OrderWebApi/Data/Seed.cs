using MongoDB.Driver;
using OrderWebApi.Entities;

namespace OrderWebApi.Data
{
    public class Seed
    {
        public static async Task SeedData(IMongoCollection<Order> collection)
        {
            bool existProduct = collection.Find(p => true).Any();
            if (!existProduct)
            {
                await collection.InsertManyAsync(new List<Order>
                {
                    new Order
                    {
                        Id="",
                        CustomerId=1,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                    new Order
                    {
                         Id="",
                        CustomerId=2,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                    new Order
                    {
                        Id="",
                        CustomerId=3,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                    new Order
                    {
                      Id="",
                        CustomerId=4,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                    new Order
                    {
                        Id="",
                        CustomerId=5,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                    new Order
                    {
                         Id="",
                        CustomerId=6,
                        OrderedOn=DateTime.Now,
                        OrderDetails=
                        {
                            new OrderDetail
                            {
                                ProductId=1,
                                UnitPrice=999,
                                Quantity=1
                            }
                        }
                    },
                });
            }
        }


    }
}
