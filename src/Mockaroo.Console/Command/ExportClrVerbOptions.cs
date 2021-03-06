﻿using CommandLine;

namespace Mockaroo.Command
{
    public class ExportClrVerbOptions : ExportVerbOptionsBase
    {
        [Option('a', "assembly", HelpText = "Say something useful.")]
        public string AssemblyPath { get; set; }

        [Option('t', "type", HelpText = "Say something useful.")]
        public string TypeName { get; set; }
    }
}