namespace RecycleCoinServer.Servisler
{
    public static class ServisHavuzu
    {
        public static BlokBasimServisi BlokBasimServisi { set; get; }
        public static VaritabaniServisi VeritabaniServisi  { set; get; }
        public static ArayuzServisi ArayuzServisi  { set; get; }
        public static CuzdanServisi CuzdanServisi  { set; get; }
        public static EstenEseServis EstenEseServis  { set; get; }

        public static void Ekle(
            CuzdanServisi cuzdan,
            VaritabaniServisi vt,
            ArayuzServisi arayuz,
            BlokBasimServisi darphane,
            EstenEseServis estenese)
        {
            CuzdanServisi = cuzdan;
            VeritabaniServisi = vt;
            ArayuzServisi = arayuz;
            BlokBasimServisi = darphane;
            EstenEseServis = estenese;
        }

        public static void Baslat()
        {
            CuzdanServisi.Baslat();
            VeritabaniServisi.Baslat();
            ArayuzServisi.Baslat();
            EstenEseServis.Baslat();
            BlokBasimServisi.Baslat();
        }

        public static void Durdur()
        {
            VeritabaniServisi.Durdur();
            BlokBasimServisi.Durdur();
        }
    }
}
