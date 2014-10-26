﻿using System;

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
            if ( ReferenceEquals( other, null ) ) return false;
            return Name.Equals( other.Name ) &&
                Server.Equals( other.Server );
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
            if ( ReferenceEquals( first, null ) ) return ReferenceEquals( second, null );
            return first.Equals( second );
        }

        public static Boolean operator !=( WowCharacter first, WowCharacter second )
        {
            return !( first == second );
        }
        #endregion

        #region IComparable
        public Int32 CompareTo( WowCharacter other )
        {
            if ( ReferenceEquals( this, other ) ) return 0;
            return 1;
        }

        public Int32 CompareTo( Object obj )
        {
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