using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoREPOSITORY;
namespace ConsoleDemo
{
    class Program
    {
        static void Main()
        {
            IDataAccess dataAccess = new DataAccessImplement();
            XpayModel xpayModel = new XpayModel();

            Console.WriteLine("Select Operation To Perform: ");
            Console.Write("Press 1 to Read Data: ");
            Console.WriteLine();
            Console.Write("Press 2 to Create Data: ");
            Console.WriteLine();
            Console.Write("Press 3 to Update Data: ");
            Console.WriteLine();
            Console.Write("Press 4 to Delete Data: ");
            Console.WriteLine();

            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    List<XpayModel> list = new List<XpayModel>();
                    list = dataAccess.Read();
                    Console.WriteLine("ID \t\t Name \t\t Description \t\t\t Amount \t\t Term and Condition");
                    foreach (var obj in list)
                    {
                        Console.WriteLine(obj.id+ "\t\t "+obj.Name + "\t\t " + obj.Description+ "\t\t\t " + obj.amount+ "\t\t\t "+obj.TermAndCondition);
                    }
                    break;
                case 2:
                    Console.Write("Enter New Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter T&C: ");
                    string tC = Console.ReadLine();
                    Console.WriteLine();
                    xpayModel.Name = name;
                    xpayModel.Description = description;
                    xpayModel.amount = amount;
                    xpayModel.TermAndCondition = tC;
                    Console.WriteLine();

                    dataAccess.Create(xpayModel);

                    Console.WriteLine();
                    Console.WriteLine("Data Inserted Successfully..");

                 
                    break;
                case 3:
                    Console.Write("Enter Id to Update Record: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter New Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter New Description: ");
                    string newDescription = Console.ReadLine();
                    Console.Write("Enter New Amount: ");
                    
                    int newAmount =int.Parse( Console.ReadLine());
                    Console.Write("Enter New TermAndCondition: ");
                    string newTC = Console.ReadLine();
                    Console.WriteLine();
                    xpayModel.id = id;
                    xpayModel.Name = newName;
                    xpayModel.Description = newDescription;
                    xpayModel.amount = newAmount;
                    xpayModel.TermAndCondition = newTC;

                    dataAccess.Update(xpayModel);

                    Console.WriteLine();
                    Console.WriteLine("Record Updated Successfully..");

                    break;
                case 4:
                    Console.Write("Enter ID: ");
                    int eid =int.Parse( Console.ReadLine());
                    Console.WriteLine();
                    xpayModel.id = eid;
                    dataAccess.Delete(xpayModel);
                    Console.WriteLine("Record Deleted Successfully..");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Try Again..");
                    break;
            }
            Console.WriteLine();
            Main();
             Console.WriteLine();
            Console.ReadLine();


        }
    }
}
