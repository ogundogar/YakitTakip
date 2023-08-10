namespace YakitTakip.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime IlkKayitTarihi { get; set; }
        public DateTime? SonKayitTarihi { get; set; }
    }
}
