using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for passCodeGenerator
/// </summary>
public class PassCodeGenerator
{
    Random rand;

        public PassCodeGenerator()
            {
            rand = new Random();
            }

    public int GetPasscode()
    {
        return rand.Next(1000000, 9999999);

    }
}