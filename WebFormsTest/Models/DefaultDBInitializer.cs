using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebFormsTest.Models
{
    public class DefaultDBInitializer : DropCreateDatabaseIfModelChanges<DefaultContext>
    {
        protected override void Seed(DefaultContext context)
        {
            GetCustomers().ForEach(x => context.Customers.Add(x));
            GetPayments().ForEach(x => context.Payments.Add(x));
        }

        private static List<Customer> GetCustomers()
        {
            var customers = new List<Customer> {
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Microsoft"
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "IBM"
                },
                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "TireFitting24"
                }
            };

            return customers;
        }

        private static List<Payment> GetPayments()
        {
            Random rnd = new Random();

            var payments = new List<Payment> {
                new Payment
                {
                    PaymentId = 1,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 250,
                    CustomerId = 1
                },
                new Payment
                {
                    PaymentId = 2,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 500,
                    CustomerId = 1
                },
                new Payment
                {
                    PaymentId = 3,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 750,
                    CustomerId = 1
                },
                new Payment
                {
                    PaymentId = 4,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 1000,
                    CustomerId = 1
                },
                new Payment
                {
                    PaymentId = 5,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 1250,
                    CustomerId = 1
                },
                new Payment
                {
                    PaymentId = 6,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 100,
                    CustomerId = 2
                },
                new Payment
                {
                    PaymentId = 7,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 200,
                    CustomerId = 2
                },
                new Payment
                {
                    PaymentId = 8,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 300,
                    CustomerId = 2
                },
                new Payment
                {
                    PaymentId = 9,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 400,
                    CustomerId = 2
                },
                new Payment
                {
                    PaymentId = 10,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 500000,
                    CustomerId = 3
                },
                new Payment
                {
                    PaymentId = 11,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 600000,
                    CustomerId = 3
                },
                new Payment
                {
                    PaymentId = 12,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 700000,
                    CustomerId = 3
                },
                new Payment
                {
                    PaymentId = 13,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 800000,
                    CustomerId = 3
                },
                new Payment
                {
                    PaymentId = 14,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 900000,
                    CustomerId = 3
                },
                new Payment
                {
                    PaymentId = 15,
                    PaymentDate = DateTime.UtcNow.AddDays(rnd.Next(0, 3)),
                    Sum = 1000000,
                    CustomerId = 3
                }
            };

            return payments;
        }
    }
}