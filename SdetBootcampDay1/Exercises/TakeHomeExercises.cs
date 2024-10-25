using Microsoft.VisualBasic;
using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    /**
     * TODO: make sure that this class is recognized by NUnit as a class that contains tests.
     */
    public class TakeHomeExercises
    {
        /**
         * TODO: write a test that creates a new instance of the OrderHandler class,
         * places a new order for 1 copy of FIFA 24 (use the OrderItem.FIFA_24 enum value)
         * and verifies that the remaining number of copies of FIFA_24 on stock is 9.
         */
        [Test]
        public void OrderFIFA_24AndConfirmStock(){
            var orderHandler = new OrderHandler();
            orderHandler.OrderAndPay(OrderItem.FIFA_24, 1);

            Assert.That(orderHandler.GetStockFor(OrderItem.FIFA_24), Is.EqualTo(9));

        }
        


        /**
         * TODO: write a test that creates a new instance of the OrderHandler class
         * and verifies that placing an order for 101 copies of Fortnite yields an
         * ArgumentException with the message 'Insufficient stock for item Fortnite'.
         */

        [Test]
        public void Order101CopiesOfFortniteAndThrowsAnInsufficientStockError(){
            var orderHandler = new OrderHandler();
            var ae = Assert.Throws<ArgumentException>(()=>{
                orderHandler.OrderAndPay(OrderItem.Fortnite, 101);
            });

            Assert.That(ae.Message, Is.EqualTo("Insufficient stock for item Fortnite"));
        }
        


        /**
         * TODO: write a test that creates a new instance of the OrderHandler class
         * and verifies that trying to add new stock for Day Of The Tentacle yields
         * an ArgumentException with the message 'Unknown item DayOfTheTentacle'.
         */

        [Test]
        public void OrderDayOfTheTentacleAndThrowUnknownItemError(){
            var orderHandler = new OrderHandler();
            var ae = Assert.Throws<ArgumentException>(()=>{
                orderHandler.AddStock(OrderItem.DayOfTheTentacle, 1);
            });

            Assert.That(ae.Message, Is.EqualTo("Unknown item DayOfTheTentacle"));
        }


        /**
         * TODO: after you have written all of the above tests, calculate the code coverage.
         * What does this tell you? Do we need to write more tests? Can you think of any cases that
         * we haven't covered yet? Add tests for these cases, too and see if you can further improve
         * code coverage.
         */


        [Test]
        public void GetStockForFortnite(){
            var orderHandler = new OrderHandler();
            orderHandler.AddStock(OrderItem.Fortnite, 11);

            Assert.That(orderHandler.GetStockFor(OrderItem.Fortnite), Is.EqualTo(111));
        }

        /**
         * THINK: there are some problems with the code of the OrderHandler class
         * that make it hard to write good tests. Can you spot some of the problems
         * and explain why exactly these are problems? We'll discuss these tomorrow.
         */

         //One thing is that the order handler has hard-coded stock in the constructor function, and the payment processor is always going to be Stripe because it's hard-coded as well


         //Order and Pay could be split into separate methods
    }
}
