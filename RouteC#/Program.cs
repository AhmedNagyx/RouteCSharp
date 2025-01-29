using RouteC_;
using RouteC_.Classes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Choose
            //1 - What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class

            //2-Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private

            //3-Can an interface contain fields in C#?
            //c) Only if they are static

            //4-In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces

            //5-Which keyword is used to implement an interface in a class in C#?
            //" : ", Not in the answers.

            //6-Can an interface contain static methods in C#?
            //a) Yes

            //7-In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            //8-What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members

            //9-In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors

            //10-How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            #region Q2
            //IShape shape1 = new Circle(10);
            //shape1.DisplayShapeInfo();
            //Console.WriteLine();
            //IShape shape2 = new Rectangle(10,20);
            //shape2.DisplayShapeInfo();
            #endregion

            #region Q3
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //string username = "Ahmed";
            //string password = "1234";
            //string role = "Admin";

            //if (authenticationService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine($"User {username} is authenticated to enter.");
            //    if (authenticationService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine($"User {username} is authorized as {role}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"User is not authorized.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"User is not authenticated to enter.");

            //}
            #endregion

            #region Q4
            //INotificationService sms = new SmsNotificationService_();
            //sms.SendNotification("01021741188","hello in sms");
            //Console.WriteLine();
            //INotificationService push = new PushNotificationService();
            //push.SendNotification("xiaomi","hello in notfication");
            //Console.WriteLine();
            //INotificationService email = new EmailNotificationService_();
            //email.SendNotification("deadevilgamer32@gmail.com", "hello in email");
            #endregion
        }

    }
}
