﻿using System;

namespace LoreSoft.Shared.Extensions
{
    public static class GuidExtensions
    {
        public static bool TryParse(string input, out Guid value)
        {
            value = Guid.Empty;
            if (string.IsNullOrEmpty(input))
                return false;

            try
            {
                value = new Guid(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        //public static ShortGuid ToShortGuid(this Guid guid)
        //{
        //    return new ShortGuid(guid);
        //}

        //public static string ToShortString(this Guid guid)
        //{
        //    var id  = new ShortGuid(guid);
        //    return id.Value;
        //}

    }
}
