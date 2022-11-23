public class CalculatePrice{
    public int subtotalprice;

    public CalculatePrice(int subtotalprice){
        this.subtotalprice = subtotalprice;
    }
    public int Calculateprice(){
       Console.WriteLine("your subtotal price is {0}",subtotalprice);
    }
}