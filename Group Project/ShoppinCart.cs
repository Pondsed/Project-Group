public class ShoppingCart {
    private int cartID;
    private string foodName;
    private int quantity;
    private int timeAdded;

    public ShoppingCart(int cartID, string foodName, int quantity, int timeAdded) {
        this.cartID = cartID;
        this.foodName = foodName;
        this.quantity = quantity;
        this.timeAdded = timeAdded;
    }

    public static void AddCartItem() {
        Console.WriteLine("Select the menu");

    }

    public static void DeleteCartItem() {
        Console.WriteLine("Select the menu to delete");
    }

    public int UpdateQuantity() {
        return this.quantity;
    }

    public static void Timeadd() 
    {
        PickUpTime pickuptime = new PickUpTime(0,"",0,0,0);
        pickuptime.PickupMonth();
        pickuptime.PickupDate();
        pickuptime.PickupYear();
        pickuptime.PickupHour();
        pickuptime.PickupMinute();
    }

    public static void ViewCartDetail() {

Console.WriteLine("Your cart detail : {0}".UpdateQuantity());
    }

    public void BacktoMenu() {
        Console.Clear();
        InputMenuFromKeyboard();
    }
}