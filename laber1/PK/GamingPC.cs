namespace laber1.PK
{
    public class GamingPC : PersonalComputer
    {
        public string Gpu { get; set; }
        public int PsuWatts { get; set; }
        public bool HasRgb { get; set; }

        public GamingPC(string model, string processor, int ramGb, int storageGb, string os,string gpu, int psuWatts, bool hasRgb)
            : base(model, processor, ramGb, storageGb, os)
        {
            Gpu = gpu;
            PsuWatts = psuWatts;
            HasRgb = hasRgb;
        }

        public override string GetPurpose()
        {
            return "Игровой ПК для современных игр и стриминга";
        }

        // У игрового ПК своя «фишка» при включении
        public override string TurnOn()
        {
            return base.TurnOn() + " Подсветка RGB активирована!";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $"\nВидеокарта: {Gpu}" +
                   $"\nБП: {PsuWatts} Вт" +
                   $"\nПодсветка RGB: {(HasRgb ? "есть" : "нет")}";
        }
    }
}
