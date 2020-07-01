using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //for arraylist

namespace smjConsoleApplication1
{
    class sale
    {
        string customerName;
        DateTime localDate;
        int refreshmentCost;
        int totalCost;
        int cashReceived;
        int cashReturned;
        teaClass tea = new teaClass();
        refreshment refresh = new refreshment();

        public string customerNameProperty
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string flavourProperty
        {
            get{    return tea.teaFlavourProperty;  }
            set{    tea.teaFlavourProperty = value; }
        }

        public DateTime localDateProperty
        {
            get{    return localDate;    }
            set{    localDate = value;   }
        }

        public string refreshmentProperty
        {
            get { return refresh.refreshmentNameProperty; }
            set { refresh.refreshmentNameProperty = value; }
        }

        public int refreshmentCostProperty
        {
            get{    return refreshmentCost;    }
            set{    refreshmentCost = value;   }
        }

        public int totalCostProperty
        {
            get{    return totalCost;    }
            set{    totalCost = value;   }
        }

        public int cashReceivedProperty
        {
            get{    return cashReceived;    }
            set{    cashReceived = value;   }
        }

        public int cashReturnedProperty
        {
            get{    return cashReturned;    }
            set{    cashReturned = value;   }
        }

        public void newSale()
        {
            Console.WriteLine("Enter Tea Flavour:");
            Console.WriteLine("1. Pink Tea.");
            Console.WriteLine("2. Green Tea.");
            Console.WriteLine("3. English Tea.");
            int option1 = int.Parse(Console.ReadLine());

            if (option1 == 1)
            {
                flavourProperty = "Pink Tea";
            }
            else if (option1 == 2)
            {
                flavourProperty = "Green Tea";
            }
            else if (option1 == 3)
            {
                flavourProperty = "English Tea";
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Enter Refreshment Name:");
            Console.WriteLine("1. Muffins.");
            Console.WriteLine("2. Pastries.");
            Console.WriteLine("3. Biscuits.");
            int option2 = int.Parse(Console.ReadLine());

            if (option2 == 1)
            {
                flavourProperty = "Muffins";
            }
            else if (option2 == 2)
            {
                refreshmentProperty = "Pastries";
            }
            else if (option2 == 3)
            {
                refreshmentProperty = "Biscuits";
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Enter Customer Name:");
            customerNameProperty = Console.ReadLine();

            localDate = DateTime.Now;

            Console.WriteLine("Enter Cash Returned:");
            cashReturnedProperty = int.Parse(Console.ReadLine());

            totalCostProperty = (40 + 50);

            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Cash Received:");
                cashReceivedProperty = int.Parse(Console.ReadLine());
                if (cashReceived < totalCost)
                {
                    Console.WriteLine("ERROR!!! Enter Correct Amount");
                }
                else
                {
                    check = false;
                }
            }

            cashReturnedProperty = (cashReceived - totalCost);

            printInvoice();
            saleFileHandling sale =  new saleFileHandling();
            sale.saveNewSale(this);
        }

        public void printInvoice()
        {
            Console.WriteLine("-----------------------INVOICE-----------------------");
            Console.WriteLine("Customer Name: " + this.customerNameProperty);
            Console.WriteLine("Date and Time: " + this.localDateProperty);
            Console.WriteLine("Tea Flavour: " + this.flavourProperty);
            Console.WriteLine("Refreshment Name: " + this.refreshmentProperty);
            Console.WriteLine("Total Cost: " + this.totalCostProperty);
            Console.WriteLine("Cash Received: " + this.cashReceivedProperty);
            Console.WriteLine("Cash Returned: " + this.cashReturnedProperty);
        }

        public ArrayList getAllSales()
        {
            saleFileHandling obj = new saleFileHandling();
            return obj.collectAllSale();
        }
    }
}
