namespace ISDOCNet.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"input.isdoc";
            var fileSavePath = @"output.isdoc";
            //var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
            //var invoice = ISDOCNet.Invoice.Load(stream);
            var invoice = Sample.SimpleInvoiceVat.Create();
            invoice.Save(fileSavePath);
        }
    }
}
