namespace laber1.PK
{
    public class PersonalComputer
    {
        
        public string Model { get; set; }            
        public string Processor { get; set; }       
        public int RamGb { get; set; }               
        public int StorageGb { get; set; }            
        public string OperatingSystem { get; set; }   

        
        public bool IsPoweredOn { get; private set; }

       
        public PersonalComputer(string model, string processor, int ramGb,int storageGb, string os)
        {
            Model = model;
            Processor = processor;
            RamGb = ramGb;
            StorageGb = storageGb;
            OperatingSystem = os;
            IsPoweredOn = false;
        }

       

       
        public virtual string TurnOn()
        {
            if (IsPoweredOn)
                return $"{Model} уже включён.";

            IsPoweredOn = true;
            return $"{Model} включён. Загрузка {OperatingSystem}...";
        }

       
        public virtual string TurnOff()
        {
            if (!IsPoweredOn)
                return $"{Model} уже выключен.";

            IsPoweredOn = false;
            return $"{Model} выключен.";
        }

        
        public virtual string Restart()
        {
            if (!IsPoweredOn)
                return $"{Model} выключен — перезагрузка невозможна.";

            return $"Перезагрузка {Model}... Готово.";
        }

       
        public virtual string GetPurpose()
        {
            return "Персональный компьютер общего назначения";
        }

        
        public virtual string GetInfo()
        {
            return $"Назначение: {GetPurpose()}\n" +
                   $"Модель: {Model}\n" +
                   $"Процессор: {Processor}\n" +
                   $"RAM: {RamGb} ГБ\n" +
                   $"Накопитель: {StorageGb} ГБ\n" +
                   $"ОС: {OperatingSystem}\n" +
                   $"Состояние: {(IsPoweredOn ? "включён" : "выключен")}";
        }
    }
}
