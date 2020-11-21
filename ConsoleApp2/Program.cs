using System;
using System.Collections.Generic;
using Algorand;
using Algorand.Algod.Api;
using Algorand.Algod.Model;
using Algorand.Client;
using Account = Algorand.Account;

namespace ConsoleApp2
{
    public static class Program
    {
        public static AlgodApi algodApiInstance;
        static void Main(string[] args)
        {

            //AJ7GLWNUT6TEJYUGNYAZQ7342TK7DBZLWBMIMK3NBN6NZCWJHLNYCRYQ7I
            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();
            var a = "AJ7GLWNUT6TEJYUGNYAZQ7342TK7DBZLWBMIMK3NBN6NZCWJHLNYCRYQ7I";
            Console.WriteLine(a.ToString());
            var act = algodApiInstance.AccountInformation(a.ToString());
            var before = "Account 1 balance before: " + act.Amount.ToString();
            Console.WriteLine(act);
            Console.WriteLine(before);
            //TransactionParams transParams = null; 
            //try
            //{
            //    transParams = algodApiInstance.TransactionParams();
            //}
            //catch (ApiException err)
            //{
            //    throw new Exception("Could not get params", err);
            //}
            //var amount = Utils.AlgosToMicroalgos(1);
            //var tx = Utils.GetPaymentTransaction(account1.Address, account2.Address, amount, "pay message", transParams);
            //var tx2 = Utils.GetPaymentTransaction(account1.Address, account3.Address, amount, "pay message", transParams);
            ////SignedTransaction signedTx2 = src.SignTransactionWithFeePerByte(tx2, feePerByte);
            //Digest gid = TxGroup.ComputeGroupID(new Algorand.Transaction[] { tx, tx2 });
            //tx.AssignGroupID(gid);
            //tx2.AssignGroupID(gid);
            //// already updated the groupid, sign
            //var signedTx = account1.SignTransaction(tx);
            //var signedTx2 = account1.SignTransaction(tx2);
            //try
            //{
            //    //contact the signed msgpack
            //    List<byte> byteList = new List<byte>(Algorand.Encoder.EncodeToMsgPack(signedTx));
            //    byteList.AddRange(Algorand.Encoder.EncodeToMsgPack(signedTx2));
            //    var act = algodApiInstance.AccountInformation(account1.Address.ToString());
            //    var before = "Account 1 balance before: " + act.Amount.ToString();
            //    var id = algodApiInstance.RawTransaction(byteList.ToArray());
            //    var wait = Utils.WaitTransactionToComplete(algodApiInstance, id.TxId);
            //    Console.WriteLine(wait);

            //    // Console.WriteLine("Successfully sent tx group with first tx id: " + id);

            //    act = algodApiInstance.AccountInformation(account1.Address.ToString());
            //}
            //catch (ApiException err)
            //{
            //    // This is generally expected, but should give us an informative error message.
            //    Console.WriteLine("Exception when calling algod#rawTransaction: " + err.Message);
            //}
        }
    }
}
