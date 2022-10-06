using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YugiohTCG.Modelos.Enum;

namespace YugiohTCG.Modelos.Modelos
{
    public class InformacionCarta
    {
        public string nombre {get; set;} = "";      //T&M   C
        public string ingles {get; set;} = "";      //T&M   C
        public string japones {get; set;} = "";     //T&M   C
        public string carta
        {
            get
            {
                return this.tipoCarta.ToString();
            }
            set
            {
                this.tipoCarta = System.Enum.Parse<TipoCarta>(value.Replace(" ", ""));
            }
        }       //T&M   C
        public string atributo {get; set;} = "";    //T&M   C
        public string icono {get; set;} = "";       //T&M
        public string duracion {get; set;} = "";    //T&M
        public string velocidad {get; set;} = "";   //T&M
        public string nivel                         //      C
        {
            get
            {
                return this.nivelInt.ToString();
            } 
            set 
            {
                if (int.TryParse(value.Replace("x ", ""), out int nivelParse))
                {
                    this.nivelInt = nivelParse;
                }
                else
                {
                    this.nivelInt = 0;
                }
            }
        }
        public string tipo { get; set; } = "";                         //      C

        public string AtkDef                        //      C
        {
            get
            {
                return this.atkInt.ToString() + "/" + this.defInt.ToString();
            }
            set
            {
                if (int.TryParse(value.Replace(" ", "").Split("/")[0], out int ataqueParse))
                {
                    this.atkInt = ataqueParse;
                }
                if (int.TryParse(value.Replace(" ", "").Split("/")[1], out int defensaParse))
                {
                    this.defInt = defensaParse;
                }
            }
        }
        public string descripcion {get; set;} = ""; //T&M   C



        public int nivelInt { get; set; }
        public int atkInt { get; set; }
        public int defInt { get; set; }
        public TipoCarta tipoCarta { get; set; }
    }
}
