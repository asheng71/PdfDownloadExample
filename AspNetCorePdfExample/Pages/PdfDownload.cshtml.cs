using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wkhtmltopdf.NetCore;

namespace AspNetCorePdfExample
{
    public class PdfDownloadModel : PageModel
    {
        readonly IGeneratePdf generatePdf;

        public PdfDownloadModel(IGeneratePdf generatePdf)
        {
            this.generatePdf = generatePdf;
        }

        public async Task<IActionResult> OnGet()
        {
            return await generatePdf.GetPdf("ViewTemplates/PdfHtmlTemplate.cshtml", "hello world!");
        }
    }
}