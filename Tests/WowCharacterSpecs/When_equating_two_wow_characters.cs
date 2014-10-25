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
        public void The_reference_equals_method_should_return_true()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ) );
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

    [TestFixture]
    public class Given_a_non_null_and_null_wow_character : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = null;
        }

        [Test]
        public void The_equals_method_should_return_false()
        {
            Assert.That( firstWowCharacter.Equals( secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_base_equals_method_should_return_false()
        {
            Assert.That( firstWowCharacter.Equals( ( Object )secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_reference_equals_method_should_return_false()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_equals_operator_should_return_false()
        {
            Assert.That( firstWowCharacter == secondWowCharacter, Is.False );
        }

        [Test]
        public void The_not_equals_operator_should_return_true()
        {
            Assert.That( firstWowCharacter != secondWowCharacter );
        }
    }

    [TestFixture]
    public class Given_a_null_and_non_null_wow_character : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            firstWowCharacter = null;
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
        public void The_reference_equals_method_should_return_false()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_equals_operator_should_return_false()
        {
            Assert.That( firstWowCharacter == secondWowCharacter, Is.False );
        }

        [Test]
        public void The_not_equals_operator_should_return_true()
        {
            Assert.That( firstWowCharacter != secondWowCharacter );
        }
    }

    [TestFixture]
    public class Given_the_same_wow_character_twice : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = firstWowCharacter;
        }

        [Test]
        public void The_equals_method_should_return_true()
        {
            Assert.That( firstWowCharacter.Equals( secondWowCharacter ) );
        }

        [Test]
        public void The_base_equals_method_should_return_true()
        {
            Assert.That( firstWowCharacter.Equals( ( Object )secondWowCharacter ) );
        }

        [Test]
        public void The_reference_equals_method_should_return_true()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ) );
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

    [TestFixture]
    public class Given_a_wow_character_and_an_object : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
        }

        [Test]
        public void The_equals_method_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter.Equals( ( WowCharacter )@object ), Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_base_equals_method_should_return_false()
        {
            Assert.That( firstWowCharacter.Equals( @object ), Is.False );
        }

        [Test]
        public void The_reference_equals_method_should_return_false()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, @object ), Is.False );
        }

#pragma warning disable 253 // The reference comparison is intended for testing equality
        [Test]
        public void The_equals_operator_should_return_false()
        {
            Assert.That( firstWowCharacter == @object, Is.False );
        }

        [Test]
        public void The_not_equals_operator_should_return_true()
        {
            Assert.That( firstWowCharacter != @object );
        }
#pragma warning restore 253
    }

    [TestFixture]
    public class Given_two_wow_characters_with_the_same_name_and_server : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = new WowCharacter( firstWowCharacterName, firstWowCharacterServer );
        }

        [Test]
        public void The_equals_method_should_return_true()
        {
            Assert.That( firstWowCharacter.Equals( secondWowCharacter ) );
        }

        [Test]
        public void The_base_equals_method_should_return_true()
        {
            Assert.That( firstWowCharacter.Equals( ( Object )secondWowCharacter ) );
        }

        [Test]
        public void The_reference_equals_method_should_return_false()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ), Is.False );
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

    [TestFixture]
    public class Given_two_wow_characters_with_a_different_name_and_the_same_server : When_equating_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = new WowCharacter( secondWowCharacterName, firstWowCharacterServer );
        }

        [Test]
        public void The_equals_method_should_return_false()
        {
            Assert.That( firstWowCharacter.Equals( secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_base_equals_method_should_return_false()
        {
            Assert.That( firstWowCharacter.Equals( ( Object )secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_reference_equals_method_should_return_false()
        {
            Assert.That( Object.ReferenceEquals( firstWowCharacter, secondWowCharacter ), Is.False );
        }

        [Test]
        public void The_equals_operator_should_return_false()
        {
            Assert.That( firstWowCharacter == secondWowCharacter, Is.False );
        }

        [Test]
        public void The_not_equals_operator_should_return_true()
        {
            Assert.That( firstWowCharacter != secondWowCharacter );
        }
    }

    public abstract class When_equating_two_wow_characters_spec
    {
        protected WowCharacter firstWowCharacter;
        protected String firstWowCharacterName = "firstWowCharacterName";
        protected String firstWowCharacterServer = "firstWowCharacterServer";

        protected WowCharacter secondWowCharacter;
        protected String secondWowCharacterName = "secondWowCharacterName";
        protected String secondWowCharacterServer = "secondWowCharacterServer";

        protected readonly Object @object = new Object();

        [TestFixtureSetUp]
        public virtual void SetupFixture()
        {
            firstWowCharacter = new WowCharacter( firstWowCharacterName, firstWowCharacterServer );
            secondWowCharacter = new WowCharacter( secondWowCharacterName, secondWowCharacterServer );
        }
    }
}