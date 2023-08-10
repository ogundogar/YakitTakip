using System;
using System.Collections.Generic;

namespace YakitTakip.Models;

public partial class TbYakit:BaseEntity
{
    public int GorevId { get; set; }

    public int YuklendigiKm { get; set; }

    public bool AktifMi { get; set; }

    public virtual TbGorev Gorev { get; set; } = null!;
}
