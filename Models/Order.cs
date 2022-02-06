using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_versta24.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        [DisplayName("Адрес отправителя")]
        public string AddressSender { get; set; }

        [DisplayName("Адрес получателя")]
        public string AddressRecipient { get; set; }

        [DisplayName("Город отправителя")]
        public string CitySender { get; set; }

        [DisplayName("Город получателя")]
        public string CityRecipient { get; set; }

        [DisplayName("Вес груза")]
        public decimal WeightPackage { get; set; }

        [DisplayName("Дата забора груза")]
        public DateTime DateGet { get; set; }

    }
}
