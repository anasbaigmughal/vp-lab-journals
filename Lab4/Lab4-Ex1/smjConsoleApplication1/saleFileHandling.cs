using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace smjConsoleApplication1
{
    class saleFileHandling
    {
        public void saveNewSale(sale s)
        {
            StreamWriter writeFile = new StreamWriter("TeaShop.txt", true);
            writeFile.WriteLine(s.customerNameProperty);
            writeFile.WriteLine(s.localDateProperty);
            writeFile.WriteLine(s.flavourProperty);
            writeFile.WriteLine(s.refreshmentProperty);
            writeFile.WriteLine(s.totalCostProperty);
            writeFile.WriteLine(s.cashReceivedProperty);
            writeFile.WriteLine(s.cashReturnedProperty);
            writeFile.Close();
        }

      public ArrayList collectAllSale()
      {
          ArrayList list = new ArrayList();
          StreamReader readFile = new StreamReader("TeaShop.txt");
          sale s;

          while (!readFile.EndOfStream)
          {
              s = new sale();
              s.customerNameProperty = readFile.ReadLine();
              s.localDateProperty = DateTime.Parse(readFile.ReadLine());
              s.flavourProperty = readFile.ReadLine();
              s.refreshmentProperty = readFile.ReadLine();
              s.totalCostProperty = int.Parse(readFile.ReadLine());
              s.cashReceivedProperty = int.Parse(readFile.ReadLine());
              s.cashReturnedProperty = int.Parse(readFile.ReadLine());
              list.Add(s);
          }
          readFile.Close();
          return list;
      }
    }
}
