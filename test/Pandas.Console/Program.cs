﻿using System;
using static PandasNet.PandasApi;

namespace Pandas.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var df = pd.DataFrame.from_dict("{'col_1': [3, 2, 1, 0], 'col_2': ['a', 'b', 'c', 'd']}");
            var df1 = df[new[] { "col_1" }];
        }
    }
}
