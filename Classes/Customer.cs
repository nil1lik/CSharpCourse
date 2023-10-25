using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //Müşterinin bilgilerini tutmak için propertylerden yararlanıyoruz.
        //public string FirstName; //neden bu şekilde vermiyoruz property'i?? bu işleme field denir. yani alan tanımlamak.
        public int Id { get; set; } //bu ise bir property yani özellik tanımlamaktır.
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string City { get; set; }

        //Neden Get ve Set tanımlıyoruz?
        //Siz bir kural getiriyorsunuz. Eğer ki kullanıcı FirstName'i set ederse yani ona bir değer verirse FirstName'in başına başka bir karakter getirelim, diyebilirsiniz.
        //Böyle bir durumda kişi set eder ama get ederken olay değişir. İşte bunu yaparken get bloğunu daha açık yazarız. Örneğin noktalı virgül yerine parantez açıp kapatırız. 
        //private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mr." + _firstName; }
        //    set { _firstName = value; }
        //}
    }
}
