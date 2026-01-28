using System;
using System.Threading;
using System.Threading.Channels;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("order placed");
        await ProcessOrderAsync();
        await NotifyAsync();
        Console.WriteLine("\n order completed sucessfully");
    }
    static async  Task ValidationAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("order validate");
    }
    static async Task BillingAsync()
    {
        await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("billing completed");

            });
    }
    static async Task PaymentAsync()
    {
        await Task.Delay(1500).ConfigureAwait(false);
        Console.WriteLine("payment Done");
    }

    static async Task ProcessOrderAsync()
    {
        await Task.WhenAll(ValidationAsync(),
            BillingAsync(),
            PaymentAsync()
                            );


    }
    static async Task NotifyAsync()
    {
        Task Sms = Task.Delay(2000);
        Task Email = Task.Delay(1000);

        await Task.WhenAny(Sms, Email);

        Console.WriteLine("notified to resto");
    }
}

