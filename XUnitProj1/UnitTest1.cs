using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;
using Uppgift2;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Job.PaymentJob.Job_Pay();
            BankAccount.account01.BankBalance += Job.JobPay;

            double expected = Worker.WorkerBankBalance;

            double actual = Worker.WorkerCard;

            Assert.NotEqual(expected, actual);
        }

    }
}
