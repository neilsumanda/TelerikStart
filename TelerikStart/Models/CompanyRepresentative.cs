using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikStart.Models
{
    public class CompanyRepresentative
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }

    public class Company
    {
        public List<CompanyRepresentative> CompanyRepresentativesList()
        {
            return new List<CompanyRepresentative>
            {
                new CompanyRepresentative{ Id=1, ContactName="Maria Anders", ContactTitle="Sales Representative", CompanyName = "Alfreds Futterskite", Country ="Germany" },
                new CompanyRepresentative{ Id=2, ContactName="Ana Trujillo", ContactTitle="Owner", CompanyName = "Ana Trujillo Emparedados y helados", Country ="Mexico" },
                new CompanyRepresentative{ Id=3, ContactName="Antonio Moreno", ContactTitle="Owner", CompanyName = "Antonio Moreno Taquero", Country ="Mexico" },
                new CompanyRepresentative{ Id=4, ContactName="Thomas Hardy", ContactTitle="Sales Representative", CompanyName = "Around the Horn", Country ="UK" },
                new CompanyRepresentative{ Id=5, ContactName="Christina Berglund", ContactTitle="Order Administrator", CompanyName = "Berglunds snabbkop", Country ="Sweden" },
                new CompanyRepresentative{ Id=6, ContactName="Frederique Citeaux", ContactTitle="Marketing", CompanyName = "Blondel pere et fils", Country ="France" },
                new CompanyRepresentative{ Id=7, ContactName="Martin Sommer", ContactTitle="Owner", CompanyName = "Bolido Comidas preparadas", Country ="Spain" },
                new CompanyRepresentative{ Id=8, ContactName="Laurence Lebihan", ContactTitle="Owner", CompanyName = "Bon app", Country ="France" },
                new CompanyRepresentative{ Id=9, ContactName="Elizabeth Lincoln", ContactTitle="Accounting Manager", CompanyName = "Bottom-Dollar Markets", Country ="Canada" },
                new CompanyRepresentative{ Id=10, ContactName="Victoria Ashworth", ContactTitle="Sales Representative", CompanyName = "B's Beverages", Country ="UK" },
                new CompanyRepresentative{ Id=11, ContactName="Patricio Simpson", ContactTitle="Sales Agent", CompanyName = "Cactus Comidas para llevar", Country ="Argentina" },
                new CompanyRepresentative{ Id=12, ContactName="Francisco Chang", ContactTitle="Marketing Manager", CompanyName = "Centro comercial Moctezuma", Country ="Mexicom" },

                new CompanyRepresentative{ Id=12, ContactName="Yang Wang", ContactTitle="Owner", CompanyName = "Chop-suey Chinese", Country ="Switzerland" },
                new CompanyRepresentative{ Id=12, ContactName="Pedro Afonso", ContactTitle="Sales Associate", CompanyName = "Comercio Mineiro", Country ="Brazil" },
                new CompanyRepresentative{ Id=12, ContactName="Elizabeth Brown", ContactTitle="Sales Representative", CompanyName = "Consolidated Holdings", Country ="UK" },
                new CompanyRepresentative{ Id=12, ContactName="Rita Muller", ContactTitle="Sales Representative", CompanyName = "Die Wanderde Kuh", Country ="Germany" },
                new CompanyRepresentative{ Id=12, ContactName="Sven Ottlieb", ContactTitle="Order Administrator", CompanyName = "Drackenblut Delikatessen", Country ="Germany" },
                new CompanyRepresentative{ Id=12, ContactName="Janine Labrune", ContactTitle="Owner", CompanyName = "Du monde entier", Country ="France" },
                new CompanyRepresentative{ Id=12, ContactName="Ann Devon", ContactTitle="Sales Agent", CompanyName = "Eastern Connection", Country ="UK" },
                new CompanyRepresentative{ Id=12, ContactName="Miguel Angel Paolino", ContactTitle="Owner", CompanyName = "Tortuga Restaurante", Country ="Mexico" },
                new CompanyRepresentative{ Id=12, ContactName="Anabela Domingues", ContactTitle="Sales Representative", CompanyName = "Tradicao Hipermercados", Country ="Brazil" },
                new CompanyRepresentative{ Id=12, ContactName="Helvetius Nagy", ContactTitle="Sales Associate", CompanyName = "Trail's Head Gourmet Provisioners", Country ="USA" },
                new CompanyRepresentative{ Id=12, ContactName="Palle Ibsen", ContactTitle="Sales Manager", CompanyName = "Vaffeljernet", Country ="Denmark" },
                new CompanyRepresentative{ Id=12, ContactName="Mary Saveley", ContactTitle="Sales Agent", CompanyName = "Victuailles en stock", Country ="France" },
                new CompanyRepresentative{ Id=12, ContactName="Paul Henriot", ContactTitle="Accouting Manager", CompanyName = "Vins et alcools Chevalier", Country ="France" },
                new CompanyRepresentative{ Id=12, ContactName="Pirkko Koskitalo", ContactTitle="Accounting Manager", CompanyName = "Wartian Herkku", Country ="Finland" },
                new CompanyRepresentative{ Id=12, ContactName="Paula Parente", ContactTitle="Sales Manager", CompanyName = "Wellington Importadora", Country ="Brazil" }

                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
                //new CompanyRepresentative{ ContactName="", ContactTitle="", CompanyName = "", Country ="" },
            };

        }

    }
}