using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String appPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

        using (Stream inputPdfStream = new FileStream(appPath + "BLGLegal Intake Form.pdf", FileMode.Open, FileAccess.Read, FileShare.Read))
        using (Stream inputImageStream = new FileStream(appPath + "signature.png", FileMode.Open, FileAccess.Read, FileShare.Read))
        using (Stream outputPdfStream = new FileStream(appPath + "result.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            var reader = new PdfReader(inputPdfStream);
            var stamper = new PdfStamper(reader, outputPdfStream);
            var pdfContentByte = stamper.GetOverContent(1);

            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
            image.SetAbsolutePosition(100, 100);
            pdfContentByte.AddImage(image);
            stamper.Close();
        }
    }
}