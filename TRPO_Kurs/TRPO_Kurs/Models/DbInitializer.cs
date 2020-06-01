using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TRPO_Kurs.Models
{
    public class DbInitializer: DropCreateDatabaseAlways<EquipmentContext>
    {
        protected override void Seed(EquipmentContext context)
        {
            context.Categories.Add(new Category() { Name = "Маршрутизаторы", Id = 1 , Image= "~/Content/Images/Categories/router.jpg", Description= "Маршрутизатор — специализированный компьютер, который пересылает пакеты между различными сегментами сети на основе правил и таблиц маршрутизации. Маршрутизатор может связывать разнородные сети различных архитектур. Для принятия решений о пересылке пакетов используется информация о топологии сети и определённые правила, заданные администратором." });
            context.Categories.Add(new Category() { Name = "Коммутаторы", Id = 2, Image = "~/Content/Images/Categories/kommutator.jpg", Description= "Сетевой коммутатор — устройство, предназначенное для соединения нескольких узлов компьютерной сети в пределах одного или нескольких сегментов сети. Коммутатор работает на канальном уровне модели OSI. Коммутаторы были разработаны с использованием мостовых технологий и часто рассматриваются как многопортовые мосты." });
            context.Categories.Add(new Category() { Name = "Межсетевые экраны", Id = 3, Image = "~/Content/Images/Categories/set_display.jpg", Description= "Межсетевой экран, сетевой экран — программный или программно-аппаратный элемент компьютерной сети, осуществляющий контроль и фильтрацию проходящего через него сетевого трафика в соответствии с заданными правилами." });
            context.Categories.Add(new Category() { Name = "Wi-fi контроллеры", Id = 4, Image = "~/Content/Images/Categories/wifi-control.jpg", Description= "Контроллер беспроводной сети производит автоматический поиск, централизованную настройку WIFI точек доступа, обновление программного обеспечения подключенных точек доступа." });
            context.Categories.Add(new Category() { Name = "Серверное оборудование", Id = 5, Image = "~/Content/Images/Categories/server.png", Description= "Серверы для офиса, системы для хранения данных и массивы для высокопроизводительных вычислений." });

            context.Equipments.Add(new Equipment() { Name = "Wi-Fi роутер TP-Link Archer C20 V5.0", Producer = "TP-Link", Price = 2190, CategoryId=1, Image= "~/Content/Images/Equipment/router/archer-20.jpg", Description= "Недорогой двухдиапазонный роутер", Text= "Общая пропускная способность до 733 Мбит/с: до 300 Мбит/с на 2,4 ГГц и до 433 Мбит/с на 5 ГГц. Три внешние антенны обеспечивают стабильный всенаправленный сигнал и превосходное покрытие Wi - Fi. Три режима работы: маршрутизатор, усилитель сигнала и точка доступа. IPTV поддерживает IGMP Proxy / Snooping,Bridge и Tag VLAN для оптимизации потоковой передачи HD. Родительский контроль позволяет устанавливать, когда и как подключенные устройства могут выходить в интернет. Гостевая сеть обеспечивает отдельный доступ для гостей при защите хост - сети." });
            context.Equipments.Add(new Equipment() { Name = "Wi-Fi роутер ASUS RT-AC86U (90IG0401-BN3000)", Producer = "Asus", Price = 14700, CategoryId = 1, Image = "~/Content/Images/Equipment/router/asus-rt.jpg", Description= "Премиальный маршрутизатор для любого назначения", Text= "Роутер Asus RT-AC86U является интересным продолжением «не чрезмерно дорогой» линейки устройств этого производителя. Корпус роутера может похвастаться обновленным дизайном, но возможности крепления на стену здесь нет. Все порты расположены сзади, а на боку есть пара удобных кнопок для оперативного управления Wi-Fi. Индикаторы на лицевой панели не отвлекают высокой яркостью и могут быть отключены.Модель основана на быстрой платформе с двухъядерным процессором и большим объемом оперативной памяти.В задачах маршрутизации данное устройство показало скорости на уровне своих гигабитных портов, несмотря на то, что некоторые сценарии обрабатывались программно.Также очень впечатлила производительность сервера VPN.Наличие порта USB 3.0 в данной модели уже не выглядит излишеством: скорость доступа к данным практически не отличается от сетевых накопителей среднего уровня.Современный радиоблок обеспечивает высокую скорость работы и хорошее покрытие беспроводной сети в диапазоне 5 ГГц.Что касается работы в 2, 4 ГГц, то здесь многое будет зависеть от параметров клиентов и состояния эфира."});
            context.Equipments.Add(new Equipment() { Name = "Wi-Fi роутер Keenetic Giga (KN-1010)", Producer = "Keenetic", Price = 10000, CategoryId = 1, Image = "~/Content/Images/Equipment/router/giga.jpg", Description= "Wi-Fi роутер Keenetic Giga (KN-1010)", Text= "Wi-Fi роутер Keenetic Giga (KN-1010)" });

            base.Seed(context);
        }
        public void SaveChanges(List<Equipment> neweq)
        {
            foreach (Equipment eq in neweq)
            {
                

            }
        }
    }
}