using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sauu.Helpers
{
    public class Utils
    {
        public static string ValidarFoto(IFormFile file)
        {
            var sizeFile = file.Length / 1024;
            if (sizeFile > (1024 * 4))
                return "Este documento es muy grande. La imagen no puede tener más de 4MB de tamaño.";

            var contentTypes = new[] { "application/pdf", "image/png", "image/x-png", "image/jpeg", "image/jpeg" };
            if (!contentTypes.Contains(file.ContentType.ToLower()))
                return "Archivo de documento no valido!. Solo puedes subir fotos o archivos de formato PDF!";

            return "";
        }

        public static List<SelectListItem> AddItemDefault(IEnumerable<SelectListItem> items, string defaultString = "- Seleccione -")
        {
            var res = items.ToList();
            res.Add(new SelectListItem() { Value = "0", Text = defaultString, Selected = true });
            res.OrderByDescending(x => x.Text);
            return res;
        }
    }
}
