public class FoodMenu{
    private string foodname;
    private int normalprice;
    private int highprice;
    public FoodMenu(string foodname,int normalprice,int highprice){
        this.foodname = foodname;
        this.normalprice = normalprice;
        this.highprice = highprice;
    }
    public string GetFoodName(){
        return this.foodname;
    }
    public int GetNormalPrice(){
        return this.normalprice;
    }
    public int GetHighPrice(){
        return this.highprice;
    }

}