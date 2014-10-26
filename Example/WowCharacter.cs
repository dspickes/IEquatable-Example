using System;

namespace IEquatable.Example
{
    public sealed class WowCharacter :
        IEquatable<WowCharacter>,
        IComparable<WowCharacter>,
        IComparable
    {
        public String Name { get; private set; }
        public String Server { get; private set; }

        public WowCharacter( String name, String server )
        {
            Name = name;
            Server = server;
        }

        #region IEquatable
        public Boolean Equals( WowCharacter other )
        {
            return CompareTo( other ) == 0;
        }

        public override Boolean Equals( Object obj )
        {
            return Equals( obj as WowCharacter );
        }

        const Int32 baseHashPrime = 1212121;
        const Int32 multipliedHashPrime = 6153577;
        public override Int32 GetHashCode()
        {
            var hash = baseHashPrime;
            unchecked
            {
                hash = hash * multipliedHashPrime + Name.GetHashCode();
                hash = hash * multipliedHashPrime + Server.GetHashCode();
            }
            return hash;
        }

        public static Boolean operator ==( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) == 0;
        }

        public static Boolean operator !=( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) != 0;
        }
        #endregion

        #region IComparable
        public Int32 CompareTo( WowCharacter other )
        {
            if ( ReferenceEquals( this, other ) ) return 0;
            if ( ReferenceEquals( other, null ) ) return 1;

            var server = String.CompareOrdinal( Server, other.Server );
            var name = String.CompareOrdinal( Name, other.Name );
            return server != 0 ? server : name;
        }

        public Int32 CompareTo( Object obj )
        {
            if ( obj != null && !( obj is WowCharacter ) ) throw new ArgumentException( String.Format( "Object '{0}' is not a WoW character.", obj ) );
            return CompareTo( ( WowCharacter )obj );
        }

        public static Int32 Compare( WowCharacter first, WowCharacter second )
        {
            if ( ReferenceEquals( first, second ) ) return 0;
            if ( ReferenceEquals( first, null ) ) return -1; ;
            return first.CompareTo( second );
        }

        public static Boolean operator >( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) > 0;
        }

        public static Boolean operator >=( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) >= 0;
        }

        public static Boolean operator <( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) < 0;
        }

        public static Boolean operator <=( WowCharacter first, WowCharacter second )
        {
            return Compare( first, second ) <= 0;
        }
        #endregion
    }
}