﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public abstract class Dyr
    {
        public string DyreNavn { get; }

        /// <summary>
        /// cosntructor som tager dyrenavn som parameter
        /// </summary>
        /// <param name="navn">navnet på typen af dyr</param>
        public Dyr(string navn)
        {
            this.DyreNavn = navn;

        }


    }
}
