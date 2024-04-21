using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WebApplication2
{
    public class Usuario
    {
        public string gender { get; set; }
        public Nombre name { get; set; }
        public Localizacion location { get; set; }
        public string email { get; set; }
        public Acceso login { get; set; }
        public FechaNacim dob { get; set; }
        public Registro registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Identificacion id { get; set; }
        public Fotografia picture { get; set; }
        public string nat { get; set; }
    }
    public class Nombre
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }
    public class Localizacion
    {
        public Calle street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public Coordenadas cordinates { get; set; }
        public ZonaHoraria timezone { get; set; }
    }
    public class Calle
    {
        public string number { get; set; }
        public string name { get; set; }
    }
    public class Coordenadas
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
    public class ZonaHoraria
    {
        public string offset { get; set; }
        public string description { get; set; }
    }
    public class Acceso
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }
    public class FechaNacim
    {
        public string date { get; set; }
        public int age { get; set; }
    }
    public class Registro
    {
        public string date { get; set; }
        public int age { get; set; }
    }
    public class Identificacion
    {
        public string name { get; set; }
        public string value { get; set; }
    }
    public class Fotografia
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }
    public class Resultados
    {
        public IList<Usuario> results { get; set; }
    }
}