// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    //using FestivalManager.Entities;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class StageTests
    {
        private Stage myStage;

        [SetUp]
        public void SetUp()
        {
            myStage = new Stage();
        }

        [Test]
        public void AddPerformer_TE_WhenPerformerIsUnder18()
        {
            Performer small = new Performer("Pet", "Petrov", 15);
            Assert.Throws<ArgumentException>(() => myStage.AddPerformer(small));
        }

        [Test]
        public void AddPerformer_TE_WhenPerformerIsNull()
        {
            Performer small = null;
            Assert.Throws<ArgumentNullException>(() => myStage.AddPerformer(small));
        }

        [Test]
        public void AddSong_TE_WhenSongIsNull()
        {
            Song small = null;
            Assert.Throws<ArgumentNullException>(() => myStage.AddSong(small));
        }

        [Test]
        public void AddSong_TE_WhenSongIsUnder1Min()
        {
            Song small = new Song("Leshta", new TimeSpan(0, 0, 30));
            Assert.Throws<ArgumentException>(() => myStage.AddSong(small));
        }

        [Test]
        public void AddSongToPerformer_TE_WhenSongNameIsNull()
        {
            Song small = new Song(null, new TimeSpan(0, 2, 30));
            Performer big = new Performer("Petar", "Petrov", 25);
            Assert.Throws<ArgumentNullException>(() => myStage.AddSongToPerformer(small.Name, big.FullName));
        }

        [Test]
        public void AddSongToPerformer_Postive()
        {
            Song small = new Song("Leshta", new TimeSpan(0, 2, 30));
            Performer big = new Performer("Petar", "Petrov", 25);

            myStage.AddSong(small);
            myStage.AddPerformer(big);

            Assert.That(myStage.AddSongToPerformer(small.Name, big.FullName), Is.EqualTo($"{small} will be performed by {big}"));
        }

        [Test]
        public void AddSongToPerformer_TE_WhenPerformerNameIsNull()
        {
            Song small = new Song("Leshta", new TimeSpan(0, 2, 30));
            // Performer big = new Performer("Petar", "Petrov", 25);
            Assert.Throws<ArgumentNullException>(() => myStage.AddSongToPerformer(small.Name, null));
        }

        [Test]
        public void Play_Positive()
        {
            Song small = new Song("Leshta", new TimeSpan(0, 2, 30));
            Performer big = new Performer("Petar", "Petrov", 25);
            myStage.AddSong(small);
            myStage.AddPerformer(big);
            myStage.AddSongToPerformer(small.Name, big.FullName);

            Assert.That(myStage.Play(), Is.EqualTo("1 performers played 1 songs"));
        }

        [Test]
        public void Ctor_Positive()
        {
            Assert.IsNotNull(myStage.Performers);
        }
    }
}