using IEquatable.Example;
using NUnit.Framework;
using System;

namespace IEquatable.Tests.WowCharacterSpecs.When_equating_two_wow_characters
{
    [TestFixture]
    public class Given_two_null_wow_characters : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            firstWowCharacter = null;
            secondWowCharacter = null;
        }

        [Test]
        public void The_equals_method_should_throw_a_null_reference_exception()
        {
            Assert.That( () => firstWowCharacter.Equals( secondWowCharacter ), Throws.TypeOf<NullReferenceException>() );
        }

        [Test]
        public void The_base_equals_method_should_throw_a_null_reference_exception()
        {
            Assert.That( () => firstWowCharacter.Equals( ( Object )secondWowCharacter ), Throws.TypeOf<NullReferenceException>() );
        }

        [Test]
        public void The_equals_operator_should_return_true()
        {
            Assert.That( firstWowCharacter == secondWowCharacter );
        }

        [Test]
        public void The_not_equals_operator_should_return_false()
        {
            Assert.That( firstWowCharacter != secondWowCharacter, Is.False );
        }
    }

    public abstract class When_equating_two_wow_characters_spec
    {
        protected WowCharacter firstWowCharacter;
        protected String firstWowCharacterName;
        protected String firstWowCharacterServer;

        protected WowCharacter secondWowCharacter;
        protected String secondWowCharacterName;
        protected String secondWowCharacterServer;

        [TestFixtureSetUp]
        public virtual void SetupFixture()
        {
            firstWowCharacter = new WowCharacter( firstWowCharacterName, firstWowCharacterServer );
            secondWowCharacter = new WowCharacter( secondWowCharacterName, secondWowCharacterServer );
        }
    }
}