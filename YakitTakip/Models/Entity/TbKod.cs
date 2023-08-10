using System;
using System.Collections.Generic;

namespace YakitTakip.Models;

public partial class TbKod:BaseEntity
{
    public long? UstKodId { get; set; }

    public string Ad { get; set; } = null!;

    public short SiraNo { get; set; }

    public string? Aciklama { get; set; }

    public bool AktifMi { get; set; }

    public virtual ICollection<TbArac> TbAracMarkaKods { get; set; } = new List<TbArac>();

    public virtual ICollection<TbArac> TbAracModelKods { get; set; } = new List<TbArac>();

    public virtual ICollection<TbArac> TbAracVitesKods { get; set; } = new List<TbArac>();

    public virtual ICollection<TbArac> TbAracYakitTipiKods { get; set; } = new List<TbArac>();
}
