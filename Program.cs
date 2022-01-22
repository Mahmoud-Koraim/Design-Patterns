﻿using System;
using DesignPatterns.singleton;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern - Lazy Initialization Implementation
            /*    Counter counter1 = Counter.GetInstance();
                Counter counter2 = Counter.GetInstance();
                counter1.AddOne();
                counter2.AddOne();

                Console.WriteLine("counter 1:" + counter1.Count.ToString());
                Console.WriteLine("counter 2:" + counter2.Count.ToString());
                Console.WriteLine();

                counter1.AddOne();
                Console.WriteLine("counter 1:" + counter1.Count.ToString());
                Console.WriteLine("counter 2:" + counter2.Count.ToString());
            */

            //Thread Safety Singleton Pattern Implementation
            /*
                 Task task1 = Task.Factory.StartNew(() => {  
                   Counter counter1 = Counter.GetInstance();
                   counter1.AddOne();
                   Console.WriteLine("counter 1 :"+ counter1.Count.ToString());
                }); 

                Task task2 = Task.Factory.StartNew(() => {  
                   Counter counter2 = Counter.GetInstance();
                   counter2.AddOne();
                   Console.WriteLine("counter 2 :"+ counter2.Count.ToString());
                   Console.WriteLine();
                }); 
            */
            #region prototype Implementation
            EmployeePrototype tempEmp1 = new TempEmployee();
            tempEmp1.Name = "Amr";
            tempEmp1.Id = 18;
            tempEmp1.EmpAddress = new Address { City = "Giza", Building = "B1", StreetName = "Alharm" };

            EmployeePrototype tempEmp2 = tempEmp1.ShallowCopy();

         // EmployeePrototype tempEmp2 = tempEmp1.DeepCopy();
            Console.WriteLine("========= Temp Emp 1 Original Values=============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 Copy========================");
            Console.WriteLine(tempEmp2.ToString());

            tempEmp2.EmpAddress.City = "maadi";
            tempEmp1.EmpAddress.Building = "B2";
    
            tempEmp2.Name = "Ali";
            tempEmp2.Id = 36;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 After Change =============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 ==========================");
            Console.WriteLine(tempEmp2.ToString());

            #endregion
            Console.ReadKey();
        }
    }
}

