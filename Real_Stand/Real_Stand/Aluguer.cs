
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Real_Stand
{

using System;
    using System.Collections.Generic;
    
public partial class Aluguer
{

    public int IdAluguer { get; set; }

    public int DataInicio { get; set; }

    public int DataFim { get; set; }

    public int Valor { get; set; }

    public int Kms { get; set; }

    public int ClienteIdCliente { get; set; }



    public virtual Cliente Cliente { get; set; }

    public virtual CarroAluguer CarroAluguer { get; set; }

}

}
