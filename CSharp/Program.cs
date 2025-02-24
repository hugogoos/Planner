﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ThreadMonitor.LockTryEnterRun();

            Console.ReadKey();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                         .WithOptions(ConfigOptions.DisableOptimizationsValidator);
            //.WithSummaryStyle(new SummaryStyle(cultureInfo: CultureInfo.InvariantCulture,
            //                                   printUnitsInHeader: false,
            //                                   sizeUnit: null,
            //                                   timeUnit: null,
            //                                   textColumnJustification: SummaryTable.SummaryTableColumn.TextJustification.Right));
            //_ = BenchmarkRunner.Run<TrimLastCharBenchmark>(config);
        }
    }
}
