using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Olion_serialisointi_AUTE19SA
{
    class Program
    {
        private static Viesti v;
        private static List<Viesti> l;

        static void Main(string[] args)
        {
            v = new Viesti();
            v.lahettaja = "Matti";
            v.vastaanottaja = "Teppo";
            v.viesti = "Mukavaa hiihtoloman odotusta";

            Tallenna();
            Avaa();
            Console.ReadKey();
        }
        public static void Tallenna()
        {
            string json = JsonConvert.SerializeObject(l,Formatting.Indented);
            //Console.WriteLine(json);
            File.WriteAllText(@"c:\viesti.json", json);
        }
        public static void Avaa()
        {
            Viesti v2 = JsonConvert.DeserializeObject<Viesti>(File.ReadAllText(@"c:\viesti.json"));
            Console.WriteLine("v2 " + v.lahettaja + " " + v.vastaanottaja + " " + v.viesti + " " + v.kuitattu);
        }
    }
}
