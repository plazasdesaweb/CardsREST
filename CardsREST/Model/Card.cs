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
    
    public partial class Card
    {
        public Card()
        {
            this.Accounts = new HashSet<Account>();
            this.HistCardStatus = new HashSet<HistCardStatu>();
        }
    
        public int cardID { get; set; }
        public string PAN { get; set; }
        public Nullable<int> pluginID { get; set; }
        public Nullable<int> merchantID { get; set; }
        public Nullable<int> clientID { get; set; }
        public Nullable<int> brandID { get; set; }
        public string expdateCard { get; set; }
        public string cvv2Card { get; set; }
        public Nullable<int> status { get; set; }
        public string offset { get; set; }
        public string lastOffset { get; set; }
        public string printed { get; set; }
        public Nullable<int> batchprinted { get; set; }
        public System.DateTime carddate { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Client Client { get; set; }
        public virtual Merchant Merchant { get; set; }
        public virtual Plugin Plugin { get; set; }
        public virtual ICollection<HistCardStatu> HistCardStatus { get; set; }
    }
}
