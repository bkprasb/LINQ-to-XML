using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML tree using Linq to Xml"),
                new XElement("Students",//declaring root element
                    new XElement("Student",//declaring child element
                        new XAttribute("Id", 101),// attribute of child element
                        new XElement("Name", "Mark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 400)),

                        new XElement("Student",//declaring child element
                        new XAttribute("Id", 102),// attribute of child element
                        new XElement("Name", "Frank"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 450)),

                        new XElement("Student",//declaring child element
                        new XAttribute("Id", 103),// attribute of child element
                        new XElement("Name", "Parry"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 500)),

                        new XElement("Student",//declaring child element
                        new XAttribute("Id", 104),// attribute of child element
                        new XElement("Name", "Klark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 550))
                        ));

            xmlDocument.Save("C:\\GIT\\Projects\\LINQ to XML\\LINQ-to-XML\\LinqToXmlPractise\\LinqToXmlDemo\\Data.xml");
                        


        }
    }
}
