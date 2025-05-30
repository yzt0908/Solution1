using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GoodEntity
    {
        string title;
        int price;
        int num;
        string img;
        string detail;
        DateTime adddate;

        public string Title { get => title; set => title = value; }
       
        public int Num { get => num; set => num = value; }
        public string Img { get => img; set => img = value; }
        public string Detail { get => detail; set => detail = value; }
        public DateTime Adddate { get => adddate; set => adddate = value; }
        public int Price { get => price; set => price = value; }
    }
}
