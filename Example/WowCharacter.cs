using System;

namespace IEquatable.Example
{
    public sealed class WowCharacter : IEquatable<WowCharacter>
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
            return other != null;
        }

        public override Boolean Equals( Object obj )
        {
            return Equals( obj as WowCharacter );
        }

        public override Int32 GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static Boolean operator ==( WowCharacter first, WowCharacter second )
        {
            return ReferenceEquals( first, second ) || first.Equals( second );
        }

        public static Boolean operator !=( WowCharacter first, WowCharacter second )
        {
            return !( first == second );
        }
        #endregion
    }
}