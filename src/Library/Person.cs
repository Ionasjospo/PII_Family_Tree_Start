using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
      public int edad{get; set;}
      public string nombre{get; set;}
      public string apellido{get; set;}

      public Person(int edad, string nombre, string apellido)
      {
          this.edad = edad;
          this.nombre = nombre;
          this.apellido = apellido;
      }

    }



}