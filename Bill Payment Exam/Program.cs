using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        BillPaymentSystem billSystem = new BillPaymentSystem();

        billSystem.AddToBillQueue(123);
        billSystem.AddToBillQueue(456);
        billSystem.AddToBillQueue(789);

        billSystem.ProcessBillPayments();
        billSystem.ViewBillPaymentStack();

        billSystem.CompleteBillPayments();
        billSystem.ViewBillPaymentStack();

   }
}
