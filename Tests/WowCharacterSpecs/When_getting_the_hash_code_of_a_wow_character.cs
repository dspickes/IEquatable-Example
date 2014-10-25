using IEquatable.Example;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace IEquatable.Tests.WowCharacterSpecs.When_getting_the_hash_code_of_a_wow_character
{
    [TestFixture]
    public class Given_a_wow_character : When_getting_the_hash_code_of_a_wow_character_spec
    {
        const Int32 basePrime = 1212121;
        const Int32 multipliedPrime = 6153577;
        Int32 calculatedHashCode;

        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();

            calculatedHashCode = basePrime;
            unchecked
            {
                calculatedHashCode = calculatedHashCode * multipliedPrime + firstWowCharacter.Name.GetHashCode();
                calculatedHashCode = calculatedHashCode * multipliedPrime + firstWowCharacter.Server.GetHashCode();
            }
        }

        [Test]
        public void The_returned_hash_code_should_be_calculated_using_an_additive_hash_on_the_name_and_server_with_primes_1212121_and_6153577()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.EqualTo( calculatedHashCode ) );
        }
    }

    [TestFixture]
    public class Given_the_same_wow_character_twice : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            secondWowCharacter = firstWowCharacter;
        }

        [Test]
        public void The_hash_codes_should_be_the_same()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_two_different_wow_characters_with_the_same_name_and_server : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterName = firstWowCharacterName;
            secondWowCharacterServer = firstWowCharacterServer;
            base.SetupFixture();
        }

        [Test]
        public void The_hash_codes_should_be_the_same()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_two_different_wow_characters_with_the_same_name_and_a_different_server : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterName = firstWowCharacterName;
            base.SetupFixture();
        }

        [Test]
        public void The_hash_codes_should_be_different()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.Not.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_two_different_wow_characters_with_a_different_name_and_the_same_server : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterServer = firstWowCharacterServer;
            base.SetupFixture();
        }

        [Test]
        public void The_hash_codes_should_be_different()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.Not.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_two_different_wow_characters_with_different_names_and_servers : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
        }

        [Test]
        public void The_hash_codes_should_be_different()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.Not.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_two_different_wow_characters_with_an_inverted_name_and_server : When_getting_the_hash_code_of_a_wow_character_spec
    {
        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            secondWowCharacterName = firstWowCharacterServer;
            secondWowCharacterServer = firstWowCharacterName;
            base.SetupFixture();
        }

        [Test]
        public void The_hash_codes_should_be_different()
        {
            Assert.That( firstWowCharacter.GetHashCode(), Is.Not.EqualTo( secondWowCharacter.GetHashCode() ) );
        }
    }

    [TestFixture]
    public class Given_one_hundred_thousand_different_wow_characters_with_different_names_and_servers : When_getting_the_hash_code_of_a_wow_character_spec
    {
        const Int32 numberOfCharacters = 100000;
        readonly HashSet<Int32> calculatedHashCodes = new HashSet<Int32>();

        [TestFixtureSetUp]
        public override void SetupFixture()
        {
            base.SetupFixture();
            for( var characterIndex = 0; characterIndex < numberOfCharacters; characterIndex++ )
            {
                var name = String.Format( "Name{0}", characterIndex );
                var server = String.Format( "Server{0}", characterIndex );
                var character = new WowCharacter( name, server );
                calculatedHashCodes.Add( character.GetHashCode() );
            }
        }

        [Test]
        public void The_hash_codes_should_be_unique()
        {
            Assert.That( calculatedHashCodes.Count, Is.EqualTo( numberOfCharacters ) );
        }
    }

    public abstract class When_getting_the_hash_code_of_a_wow_character_spec
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