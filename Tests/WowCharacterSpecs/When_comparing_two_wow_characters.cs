using IEquatable.Example;
using NUnit.Framework;
using System;

namespace IEquatable.Tests.WowCharacterSpecs.When_comparing_two_wow_characters
{
    [TestFixture]
    public class Given_two_null_wow_characters : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            firstWowCharacter = null;
            secondWowCharacter = null;
        }

        [Test]
        public void The_compare_to_method_should_throw_a_null_reference_exception()
        {
            Assert.That( () => firstWowCharacter.CompareTo( secondWowCharacter ), Throws.TypeOf<NullReferenceException>() );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_throw_a_null_reference_exception()
        {
            Assert.That( () => firstWowCharacter.CompareTo( ( Object )secondWowCharacter ), Throws.TypeOf<NullReferenceException>() );
        }

        [Test]
        public void The_static_compare_method_should_return_zero()
        {
            Assert.That( WowCharacter.Compare( firstWowCharacter, secondWowCharacter ), Is.EqualTo( 0 ) );
        }

        [Test]
        public void The_greater_than_operator_should_return_false()
        {
            Assert.That( firstWowCharacter > secondWowCharacter, Is.False );
        }

        [Test]
        public void The_greater_than_or_equal_operator_should_return_true()
        {
            Assert.That( firstWowCharacter >= secondWowCharacter );
        }

        [Test]
        public void The_less_than_operator_should_return_false()
        {
            Assert.That( firstWowCharacter < secondWowCharacter, Is.False );
        }

        [Test]
        public void The_less_than_or_equal_operator_should_return_true()
        {
            Assert.That( firstWowCharacter <= secondWowCharacter );
        }
    }

    public abstract class When_comparing_two_wow_characters_spec
    {
        protected WowCharacter firstWowCharacter;
        protected String firstWowCharacterName = "firstWowCharacterName";
        protected String firstWowCharacterServer = "firstWowCharacterServer";

        protected WowCharacter secondWowCharacter;
        protected String secondWowCharacterName = "secondWowCharacterName";
        protected String secondWowCharacterServer = "secondWowCharacterServer";

        [TestFixtureSetUp]
        public virtual void SetupFixture()
        {
            firstWowCharacter = new WowCharacter( firstWowCharacterName, firstWowCharacterServer );
            secondWowCharacter = new WowCharacter( secondWowCharacterName, secondWowCharacterServer );
        }
    }
}