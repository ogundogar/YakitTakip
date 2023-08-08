using System;
using System.Collections.Generic;

namespace YakitTakip.Models;

public partial class TbGorev:BaseEntity
{
    public int PersonelId { get; set; }

    public int AracId { get; set; }

    public int GorevTipiKodId { get; set; }

    public string? Aciklama { get; set; }

    public DateTime GorevBaslangicTarihi { get; set; }

    public DateTime GorevSonuTarihi { get; set; }

    public int BaslangicKm { get; set; }

    public int BitisKm { get; set; }

    public bool AktifMi { get; set; }

    public virtual TbArac Arac { get; set; } = null!;

    public virtual TbPersonel Personel { get; set; } = null!;

    public virtual ICollection<TbYakit> TbYakits { get; set; } = new List<TbYakit>();
}
