using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineExam.Models
{
    public static class Utility
    {
        public static string GetModelStateError(ModelStateDictionary modelState)
        {
            return string.Join(" | ", modelState.Values.SelectMany(v=>v.Errors).Select(e=>e.ErrorMessage));

        }
    }
}
