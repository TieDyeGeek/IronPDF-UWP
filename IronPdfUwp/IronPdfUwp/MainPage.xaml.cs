using System;
using System.IO;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using IronPdf;

namespace IronPdfUwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Generate PDF

            var renderer = new HtmlToPdf
            {
                PrintOptions = new PdfPrintOptions
                {
                    PaperSize = PdfPrintOptions.PdfPaperSize.Letter,
                    PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Portrait,
                    RenderDelay = 1000,
                    Footer = new SimpleHeaderFooter
                    {
                        RightText = "Page {page} of {total-pages}",
                        FontSize = 8
                    }
                }
            };

            var pdf = await renderer.RenderUrlAsPdfAsync(new Uri("https://ironpdf.com/"));


            //Save PDF to file in Downloads/IronPdfUwp/
            var newFile = await DownloadsFolder.CreateFileAsync("UWP-test.pdf", CreationCollisionOption.GenerateUniqueName);

            var fileStream = await newFile.OpenStreamForWriteAsync();
            if (fileStream.CanWrite)
                await fileStream.WriteAsync(pdf.BinaryData, 0, pdf.BinaryData.Length);

            fileStream.Close();
        }
    }
}
