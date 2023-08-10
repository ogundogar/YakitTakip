using System;
using System.Collections.Generic;

namespace YakitTakip.Models;

public partial class TbArac:BaseEntity
{
    public string Plaka { get; set; } = null!;

    public bool MuayeneDurumu { get; set; }

    public DateTime MuayeneGecerlilikTarihi { get; set; }

    public int Km { get; set; }

    public int MarkaKodId { get; set; }

    public int ModelKodId { get; set; }

    public int VitesKodId { get; set; }

    public int YakitTipiKodId { get; set; }

    public int? MotorGucu { get; set; }

    public int? MotorHacmi { get; set; }

    public bool AktifMi { get; set; }

    public virtual TbKod MarkaKod { get; set; } = null!;

    public virtual TbKod ModelKod { get; set; } = null!;

    public virtual ICollection<TbGorev> TbGorevs { get; set; } = new List<TbGorev>();

    public virtual TbKod VitesKod { get; set; } = null!;

    public virtual TbKod YakitTipiKod { get; set; } = null!;
}
