namespace ExampleWithGroupBy
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}