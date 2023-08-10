using System;
using System.Collections.Generic;

namespace YakitTakip.Models;

public partial class TbPersonel:BaseEntity
{
    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string TelefonNo { get; set; } = null!;

    public bool AktifMi { get; set; }

    public virtual ICollection<TbGorev> TbGorevs { get; set; } = new List<TbGorev>();
}
