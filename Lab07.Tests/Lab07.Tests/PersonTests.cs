using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Entities;

namespace Lab07.Tests
{

    /***
     * Operación matematicas tiene que tener unit testing o lógica de negocio (entradas o salidas de dinero)
     * SHIFT+ALT+F10 SUGERENCIAS DEL PROGRAMA
     * F12 para viajar al método donde esta el curso
     * Build: Ctrl+shift+B
    ***/

    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void APersonIsCreated() //Prueba de crear un objeto
        {
            //Arrange: configura todo lo que va a utilizar

            PersonBL logic = new PersonBL();
            Person person = new Person()  
            {
                Id = 1,
                Name = "Some Person",
                BirthDate = DateTime.Now
            };


            //Act: llama al método
            logic.Create(person); 
            Person saved = logic.GetById(1);


            //Assert: que tuvo que pasar
            Assert.IsNotNull(saved,"Person should have not been null after insert"); 

        }


        [TestMethod]
        public void APersonMustHaveAName()
        {
            //ARRANGE

            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "",
                BirthDate = DateTime.Now
            };

            
            //Act & Assert  //Action no devuelve valor y Function si devuelve
            Assert.ThrowsException<ArgumentException>(() => logic.Create(person));

        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {
            
            //Arrange
            Person person = new Person()
            {
                Id = 1,
                Name = "Some Person",
                BirthDate = new DateTime(2000,10,5)
            };


            //Act & Assert
            Assert.AreEqual(person.Age,18);

        }

    }
}
