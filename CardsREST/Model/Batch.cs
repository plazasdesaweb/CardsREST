//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardsREST.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Batch
    {
        public int BatchID { get; set; }
        public Nullable<int> BatchNum { get; set; }
        public Nullable<int> InvoiceNum { get; set; }
        public Nullable<int> AccountType { get; set; }
        public Nullable<int> BatchUpload { get; set; }
        public Nullable<int> TransCode { get; set; }
        public Nullable<int> Reversada { get; set; }
        public Nullable<int> Anulada { get; set; }
        public Nullable<int> transyear { get; set; }
        public Nullable<int> transmonth { get; set; }
        public Nullable<int> transday { get; set; }
        public string transDate { get; set; }
        public string IsoDescription { get; set; }
        public Nullable<int> Settlement { get; set; }
        public string sourceaccount { get; set; }
        public string b002 { get; set; }
        public string b003 { get; set; }
        public Nullable<decimal> b004 { get; set; }
        public Nullable<int> b011 { get; set; }
        public string b012 { get; set; }
        public string b013 { get; set; }
        public string b014 { get; set; }
        public string b032 { get; set; }
        public string b035 { get; set; }
        public Nullable<int> b037 { get; set; }
        public string b038 { get; set; }
        public string b039 { get; set; }
        public string b041 { get; set; }
        public string b042 { get; set; }
        public Nullable<int> fileid { get; set; }
        public Nullable<int> statusFile { get; set; }
        public Nullable<int> MsgType { get; set; }
        public string BinPan { get; set; }
        public Nullable<int> liquidado { get; set; }
        public System.DateTime batchdate { get; set; }
        public Nullable<System.DateTime> liquidadodate { get; set; }
        public Nullable<int> puntos { get; set; }
        public Nullable<decimal> factor_acred { get; set; }
        public Nullable<decimal> factor_canje { get; set; }
    }
}
