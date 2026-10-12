namespace laber1.PK
{
    public class Server : PersonalComputer
    {
        public int RackUnits { get; set; }   // Высота в юнитах (U)

        public Server(int rackUnits)
            : base("Rack Server", "AMD EPYC 7763", 256, 16000, "Ubuntu Server 22.04")
        {
            RackUnits = rackUnits;
        }

        public override string GetPurpose()
        {
            return "Сервер для хостинга приложений и баз данных";
        }

        // У сервера своя логика перезагрузки — переопределяем
        public override string Restart()
        {
            return $"{Model}: плановая перезагрузка сервера (без отключения сервисов)...";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $"\nВысота: {RackUnits}U";
        }
    }
}
