using System;
using System.Collections.Generic;
class MainMenu{
  private Register registermenu;
  private Login loginmenu;
  private List<User> userList;
  public void ShowMainMenu(){
    PrepareListUsersWhenMainScreenIsLoaded();
    Console.WriteLine("Welcome to KMUTT Bangkhuntian Canteen");
    Console.WriteLine("1 : Register Menu");
    Console.WriteLine("2 : Login Menu");
    Console.Write("Please input Menu : ");
    int menu = int.Parse(Console.ReadLine());
    switch(menu){
        case 1:
        LoginMenu();
        bool verify = this.loginmenu.InputLogin(this.userList);
        ShowLoginIncorrectScreen(verify);
        break;
        case 2:
        RegisterMenu();
        this.userList.Add(this.registermenu.InputRegister());
        break;
        default:
        break;
    }
  }
  private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.userList = new List<User>();
    }
    public void LoginMenu(){
        this.loginmenu = new Login();
        this.loginmenu.InputLogin(userList);
    }
     public void RegisterMenu() {
        this.registermenu = new Register();
        this.registermenu.InputRegister();
    }
    public void ShowLoginIncorrectScreen(bool verifystatus){
        if(!verifystatus){
            Console.WriteLine("Login Fail Please try again");
            ShowMainMenu();
        }
    }
}