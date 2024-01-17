
namespace The_Shopping_Basket
{
    public class Program
    {
        static void Main()
        {
            // We create a product
            Product product = new Product();
            // Let's ask the user for input
            Console.WriteLine("Hello, welcome to the Console-shop!");
            
            // 
            product.ReadInput();
            product.CalculateCost();
            product.ShowReceipt();
        }
    }
}
