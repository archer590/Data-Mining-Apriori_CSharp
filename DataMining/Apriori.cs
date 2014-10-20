using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DataMining
{
    public class Apriori
    {
        public String[] attributes_name = null;

        public Apriori()
        {
            attributes_name = new String[] { "age", "job", "marital", "education", "default", "balance", "housing", "loan", "contact", "day", "month", "duration", "campaign", "pdays", "previuos", "poutcome", "y" };
        }

        public ArrayList ExtractData()
        {
            ArrayList transactions = new ArrayList();
            StreamReader fr = new StreamReader("C:/Users/Simone/Documents/Visual Studio 2010/Projects/DataMining/DataMining/sample_transactions.arff");
            String currentLine = fr.ReadLine();
            Console.WriteLine("Start");
            while (currentLine != null)
            {
                if (currentLine.Equals("@DATA"))
                {
                    break;
                }
                currentLine = fr.ReadLine();
            }
            currentLine = fr.ReadLine();
            String[] stringSplitted = null;
            Item currentItem = null;
            while (currentLine != null)
            {
                Console.WriteLine(currentLine);
                //Console.WriteLine("Enter WHILE");
                stringSplitted = currentLine.Split(',');
                Console.WriteLine(stringSplitted.Length);
                for (int i = 0; i < stringSplitted.Length - 1; i++)
                {
                    //Console.WriteLine("Enter FOR");
                    currentItem = new Item(attributes_name[i], stringSplitted[i]);
                    transactions.Add(currentItem);
                }
                currentLine = fr.ReadLine();
            }
            fr.Close();
            return transactions;
        }
        public static void Main(string[] args)
        {
            Apriori a = new Apriori();
            a.ExtractData();
            Console.ReadLine();
        }
    }
}
