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

    [TestFixture]
    public class Given_a_null_and_non_null_wow_character : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            firstWowCharacter = null;
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
        public void The_static_compare_method_should_return_negative_one()
        {
            Assert.That( WowCharacter.Compare( firstWowCharacter, secondWowCharacter ), Is.EqualTo( -1 ) );
        }

        [Test]
        public void The_greater_than_operator_should_return_false()
        {
            Assert.That( firstWowCharacter > secondWowCharacter, Is.False );
        }

        [Test]
        public void The_greater_than_or_equal_operator_should_return_false()
        {
            Assert.That( firstWowCharacter >= secondWowCharacter, Is.False );
        }

        [Test]
        public void The_less_than_operator_should_return_true()
        {
            Assert.That( firstWowCharacter < secondWowCharacter );
        }

        [Test]
        public void The_less_than_or_equal_operator_should_return_true()
        {
            Assert.That( firstWowCharacter <= secondWowCharacter );
        }
    }

    [TestFixture]
    public class Given_a_non_null_and_null_wow_character : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = null;
        }

        [Test]
        public void The_compare_to_method_should_return_one()
        {
            Assert.That( firstWowCharacter.CompareTo( secondWowCharacter ), Is.EqualTo( 1 ) );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_return_one()
        {
            Assert.That( firstWowCharacter.CompareTo( ( Object )secondWowCharacter ), Is.EqualTo( 1 ) );
        }

        [Test]
        public void The_static_compare_method_should_return_one()
        {
            Assert.That( WowCharacter.Compare( firstWowCharacter, secondWowCharacter ), Is.EqualTo( 1 ) );
        }

        [Test]
        public void The_greater_than_operator_should_return_true()
        {
            Assert.That( firstWowCharacter > secondWowCharacter );
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
        public void The_less_than_or_equal_operator_should_return_false()
        {
            Assert.That( firstWowCharacter <= secondWowCharacter, Is.False );
        }
    }

    [TestFixture]
    public class Given_the_same_wow_character_twice : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = firstWowCharacter;
        }

        [Test]
        public void The_compare_to_method_should_return_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( secondWowCharacter ), Is.EqualTo( 0 ) );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_return_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( ( Object )secondWowCharacter ), Is.EqualTo( 0 ) );
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

    [TestFixture]
    public class Given_a_wow_character_and_an_object : When_comparing_two_wow_characters_spec
    {
        readonly Object @object = new Object();

        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
        }

        [Test]
        public void The_compare_to_method_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter.CompareTo( ( WowCharacter )@object ), Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_throw_an_argument_exception()
        {
            Assert.That( () => firstWowCharacter.CompareTo( @object ), Throws.ArgumentException );
        }

        [Test]
        public void The_static_compare_method_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => WowCharacter.Compare( firstWowCharacter, ( WowCharacter )@object ), Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_greater_than_operator_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter > ( WowCharacter )@object, Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_greater_than_or_equal_operator_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter >= ( WowCharacter )@object, Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_less_than_operator_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter < ( WowCharacter )@object, Throws.TypeOf<InvalidCastException>() );
        }

        [Test]
        public void The_less_than_or_equal_operator_should_throw_an_invalid_cast_exception()
        {
            Assert.That( () => firstWowCharacter <= ( WowCharacter )@object, Throws.TypeOf<InvalidCastException>() );
        }
    }

    [TestFixture]
    public class Given_two_wow_characters_with_the_same_name_and_server : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterName = firstWowCharacterName;
            secondWowCharacterServer = firstWowCharacterServer;
            base.SetupFixture();
        }

        [Test]
        public void The_compare_to_method_should_return_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( secondWowCharacter ), Is.EqualTo( 0 ) );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_return_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( ( Object )secondWowCharacter ), Is.EqualTo( 0 ) );
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

    [TestFixture]
    public class Given_two_wow_characters_with_a_different_name_and_the_same_server : When_comparing_two_wow_characters_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterServer = firstWowCharacterServer;
            base.SetupFixture();
        }

        [Test]
        public void The_compare_to_method_should_return_non_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( secondWowCharacter ), Is.Not.EqualTo( 0 ) );
        }

        [Test]
        public void The_non_generic_compare_to_method_should_return_non_zero()
        {
            Assert.That( firstWowCharacter.CompareTo( ( Object )secondWowCharacter ), Is.Not.EqualTo( 0 ) );
        }

        [Test]
        public void The_static_compare_method_should_return_non_zero()
        {
            Assert.That( WowCharacter.Compare( firstWowCharacter, secondWowCharacter ), Is.Not.EqualTo( 0 ) );
        }

        [Test]
        public void The_greater_than_operator_should_return_the_opposite_of_the_less_than_operator()
        {
            Assert.That( firstWowCharacter > secondWowCharacter, Is.Not.EqualTo( firstWowCharacter < secondWowCharacter ) );
        }

        [Test]
        public void The_greater_than_operator_should_return_the_same_as_the_greater_than_or_equal_operator()
        {
            Assert.That( firstWowCharacter > secondWowCharacter, Is.EqualTo( firstWowCharacter >= secondWowCharacter ) );
        }

        [Test]
        public void The_less_than_operator_should_return_the_same_as_the_less_than_or_equal_operator()
        {
            Assert.That( firstWowCharacter < secondWowCharacter, Is.EqualTo( firstWowCharacter <= secondWowCharacter ) );
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