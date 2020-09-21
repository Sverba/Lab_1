using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTPRegistration.Models
{
    public class DTPRegistr
    {
        //Id офрмлення ДТП
        public int Id { get; set; }
        //ПІП порушника
        public string PIP { get; set; }
        //Дата народження порушника
        public string Date_Birth { get; set; }
        //Марка автомобіля
        public string Marka_Auto { get; set; }
        //Номерний знак автомобіля
        public string Nomer_Auto { get; set; }
        //Адреса порушення
        public string Address { get; set; }
        // ID типу правопорушення 
        public int TypeId { get; set; }
        //Дата порушення
        public DateTime Date_Por { get; set; }
    }
}