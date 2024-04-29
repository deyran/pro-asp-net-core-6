namespace LanguageFeatures;

public class Product
{
    //! Assigning the Name property with default value, in this case null (string.Empty)
    public string Name { get; set; } = string.Empty;
    public decimal? Price { get; set; }
    public static Product?[] GetProducts()
    {
        Product kayak = new Product
        {
            Name = "Kayak",
            Price = 275M
        };
        Product lifejacket = new Product
        {
            Name = "Lifejacket",
            Price = 48.95M
        };
        return new Product?[] { kayak, lifejacket, null };
    }
}