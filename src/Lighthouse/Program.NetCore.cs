﻿using System;

namespace Lighthouse
{
    public partial class Program
    {
#if NETCOREAPP2_0
        public static void Main(string[] args)
        {
            var lighthouseService = new LighthouseService();
            lighthouseService.Start();
            Console.WriteLine("Press Control + C to terminate.");
            Console.CancelKeyPress += async (sender, eventArgs) =>
            {
                await lighthouseService.StopAsync();
            };
            lighthouseService.TerminationHandle.Wait(); 
        }
#endif
    }
}
