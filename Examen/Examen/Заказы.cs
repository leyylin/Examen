//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказы
    {
        public int Номер_заказа { get; set; }
        public string Статус_заказа { get; set; }
        public Nullable<System.DateTime> Дата_доставки { get; set; }
        public Nullable<int> Пункт_выдачи { get; set; }
        public string Дата_заказа { get; set; }
        public Nullable<int> ФИО_клиента { get; set; }
        public Nullable<int> Код_для_получения { get; set; }
    
        public virtual Пользователи Пользователи { get; set; }
        public virtual Пункт_получения_заказа Пункт_получения_заказа { get; set; }
    }
}
