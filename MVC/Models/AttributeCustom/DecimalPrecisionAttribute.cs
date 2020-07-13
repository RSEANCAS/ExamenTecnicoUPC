using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models.AttributeCustom
{
    public class DecimalAttribute : Attribute
    {
        public DecimalAttribute(byte precision, byte scale)
        {
            Precision = precision;
            Scale = scale;

        }

        public byte Precision { get; set; }
        public byte Scale { get; set; }
    }
}