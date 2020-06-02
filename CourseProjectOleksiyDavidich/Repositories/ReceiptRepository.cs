using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using CourseProjectOleksiyDavidich.Models;
using Dapper;

namespace CourseProjectOleksiyDavidich.Repositories
{
    public class ReceiptRepository
    {
        private readonly string _connectionString;

        public ReceiptRepository()
        {
            _connectionString = Properties.Settings.Default.BudgetixDBConnectionString;
        }

        public Models.Receipt Load(int receiptId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sqlQuery = 
                    "SELECT Id, StoreId, PurchaseDatePT as PurchaseDate "+
                    "FROM Receipts "+
                    "WHERE Id = @Id";

                var receipt = connection
                    .Query<Models.Receipt>(sqlQuery, new {Id = receiptId})
                    .Single();

                var sqlDetailsQuery =
                    "SELECT rd.ReceiptId, rd.LineNumber, rd.Quantity, rd.UnitPrice, " +
                    "       rd.StoreItemId " +
                    //"       si.Id, si.Title, si.CategoryId, si.Units " +
                    "FROM ReceiptDetails rd " +
                    //"JOIN StoreItems si ON rd.StoreItemId = si.Id " +
                    "WHERE ReceiptId = @ReceiptId";

                receipt.Details = connection
                    .Query<ReceiptDetail/*, StoreItem, ReceiptDetail*/>(
                        sqlDetailsQuery,
                        //(detail, item) => { detail.StoreItem = item;  return detail; },
                        new { ReceiptId = receiptId })
                    .ToList();

                return receipt;
            }
        }

        public void Save(Models.Receipt receipt)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();

                try
                {
                    var insertReceiptSql =
                        "INSERT INTO [dbo].[Receipts]([StoreId],[PurchaseDateUTC]) " +
                        "VALUES (@StoreId, @PurchaseDate); SELECT @@IDENTITY";

                    var executeScalar = connection.ExecuteScalar(insertReceiptSql, new {receipt.StoreId, receipt.PurchaseDate}, transaction: transaction);
                    receipt.Id = (int)(decimal)executeScalar;
                    receipt.Details.ForEach(d => d.ReceiptId = receipt.Id);

                    var insertDetailSql =
                        "INSERT INTO [dbo].[ReceiptDetails] ([ReceiptId],[LineNumber],[StoreItemId],[Quantity],[UnitPrice]) " +
                        "VALUES(@ReceiptId, @LineNumber, @StoreItemId, @Quantity, @UnitPrice)";

                    foreach (var receiptDetail in receipt.Details)
                    {
                        connection.Execute(insertDetailSql, receiptDetail, transaction);
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    //throw;
                }

            }
        }
    }
}