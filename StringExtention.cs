using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Tile;

namespace School
{
    public static class StringExtention
    {
        /// <summary>
        /// Null or Empty durumu sorgulanır.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this String str)
        {
            if (String.IsNullOrEmpty(str) == false)
                return true;
            else
                return false;
        }
    }
}
