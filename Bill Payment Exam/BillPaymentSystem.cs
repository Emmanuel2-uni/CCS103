using System;
using System.Collections.Generic;
public class BillPaymentSystem
{
    private Queue<int> billQueue;
    private Stack<int> billPaymentStack;

    public BillPaymentSystem()
    {
        billQueue = new Queue<int>();
        billPaymentStack = new Stack<int>();
    }

    public void AddToBillQueue(int accountNumber)
    {
        billQueue.Enqueue(accountNumber);
        System.Console.WriteLine("Customer " + accountNumber + " added to the Queue.");
    }

    public void ProcessBillPayments()
    {
        int count = billQueue.Count;
        if (count == 0)
        {
            System.Console.WriteLine("No pending account.");
            return;
        }
        for(int i = 0; i<count; i++)
         {
            billPaymentStack.Push(billQueue.Peek());
            billQueue.Dequeue();
        }
    }

    public void ViewBillPaymentStack()
    {
        int count = 1;
        if(billPaymentStack.Count == 0)
        {
            System.Console.WriteLine("\nStack is empty.\n");
            return;
        }

        System.Console.WriteLine("\nCurrent stack: ");
        foreach (var item in billPaymentStack)
        {
            System.Console.WriteLine(count + ". " + item);
            count++;
        }
        System.Console.WriteLine("");
    }

    public void CompleteBillPayments()
    {
        int count = billPaymentStack.Count;
        for(int i = 0; i < count; i++)
        {
            System.Console.WriteLine("Popping/Serving customer: " + billPaymentStack.Peek());
            billPaymentStack.Pop();
        }
        System.Console.WriteLine("\nStack is empty. All bills are paid.");
    }
}
