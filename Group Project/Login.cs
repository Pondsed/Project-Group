using System.Collections.Generic;
using System;
public class Login {
    public bool InputLogin(List<User> listusers){
        Console.Clear();
        ShowInputMenu();
        int n = int.Parse(Console.ReadLine());
        if (n == 1){
            int inputphonenumber = Inputphonenumber();
            string password = InputPassword();
            foreach(User user in listusers){
                if(user.GetPhoneNumber() == inputphonenumber && user.GetPassword() == password){
                    ShowSuccesLoginMenu(user);
                    return true;
                }
            }
        }
        if (n == 2){
            string inputEmail = InputEmail();
            string password = InputPassword();
            foreach(User user in listusers){
                if(user.GetEmailUser() == inputEmail && user.GetPassword() == password){
                    ShowSuccesLoginMenu(user);
                    return true;
                }
            }
        }
        return false;
        }
        public void ShowInputMenu(){
            Console.WriteLine("Please select Login Menu");
        Console.WriteLine("1 = Login with Phone number");
        Console.WriteLine("2 = Login with Email");
        Console.Write("Menu : ");
        }
        public int Inputphonenumber(){
            Console.Write("Phone number : ");
            return int.Parse(Console.ReadLine());
        }
        public string InputPassword(){
            Console.Write("Password : ");
            return Console.ReadLine();
        }
        public string InputEmail(){
            Console.Write("Email : ");
            return Console.ReadLine();
        }
        public void ShowSuccesLoginMenu()
        }
    

