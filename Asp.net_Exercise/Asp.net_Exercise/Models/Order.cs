
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Asp.net_Exercise.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Order
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public int Store_Id { get; set; }

    public int User_Id { get; set; }

    public string MerchantTradeNo { get; set; }

    public Nullable<System.DateTime> TradeDate { get; set; }

    public Nullable<int> Pay { get; set; }

    public string TradeNo { get; set; }

    public Nullable<System.DateTime> PaymentDate { get; set; }

    public Nullable<int> Total { get; set; }



    public virtual Member Member { get; set; }

    public virtual Store Store { get; set; }

}

}