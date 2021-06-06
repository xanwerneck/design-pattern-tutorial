using System;
using Xunit;
using DesignPatternsTutorial.ChainOfResponsibility;
using DesignPatternsTutorial.ChainOfResponsibility.Handlers;

namespace DesignPatternsTutorialTest
{
    public class ChainOfResponsibilityTest {
        [Fact]
        public void Start()
        {     
            Participation participation = new Participation();
            Attendance attendance       = new Attendance();
            Publication publication     = new Publication();
            participation.setNext(attendance);
            attendance.setNext(publication);

            Inscription inscription = new Inscription
            {
                Name = "UserExample",
                Type = "Student",
                Value = 102.5,
                Papers = new System.Collections.Generic.List<string> { },
                Status = "Waiting payment",
                Watched = 1
            };

            // Emit certificate for not paid inscription
            object result = participation.Emit(inscription);
            Assert.Equal("Inscription not paid", result.ToString());

            // Emit certificate for student - PAID - without paper submittion
            inscription.Status = "Paid";
            result = participation.Emit(inscription);
            Assert.Equal("Only 10% watched", result.ToString());

            inscription.Watched = 8;
            result = participation.Emit(inscription);
            Assert.Equal("Success emiting certificate", result.ToString());


            inscription.Papers.Add("ML Test");
            result = participation.Emit(inscription);
            Assert.Equal("Published content - " + "Success emiting certificate", result.ToString());
        }
    }
}