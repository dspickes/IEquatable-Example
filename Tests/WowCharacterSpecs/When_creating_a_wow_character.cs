using IEquatable.Example;
using NUnit.Framework;
using System;

namespace IEquatable.Tests.WowCharacterSpecs
{
    [TestFixture]
    public class When_creating_a_wow_character
    {
        String givenName = "givenName";
        String givenServer = "givenServer";

        WowCharacter createdCharacter;

        [TestFixtureSetUp]
        public void SetupFixture()
        {
            createdCharacter = new WowCharacter( givenName, givenServer );
        }

        [Test]
        public void The_created_character_name_should_be_the_given_name()
        {
            Assert.That( createdCharacter.Name, Is.EqualTo( givenName ) );
        }

        [Test]
        public void The_created_character_server_should_be_the_given_server()
        {
            Assert.That( createdCharacter.Server, Is.EqualTo( givenServer ) );
        }
    }
}