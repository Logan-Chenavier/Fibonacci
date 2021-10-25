﻿using System;
using System.Collections.Generic;

namespace Fibonacci.Core
{
    public partial class TFibonacci
    {
        public Guid FibId { get; set; }
        public int FibInput { get; set; }
        public long FibOutput { get; set; }
        public DateTime FibCreatedTimestamp { get; set; }
    }
}