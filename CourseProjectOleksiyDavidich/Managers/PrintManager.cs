using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseProjectOleksiyDavidich.Models;

namespace CourseProjectOleksiyDavidich.Managers
{
    public class PrintManager
    {
        private readonly Models.Receipt _receipt;
        private readonly Dictionary<int, Store> _stores;
        private readonly Dictionary<int, StoreItem> _items;
        private readonly Font _printFont;
        private Queue<string> _lines;

        public PrintManager(Models.Receipt receipt, Dictionary<int, Store> stores, Dictionary<int, StoreItem> items)
        {
            _receipt = receipt;
            _stores = stores;
            _items = items;
            _printFont = new Font("Courier New", 10);
        }

        public void Print()
        {
            try
            {
                var printDialog = new PrintDialog();
                var res = printDialog.ShowDialog();
                if (res != DialogResult.OK)
                    return;


                _lines = BuildContent();
                
                PrintDocument pd = new PrintDocument
                {
                    PrinterSettings = printDialog.PrinterSettings
                };

                pd.PrintPage += OnPrintPage;
                pd.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnPrintPage(object sender, PrintPageEventArgs ev)
        {
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;

            // Calculate the number of lines per page.
            var linesPerPage = ev.MarginBounds.Height / _printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage && _lines.Any())
            {
                var line = _lines.Dequeue();

                var yPos = topMargin + (count * _printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, _printFont, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            ev.HasMorePages = _lines.Any();
        }

        private Queue<string> BuildContent()
        {
            var lines = new Queue<string>();

            var store = _stores[_receipt.StoreId];

            lines.Enqueue($"Receipt #{_receipt.Id}");
            lines.Enqueue($"Store name: {store.Name}");
            lines.Enqueue($"Date: {_receipt.PurchaseDate.ToShortDateString()}");
            lines.Enqueue($"Time: {_receipt.PurchaseDate.ToShortTimeString()}");
            lines.Enqueue("");


            lines.Enqueue(new string('-', 72));
            lines.Enqueue("|  # | Item                                |       Qnt X Price = Total |");
            lines.Enqueue(new string('-', 72));


            foreach (var detail in _receipt.Details)
            {
                var storeItem = _items[detail.StoreItemId];
                var title = storeItem.Title.Length >= 35
                    ? storeItem.Title.Substring(0, 35)
                    : storeItem.Title.PadRight(35);

                var priceInfo = $"{detail.Quantity:#0.###} X {detail.UnitPrice:C} = {detail.Total:C}";

                lines.Enqueue($"|{detail.LineNumber,3} | {title} |{priceInfo,26} |");
            }
            lines.Enqueue(new string('-', 72));

            var total = _receipt.Details.Count == 0
                ? 0
                : _receipt.Details.Sum(d => d.Quantity * d.UnitPrice);
            var totalString = $"GRANT TOTAL: {total:C}";
            lines.Enqueue($"{totalString,70}");

            return lines;
        }

    }
}